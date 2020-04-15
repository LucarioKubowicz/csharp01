using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Member ziom = new Member("FistN", "LastN");
            Member drugi = new Member(65,"Steve","Wozniak");
        }
    }
    class Member
    {
        private byte _memberAge;
        private string _memberFirstName;
        private string _memberLastName;

        public string PropMemberFirstName
        {
            get => _memberFirstName;
            set => _memberFirstName = value;
        }

        public string PropMemberLastName
        {
            get => _memberLastName;
            set => _memberLastName = value;
        }

        public byte PropMemberAge
        {
            get => _memberAge;
            set => _memberAge = value;
        }
        
        public Member(string P_memberFirstName, string P_memberLastName)
        {
            _memberFirstName = P_memberFirstName;
            _memberLastName = P_memberLastName;
            Console.WriteLine($"2 P. {P_memberFirstName} {P_memberLastName}");
        }
        public Member(byte P_memberAge, string P_memberFirstName, string P_memberLastName)
        {
            _memberAge = P_memberAge;
            _memberFirstName = P_memberFirstName;
            _memberLastName = P_memberLastName;
            Console.WriteLine($"3 P. Wiek:{P_memberAge}, Imię:{P_memberFirstName}, Nazwisko:{P_memberLastName}");
        }
    }


}