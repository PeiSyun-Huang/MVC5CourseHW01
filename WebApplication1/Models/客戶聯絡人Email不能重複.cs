using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class 客戶聯絡人Email不能重複
    {
        public bool IsEmailExist(客戶聯絡人 客戶聯絡人)
        {
            客戶資料Entities db = new 客戶資料Entities();
            var 同客戶的聯絡人 = db.客戶聯絡人.Where(客 => 客.客戶Id == 客戶聯絡人.客戶Id && 客.Id != 客戶聯絡人.Id).ToList();
            foreach (var item in 同客戶的聯絡人)
            {
                if (item.Email.Equals(客戶聯絡人.Email))
                {
                    return true;
                }
            }
            return false;
        }
    }
}