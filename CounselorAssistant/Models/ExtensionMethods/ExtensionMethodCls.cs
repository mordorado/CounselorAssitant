using System.Reflection;
using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using CounselorAssistant.Helpers;
using CounselorAssistant.Models;
namespace CounselorAssistant.Models
{
    public static class ExtensionMethodCls
    {
        public static SelectList GetSelectList<TEnum>(this TEnum enumObj)
            where TEnum : struct, IComparable, IFormattable, IConvertible
        {
            var values = from TEnum e in Enum.GetValues(typeof(TEnum))
                         select new
                         {
                             ID = (Convert.ToInt64(e)),
                             Name = e.ToString()
                         };

            return new SelectList(values, "Id", "Name", enumObj);
        }
        /// <summary>
        /// خروجی متن تعیین شده در 
        /// Description
        /// می باشد
        /// </summary>
        /// <param name="enu"></param>
        /// <returns></returns>
        public static string GetDescription(this Enum enu)
        {

            Type type = enu.GetType();

            MemberInfo[] memInfo = type.GetMember(enu.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {

                object[] attrs = memInfo[0].GetCustomAttributes(typeof(Description), false);

                if (attrs != null && attrs.Length > 0)
                    return ((Description)attrs[0]).Text;
            }

            return enu.ToString();
        }
        /// <summary>
        /// خروجی مقدار عددی نسبت داده شده به 
        /// enum نوع
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static long Value(this Enum enumValue)
        {
            return Convert.ToInt64(enumValue);
        }

        public static System.Web.Mvc.SelectList ToSelectList<TEnum>(this TEnum obj)
    where TEnum : struct, IComparable, IFormattable, IConvertible // correct one
        {

            return new SelectList(Enum.GetValues(typeof(TEnum)).OfType<Enum>()
                .Select(x =>
                    new SelectListItem
                    {
                        Text = x.GetDescription(),
                        Value = (Convert.ToInt32(x)).ToString()
                    }), "Value", "Text");
        }

        /// <summary>
        /// خروجی این خاصیت متنی است که توسط 
        /// EnumDisplayNameAttribute
        /// تعیین شده باشد
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DisplayName(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());

            EnumDisplayNameAttribute attribute
                    = Attribute.GetCustomAttribute(field, typeof(EnumDisplayNameAttribute))
                        as EnumDisplayNameAttribute;

            return attribute == null ? value.ToString() : attribute.DisplayName;
        }
        /// <summary>
        /// enum نوع برای  in عملگر
        /// </summary>
        /// <param name="value"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static bool In(this Enum value, params Enum[] values)
        {
            return values.Contains(value);
        }

    }

}