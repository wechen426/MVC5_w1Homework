using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MVCw1Homework.Models.Vailedation
{
    public class 手機號碼驗證Attribue:DataTypeAttribute
    {
        public 手機號碼驗證Attribue() : base(DataType.Text)
        {
            ErrorMessage = "手機號碼格式錯誤 (格式09XX-XXXXXX)";

        }
        public override bool IsValid(object value)
        {
            //手機驗證
            string mobile = Convert.ToString(value);
            //if(mobile.Length == 10 && mobile.Substring(0,2)=="09" && mobile.Substring(4,1)=="-")
            //{
            //    return true;
            //}
         
            if (Regex.IsMatch(mobile, "\\d{4}-\\d{6}")  && mobile.Substring(0, 2) == "09")
            {
                return true;
            }

                return false;
        }
    }
}