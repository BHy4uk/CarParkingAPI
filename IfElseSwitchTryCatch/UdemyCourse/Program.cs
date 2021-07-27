using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IfElseSwitch
{
    class Program
    {
        //static int highScore = 62;
        //static string highscorePlayer = "Tommy";
        


        static void Main(string[] args)
        {
            // IF ELSE 

            //string temperature1 = Console.ReadLine();
            //int temperature = Int32.Parse(temperature1);

            //if (temperature < 10)
            //{
            //    Console.WriteLine("It's is quite cold today");
            //}
            //else if (temperature > 10)
            //{
            //    Console.WriteLine("It's too hot for me");
            //}
            //else 
            //{
            //    Console.WriteLine("It's 10 degree, I will go for a walk");
            //}


            // TRYPARSE 
            //string num = "128";
            //int result;

            //bool success = int.TryParse(num, out result);

            //if (success)
            //{
            //    Console.WriteLine("A sting is converted to" + result);
            //}
            //else
            //{
            //    Console.WriteLine("TryParse is failed");
            //}



            //NESTED SYSTEM           

            //string Name = "";
            //Console.WriteLine("Please, enter your first name to register");
            //Name = Console.ReadLine();
            //string password = "";
            //Console.WriteLine("Please, create your password to register");
            //password = Console.ReadLine();

            //Console.WriteLine("Write your name and password to login");
            //string registeredName = Console.ReadLine();
            //string registeredPassword = Console.ReadLine();

            //if (Name == registeredName && password == registeredPassword)
            //{
            //    Console.WriteLine("Hi there, registered user");

            //}
            //else if (Name == registeredName && password != registeredPassword)
            //{
            //    Console.WriteLine("Please, write the correct password");
            //}
            //else if (Name != registeredName && password == registeredPassword)
            //{
            //    Console.WriteLine("Please, write the correct Name");
            //}
            //else
            //{
            //    Console.WriteLine("Please, write the correct Name and password");
            //}


            //SWTICH
            //string age = Console.ReadLine();
            //int ageInt = Int32.Parse(age);

            //switch (ageInt)
            //{
            //    case 15:
            //        Console.WriteLine ("You are too young");
            //            break;
            //    case 22:
            //        Console.WriteLine("Good to go");
            //        break;
            //}


            //CHALLENGE IF
            //    NewScore( "Jack", 80);
            //    NewScore("Tracey", 55);
            //    NewScore("Illia", 108);



            //}
            //public static void NewScore( string playerName,  int score)
            //{

            //    if(score > highScore)
            //    {
            //        highScore = score;
            //        highscorePlayer = playerName;

            //        Console.WriteLine("New highscore is " + score);
            //        Console.WriteLine("New hiscorer name is: " + playerName);
            //    }
            //    else
            //    {
            //        Console.WriteLine("The old highscore of " + highScore + " could not be broken and still held by " + highscorePlayer);
            //    }


            //ENHANCED IF STATEMENTS - TERNARY OPERATOR
            //int temperarure = 130;
            //string stateOfMatter;

            //stateOfMatter = temperarure > 100 ? "gas" : temperarure < 0 ? "solid" : "liquid";
            //Console.WriteLine("State of Matter is {0}", stateOfMatter);


            //CHALLENGE TERNARY OPERATOR
            //Console.WriteLine("Enter the current temperature");
            //string temperatureStr = Console.ReadLine();
            //int temperature = Int32.Parse(temperatureStr);
            //string StateOfMatter;

            //bool validInteger = int.TryParse(temperatureStr, out temperature);

            //StateOfMatter = temperature <= 15 ? "Its too cold here" : (temperature >= 16 && temperature <= 28) ? "Its ok" : temperature > 28 ? "Its too hot here" : "";
            //Console.WriteLine("State of Matter is {0}", StateOfMatter);
           


            Console.ReadLine();
        }               
     
    }
}
