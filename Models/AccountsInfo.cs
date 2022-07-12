using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace LibraryManagmentSystem.Models
{
    public class AccountsInfo
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }

        internal static IQueryable<AccountsInfo> AsNoTracking()
        {
            throw new NotImplementedException();
        }
    }
}
