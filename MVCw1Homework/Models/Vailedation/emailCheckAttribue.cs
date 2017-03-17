using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MVCw1Homework.Models.Vailedation
{
    public class emailCheckAttribue:DataTypeAttribute
    {
        private 客戶資料Entities1 db = new 客戶資料Entities1();
        public emailCheckAttribue() : base(DataType.Text)
        {
            ErrorMessage = @"Email格式錯誤 或 相同客戶下的聯絡人E-mail不得重複!!";

        }
        public override bool IsValid(object value)
        {
            //手機驗證
            string mailaddr = Convert.ToString(value);
            if (Regex.IsMatch(mailaddr, "\\@[A-Za-z0-9]"))
            {
                //確認格式沒有問題後檢查是否有重複的EMAIL
                var data = db.客戶聯絡人.AsQueryable();
                data= data.Where(d => d.Email.Contains(value.ToString()));
                IList s = data.ToList();
                if (s.Count==0)
                {
                    ErrorMessage = @"相同客戶下的聯絡人E-mail不得重複!! ";
                    return true; }
                else
                {
                    return false;
                }
            }

            return false;
        }
    }
}