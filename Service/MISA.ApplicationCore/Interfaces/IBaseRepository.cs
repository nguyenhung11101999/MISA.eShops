using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MISA.ApplicationCore.Interfaces
{
    /// <summary>
    /// Interface chứa các phương thức tương tác với cơ sở dữ liệu
    /// </summary>
    /// CreatedBy: nmhung(23/3/2021)
    public interface IBaseRepository<T>
    {
        /// <summary>
        /// Lấy toàn bộ danh sách entity
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        /// <returns>Danh sách entity</returns>
        IEnumerable<T> GetTs();

        /// <summary>
        /// Lấy entity theo id
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        /// <param name="entityId">id entity</param>
        /// <returns>Đối tượng</returns>
        T GetTById(Guid entityId);

        /// <summary>
        /// Thêm mới entity
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        /// <param name="entity">Dối tượng cần thêm</param>
        /// <returns>Số dòng bị ảnh hưởng</returns>
        int Add(T entity);

        /// <summary>
        /// Cập nhật entity
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        /// <param name="entity">Dối tượng sửa</param>
        /// <returns>Số dòng bị ảnh hưởng</returns>
        int Update(T entity);

        /// <summary>
        /// Xóa bỏ entity
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        /// <param name="entityId">id của đối tượng cần xóa</param>
        /// <returns>Số dòng bị ảnh hưởng</returns>
        int Delete(Guid entityId);

        /// <summary>
        /// Lấy ra đối tượng từ giá trị của property của đối tượng đó
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        /// <param name="entity">Đối tượng </param>
        /// <param name="property"></param>
        /// <returns></returns>
        T GetEntityByProperty(T entity, PropertyInfo property);
    }
}
