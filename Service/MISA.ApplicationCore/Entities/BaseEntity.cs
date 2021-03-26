using MISA.ApplicationCore.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Entities
{
    /// <summary>
    /// Hiển thị tên thuộc tính
    /// CreatedBy: nmhung(23/3/2021)
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DisplayName : Attribute
    {
        public string Name { get; set; }
        public DisplayName(string name = null)
        {
            this.Name = name;
        }
    }
    /// <summary>
    /// Check khóa chính
    /// CreatedBy: nmhung(23/3/2021)
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class PrimaryKey : Attribute
    {

    }
    /// <summary>
    /// Bắt buộc nhập
    /// CreatedBy: nmhung(23/3/2021)
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class Required : Attribute
    {

    }
    /// <summary>
    /// Check trùng dữ liệu
    /// CreatedBy: nmhung(23/3/2021)
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class CheckDuplicate : Attribute
    {

    }
    /// <summary>
    /// Lớp xác định độ dài tối đa của thuộc tính đối tượng
    /// CreatedBy: nmhung(23/3/2021)
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class MaxLength : Attribute
    {
        public int Value { get; set; }
        public string ErrorMsg { get; set; }
        public MaxLength(int length, string erroMsg = null)
        {
            this.Value = length;
            this.ErrorMsg = erroMsg;
        }
    }
    /// <summary>
    /// Class chứa các thuộc tính chung nhất mà mọi đối tượng kế thừa
    /// CreatedBy: nmhung(23/3/2021)
    /// </summary>
    public class BaseEntity
    {
        #region Propeeties
        /// <summary>
        /// Trạng thái của đối tượng
        /// CreatedBy: nmhung(20/2/2021)
        /// </summary>
        public EntityState EntityState { get; set; } = EntityState.AddNew;
        /// <summary>
        /// Ngày tạo bản ghi
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Người tạo bản ghi
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Ngày sửa đổi bản ghi
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Người sửa đổi bản ghi
        /// CreatedBy: nmhung(23/3/2021)
        /// </summary>
        public string ModifiedBy { get; set; }
        #endregion
    }
}
