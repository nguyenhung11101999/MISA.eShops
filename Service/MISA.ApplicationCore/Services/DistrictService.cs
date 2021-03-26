using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Services
{
    /// <summary>
    /// LỚp thực thi các phương thức nghiệp vụ riêng của đối tượng quận/ huyện
    /// </summary>
    /// CreatedBy: nmhung(23/3/2021)
    public class DistrictService:BaseService<District>, IDistrictService
    {
        #region DECLARE
        IDistrictRepository _districtRepository;
        #endregion

        #region CONSTRUCTOR
        public DistrictService(IBaseRepository<District> baseRepository, IDistrictRepository districtRepository) : base(baseRepository)
        {
            _districtRepository = districtRepository;
        }
        #endregion
    }
}
