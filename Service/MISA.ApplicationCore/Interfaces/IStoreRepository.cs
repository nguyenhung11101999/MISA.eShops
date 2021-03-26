using MISA.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Interfaces
{
    /// <summary>
    /// Interface của Store chứa các phương thức của lớp tra và có các phương thức riêng.
    /// CreatedBy: nmhung(23/3/2021)
    /// </summary>
    public interface IStoreRepository:IBaseRepository<Store>
    {
        /// <summary>
        /// Lấy danh sách tỉnh thành theo quốc gia
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        /// <returns>Danh sách entity</returns>
        IEnumerable<Store> GetProvinceWithCountry(Guid Id);
    }
}
