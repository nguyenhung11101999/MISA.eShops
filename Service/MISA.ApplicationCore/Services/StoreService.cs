using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Services
{
    /// <summary>
    /// LỚp thực thi các phương thức nghiệp vụ riêng của đối tượng cửa hàng
    /// </summary>
    /// CreatedBy: nmhung(23/3/2021)
    public class StoreService:BaseService<Store>, IStoreService
    {
        #region DECLARE
        IStoreRepository _storeRepository;
        #endregion

        #region CONSTRUCTOR
        public StoreService(IBaseRepository<Store> baseRepository, IStoreRepository storeRepository) : base(baseRepository)
        {
            _storeRepository = storeRepository;        
        }

        public IEnumerable<Store> GetProvinceWithCountry(Guid Id)
        {
            return _storeRepository.GetProvinceWithCountry(Id);
        }


        #endregion
    }
}
