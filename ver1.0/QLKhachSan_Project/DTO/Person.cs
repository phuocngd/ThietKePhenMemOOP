using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Person
    {
        public int Name
        {
            get => default(int);
            set
            {
            }
        }

        public void SayHello()
        {
            throw new System.NotImplementedException();
        }
    }
}