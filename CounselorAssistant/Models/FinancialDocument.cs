using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace CounselorAssistant.Models
{
    [Table("FinancialDocument")]
    public class FinancialDocument : BaseEntity
    {
        #region Configuration
        internal class Configuration : EntityTypeConfiguration<User>
        {
            public Configuration()
            {
            }
        }

        #endregion Configuration

        #region Constructor
        /// <summary>
        /// تابع سازنده کلاس اسناد مالی
        /// </summary>
        public FinancialDocument()
        {
        }

        #endregion Constructor

        #region Properties
        /// <summary>
        /// تاریخ و ساعت پرداخت
        /// </summary>
        public DateTime PaymentDate { get; set; }
        /// <summary>
        /// نوع پرداخت
        /// </summary>
        public DomainEnums.PaymentType DomPaymentType { get; set; }

        /// <summary>
        /// مبلغ پرداختی
        /// </summary>
        public long Amount { get; set; }

        /// <summary>
        /// تاریخ سررسید
        /// </summary>
        public DateTime DueDate { get; set; }
        /// <summary>
        /// ضمایم
        /// </summary>
        public long AttachmentGroupID { get; set; }

        #endregion Properties

        #region Methods

        #endregion Methods
    }
}