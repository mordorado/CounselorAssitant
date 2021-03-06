﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace CounselorAssistant.Models
{
    [Table("People")]
    public class People : BaseEntity
    {
        #region Configuration
        internal class Configuration : EntityTypeConfiguration<People>
        {
            public Configuration()
            {
            }
        }
        #endregion Configuration
        #region Contsructor
        public People()
        {
            DomMarriageStatus = DomainEnums.MarriageStatus.UnkownMarriage;
            DomEducation = DomainEnums.Education.UnknownDegree;
            DomGender = DomainEnums.Gender.Male;
            DomJobStatus = DomainEnums.JobStatus.OtherJob;

        }
        #endregion  Contsructor

         
        [Display(Name = "نام")]
        [StringLength(maximumLength:50)]
        [Required(AllowEmptyStrings = false)]
        public String Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        [StringLength(maximumLength:50)]
        [Required(AllowEmptyStrings = false)]
        public String Family { get; set; }

        [Display(Name = "تلفن همراه")]
        [StringLength(maximumLength:11,MinimumLength =11)]
        public String CellPhoneNumber { get; set; }

        [Display(Name = "تلفن")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20)]
        public String PhoneNumber { get; set; }

        [Display(Name = "کد ملی")]
        [StringLength(10)]
        //[Required(AllowEmptyStrings = false)]
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
        public DomainEnums.Education DomEducation { get; set; }
        public DomainEnums.JobStatus DomJobStatus { get; set; }

        [Display(Name = "عنوان شغل")]
        [StringLength(50)]
        public String JobTitle { get; set; }

    }
}