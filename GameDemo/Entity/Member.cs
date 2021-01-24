using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entity
{
    class Member : IEntity
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string LastName { get; set; }
        public string TCNumber { get; set; }
        public DateTime BirthYear { get; set; }
    }
}
