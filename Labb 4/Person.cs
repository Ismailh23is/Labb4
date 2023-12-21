using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labb_4
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender TheGender { get; private set; }
        public Hair TheHair { get; set; }
        public DateTime Birthday { get; set; }
        public string EyeColor { get; set; }



        public Person(string firstname,string lastname, Gender gender, Hair hair, DateTime birthday, string eyecolor)
        {
            FirstName = firstname;
            LastName = lastname;
            TheGender=gender;
            TheHair=hair;
            Birthday=birthday;
            EyeColor=eyecolor;

        }

        public override string ToString()
        {
            return
                $"Name: {FirstName} {LastName}" +
                $"\nGender: {TheGender}" +
                $"\nHair : {TheHair.hairLength} and {TheHair.hairColor}" +
                $"\nEyecolor : {EyeColor}" +
                $"\nBirthday : {Birthday:yyyy/MM/dd}"+
                $"\n";
        }




    }
}
