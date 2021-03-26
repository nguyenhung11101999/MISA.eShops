using Microsoft.Extensions.Configuration;
using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Infrastructure
{
    /// <summary>
    /// Lớp tương tác với đối tượng quốc gia trong cơ sở dữ liệu
    /// </summary>
    /// CreatedBy: nmhung(23/3/2021)
    public class CountryRepository:BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(IConfiguration configuration):base(configuration)
        {

        }
    }
}
