using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Enums;
using MISA.ApplicationCore.Interfaces;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MISA.Infrastructure
{
    /// <summary>
    /// LỚp thực thi các thao tác tương tác với cơ sở dữ liệu
    /// </summary>
    /// CreatedBy: nmhung(23/3/2021)
    /// <typeparam name="T">Đối tượng</typeparam>
    public class BaseRepository<T> : IBaseRepository<T>, IDisposable where T : BaseEntity
    {
        #region DECLARE
        IConfiguration _configuration;
        string _connectionString = string.Empty;
        protected IDbConnection _dbConnection = null;
        protected string _tableName;
        #endregion

        #region CONSTRUCTOR
        public BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("MISACukCukConnectionString");
            _dbConnection = new MySqlConnection(_connectionString);
            _tableName = typeof(T).Name;
        }
        #endregion
        public IEnumerable<T> GetTs()
        {
            var entities = _dbConnection.Query<T>($"Proc_Get{_tableName}s", commandType: CommandType.StoredProcedure);
            return entities;
        }

        public T GetTById(Guid entityId)
        {
            var parameter = new DynamicParameters();
            parameter.Add($@"{_tableName}Id", entityId, DbType.String);
            var entitie = _dbConnection.Query<T>($"Proc_Get{_tableName}ById", parameter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return entitie;
        }
        public int Add(T entity)
        {
            var rowAffects = 0;
            _dbConnection.Open();
            using (var transaction = _dbConnection.BeginTransaction())
            {
                try
                {
                    var parameters = MappingDbType(entity);
                    //Thực hiện thêm khách hàng:
                    rowAffects = _dbConnection.Execute($"Proc_Insert{_tableName}", parameters, transaction, commandType: CommandType.StoredProcedure);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    transaction.Rollback();
                }

            }
            return rowAffects;
        }
        public int Update(T entity)
        {
            var rowAffect = 0;
            _dbConnection.Open();
            using (var transaction = _dbConnection.BeginTransaction())
            {
                try
                {
                    var parameters = MappingDbType(entity);
                    rowAffect = _dbConnection.Execute($"Proc_Update{_tableName}", parameters, transaction, commandType: CommandType.StoredProcedure);
                    transaction.Commit();
                }
                catch (Exception)
                {

                    transaction.Rollback();
                }
            }
            return rowAffect;
        }

        public int Delete(Guid entityId)
        {
            var rowAffect = 0;
            _dbConnection.Open();
            using (var transaction = _dbConnection.BeginTransaction())
            {
                try
                {
                    var parameters = new DynamicParameters();
                    parameters.Add($@"{_tableName}Id", entityId, DbType.String);
                    rowAffect = _dbConnection.Execute($"Proc_Delete{_tableName}", parameters, transaction, commandType: CommandType.StoredProcedure);
                    transaction.Commit();
                }
                catch (Exception)
                {

                    transaction.Rollback();
                }
            }
            return rowAffect;
        }

        /// <summary>
        /// Chuyển kiểu guid sang string
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DynamicParameters MappingDbType(T entity)
        {
            var properties = entity.GetType().GetProperties();
            var parameters = new DynamicParameters();
            foreach (var property in properties)
            {
                var propertyName = property.Name;
                var propertyValue = property.GetValue(entity);
                var propertyType = property.PropertyType;
                if (propertyType == typeof(Guid) || propertyType == typeof(Guid?))
                {
                    parameters.Add($"@{propertyName}", propertyValue, DbType.String);
                }
                else if (propertyType == typeof(bool) || propertyType == typeof(bool?))
                {
                    //Nếu không thành công thì comment dòng dưới và mở comment propertyType
                    var dbValue = ((bool)propertyValue == true ? 1 : 0);
                    parameters.Add($"@{propertyName}", /*propertyType*/ dbValue, DbType.Int32);
                }
                else
                {
                    parameters.Add($"@{propertyName}", propertyValue);
                }
            }
            return parameters;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        /// CreatedBy: nmhung(20/2/2021)
        public T GetEntityByProperty(T entity, PropertyInfo property)
        {
            var propertyName = property.Name;
            var propertyValue = property.GetValue(entity);
            var keyValue = entity.GetType().GetProperty($"{_tableName}Id").GetValue(entity);
            var query = string.Empty;
            if (entity.EntityState == EntityState.AddNew)
            {
                query = $"SELECT * FROM {_tableName} WHERE {propertyName} = '{propertyValue}'";
            }
            else if (entity.EntityState == EntityState.Update)
            {
                query = $"SELECT * FROM {_tableName} WHERE {propertyName} = '{propertyValue}' AND {_tableName}Id <> '{keyValue}'";
            }
            else
            {
                return null;
            }
            var entityReturn = _dbConnection.Query<T>(query, commandType: CommandType.Text).FirstOrDefault();
            return entityReturn;
        }

        public void Dispose()
        {
            if (_dbConnection.State == ConnectionState.Open)
            {
                _dbConnection.Close();
            }
        }
    }
}
