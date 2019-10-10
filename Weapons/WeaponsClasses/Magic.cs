using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponsClasses {
    class Magic : Weapon, IDamage {
        public Magic (int baseDamage, int baseRange, int critDamage) : base(baseDamage, baseRange, critDamage) {
        }

        public double dealDamage(int range) {
            if (range <= BaseRange){
                return BaseDamage;
            }
            else {
                return 0;
            }
        }
    }
}
