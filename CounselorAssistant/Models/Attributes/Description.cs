using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
namespace CounselorAssistant.Models
{
    public class Description:Attribute
    {
        public string Text;
        public Description(string text)
        {
            Text = text;
        }
    }
}