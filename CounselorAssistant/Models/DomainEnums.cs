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
            [Description("فروردین")]
            Farvardin = 9,
            [Description("اردیبهشت")]
            Ordibehesht = 10,
            [Description("خرداد")]
            Khordad = 11,
            [Description("تیر ")]
            Tir = 12,
            [Description("مرداد")]
            Mordad = 13,
            [Description("شهریور")]
            Shahrivar = 14,
            [Description("مهر")]
            Mehr = 15,
            [Description("آبان")]
            Aban = 16,
            [Description("آذر")]
            Azar = 17,
            [Description("دی")]
            Dey = 18,
            [Description("بهمن")]
            Bahman = 19,
            [Description("اسفند")]
            Esfand = 20,
            //-------------وضعیت کاربر
            [Description("وضعیت کاربر")]
            UserStatus = 21,
            [Description("فعال")]
            UserEnabled = 22,
            [Description("غیرفعال")]
            UserDisabled = 23,
            [Description("حذف شده")]
            UserDeleted = 24,
            //--------------نوع کاربر
            [Description("نوع کاربر")]
            UserType = 25,
            [Description("کاربر مدیر")]
            UserAdmin = 26,
            [Description("کاربر سیستم")]
            UserSystem = 27,
            //[Description("رزرو")]
            //UserSystem = 28,
            //--------------وضعیت تاهل
            [Description("وضعیت تاهل")]
            MarriageStatus = 29,
            [Description("متاهل")]
            Married = 30,
            [Description("مجرد")]
            Single = 31,
            [Description("مطلقه")]
            Divorced = 32,
            [Description("نامشخص")]
            UnkownMarriage = 33,
            //--------------جنسیت
            [Description("مرد")]
            Gender = 34,
            [Description("مرد")]
            Male = 35,
            [Description("زن")]
            Female = 36,
            //--------------تحصیلات
            [Description("تحصیلات")]
            Education = 37,
            [Description("نامشخص")]
            UnknownDegree = 38,
            [Description("بیسواد")]
            Illiterate = 39,
            [Description("ابتدایی")]
            Elementary = 40,
            [Description("متوسطه")]
            Secondary = 41,
            [Description("دیپلم")]
            Diploma = 42,
            [Description("فوق دیپلم")]
            Associate = 43,
            [Description("کارشناسی")]
            Bachelor = 44,
            [Description("کارشناسی ارشد")]
            Master = 45,
            [Description("دکترا")]
            PhD = 46,
            //--------------وضعیت اشتغال
            [Description("وضعیت اشتغال")]
            JobStatus = 47,
            [Description("سایر موارد")]
            OtherJob = 48,
            [Description("شاغل")]
            Employed = 49,
            [Description("بیکار")]
            UnEmployed = 50,

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
        public enum JobStatus
        {
            [Description("سایر موارد")]
            OtherJob = Domains.OtherJob,
            [Description("شاغل")]
            Employed = Domains.Employed,
            [Description("بیکار")]
            UnEmployed = Domains.UnEmployed
        }
    }
}