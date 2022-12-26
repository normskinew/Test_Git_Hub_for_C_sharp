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
        private int currentPopulation = 0;
        private int attackPower = 0;
        private int defense = 0;
        public int CurrentPopulation
        {
            set
            {
                if (value <= 0) currentPopulation = 0;
                else if (value >= maxPopulation) currentPopulation = maxPopulation;
                else currentPopulation = value;
            }
            get { return currentPopulation; }
        }

        public int AttackPower
        {
            set 
            { 
                if (value <= 0) attackPower = 0;
                else if (value >= 500) attackPower = 500;
                else attackPower = value;
            }
            get { return attackPower; }
        }
        public int Defense
        {
            set
            {
                if (value <= 0) defense = 0;
                else if (value >= 500) defense = 500;
                else defense = value;
            }
            get { return defense; }
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
