using System;
using System.Collections.Generic;
using System.Linq;


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

            Muscle Paul = new Muscle("Paul", 50, 25);

            Hacker Logan = new Hacker("Logan", 40, 10);
            LockSpecialist Will = new LockSpecialist("Will", 30, 10);
            Muscle Jenny = new Muscle("Jenny", 40, 20);

            List<IRobber> rolodex = new List<IRobber>()
                { James, Laura, Paul, Logan, Will, Jenny };



            //   When the program starts, print out the number of current operatives in the rolodex. 
            //   Then prompt the user to enter the name of a new possible crew member. 
            //   Once the user has entered a name, print out a list of possible specialties
            //    and have the user select which specialty this operative has. The list should
            //     contain the following options
            string nameResponse = " ";
            while (nameResponse.Length > 0)
            {
                Console.WriteLine(rolodex.Count);
                Console.WriteLine("Who would you like to add to your crew???");
                nameResponse = Console.ReadLine();
                if (nameResponse.Length == 0)
                {
                    break;
                }
                Console.WriteLine("1.) Hacker (Disables alarms) \n2.)Muscle (Disarms guards) \n3.)Lock Specialist (cracks vault)");
                int roleResponse = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter this dirty thief's skill level (number between 1 and 100): ");
                int skillResponse = int.Parse(Console.ReadLine());
                Console.WriteLine("What percentage cut should this lowlife get?: ");
                int cutResponse = int.Parse(Console.ReadLine());

                if (roleResponse == 1)
                {
                    Hacker newHacker = new Hacker(nameResponse, skillResponse, cutResponse);
                    rolodex.Add(newHacker);
                }
                else if (roleResponse == 2)
                {
                    Muscle newMuscle = new Muscle(nameResponse, skillResponse, cutResponse);
                    rolodex.Add(newMuscle);
                }
                else if (roleResponse == 3)
                {
                    LockSpecialist newLockSpecialist = new LockSpecialist(nameResponse, skillResponse, cutResponse);
                    rolodex.Add(newLockSpecialist);
                }
            }

            Console.WriteLine("It's time to begin the heist, you lousy criminals!");
            Random r = new Random();
            Bank newBank = new Bank(r.Next(0, 101), r.Next(0, 101), r.Next(0, 101), r.Next(50000, 1000001));

            List<int> scores = new List<int>() {
                    newBank.AlarmScore, newBank.VaultScore, newBank.SecurityGuardScore
                };

            Console.WriteLine($"Alarm score: {newBank.AlarmScore}; Vault score: {newBank.VaultScore}; SG Score: {newBank.SecurityGuardScore}");

            int alarmScore = scores[0];
            int vaultScore = scores[1];
            int sgScore = scores[2];

            Console.WriteLine($"");

            if (alarmScore > vaultScore && alarmScore > sgScore)
            {
                Console.WriteLine("Most secure system: Alarm");
            }
            else if (vaultScore > alarmScore && vaultScore > sgScore)
            {
                Console.WriteLine("Most secure system: Vault");
            }
            else if (sgScore > vaultScore && sgScore > alarmScore)
            {
                Console.WriteLine("Most secure system: Security Guard");
            }

            if (alarmScore < vaultScore && alarmScore < sgScore)
            {
                Console.WriteLine("Least secure system: Alarm");
            }
            else if (vaultScore < alarmScore && vaultScore < sgScore)
            {
                Console.WriteLine("Least secure system: Vault");
            }
            else if (sgScore < vaultScore && sgScore < alarmScore)
            {
                Console.WriteLine("Least secure system: Security Guard");
            }

            void PrintRobbers()
            {
                foreach (var member in rolodex)
                {
                    Console.WriteLine($"{rolodex.IndexOf(member) + 1}) {member.Name}, a {member.GetType().Name}, skill: {member.SkillLevel}, Cut: {member.PercentageCut}");
                }
            }

                PrintRobbers();

            List<IRobber> crew = new List<IRobber>();
            Console.WriteLine("Enter the number of the member you want to add to your crew.");

            int crewSelection = int.Parse(Console.ReadLine());
            // look at the selected member in the rolodex and add them to the crew.
            crew.Add(rolodex[crewSelection - 1]);

            foreach (var crewmate in crew)
            {
                Console.WriteLine(crewmate.Name);
            }
        }
    }
}