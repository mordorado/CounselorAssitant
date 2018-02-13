using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CounselorAssistant.Models
{
    public static class DomainEnums
    {
        public enum Domains
        {/// <summary>
         /// وضعیت رکورد    
         /// </summary>
            [Description("وضعیت رکورد")]
            RecordStatus = 1,
            /// <summary>
            ///  رکورد فعال
            /// </summary>
            [Description("فعال")]
            RecordEnabled = 2,
            /// <summary>
            /// رکورد غیر فعال
            /// </summary>
            [Description("غیرفعال")]
            RecordDisabled = 3,
            /// <summary>
            /// رکورد حدف شده
            /// </summary>
            [Description("حذف شده")]
            RecordDeleted = 4,
            /// <summary>
            /// ماههای سال
            /// </summary>
            [Description("ماههای سال")]
            Months = 8,
            /// <summary>
            ///  فروردین
            /// </summary>
            [Description("فروردین")]
            Farvardin = 9,
            /// <summary>
            ///  اردیبهشت
            /// </summary>
            [Description("اردیبهشت")]
            Ordibehesht = 10,
            /// <summary>
            ///  خرداد
            /// </summary>
            [Description("خرداد")]
            Khordad = 11,
            /// <summary>
            ///  تیر
            /// </summary>
            [Description("تیر ")]
            Tir = 12,
            /// <summary>
            ///  مرداد
            /// </summary>
            [Description("مرداد")]
            Mordad = 13,
            /// <summary>
            ///  شهریور
            /// </summary>
            [Description("شهریور")]
            Shahrivar = 14,
            /// <summary>
            ///  مهر
            /// </summary>
            [Description("مهر")]
            Mehr = 15,
            /// <summary>
            ///  آبان
            /// </summary>
            [Description("آبان")]
            Aban = 16,
            /// <summary>
            ///  آذر
            /// </summary>
            [Description("آذر")]
            Azar = 17,
            /// <summary>
            ///  دی
            /// </summary>
            [Description("دی")]
            Dey = 18,
            /// <summary>
            ///  بهمن
            /// </summary>
            [Description("بهمن")]
            Bahman = 19,
            /// <summary>
            ///  اسفند
            /// </summary>
            [Description("اسفند")]
            Esfand = 20,
            //-------------وضعیت کاربر
            /// <summary>
            ///  وضعیت کاربر
            /// </summary>
            [Description("وضعیت کاربر")]
            UserStatus = 21,
            /// <summary>
            ///  فعال
            /// </summary>
            [Description("فعال")]
            UserEnabled = 22,
            /// <summary>
            ///  غیرفعال
            /// </summary>
            [Description("غیرفعال")]
            UserDisabled = 23,
            /// <summary>
            ///  حذف شده
            /// </summary>
            [Description("حذف شده")]
            UserDeleted = 24,
            //--------------نوع کاربر
            /// <summary>
            ///  نوع کاربر
            /// </summary>
            [Description("نوع کاربر")]
            UserType = 25,
            /// <summary>
            ///  کاربر مدیر
            /// </summary>
            [Description("کاربر مدیر")]
            UserAdmin = 26,
            /// <summary>
            ///  کاربر سیستم
            /// </summary>
            [Description("کاربر سیستم")]
            UserSystem = 27,
            //[Description("رزرو")]
            //UserSystem = 28,
            //--------------وضعیت تاهل
            /// <summary>
            ///  وضعیت تاهل
            /// </summary>
            [Description("وضعیت تاهل")]
            MarriageStatus = 29,
            /// <summary>
            ///  متاهل
            /// </summary>
            [Description("متاهل")]
            Married = 30,
            /// <summary>
            ///  مجرد
            /// </summary>
            [Description("مجرد")]
            Single = 31,
            /// <summary>
            ///  مطلقه
            /// </summary>
            [Description("مطلقه")]
            Divorced = 32,
            /// <summary>
            ///  نامشخص
            /// </summary>
            [Description("نامشخص")]
            UnkownMarriage = 33,
            //--------------جنسیت
            /// <summary>
            ///  جنسیت
            /// </summary>
            [Description("جنسیت")]
            Gender = 34,
            /// <summary>
            ///  مرد
            /// </summary>
            [Description("مرد")]
            Male = 35,
            /// <summary>
            ///  زن
            /// </summary>
            [Description("زن")]
            Female = 36,
            //--------------تحصیلات
            /// <summary>
            ///  تحصیلات
            /// </summary>
            [Description("تحصیلات")]
            Education = 37,
            /// <summary>
            ///  نامشخص
            /// </summary>
            [Description("نامشخص")]
            UnknownDegree = 38,
            /// <summary>
            ///  بیسواد
            /// </summary>
            [Description("بیسواد")]
            Illiterate = 39,
            /// <summary>
            ///  ابتدایی
            /// </summary>
            [Description("ابتدایی")]
            Elementary = 40,
            /// <summary>
            ///  متوسطه
            /// </summary>
            [Description("متوسطه")]
            Secondary = 41,
            /// <summary>
            ///  دیپلم
            /// </summary>
            [Description("دیپلم")]
            Diploma = 42,
            /// <summary>
            ///  فوق دیپلم
            /// </summary>
            [Description("فوق دیپلم")]
            Associate = 43,
            /// <summary>
            ///  کارشناسی
            /// </summary>
            [Description("کارشناسی")]
            Bachelor = 44,
            /// <summary>
            ///  کارشناسی ارشد"
            /// </summary>
            [Description("کارشناسی ارشد")]
            Master = 45,
            /// <summary>
            ///  دکترا
            /// </summary>
            [Description("دکترا")]
            PhD = 46,
            //--------------وضعیت اشتغال
            /// <summary>
            ///  وضعیت اشتغال
            /// </summary>
            [Description("وضعیت اشتغال")]
            JobStatus = 47,
            /// <summary>
            ///  سایر موارد
            /// </summary>
            [Description("سایر موارد")]
            OtherJob = 48,
            /// <summary>
            ///  شاغل
            /// </summary>
            [Description("شاغل")]
            Employed = 49,
            /// <summary>
            ///  بیکار
            /// </summary>
            [Description("بیکار")]
            UnEmployed = 50,

            //--------------نوع فایل
            /// <summary>
            ///  نوع فایل
            /// </summary>
            [Description("نوع فایل")]
            FileType = 51,
            /// <summary>
            ///  jpg
            /// </summary>
            [Description("jpg")]
            jpg = 52,
            /// <summary>
            ///  jpeg
            /// </summary>
            [Description("jpeg")]
            jpeg = 53,
            /// <summary>
            ///  pdf
            /// </summary>
            [Description("pdf")]
            pdf = 54,
            /// <summary>
            ///  gif
            /// </summary>
            [Description("gif")]
            gif = 55,
            /// <summary>
            ///  bmp
            /// </summary>
            [Description("bmp")]
            bmp = 56,
            //--------------نوع پرداخت
            /// <summary>
            ///  نوع پرداخت
            /// </summary>
            [Description("نوع پرداخت")]
            PaymentType = 57,
            /// <summary>
            ///  نقد
            /// </summary>
            [Description("نقد")]
            Cash = 58,
            /// <summary>
            ///  سند مدت دار
            /// </summary>
            [Description("سند مدت دار")]
            cheque = 59,
            /// <summary>
            ///  پرداخت متفرقه
            /// </summary>
            [Description("پرداخت متفرقه")]
            OtherPayment = 60

        }
        public enum RecordStatus : long
        {
            [Description("فعال")]
            RecordEnabled = Domains.RecordEnabled,
            [Description("غیرفعال")]
            RecordDisabled = Domains.RecordDisabled,
            [Description("حذف شده")]
            RecordDeleted = Domains.RecordDeleted,
        }

        [Description("ماههای سال")]
        public enum Months : long
        {
            [Description("فروردین")]
            Farvardin = Domains.Farvardin,
            [Description("اردیبهشت")]
            Ordibehesht = Domains.Ordibehesht,
            [Description("خرداد")]
            Khordad = Domains.Khordad,
            [Description("تیر ")]
            Tir = Domains.Tir,
            [Description("مرداد")]
            Mordad = Domains.Tir,
            [Description("شهریور")]
            Shahrivar = Domains.Shahrivar,
            [Description("مهر")]
            Mehr = Domains.Mehr,
            [Description("آبان")]
            Aban = Domains.Aban,
            [Description("آذر")]
            Azar = Domains.Azar,
            [Description("دی")]
            Dey = Domains.Dey,
            [Description("بهمن")]
            Bahman = Domains.Bahman,
            [Description("اسفند")]
            Esfand = Domains.Esfand
        }
        [Description("وضعیت کاربر")]
        public enum UserStatus : long
        {
            [Description("فعال")]
            UserEnabled = Domains.UserEnabled,
            [Description("غیرفعال")]
            UserDisabled = Domains.UserDisabled,
            [Description("حذف شده")]
            UserDeleted = Domains.UserDeleted
        }
        [Description("نوع کاربر")]
        public enum UserType : long
        {
            [Description("کاربر مدیر")]
            UserAdmin = Domains.UserAdmin,
            [Description("کاربر سیستم")]
            UserSystem = Domains.UserSystem
        }
        [Description("وضعیت تاهل")]
        public enum MarriageStatus : long
        {
            [Description("متاهل")]
            Married = Domains.Married,
            [Description("مجرد  ")]
            Single = Domains.Single,
            [Description("مطلقه  ")]
            Divorced = Domains.Divorced,
            [Description("نامشخص")]
            UnkownMarriage = Domains.UnkownMarriage,
        }
        public enum Gender : long
        {
            [Description("مرد")]
            Male = Domains.Male,
            [Description("زن  ")]
            Female = Domains.Female,
        }
        public enum Education : long
        {
            [Description("نامشخص")]
            UnknownDegree = Domains.UnknownDegree,
            [Description("بیسواد")]
            Illiterate = Domains.Illiterate,
            [Description("ابتدایی")]
            Elementary = Domains.Elementary,
            [Description("متوسطه")]
            Secondary = Domains.Secondary,
            [Description("دیپلم")]
            Diploma = Domains.Diploma,
            [Description("فوق دیپلم")]
            Associate = Domains.Associate,
            [Description("کارشناسی")]
            Bachelor = Domains.Bachelor,
            [Description("کارشناسی ارشد")]
            Master = Domains.Master,
            [Description("دکترا")]
            PhD = Domains.PhD
        }
        public enum JobStatus : long
        {
            [Description("سایر موارد")]
            OtherJob = Domains.OtherJob,
            [Description("شاغل")]
            Employed = Domains.Employed,
            [Description("بیکار")]
            UnEmployed = Domains.UnEmployed
        }
        public enum FileType : long
        {
            /// <summary>
            ///  jpg
            /// </summary>
            [Description("jpg")]
            jpg = Domains.jpg,
            /// <summary>
            ///  jpeg
            /// </summary>
            [Description("jpeg")]
            jpeg = Domains.jpeg,
            /// <summary>
            ///  pdf
            /// </summary>
            [Description("pdf")]
            pdf = Domains.pdf,
            /// <summary>
            ///  gif
            /// </summary>
            [Description("gif")]
            gif = Domains.gif,
            /// <summary>
            ///  bmp
            /// </summary>
            [Description("bmp")]
            bmp = Domains.bmp,
        }

        //--------------نوع پرداخت
        /// <summary>
        ///  نوع پرداخت
        /// </summary>
        [Description("نوع پرداخت")]
        public enum PaymentType : long
        {
            /// <summary>
            ///  نقد
            /// </summary>
            [Description("نقد")]
            Cash = Domains.Cash,
            /// <summary>
            ///  سند مدت دار
            /// </summary>
            [Description("سند مدت دار")]
            cheque = Domains.cheque,
            /// <summary>
            ///  پرداخت متفرقه
            /// </summary>
            [Description("پرداخت متفرقه")]
            OtherPayment = Domains.OtherPayment

        }

        /// <summary>
        /// تابع تشخیص رکورد درای وضعیت حذف شده
        /// </summary>
        /// <param name="Status">وضعیت رکورد</param>
        /// <returns>مقدار بولین که در صورتی که رکورد حذف منطقی شده باشد مقدار  صحیح برمیگرداند</returns>
        public static bool IsDeletedRecord(RecordStatus Status)
        {            
            return (Status != RecordStatus.RecordDeleted);
        }

        public static bool IsValidRecord(RecordStatus Status)
        {
            return Status.In(DomainEnums.RecordStatus.RecordDisabled, DomainEnums.RecordStatus.RecordEnabled);
        }
    }
}