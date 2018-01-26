using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CounselorAssistant.Models
{
    public class Domain : Object
    {
        #region Configuration
        internal class Configuration : EntityTypeConfiguration<Domain>
        {
            public Configuration()
            {               
                this.HasOptional(x => x.Parent)
                    .WithMany(x => x.ChildDomain)
                    .HasForeignKey(x => x.ParentDomain)
                    .WillCascadeOnDelete(false);
            }
        }

        #endregion Configuration
        public Domain()
        {
            Status = true;
            Desc = string.Empty;
        }

        [ScaffoldColumn(false)]
        [Display(Name = "کد شناسایی")]
        [Key]
        [Required(ErrorMessage = "لطفا مقدار کلید را مشخص نمایید")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Display(Name = "نام دومین")]
        [MaxLength(50, ErrorMessage = "حداکثر طول نام دومین 50 کاراکتر می باشد")]
        public string Name { get; set; }

        [Display(Name = "عنوان دومین")]
        [MaxLength(50, ErrorMessage = "حداکثر طول عنوان دومین 50 کاراکتر می باشد")]
        public string Title { get; set; }
        [Display(Name = "وضعیت")]
        public Boolean Status { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "توضیحات")]
        public string Desc { get; set; }
        
        [Display(Name = "آیدی والد")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "آیدی والد را صحیح وارد کنید")]
        [NotMapped]
        public long? ParentDomain { get; set; }
        public virtual Domain Parent { get; set; }
        public virtual ICollection<Domain> ChildDomain{ get; set; }
        
    }
}