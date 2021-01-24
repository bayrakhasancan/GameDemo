using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    interface IMemberCheckService
    {
        bool IsMemberReal(Member member);
    }
}
