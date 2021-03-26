using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Entities
{
    /// <summary>
    /// Đối tượng quốc gia
    /// </summary>
    public class Country:BaseEntity
    {
        #region Property
        /// <summary>
        /// Khóa chính
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public Guid CountryId { get; set; }

        /// <summary>
        /// Tên quốc gia
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public string CountryName { get; set; }
        #endregion
    }
}
