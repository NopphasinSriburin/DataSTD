using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStudent
{
    internal class StudentAll
    {
        public string _Name;
        public string _Id;
        public int _age;
        public int _BirthYear;
        public int _Hight;
        public int _Grade;
        public string _Branch;
        public StudentAll(string name, string id, int BirthYear, int Age, int Hight, int Grade, string Branchs)
        {
            this._Name = name;
            this._BirthYear = BirthYear;
            this._Id = id;
            this._Hight = Hight;
            this._Grade = Grade;
            this._Branch = Branchs;
            this._age = Age;
        }
    }
}
