//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class 客戶聯絡人
    {
        public int Id { get; set; }
        public int 客戶Id { get; set; }
        [Required]
        public string 職稱 { get; set; }
        [Required]
        public string 姓名 { get; set; }
        [Required]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Email格式錯誤")]
        public string Email { get; set; }
        [Required]
        [RegularExpression("\\d{4}-\\d{6}", ErrorMessage = "電話請填手機，例如：0910-123456")]
        public string 手機 { get; set; }
        [Required]
        [RegularExpression("\\d{2}-\\d{8}", ErrorMessage = "例如：04-12345678")]
        public string 電話 { get; set; }
        public Nullable<bool> 是否已刪除 { get; set; }
    
        public virtual 客戶資料 客戶資料 { get; set; }
    }
}
