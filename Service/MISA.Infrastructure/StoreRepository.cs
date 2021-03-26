using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MISA.Infrastructure
{
    /// <summary>
    /// Lớp tương tác với đối tượng cửa hàng trong cơ sở dữ liệu
    /// </summary>
    /// CreatedBy: nmhung(23/3/2021)
    public class StoreRepository:BaseRepository<Store>, IStoreRepository
    {
        public StoreRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public IEnumerable<Store> GetProvinceWithCountry(Guid Id)
        {
            string procName = $"Proc_GetProvinceWithCountry";
            var parameters = new DynamicParameters();
            parameters.Add("@CountryId", Id.ToString());
            var res = _dbConnection.Query<Store>(procName,parameters,commandType:CommandType.StoredProcedure);
            return res;
        }
    }
}
