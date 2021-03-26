using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Services
{
    /// <summary>
    /// LỚp thực thi interface ICountryService
    /// </summary>
    /// CreatedBy: nmhung(23/3/2021)
    public class CountryService:BaseService<Country>, ICountryService
    {
        #region DECLARE
        ICountryRepository _countryRepository;
        #endregion

        #region CONSTRUCTOR
        public CountryService(IBaseRepository<Country> baseRepository, ICountryRepository countryRepository) : base(baseRepository)
        {
            _countryRepository = countryRepository;
        }
        #endregion
    }
}
