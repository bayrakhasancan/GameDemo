using GameDemo.Abstract;
using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business
{
    class MemberManager : IManager
    {
        private Member _member;

        public MemberManager(Member member, IMemberCheckService memberCheckService)
        {
            if (!memberCheckService.IsMemberReal(member))
                throw new Exception("Gerçek bir kişi ekleyiniz.");

            _member = member;
        }
        public void Add()
        {
            Console.WriteLine(_member.Name + " added");
        }

        public void Delete()
        {
            Console.WriteLine(_member.Name + "Member deleted");
        }

        public void Update()
        {
            Console.WriteLine(_member.Name + "Member updated");
        }
    }
}
