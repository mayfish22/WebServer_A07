using System.ComponentModel.DataAnnotations;

namespace WebServer.Models
{
    public class SigninViewModel
    {
        //帳號
        [Display(Name = "帳號")]
        [Required(ErrorMessage = "帳號必填")]
        public string? Account { get; set; }
        //密碼
        [Display(Name = "密碼")]
        [Required(ErrorMessage = "密碼必填")]
        public string? Password { get; set; }
        //登入後轉跳的頁面
        public string? ReturnUrl { get; set; }
        //錯誤訊息
        public string? ErrorMessage { get; set; }
    }
}