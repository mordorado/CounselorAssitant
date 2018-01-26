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
        [MaxLength(50)]
        [MinLength(5)]
        [Required(AllowEmptyStrings = false)]
        [Index("IX_UserName", 1, IsUnique = true)]
        public string UserName { get; set; }

        [Display(Name = "عنوان کاربر")]
        public long PeoID { get; set; }
        [ForeignKey("PeoID")]
        public virtual  People People { get; set; }
        //public virtual ICollection<User> Users { get; set; }

        //[Display(Name = "عنوان کاربر")]
        //[MaxLength(50)]
        //[MinLength(10)]
        //[Required(AllowEmptyStrings = false)]
        //public string UserTitle { get; set; }

        [MaxLength(50)]
        [MinLength(10)]
        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [Display(Name = "کلمه عبور")]
        public string Password { get; set; }

        [Display(Name = "نوع کاربر")]
        public DomainEnums.UserType DomUserType { get; set; }
        [NotMapped]
        public string UserTypeTitle
        {   
            get { return DomUserType.GetDescription(); ; }
        }
 
        //[Display(Name = "سازمان درخواست دهنده")]
        //[Required(ErrorMessage = "سازمان درخواست دهنده مورد نظر را انتخاب کنید")]
        //public long OrgID { get; set; }

        //[ForeignKey("OrgID")]
        //public virtual Organization Organization { get; set; }

        [Display(Name = "تاریخ انقضا")]
        [Required]
        [DataType(DataType.Date)]
        [UIHint("DateTime")]
        public DateTime ExpireDate { get; set; }

    }
}