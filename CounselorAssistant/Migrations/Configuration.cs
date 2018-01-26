namespace CounselorAssistant.Migrations
{
    using System.Linq;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Collections.Generic;
    using System.Collections;
    using CounselorAssistant.Models;
        internal sealed class Configuration : DbMigrationsConfiguration<CounselorAssistant.Models.AssistantContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Models.AssistantContext"; ;
        }

        protected override void Seed(CounselorAssistant.Models.AssistantContext context)
        {
            Domain objDomains = new Domain();
            People objPeople = new People();
            User objUser = new User();
            List<Domain> Domains = new List<Domain>();
            List<People> People = new List<People>();
            List<User> Users = new List<User>();
            //-------------------------------------  انواع وضعیت رکورد-------------------------------------------
            Domains.Add(new Domain { ID = DomainEnums.Domains.RecordStatus.Value(), Name = "RecordStatus", Title = "وضعیت رکورد", Parent = null });
            objDomains = Domains.Where(x => x.Name == DomainEnums.Domains.RecordStatus.ToString()).FirstOrDefault();
            Domains.Add(new Domain { ID = DomainEnums.Domains.RecordEnabled.Value(), Name = "RecordEnabled", Title = "فعال", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.RecordDisabled.Value(), Name = "RecordDisabled", Title = "غیرفعال", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.RecordDeleted.Value(), Name = "RecordDeleted", Title = "حذف شده", Parent = objDomains });
            //-------------------------------------  ماه های سال-------------------------------------------
            Domains.Add(new Domain { ID = DomainEnums.Domains.Months.Value(), Name = "Months", Title = "ماه های سال", Parent = null });
            objDomains = Domains.Where(x => x.Name == DomainEnums.Domains.Months.ToString()).FirstOrDefault();
            Domains.Add(new Domain { ID = DomainEnums.Domains.Farvardin.Value(), Name = "Farvardin", Title = "فروردین", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Ordibehesht.Value(), Name = "Ordibehesht", Title = "اردیبهشت", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Khordad.Value(), Name = "Khordad", Title = "خرداد", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Tir.Value(), Name = "Tir", Title = "تیر", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Mordad.Value(), Name = "Mordad", Title = "مرداد", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Shahrivar.Value(), Name = "Shahrivar", Title = "شهریور", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Mehr.Value(), Name = "Mehr", Title = "مهر", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Aban.Value(), Name = "Aban", Title = "آبان", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Azar.Value(), Name = "Azar", Title = "آذر", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Dey.Value(), Name = "Dey", Title = "دی", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Bahman.Value(), Name = "Bahman", Title = "بهمن", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Esfand.Value(), Name = "Esfand", Title = "اسفند", Parent = objDomains });
            //-------------------------------------  وضعیت کاربر-------------------------------------------
            Domains.Add(new Domain { ID = DomainEnums.Domains.UserStatus.Value(), Name = "UserStatus", Title = "وضعیت کاربر", Parent = null });
            objDomains = Domains.Where(x => x.Name == DomainEnums.Domains.UserStatus.ToString()).FirstOrDefault();
            Domains.Add(new Domain { ID = DomainEnums.Domains.UserDisabled.Value(), Name = "UserDisabled", Title = "فعال", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.UserEnabled.Value(), Name = "UserEnabled", Title = "غیرفعال", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.UserDeleted.Value(), Name = "UserDeleted", Title = "حذف شده", Parent = objDomains });
            //-------------------------------------  نوع کاربر-------------------------------------------
            Domains.Add(new Domain { ID = DomainEnums.Domains.UserType.Value(), Name = "UserType", Title = "نوع کاربر", Parent = null });
            objDomains = Domains.Where(x => x.Name == DomainEnums.Domains.UserType.ToString()).FirstOrDefault();
            Domains.Add(new Domain { ID = DomainEnums.Domains.UserAdmin.Value(), Name = "UserAdmin", Title = "کاربر مدیر", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.UserSystem.Value(), Name = "UserSystem", Title = "کاربر سیستم", Parent = objDomains });
            //-------------------------------------  وضعیت تاهل-------------------------------------------
            Domains.Add(new Domain { ID = DomainEnums.Domains.MarriageStatus.Value(), Name = "MarriageStatus", Title = "وضعیت تاهل", Parent = null });
            objDomains = Domains.Where(x => x.Name == DomainEnums.Domains.MarriageStatus.ToString()).FirstOrDefault();
            Domains.Add(new Domain { ID = DomainEnums.Domains.Married.Value(), Name = "Married", Title = "متاهل", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Single.Value(), Name = "Single", Title = "مجرد", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Divorced.Value(), Name = "Divorced", Title = "مطلقه", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.UnkownMarriage.Value(), Name = "UnkownMarriage", Title = "نامشخص", Status = false, Parent = objDomains });
            //-------------------------------------  جنسیت-------------------------------------------
            Domains.Add(new Domain { ID = DomainEnums.Domains.Gender.Value(), Name = "Gender", Title = "جنسیت", Parent = null });
            objDomains = Domains.Where(x => x.Name == DomainEnums.Domains.Gender.ToString()).FirstOrDefault();
            Domains.Add(new Domain { ID = DomainEnums.Domains.Male.Value(), Name = "Male", Title = "مرد", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Female.Value(), Name = "Female", Title = "زن", Parent = objDomains });
            //-------------------------------------  تحصیلات-------------------------------------------
            Domains.Add(new Domain { ID = DomainEnums.Domains.Education.Value(), Name = "Education", Title = "تحصیلات", Parent = null });
            objDomains = Domains.Where(x => x.Name == DomainEnums.Domains.Education.ToString()).FirstOrDefault();
            Domains.Add(new Domain { ID = DomainEnums.Domains.UnknownDegree.Value(), Name = "UnknownDegree", Title = "نامشخص", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Illiterate.Value(), Name = "Illiterate", Title = "بیسواد", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Elementary.Value(), Name = "Elementary", Title = "ابتدایی", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Secondary.Value(), Name = "Secondary", Title = "متوسطه", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Diploma.Value(), Name = "Diploma", Title = "دیپلم", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Associate.Value(), Name = "Associate", Title = "فوق دیپلم", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Bachelor.Value(), Name = "Bachelor", Title = "کارشناسی", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Master.Value(), Name = "Master", Title = "کارشناسی ارشد", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.PhD.Value(), Name = "PhD", Title = "دکترا", Parent = objDomains });
            //-------------------------------------  وضعیت اشتغال-------------------------------------------
            Domains.Add(new Domain { ID = DomainEnums.Domains.JobStatus.Value(), Name = "JobStatus", Title = "وضعیت اشتغال", Parent = null });
            objDomains = Domains.Where(x => x.Name == DomainEnums.Domains.JobStatus.ToString()).FirstOrDefault();
            Domains.Add(new Domain { ID = DomainEnums.Domains.OtherJob.Value(), Name = " OtherJob", Title = "سایر موارد", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Employed.Value(), Name = "Employed", Title = "شاغل", Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.UnEmployed.Value(), Name = "UnEmployed", Title = "بیکار", Parent = objDomains });
            //----------------------بروزرسانی جدول دومین-----------------------
            Domains.ForEach(s => context.Domains.AddOrUpdate(s));
            context.SaveChanges();
            //----------------------------------------------------------------------------------------------
            //People.Add(new People { Name = "راهبر", Family = "ارشد" });
            //People.ForEach(s => context.People.AddOrUpdate(s));

            //context.SaveChanges();

        }
    }
}
