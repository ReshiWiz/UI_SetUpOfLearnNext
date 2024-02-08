using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entries
{
    public class User
    {
        public int User_Id { get; set; }
        public string? User_Name { get; set; }
        public string? User_Email { get; set; }
        public string? User_Password { get; set; }
        public string? User_Phone { get; set; }
        public string? User_Dept { get; set; }
  
    }
}
