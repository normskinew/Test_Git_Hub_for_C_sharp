using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteaProjectCivilization
{
    public abstract class Civilization
    {
        public const int maxPopulation = 50000;
        public int CurrentPopulation
        {
            set
            {
                if (value <= 0) CurrentPopulation = 0;
                if (value >= maxPopulation) CurrentPopulation = maxPopulation;
            }
            get { return CurrentPopulation; }
        }

        public int AttackPower
        {
            set { if (value <= 0) AttackPower = 0; }
            get { return AttackPower; }
        }
        public int Defense
        {
            set { if (value <= 0) Defense = 0; }
            get { return Defense; }
        }
        


       



        //void War(Civilization c1, Civilization c2)
        //{
        //    // Calculate the damage dealt by c1 to c2
        //    int c1Attack = c1.Attack;
        //    int c2Defense = c2.Defense;
        //    int c1Damage = c1Attack - c2Defense;
        //    if (c1Damage < 0) c1Damage = 0;  // Damage can't be negative
        //    c2.CurrentPopulation -= c1Damage;  // Reduce c2's population by the damage dealt

        //    // Calculate the damage dealt by c2 to c1
        //    int c2Attack = c2.Attack;
        //    int c1Defense = c1.Defense;
        //    int c2Damage = c2Attack - c1Defense;
        //    if (c2Damage < 0) c2Damage = 0;  // Damage can't be negative
        //    c1.CurrentPopulation -= c2Damage;  // Reduce c1's population by the damage dealt
        //}
        //ublic void Attack(Civilization other)
        //{
        //    int damage = this.attack - other.defense;
        //    if (damage > 0)
        //    {
        //        other.population -= damage;



    }
}
