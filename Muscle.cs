using System;

namespace heist {

    public class Muscle: IRobber 
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill (Bank bank) 
        {
            bank.SecurityGuardScore -= SkillLevel;
            Console.WriteLine( $"{Name} is hacking the alarm System. Decreased security {SkillLevel} points.");
            Console.WriteLine( $"{Name} has disabled the alarm System");
        }
    }
}