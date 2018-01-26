using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using CounselorAssistant.Models;

namespace CounselorAssistant.Models
{
    public partial class BaseEntity
    {
        #region Configuration
        internal class Configuration : EntityTypeConfiguration<BaseEntity>
        {
            public Configuration()
            {         
            }
        }

        #endregion Configuration
        /// <summary>
        /// سازنده پیش فرض 
        /// </summary>
        public BaseEntity()
        {
            //ID = Guid.NewGuid();
            DomStatus = DomainEnums.RecordStatus.RecordEnabled;
            Descriptions = string.Empty;
        }


        [Display(Name = "کد شناسایی")]
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        /// <summary>
        /// فیلد وضعیت رکورد که شامل فعال ،غیر فعال ، حذف ، ویرایش شده و غیره  باشد
        /// که از جدول دامین استفاده می کند
        /// </summary>
        [Display(Name = "وضعیت")]
        [Required]        
        public DomainEnums.RecordStatus  DomStatus { get; set; }

        [NotMapped]
        public string StatusTitle
        {
            get { return DomStatus.GetDescription(); ; }
        }
        [Display(Name = "توضیحات")]
        [DataType(DataType.MultilineText)]
        [Description("توضیحات")]
        public string Descriptions { get; set; }
    }
}