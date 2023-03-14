using System;
using System.Collections.Generic;


namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {

            // In the Main method, create a List<IRobber> and store it in a variable named rolodex. 
            // This list will contain all possible operatives that we could employ for 
            // future heists. We want to give the user the opportunity to add new operatives
            //  to this list, but for now let's pre-populate the list with 5 or 6 robbers
            //   (give it a mix of Hackers, Lock Specialists, and Muscle).

                Hacker James = new Hacker("James", 30, 30);
                LockSpecialist Laura = new LockSpecialist("Laura", 20, 20);

                Muscle Paul = new Muscle("Paul", 50, 25 );
              
                Hacker Logan = new Hacker("Logan", 40, 10);
                LockSpecialist Will = new LockSpecialist("Will", 30, 10);
                Muscle Jenny = new Muscle("Jenny", 40, 20);

                List<IRobber> rolodex = new List<IRobber>()
                { James, Laura, Paul, Logan, Will, Jenny };

                Console.WriteLine(rolodex.Count);
                Console.WriteLine("Who would you like to add to your crew???");
                string answer = Console.ReadLine();
                Console.WriteLine("1.) Hacker (Disables alarms) \n2.)Muscle (Disarms guards) \n3.)Lock Specialist (cracks vault)");
                int answerTwo = int.Parse(Console.ReadLine());

        //   When the program starts, print out the number of current operatives in the rolodex. 
        //   Then prompt the user to enter the name of a new possible crew member. 
        //   Once the user has entered a name, print out a list of possible specialties
        //    and have the user select which specialty this operative has. The list should
        //     contain the following options
          

        }
    }
}