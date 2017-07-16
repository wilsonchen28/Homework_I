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
        [NoIs("skilltree,demo,twMVC", ErrorMessage = "請使用別的名稱")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w.+\@\w.+")]
        [Display(Name = "帳號")]
        public string Account { get; set; }
        [StringLength(20, MinimumLength = 4)]
        [Display(Name = "密碼")]
        public string Password { get; set; }
        public string Message { get; set; }
    }
}