using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponsClasses {
    public class Melee : Weapon, IDamage, ICriticalDamage {
        public Melee(int baseDamage, int baseRange, int critDamage) : base(baseDamage, baseRange, critDamage) {
        }

        public bool critHit(int range) {
            Random rand = new Random();
            double chance = rand.Next(1, 100);
            if (chance <= 2) {
                return true;
            }
            else {
                return false;
            }
        }

        public double dealDamage(int range) {
            if (critHit(range)) {
                return 2 * BaseDamage;
            }
            else if (range < 0.5 * BaseRange) {
                return 1.2 * BaseDamage;
            }
            else if (range <= BaseRange) {
                return BaseDamage;
            }
            else {
                return 0;
            }
        }

        
    }
}
