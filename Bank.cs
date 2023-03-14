using System;
using System.Collections.Generic;

namespace heist
{
    public class Bank
    {

        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public int CashOnHand { get; set; }

        public Bank (int alarm, int vault, int cut, int cash)
        {
            AlarmScore = alarm;
            VaultScore = vault;
            SecurityGuardScore = cut;
            CashOnHand = cash;
        }


        public bool IsSecure
        {
            get
            {
                if (AlarmScore > 0 || SecurityGuardScore > 0 || VaultScore > 0 || SecurityGuardScore > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }




    }
}