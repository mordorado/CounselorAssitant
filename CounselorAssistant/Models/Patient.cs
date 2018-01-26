using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CounselorAssistant.Models
{
    public abstract class Patient : BaseEntity
    {
        #region Configuration
        internal class Configuration : EntityTypeConfiguration<Patient>
        {
            public Configuration()
            {
            }
        }
        #endregion Configuration

        [Display(Name = "نام")]
        [MaxLength(50)]
        [MinLength(10)]
        [Required(AllowEmptyStrings = false)]
        public String Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        [MaxLength(50)]
        [MinLength(10)]
        [Required(AllowEmptyStrings = false)]
        public String Family { get; set; }

        [Display(Name = "تلفن همراه")]
        public String CellPhoneNumber { get; set; }

        [Display(Name = "تلفن")]
        [DataType(DataType.PhoneNumber)]
        public String PhoneNumber { get; set; }

        [Display(Name = "کد ملی")]
        [MaxLength(10)]
        [MinLength(10)]
        [Required(AllowEmptyStrings = false)]
        public String NationalCode { get; set; }

        [Display(Name = "تاریخ تولد")]
        [DataType(DataType.Date)]
        //[Required(ErrorMessage= "تاریخ تولد را تکمیل کنید")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "وضعیت تاهل")]
        public DomainEnums.MarriageStatus DomMarriageStatus { get; set; }

        [Display(Name = "تعداد فرزندان")]
        public Byte NumChild { get; set; }

        [Display(Name = "جنسیت")]
        public DomainEnums.Gender DomGender { get; set; }

        [Display(Name = "تحصیلات")]
        public DomainEnums.Education DomEducation { get; set; }

        [Display(Name = "وضعیت اشتغال")]
        public DomainEnums.JobStatus DomJobStatus { get; set; }

        [Display(Name = "عنوان شغل")]
        public String JobTitle { get; set; }
    }
}