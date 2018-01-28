using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;



namespace CounselorAssistant.Models
{
    public class User : BaseEntity
    {
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

        [Display(Name = "نام کاربری")]
        [MaxLength(50,ErrorMessage ="حداکثر طول نام کاربری 50 حرف می باشد")]
        [MinLength(5, ErrorMessage = "حداقل طول نام کاربری 5 حرف می باشد")]
        [Required(AllowEmptyStrings = false)]
        [Index("IX_UserName", 1, IsUnique = true)]
        public string UserName { get; set; }

        [Display(Name = "عنوان کاربر")]
        public long? PeoID { get; set; }
        [ForeignKey("PeoID")]
        public virtual People People { get; set; }

        [MaxLength(50)]
        [MinLength(10)]
        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [Display(Name = "کلمه عبور")]
        public string Password { get; set; }

        [Display(Name = "نوع کاربر")]
        [Required]
        public DomainEnums.UserType DomUserType { get; set; }
        [NotMapped]
        public string UserTypeTitle
        {
            get { return DomUserType.GetDescription(); ; }
        }

        [Display(Name = "تاریخ ایجاد")]
        [DataType(DataType.Date)]
        [UIHint("DateTime")]
        public DateTime? CreateDate { get; set; }

        [Display(Name = "تاریخ انقضا")]
        [DataType(DataType.Date)]
        [UIHint("DateTime")]      
        public DateTime? ExpireDate { get; set; }

    }
}