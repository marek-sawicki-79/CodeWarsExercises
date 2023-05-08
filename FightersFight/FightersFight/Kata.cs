using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightersFight
{
    public class Kata
    {
        public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            do
            {
                if (fighter1.Name == firstAttacker)
                {
                    fighter2.Health = fighter2.Health - fighter1.DamagePerAttack;
                    fighter1.Health = fighter1.Health - fighter2.DamagePerAttack;
                }
                else
                {
                    fighter1.Health = fighter1.Health - fighter2.DamagePerAttack;
                    fighter2.Health = fighter2.Health - fighter1.DamagePerAttack;
                }
            }while (fighter1.Health <= 0 || fighter2.Health <= 0);
            if (fighter1.Health <= 0) return fighter2.Name;
            else return fighter1.Name;
        }
    }
}
