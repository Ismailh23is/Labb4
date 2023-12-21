using System.Xml.Linq;

namespace Labb_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            int choice = 0;
            bool keepProgram = true;

            // Huvudprogramloopen
            while (keepProgram == true)
            {
                try 
                {
                    Console.WriteLine(
                   "\n---------------------------------------------------------" +
                   "\nChoose one of the options below:" +
                   "\n1.) Add person" +
                   "\n2.) Print a list of all added people" +
                   "\n3.) End" +
                   "\n----------------------------------------------------------"
                   );
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // här har jag fixat switch-case för de olika meny alternativen
                switch (choice)
                {
                    case 1:
                        addPerson();
                        break;

                    case 2:
                        listPersons();
                             break;
                    case 3:
                        keepProgram = false; 
                                   break;
                }
            }
            // Metod för att lägga till en ny person i listan
            void addPerson() 
            {
                bool incorrectInput = false;
                int userInput= 1;
                // Användarinput för förnamn
                string firstName;
                Console.WriteLine("Enter the first name of the person");
                firstName = Console.ReadLine();
                // Användarinput för efternamn
                string lastName;
                Console.WriteLine("Enter the last name of the person");
                lastName = Console.ReadLine();

                Gender gender = Gender.Man;
                Hair hair = new Hair ();
                DateTime datetime = DateTime.Now;
                string eyeColor = " ";

                // Validera och få användarinput för födelsedatum
                bool incorrectDate = false;
                do 
                {
                    try
                    {
                        Console.WriteLine("When is your birthday, write in YYYY-MM-DD format");
                        datetime = DateTime.Parse(Console.ReadLine());
                        incorrectDate = false;
                    }
                    catch 
                    {
                        Console.WriteLine("Please, only write with numbers and don´t forger hyphens (-) ");
                        incorrectDate = true;
                    }
                }while (incorrectDate == true);

                // Validera och få användarinput för kön
                do
                {
                    try
                    {
                        Console.WriteLine("What is the pereson´s gender? \n1 . Man \n2 . Woman \n3 . Nonbinary \n4 . Other");
                        bool parse;
                        parse = int.TryParse(Console.ReadLine(),out userInput);

                        if (parse == false || userInput == 0 || userInput < 0 || userInput >5) 
                        {
                            Console.WriteLine("du kan bara skriva en siffra mellan 1-4");
                            incorrectInput = false;
                        }

                        else
                        {
                            incorrectInput= true;
                        }

                    }
                    catch
                    {

                        incorrectInput = true;
                    }
                }while (incorrectInput == false);

                // Sätt kön baserat på användarinput
                switch (userInput) 
                 {
                    case 1:
                        gender = Gender.Man;
                            break;

                    case 2:
                        gender = Gender.Woman;
                            break;

                    case 3:

                        gender = Gender.Nonbinary;
                            break;

                    case 4:
                        gender = Gender.Other;
                            break;
                }
                // Validera och få användarinput för hårfärg
                bool incorrectHair = false;
                do
                {
                    try
                    {

                        Console.WriteLine("What hair color does the person have?");
                        hair.hairColor = Console.ReadLine();
                        incorrectHair = false;
                        if (hair.hairColor.All(Char.IsDigit)) 
                        {

                            throw new Exception();
                        } 
                    }
                    catch 
                    {

                        Console.WriteLine("Please, specify a color.");
                        incorrectHair = true;
                    }
                }while (incorrectHair == true);
                // Validera och få användarinput för hårlängd    
                bool hairIncorrectInput = false;
                do
                {
                                        
                    Console.WriteLine("What is the persone´s hairlength.");
                    hair.hairLength = Console.ReadLine();
                    hairIncorrectInput = false;
                    

                }while (hairIncorrectInput == true);

                // Validera och få användarinput för ögonfärg
                bool incorrectEyes = false;
                do
                {
                    try
                    {

                        Console.WriteLine("What is the person´s eye color? ");
                        eyeColor = Console.ReadLine();
                        incorrectEyes = false;
                        if (eyeColor.All(Char.IsDigit))
                        {
                            throw new Exception();
                        }
                    }

                    catch
                    {
                        Console.WriteLine("Please, enter with letter");
                        incorrectEyes = true;
                    }
                }while(incorrectEyes == true);
                // Skapa en ny Person-objekt och lägg till det i listan
                    Person person = new Person(firstName, lastName, gender, hair, datetime, eyeColor );
                    list.Add(person);
            


                

            }
            // Metod för att skriva ut listan över personer
            void listPersons()
            {
                foreach (Person person in list)
                {
                    Console.WriteLine(person.ToString());
                }
            }

        }

    }
}
