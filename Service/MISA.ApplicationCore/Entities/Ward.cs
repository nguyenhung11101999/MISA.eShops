using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Entities
{
    /// <summary>
    /// Đối tượng phường/xã
    /// CreatedBy: nmhung(23/3/2021)
    /// </summary>
    public class Ward:BaseEntity
    {
        #region Property
        /// <summary>
        /// Khóa chính
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public Guid WardId { get; set; }

        /// <summary>
        /// Tên phường/xã
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public string WardName { get; set; }
        /// <summary>
        /// Mã quận/huyện
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public Guid? DistrictId { get; set; }
        #endregion
    }
}
