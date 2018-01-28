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
            //Domains.Add(new Domain { ID = DomainEnums.Domains.RecordStatus.Value(), Name = "RecordStatus", Title = "وضعیت رکورد", Parent = null });
            Domains.Add(new Domain { ID = DomainEnums.Domains.RecordStatus.Value(), Name = DomainEnums.Domains.RecordStatus.ToString(), Title = DomainEnums.Domains.RecordStatus.GetDescription(), Parent = null });
            objDomains = Domains.Where(x => x.Name == DomainEnums.Domains.RecordStatus.ToString()).FirstOrDefault();
            Domains.Add(new Domain { ID = DomainEnums.Domains.RecordEnabled.Value(), Name = DomainEnums.Domains.RecordEnabled.ToString(), Title = DomainEnums.Domains.RecordEnabled.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.RecordDisabled.Value(), Name = DomainEnums.Domains.RecordDisabled.ToString(), Title = DomainEnums.Domains.RecordDisabled.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.RecordDeleted.Value(), Name = DomainEnums.Domains.RecordDeleted.ToString(), Title = DomainEnums.Domains.RecordDeleted.GetDescription(), Parent = objDomains });
            //-------------------------------------  ماه های سال-------------------------------------------
            Domains.Add(new Domain { ID = DomainEnums.Domains.Months.Value(), Name = DomainEnums.Domains.Months.ToString(), Title = DomainEnums.Domains.Months.GetDescription(), Parent = null });
            objDomains = Domains.Where(x => x.Name == DomainEnums.Domains.Months.ToString()).FirstOrDefault();
            Domains.Add(new Domain { ID = DomainEnums.Domains.Farvardin.Value(), Name = DomainEnums.Domains.Farvardin.ToString(), Title = DomainEnums.Domains.Farvardin.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Ordibehesht.Value(), Name = DomainEnums.Domains.Ordibehesht.ToString(), Title = DomainEnums.Domains.Ordibehesht.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Khordad.Value(), Name = DomainEnums.Domains.Khordad.ToString(), Title = DomainEnums.Domains.Khordad.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Tir.Value(), Name = DomainEnums.Domains.Tir.ToString(), Title = DomainEnums.Domains.Tir.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Mordad.Value(), Name = DomainEnums.Domains.Mordad.ToString(), Title = DomainEnums.Domains.Mordad.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Shahrivar.Value(), Name = DomainEnums.Domains.Shahrivar.ToString(), Title = DomainEnums.Domains.Shahrivar.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Mehr.Value(), Name = DomainEnums.Domains.Mehr.ToString(), Title = DomainEnums.Domains.Mehr.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Aban.Value(), Name = DomainEnums.Domains.Aban.ToString(), Title = DomainEnums.Domains.Aban.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Azar.Value(), Name = DomainEnums.Domains.Azar.ToString(), Title = DomainEnums.Domains.Azar.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Dey.Value(), Name = DomainEnums.Domains.Dey.ToString(), Title = DomainEnums.Domains.Dey.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Bahman.Value(), Name = DomainEnums.Domains.Bahman.ToString(), Title = DomainEnums.Domains.Bahman.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Esfand.Value(), Name = DomainEnums.Domains.Esfand.ToString(), Title = DomainEnums.Domains.Esfand.GetDescription(), Parent = objDomains });
            //-------------------------------------  وضعیت کاربر-------------------------------------------
            Domains.Add(new Domain { ID = DomainEnums.Domains.UserStatus.Value(), Name = DomainEnums.Domains.UserStatus.ToString(), Title = DomainEnums.Domains.UserStatus.GetDescription(), Parent = null });
            objDomains = Domains.Where(x => x.Name == DomainEnums.Domains.UserStatus.ToString()).FirstOrDefault();
            Domains.Add(new Domain { ID = DomainEnums.Domains.UserDisabled.Value(), Name = DomainEnums.Domains.UserDisabled.ToString(), Title = DomainEnums.Domains.UserDisabled.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.UserEnabled.Value(), Name = DomainEnums.Domains.UserEnabled.ToString(), Title = DomainEnums.Domains.UserEnabled.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.UserDeleted.Value(), Name = DomainEnums.Domains.UserDeleted.ToString(), Title = DomainEnums.Domains.UserDeleted.GetDescription(), Parent = objDomains });
            //-------------------------------------  نوع کاربر-------------------------------------------
            Domains.Add(new Domain { ID = DomainEnums.Domains.UserType.Value(), Name = DomainEnums.Domains.UserType.ToString(), Title = DomainEnums.Domains.UserType.GetDescription(), Parent = null });
            objDomains = Domains.Where(x => x.Name == DomainEnums.Domains.UserType.ToString()).FirstOrDefault();
            Domains.Add(new Domain { ID = DomainEnums.Domains.UserAdmin.Value(), Name = DomainEnums.Domains.UserAdmin.ToString(), Title = DomainEnums.Domains.UserAdmin.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.UserSystem.Value(), Name = DomainEnums.Domains.UserAdmin.ToString(), Title = DomainEnums.Domains.UserAdmin.GetDescription(), Parent = objDomains });
            //-------------------------------------  وضعیت تاهل-------------------------------------------
            Domains.Add(new Domain { ID = DomainEnums.Domains.MarriageStatus.Value(), Name = DomainEnums.Domains.MarriageStatus.ToString(), Title = DomainEnums.Domains.MarriageStatus.GetDescription(), Parent = null });
            objDomains = Domains.Where(x => x.Name == DomainEnums.Domains.MarriageStatus.ToString()).FirstOrDefault();
            Domains.Add(new Domain { ID = DomainEnums.Domains.Married.Value(), Name = DomainEnums.Domains.Married.ToString(), Title = DomainEnums.Domains.Married.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Single.Value(), Name = DomainEnums.Domains.Single.ToString(), Title = DomainEnums.Domains.Single.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Divorced.Value(), Name = DomainEnums.Domains.Divorced.ToString(), Title = DomainEnums.Domains.Divorced.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.UnkownMarriage.Value(), Name = DomainEnums.Domains.UnkownMarriage.ToString(), Title = DomainEnums.Domains.UnkownMarriage.GetDescription(), Status = false, Parent = objDomains });
            //-------------------------------------  جنسیت-------------------------------------------
            Domains.Add(new Domain { ID = DomainEnums.Domains.Gender.Value(), Name = DomainEnums.Domains.Gender.ToString(), Title = DomainEnums.Domains.Gender.GetDescription(), Parent = null });
            objDomains = Domains.Where(x => x.Name == DomainEnums.Domains.Gender.ToString()).FirstOrDefault();
            Domains.Add(new Domain { ID = DomainEnums.Domains.Male.Value(), Name = DomainEnums.Domains.Male.ToString(), Title = DomainEnums.Domains.Male.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Female.Value(), Name = DomainEnums.Domains.Female.ToString(), Title = DomainEnums.Domains.Female.GetDescription(), Parent = objDomains });
            //-------------------------------------  تحصیلات-------------------------------------------
            Domains.Add(new Domain { ID = DomainEnums.Domains.Education.Value(), Name = DomainEnums.Domains.Education.ToString(), Title = DomainEnums.Domains.Education.GetDescription(), Parent = null });
            objDomains = Domains.Where(x => x.Name == DomainEnums.Domains.Education.ToString()).FirstOrDefault();
            Domains.Add(new Domain { ID = DomainEnums.Domains.UnknownDegree.Value(), Name = DomainEnums.Domains.UnknownDegree.ToString(), Title = DomainEnums.Domains.UnknownDegree.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Illiterate.Value(), Name = DomainEnums.Domains.Illiterate.ToString(), Title = DomainEnums.Domains.Illiterate.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Elementary.Value(), Name = DomainEnums.Domains.Elementary.ToString(), Title = DomainEnums.Domains.Elementary.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Secondary.Value(), Name = DomainEnums.Domains.Secondary.ToString(), Title = DomainEnums.Domains.Secondary.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Diploma.Value(), Name = DomainEnums.Domains.Diploma.ToString(), Title = DomainEnums.Domains.Diploma.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Associate.Value(), Name = DomainEnums.Domains.Associate.ToString(), Title = DomainEnums.Domains.Associate.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Bachelor.Value(), Name = DomainEnums.Domains.Bachelor.ToString(), Title = DomainEnums.Domains.Bachelor.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Master.Value(), Name = DomainEnums.Domains.Master.ToString(), Title = DomainEnums.Domains.Master.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.PhD.Value(), Name = DomainEnums.Domains.PhD.ToString(), Title = DomainEnums.Domains.PhD.GetDescription(), Parent = objDomains });
            //-------------------------------------  وضعیت اشتغال-------------------------------------------
            Domains.Add(new Domain { ID = DomainEnums.Domains.JobStatus.Value(), Name = DomainEnums.Domains.JobStatus.ToString(), Title = DomainEnums.Domains.JobStatus.GetDescription(), Parent = null });
            objDomains = Domains.Where(x => x.Name == DomainEnums.Domains.JobStatus.ToString()).FirstOrDefault();
            Domains.Add(new Domain { ID = DomainEnums.Domains.OtherJob.Value(), Name = DomainEnums.Domains.OtherJob.ToString(), Title = DomainEnums.Domains.OtherJob.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.Employed.Value(), Name = DomainEnums.Domains.Employed.ToString(), Title = DomainEnums.Domains.Employed.GetDescription(), Parent = objDomains });
            Domains.Add(new Domain { ID = DomainEnums.Domains.UnEmployed.Value(), Name = DomainEnums.Domains.UnEmployed.ToString(), Title = DomainEnums.Domains.UnEmployed.GetDescription(), Parent = objDomains });
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
