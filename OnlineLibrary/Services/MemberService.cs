using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineLibrary.Models.People;

namespace OnlineLibrary.Services
{
    public class MemberService
    {
        public static List<Member> members = new List<Member>();

        public static void AddMemeber(Member member)
        {
            if (member is null)
                return;
            members.Add(member);
        }

        public static void UpdateMember(Member member)
        {
            int index = members.FindIndex(c => c.MemberID == member.MemberID);
            if (index == -1)
                return;
            members[index] = member;
        }

        public static void RemoveMember(string id)
        {
            var member = members.FirstOrDefault(c => c.MemberID == id);
            if (member is null)
                return;
            members.Remove(member);
            Console.WriteLine("Removed Member . . .");
        }
    }
}
