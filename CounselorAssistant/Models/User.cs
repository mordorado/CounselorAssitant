using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using CounselorAssistant.Models;

namespace CounselorAssistant.Models
{
    [Table("User")]
    public class User : BaseEntity

    {
        private AssistantContext DB = new AssistantContext();
        #region Configuration
        internal class Configuration : EntityTypeConfiguration<User>
        {
            public Configuration()
            {
                this.HasRequired(p => p.People)
                    .WithMany()
                    .HasForeignKey(x => x.PeoID)
                    .WillCascadeOnDelete(false);
            }
        }

        #endregion Configuration
        #region Constructor
        /// <summary>
        ///  تابع سازنده کلاس کاربر
        /// </summary>
        public User()
        {
            CreateDate = DateTime.Now;
        }
        #endregion Constructor
        #region Properties
        /// <summary>
        /// نام کاربری
        /// این نام باید به صورت یکتا باشد و حداقل 5 کاراکتر و حداکثر 50 کاراکتر می باشد
        /// </summary>
        [Display(Name = "نام کاربری")]
        [MaxLength(50, ErrorMessage = "حداکثر طول نام کاربری 50 حرف می باشد")]
        [MinLength(5, ErrorMessage = "حداقل طول نام کاربری 5 حرف می باشد")]
        [Required(AllowEmptyStrings = false)]
        [Index("IX_UserName", 1, IsUnique = true)]
        public string UserName { get; set; }
        /// <summary>
        /// عنوان کاربر که در نرم افزار نمایش داده می شود
        /// </summary>
        [Display(Name = "عنوان کاربر")]
        public long? PeoID { get; set; }
        [ForeignKey("PeoID")]
        public virtual People People { get; set; }
        /// <summary>
        ///کلمه عبور که حداقل 6 کاراکتر و حداکثر 50 کاراکتر می باشد 
        /// </summary>
        [MaxLength(50, ErrorMessage = "کلمع عبور حداکثر 50 کاراکتر می باشد")]
        [MinLength(6, ErrorMessage = "کلمه عبور حداقل 6 کاراکتر باشد ")]
        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [Display(Name = "کلمه عبور")]
        public string Password { get; set; }

        /// <summary>
        /// نوع کاربر که در جدول دامین تعریف شده است
        /// </summary>
        [Display(Name = "نوع کاربر")]
        [Required(ErrorMessage = "نوع کاربر مشخص نشده است")]
        public DomainEnums.UserType DomUserType { get; set; }
        /// <summary>
        /// خصوصیت نمایش تیتر نوع کاربر
        /// فقط خواندنی می باشد
        /// </summary>
        [NotMapped]
        public string UserTypeTitle
        {
            get { return DomUserType.GetDescription(); ; }
        }
        /// <summary>
        /// تاریخ ایجاد کاربر
        /// </summary>
        [Display(Name = "تاریخ و زمان ایجاد")]
        [DataType(DataType.DateTime)]
        [UIHint("DateTime")]
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// تاریخ و زمان انقضا نام کاربری
        /// </summary>
        [Display(Name = "تاریخ انقضا")]
        [DataType(DataType.DateTime)]
        [UIHint("DateTime")]
        public DateTime? ExpireDate { get; set; }
        #endregion Properties
        #region Methods
        /// <summary>
        /// دریافت مشخصات یک کاربر به وسیله آیدی
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public User SelectUser(long UserID)
        {
            User Result = DB.User.Single(Item => Item.ID == UserID && Item.DomStatus == DomainEnums.RecordStatus.RecordEnabled);
            return Result;

        }
        /// <summary>
        /// دریافت لیست همه کاربران
        /// </summary>
        /// <returns></returns>
        public List<User> SelectUser()
        {
            List<User> Users = (from item in DB.User
                                where (DomainEnums.IsValidRecord(item.DomStatus))
                                select item)
                                .ToList();
            return Users;

        }
        /// <summary>
        /// دریافت مشخصات کاربر به وسیله نام کاربری
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public List<User> selectUser(string UserName)
        {
            List<User> Result = (from item in DB.User
                                 where item.UserName.Contains(UserName) && DomainEnums.IsValidRecord(item.DomStatus)
                                 select item)
                         .ToList();
            return Result;
        }
        /// <summary>
        /// تابع لاگین
        /// یوزر نیم و پسورد به آن ارسال می شود و در صورتی که صحیح باشد اطلاعات یوزر را برمیگرداند
        /// </summary>
        /// <param name="UserName">نام کاربری</param>
        /// <param name="Password">پسورد</param>
        /// <returns>نوع داده ای یوزر و در صورتی که کاربری با این مشخصات پیدا نشود مقدار نال</returns>
        public User Login(String UserName, string Password)
        {
            User Result = (from item in DB.User
                           where (item.UserName == UserName.Trim()) && (item.Password == Password)
                           select item).FirstOrDefault();

            return Result;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public User AddUser([Bind(Include = "ID,ReserveDateTime,Patient_PeoID,Consultant_PeoID,AttachmentGroupID,FinancialGroupID,DomStatus,Descriptions")] User NewUser)
        {
            try
            {
                User AddedUser = DB.User.Add(NewUser);
                DB.SaveChanges();
                return AddedUser;
            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }
        #endregion Methods

    }
}