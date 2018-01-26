using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CounselorAssistant.Models
{
    [ComplexType]
    public class AdressComplex
    {
        public AdressComplex()
        {

        }
        [MaxLength(50, ErrorMessage = "حداکثر تعداد حروف استان 50 کاراکتر می باشد")]
        [Display(Name = "استان")]
        public string State { get; set; }

        [MaxLength(50, ErrorMessage = "حداکثر تعداد حروف شهر 50 کاراکتر می باشد")]
        [Display(Name = "شهر")]
        public string City { get; set; }

        [MaxLength(100, ErrorMessage = "حداکثر تعداد حروف خیابان اصلی 100 کاراکتر می باشد")]
        [Display(Name="خیابان اصلی")]
        public string MainStreet { get; set; }

        [MaxLength(100, ErrorMessage = "حداکثر تعداد حروف خیابان فرعی 100 کاراکتر می باشد")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "لطفا خیابان فرعی را تکمیل نمایید")]
        [Display(Name = "خیابان فرعی")]
        public string Alley { get; set; }

        [MaxLength(10, ErrorMessage = "حداکثر تعداد حروف پلاک 10 کاراکتر می باشد")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "لطفا پلاک را تکمیل نمایید")]
        [Display(Name = "پلاک")]
        public string Plaque { get; set; }

        [MaxLength(10, ErrorMessage = "حداکثر تعداد حروف شماره واحد 10 کاراکتر می باشد")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "لطفا شماره واحد را تکمیل نمایید")]
        [Display(Name = "شماره واحد")]
        public string UnitNo { get; set; }
    }
}