using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Models.People
{
    public class Member : IMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MemberID { get; set; }
        public DateTime RegisteryDate { get; set; }
        public DateTime MembershipExpiryDate { get; set; }
        public int Age { get; set; }
        public string SSN { get; set; }
    }
}
