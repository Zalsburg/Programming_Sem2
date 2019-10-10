using System;

namespace WeaponsClasses {
    public class Weapon {
        public int BaseDamage;
        public int BaseRange;
        public int CritDamage;

        public Weapon(int baseDamage, int baseRange, int critDamage) {
            BaseDamage = baseDamage;
            BaseRange = baseRange;
            CritDamage = critDamage;
        }

        public int Poke() {
            return 1;
        }
    }
}
