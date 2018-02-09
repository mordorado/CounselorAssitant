using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CounselorAssistant.Models
{
    [Table("Reservaion")]
    public class Reservaion : BaseEntity
    {
        #region Configuration
        internal class Configuration : EntityTypeConfiguration<Reservaion>
        {
            public Configuration()
            {
            }
        }
        #endregion Configuration

        #region Contsructor
        /// <summary>
        /// سازنده پیش فرض 
        /// </summary>
        public Reservaion()
        {
        }
        #endregion  Contsructor

        #region Properties
        /// <summary>
        /// تاریخ و ساعت ملاقات با درمانگر 
        /// </summary>

        [Display(Name ="تاریخ و ساعت ")]
        public DateTime ReserveDateTime { get; set; }

        /// <summary>
        /// مشخصات متقاضی (مراجعه کننده)
        /// </summary>
        [Display(Name = "متقاضی ")]
        public long? Patient_PeoID { get; set; }

        /// <summary>
        /// مشخصات درمانگر
        /// </summary>
        [Display(Name = "درمانگر")]
        public long? Consultant_PeoID { get; set; }

        /// <summary>
        /// ضمایم 
        /// </summary>
        [Display(Name = " ضمایم")]
        public long? AttachmentGroupID { get; set; }

        /// <summary>
        /// مشخصات مالی (پرداختی ها و جزئیات بدهکاری)؛
        /// </summary>
        [Display(Name = "مشخصات مالی")]
        public long? FinancialGroupID { get; set; }
        #endregion Properties

        #region Methods

        #endregion Methods

    }
}