using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponsClasses {
    class Ranged : Weapon, IDamage, ICriticalDamage {
        public int CloseRange;
        public Ranged (int baseDamage, int baseRange, int closeRange, int critDamage) : base(baseDamage, baseRange, critDamage) {
            CloseRange = closeRange;
        }

        public bool critHit(int range) {
            Random rand = new Random();
            double chance = rand.Next(1, 100);
            if (range == CloseRange && chance <= 2) {
                return true;
            }
            else if (range <= 0.75 * BaseRange && chance == 1) {
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
            else if (range < CloseRange) {
                return 0;
            }
            else if (range == CloseRange) {
                return BaseDamage;
            }
            else if (range <= BaseRange) {
                Random rand = new Random();
                double damage = rand.Next(50, 100) / 100;
                return damage * BaseDamage;
            }
            else {
                return 0;
            }
        }
    }
}
