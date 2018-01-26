using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CounselorAssistant.Models
{
    [ComplexType]
    public class ContactComplex
    {
        public  ContactComplex()
        {

        }
        [Display(Name = "تلفن تماس")]
        public string Phone { get; set; }

        [Display(Name = "شماره فکس")]
        public string Fax { get; set; }

        [Display(Name = "پست الکترونیک")]
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }

        [Display(Name = "تلفن همراه")]
        
        public string Mobile { get; set; }

    }
}