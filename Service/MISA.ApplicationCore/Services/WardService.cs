using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Services
{
    /// <summary>
    /// LỚp thực thi các phương thức nghiệp vụ riêng của đối tượng phường/xã.
    /// </summary>
    /// CreatedBy: nmhung(23/3/2021)
    public class WardService:BaseService<Ward>, IWardService
    {
        #region DECLARE
        IWardRepository _wardRepository;
        #endregion

        #region CONSTRUCTOR
        public WardService(IBaseRepository<Ward> baseRepository, IWardRepository wardRepository) : base(baseRepository)
        {
            _wardRepository = wardRepository;
        }
        #endregion
    }
}
