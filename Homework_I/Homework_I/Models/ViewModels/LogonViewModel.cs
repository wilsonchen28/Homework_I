using Homework_I.ValidateAttribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework_I.Models.ViewModels
{
    public class LogonViewModel
    {
        [Required]
        //[RegularExpression(@"\w.+\@\w.+", ErrorMessage = "帳號請輸入EMail格式！")]
        [NoIs("skilltree,demo,twMVC", ErrorMessage = "請使用別的名稱！")]
        [Display(Name = "帳號")]
        [Email(ErrorMessage ="帳號格式錯誤！")]
        public string Account { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 4)]
        [Display(Name = "密碼")]
        public string Password { get; set; }
        public string Message { get; set; }
    }
}