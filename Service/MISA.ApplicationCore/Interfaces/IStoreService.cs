using MISA.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Interfaces
{
    /// <summary>
    /// Interface chứa các phương thức trong quá trình nghiệp vụ và có các phương thức riêng của nó.
    /// CreatedBy: nmhung(23/3/2021)
    /// </summary>
    public interface IStoreService:IBaseService<Store>
    {
        IEnumerable<Store> GetProvinceWithCountry(Guid Id);
    }
}