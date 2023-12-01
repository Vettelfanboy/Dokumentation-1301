using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_1301
{
    internal class Person
    {
        private string _name;
        private int _age;
        private DateTime _birthdate;
        private string _emailadress;
        private string _phonenumber;
        private string _residence;
       
        public string PersonalData
        {
            get { return $"{_name}\n{_age}\n{_birthdate}\n{_emailadress}\n{_phonenumber}\n{_residence}"; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }
            
        public string Emailadress
        {
            get { return _emailadress; }
            set { _emailadress = value; }
        }

        public string Phonenumber
        {
            get { return _phonenumber; }
            set { _phonenumber = value; }
        }

        public string Residence
        {
            get { return _residence; } 
            set { _residence = value; }
        }

        public Person(string name, int age, DateTime birthdate, string emailadress, string phonenumber, string residence)
        {
           
            this._name = name;
            this._age = age;
            this._birthdate = birthdate;
            this._emailadress = emailadress;
            this._phonenumber = phonenumber;
            this._residence = residence;
        }
        
    }
        
           
        
         
}
