using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class SuperHero
    {

        //fields
        private string costume;
        private string name;
        private int strengthLevel;
        private string power;
        private bool hasCape;

        //End Fields
        //Properties

        public string Costume
        {
            get { return this.costume; }
            set { this.costume = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int StrenghtLevel
        {
            get { return this.strengthLevel; }
            set { this.strengthLevel = value; }
        }

        public string Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public bool HasCape
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }
        //End Properties
        //Constructors

        public SuperHero()
        {
            //Default constructor
        }

        public SuperHero(string costumeSH, string nameSH, int strengthLevelSH, string powerSH, bool hasCapeSH)
        {
            this.costume = costumeSH;
            this.name = nameSH;
            this.strengthLevel = strengthLevelSH;
            this.power = powerSH;
            this.hasCape = hasCapeSH;
        }
        public SuperHero(string nameSH)
        {
            this.name = nameSH;
            this.strengthLevel = 100;
        }
        //End Constructors

        //Methods

        public void BattleNemesis()
        {
            this.StrenghtLevel -= 10;//changing the values using set/get select the wrench for all these
            this.HasCape = false;
            this.Costume = "tattered";
        }

        public void AllyGame()
        {
            this.StrenghtLevel += 10;
            this.HasCape = false;
            Console.WriteLine("Thank you for being a friend");
            
        }
        
    }
}
