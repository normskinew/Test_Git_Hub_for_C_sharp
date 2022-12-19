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
            set { if (value <= 0) CurrentPopulation = 0;}
            get { return CurrentPopulation; }
        }

        public int AttackPower
        {
            set { if (value <= 0) AttackPower = 0; }
            get { return AttackPower; }
        }
        public int Defence
        {
            set { if (value <= 0) Defence = 0; }
            get { return Defence; }
        }
        public int Stamina
        {
            set { if (value <= 0) Stamina = 0; }
            get { return Stamina; }
        }
        public int Speed
        {
            set { if (value <= 0) Speed = 0; }
            get { return Speed; }
        }
        
        public event EventHandler OnDisease;
        public void OnDiseaseFunc()
        {
            OnDisease.Invoke(this, EventArgs.Empty);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        public virtual void OnDiseaseDeBuff(int PopPer,int ApPer,int DefPer,int StPer,int SpPer )
        {
            AttackPower = AttackPower - (AttackPower * ApPer / 100);
            Defence = Defence - (Defence * DefPer / 100);
            Stamina = Stamina - (Stamina * StPer / 100);
            Speed = Speed - (Speed * SpPer / 100);
            CurrentPopulation = CurrentPopulation - (CurrentPopulation * PopPer / 100);


        }
        //public virtual void deBuffStarvation(int percentage)
        //{
        //    AttackPower = AttackPower - (AttackPower * percentage / 100);
        //    Defence = Defence - (Defence * percentage / 100);
        //    Stamina = Stamina - (Stamina * percentage / 100);
        //    Speed = Speed - (Speed * percentage / 100);
        //    CurrentPopulation = CurrentPopulation - (CurrentPopulation * percentage / 100);
        //}
        
        



    }
}
