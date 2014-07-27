using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RoleManagementSample.Models
{
    public class RoleViewModel
    {
        [Required]
        [DisplayName("ロール名")]
        public string Name { get; set; }
    }
    public class ManagementViewModel
    {
        public ICollection<ApplicationRole> Roles { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }
    }
    public class AccountRecordViewModel
    {
        public ApplicationUser User { get; set; }
        public ICollection<ApplicationRole> Roles { get; set; }
    }
    public class AttachRoleViewModel
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
    public class AccountViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "{0} の長さは {2} 文字以上である必要があります。", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "パスワード")]
        public string Password { get; set; }
    }
}