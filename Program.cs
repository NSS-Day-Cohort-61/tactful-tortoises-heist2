using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> team = new List<Member>();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Let's Plan Your Heist!");
            Console.ResetColor();

            Console.WriteLine("Please select a Bank difficulty level (50-100):");
            string bankDifficultyLevelString = Console.ReadLine();
            Console.WriteLine();
            int.TryParse(bankDifficultyLevelString, out int userBankDifficultyLevel);

            string memberName = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Crew Member Name:");
                Console.ResetColor();
                memberName = Console.ReadLine();
                if (memberName == "")
                {
                    break;
                }

                Console.WriteLine($"{memberName}'s Skill Level (0-50):");
                string memberSkillLevelString = Console.ReadLine();
                int.TryParse(memberSkillLevelString, out int memberSkillLevel);

                Console.WriteLine($"{memberName}'s Courage Factor (0.0-2.0):");
                string memberCourageFactorString = Console.ReadLine();
                double.TryParse(memberCourageFactorString, out double memberCourageFactor);

                Member newMember = new Member(memberName, memberSkillLevel, memberCourageFactor);
                team.Add(newMember);
                Console.WriteLine();
            }
            while (memberName.Length > 0);
            
            int teamSkillLevel = 0;
            foreach (Member member in team)
            {
                teamSkillLevel += member.SkillLevel; 
            }
             
            Console.WriteLine("How many trials do you want to run with your current team?:");
            string trialChoiceString = Console.ReadLine();
            int.TryParse(trialChoiceString, out int trialChoice);
 
            int successfulTrials = 0;
            int failedTrials = 0;

            Console.WriteLine();
            Console.WriteLine($"With your current team and a combined Skill Level of {teamSkillLevel}...");
            for (int i = 0; i < trialChoice; i++)
            {
                int bankDifficultyLevel = userBankDifficultyLevel;
                int LuckValue = new Random().Next(-10, 11);
                bankDifficultyLevel += LuckValue;

                Console.WriteLine($"A Heist with a Bank Difficulty Level of {bankDifficultyLevel}...");

                    if ( teamSkillLevel >= bankDifficultyLevel)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Would result in SUCCESS");
                    Console.ResetColor();
                     successfulTrials++;
                } 
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Would result in JAIL TIME");
                    Console.ResetColor();
                     failedTrials++;
                }       
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine();
            Console.WriteLine($"Successful Runs: {successfulTrials}");
            Console.WriteLine($"Failed Runs: {failedTrials}");
            Console.ResetColor();
        }
    }
}