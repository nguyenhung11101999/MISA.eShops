using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Entities
{
    /// <summary>
    /// Đối tượng tỉnh/thành phố
    /// CreatedBy: nmhung(23/3/2021)
    /// </summary>
    public class Province:BaseEntity
    {
        #region Property
        /// <summary>
        /// Khóa chính
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public Guid ProvinceId { get; set; }

        /// <summary>
        /// Tên tỉnh/thành phố
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public string ProvinceName { get; set; }
        /// <summary>
        /// Mã nhóm quốc gia
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public Guid? CountryId { get; set; }
        #endregion
    }
}
