using System;

namespace heist
{

    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

     public Hacker (string name, int skillLevel, int percentageCut )
        {
            Name = name;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;
        }
        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore -= SkillLevel;
            Console.WriteLine($"{Name} is hacking the alarm system. Decreased security {SkillLevel} points.");
            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled the Alarm");
            }
        }
    }

}