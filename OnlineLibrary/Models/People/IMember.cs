using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Models.People
{
    public interface IMember : IPerson
    {
        string MemberID { get; set; }
        DateTime RegisteryDate { get; set; }
        DateTime MembershipExpiryDate { get; set; }
    }
}
