using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CodiceFiscalatore
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Sex { get; set; }
        public string Comune { get; set; }


        public Person(/*string name, string surname, DateOnly birthDate, string sex, string comune*/)
        {
            //Name = name;
            //Surname = surname;
            //BirthDate = birthDate;
            //Sex = sex;
            //Comune = comune;
        }
        public string GetCodiceFiscale()
        {
            var nameModified ="";
            var surnameModifeid = "";
            foreach (char c in Name)
            {

                if (!(c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' ||
                    c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'))
                {
                    nameModified += c;
                }
                nameModified = nameModified.Substring(0, 3);
            }

            foreach (char c in Surname)
            {

                if (!(c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' ||
                    c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'))
                {
                    surnameModifeid += c;
                }
                surnameModifeid = surnameModifeid.Substring(0, 3);
            }

            string str = surnameModifeid + nameModified;

            return str;
        }

    }

}
