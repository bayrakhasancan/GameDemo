using GameDemo.Abstract;
using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business
{
    class MemberCheckManager : IMemberCheckService
    {
        public bool IsMemberReal(Member member)
        {
            Console.WriteLine(member.Name + " gerçek bir kişidir.");
            return true;
        }
    }
}
