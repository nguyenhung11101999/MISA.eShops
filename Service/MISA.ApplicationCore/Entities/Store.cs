using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Entities
{
    /// <summary>
    /// Đối tượng cửa hàng
    /// CreatedBy: nmhung(23/3/2021)
    /// </summary>
    public class Store : BaseEntity
    {
        #region Properties
        /// <summary>
        /// Khóa chính
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        [PrimaryKey]
        public Guid StoreId { get; set; }

        /// <summary>
        /// Mã cửa hàng
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        [Required]
        [CheckDuplicate]
        [DisplayName("Mã cửa hàng")]
        public string StoreCode { get; set; }

        /// <summary>
        /// Tên cửa hàng
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        [Required]
        [DisplayName("Tên cửa hàng")]
        public string StoreName { get; set; }

        /// <summary>
        /// Địa chỉ
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        [Required]
        [DisplayName("Địa chỉ")]
        public string Address { get; set; }

        /// <summary>
        /// Số điện thoại
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Mã số thuế
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public string StoreTaxCode { get; set; }

        /// <summary>
        /// Mã nhóm quốc gia
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public Guid? CountryId { get; set; }

        /// <summary>
        /// Mã nhóm tỉnh/thành phố
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public Guid? ProvinceId { get; set; }

        /// <summary>
        /// Mã nhóm quận/huyện
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public Guid? DistrictId { get; set; }

        /// <summary>
        /// Mã nhóm phườn/xã
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public Guid? WardId { get; set; }
        /// <summary>
        /// ĐƯờng
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Trạng thái của cửa hàng
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public int Status { get; set; }
        #endregion
    }
}
