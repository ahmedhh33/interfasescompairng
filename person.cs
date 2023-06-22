using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacees
{
    internal class person
    {
        readonly string name;
        string username;
        int age;
        //const int abs = 232;

        public person(string name,string username,int age)
        {
            this.name = name;
            this.username = username;
            this.age = age;
            //name = "aass";// it can be changed inside constractor but not out
            // abs = 236; //cant be changed even in constractor
        }
        public override string ToString()
        {
            return this.name+" "+this.username+" "+this.age;
        }
        
    }
}
