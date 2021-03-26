using Microsoft.Extensions.Configuration;
using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Infrastructure
{
    /// <summary>
    /// Lớp tương tác với đối tượng quận/ huyện trong cơ sở dữ liệu
    /// </summary>
    /// CreatedBy: nmhung(23/3/2021)
    public class DistrictRepository:BaseRepository<District>, IDistrictRepository
    {
        public DistrictRepository(IConfiguration configuration):base(configuration)
        {

        }
    }
}
