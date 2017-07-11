using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            //When we initialize a new object it is call instantiated and must be instantiated before it can be used
            //All object of a specific type are created from the same template or class
            //All objects from a class will have the same number of states but each instance can have it own unique values
            //The format we use to instantiate and object looks like this
            //ClassName objectname = new ClassName()
            //ie Cat mittens = new Cat(); This is called a constructor  Cat = ClassName  mittens = objectName  same as int[] array = new int[]
            //                          (adjectives)                                (Verbs)
            //              object      characteristics                             behaviours
            //              house       hasDoors hasWindows hasFloors heated        Heats() Cools() Protects()
            //              pool        hasWater hasSides isHeated                  Cools() Wets() 
            //              cig         hasFilter hasPaper hasTobacco               Kills() Burns() Satisfies()
            //Cat mittens = new Cat();
            //mittens.Age = 25; //this uses the set command in public int Age() property
            //mittens.Name = "Pete";//this uses the set command in public string Name() property
            //int age1 = mittens.Age;
            //string name1 = mittens.Name;

            //Cat secondCat = new Cat("Oz", 3, "Orange and White");
            //Dog firstDog = new Dog(1 , "brown", "hazel", true);
            //Console.WriteLine("{0} {1} {2} {3}", firstDog.Age, firstDog.FurColor, firstDog.EyeColor, firstDog.IsBite);

            //SuperHero firstHero = new SuperHero();
            //firstHero.StrenghtLevel = 100;
            //firstHero.HasCape = true;
            //firstHero.BattleNemesis();//calls BattleNemesis method
            //Console.WriteLine(firstHero.HasCape);
            //Console.WriteLine(firstHero.StrenghtLevel);

            //firstHero.BattleNemesis();
            //Console.WriteLine(firstHero.HasCape);
            //Console.WriteLine(firstHero.StrenghtLevel);
            SuperHero secondHero = new SuperHero("diamond dan");
            Console.WriteLine("{0} {1} ",secondHero.Name,secondHero.StrenghtLevel);

            secondHero.BattleNemesis();
            secondHero.AllyGame();
            Console.WriteLine(secondHero.StrenghtLevel);



        }
    }
}
