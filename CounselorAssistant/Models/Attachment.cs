using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CounselorAssistant.Models
{
    [Table("Attachment")]
    public class Attachment:BaseEntity
    {
        #region Configuration
        internal class Configuration : EntityTypeConfiguration<Attachment>
        {
            public Configuration()
            {
            }
        }

        #endregion Configuration

        #region Construnctor
        /// <summary>
        /// سازنده پیش فرض 
        /// </summary>
        public Attachment()
        {

        }
        #endregion Construnctor

        #region Properties
        /// <summary>
        /// اطلاعات فایل
        /// </summary>
        [Display(Description="اطلاعات فایل",Name = "اطلاعات فایل", Prompt = "اطلاعات فایل")]
        [Required(ErrorMessage ="محتوای فایل بارگذاری نشده است")]
        public byte[] FileData { get; set; }
        /// <summary>
        /// نوع فایل
        /// </summary>
        [Display(Description = "نوع فایل", Name = "نوع فایل", Prompt = "نوع فایل")]
        [Required(ErrorMessage ="نوع فایل تعیین نشده است")]
        public DomainEnums.FileType DomFileType { get; set; }

        /// <summary>
        /// عنوان نوع فایل
        /// </summary>
        [NotMapped]
        public string DataTypeTitle
        {
            get { return DomFileType.GetDescription(); ; }
        }
        #endregion Properties

        #region Methods

        #endregion Methods
    }
}