using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject.Pages
{
    public class UserBookProfileModel : PageModel
    {
        private FinalProjectContext _context;
        public ICollection<UserBook> UserBooks { get; set; }
        public User UserProfileName { get; set; }
        [BindProperty]
        public string SearchUser { get; set; }
        public Book Book1 { get; set; }
        public DateTime DueDate { get; set; }
        public UserBookProfileModel(FinalProjectContext context)
        {
            _context = context;
        }
        public void OnPost()
        {
            if (!string.IsNullOrWhiteSpace(SearchUser))
            {
                UserProfileName = _context.User
                                            .Where(y => y.Name.ToLower().Contains(SearchUser.ToLower())).First();
                UserBooks = _context.UserBook
                    .Where(x => x.UserId.Equals(UserProfileName.ID))
                                    .OrderBy(x => x.CheckInDate).ToList();
                
                
            }
            else
            {
                return;
            }
            
        }
    }
}