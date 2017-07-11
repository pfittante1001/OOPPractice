using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Cat
    {
        /*Inside namespace we create the blueprint for our object
         * Classes are templates we use to creatre objects
         * They should always be named PascalCase
         * 
         * In OOP there are two types of states: Fields and Properties
         * 
         * We also have behaviors, methods and constructors.
         * 
         * Fields = variables that belong to a class
         * Properties = mix between fields and methods that allowed controlled access
         * Methods = repeatable and reusable sections of codes or actions
         * Constructrors = specialized methods that are used for intansiating objects
         * Constructors allow us to control the state of the object, perform any actions the object might 
         * need upon creation, and always share the name of the class
         */

        //The following is an example of a field
        private string name;
        private int age;
        private string furColor;
        private bool isHumgry = true;

        //The following is an example of a property
        public string Name
        {
            get{ return this.name; } //return the name contained in the current object
            set{ this.name = value; }//this allows a user in the class of cat to change the value of name
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string FurColor
        {
            get { return this.furColor; }
            set { this.furColor = value; }
        }
        //the following is an example of a default constructor
        //A default constructor takes no parameters or arguments
        //This constructor allow us to create a cat object

        public Cat()
        {

        }
        //Can Have as many constructors as you need as long as they have a unique parameters 

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        public void Eat()
        {
            if (isHumgry)
            {
                isHumgry = false;
            }
            Console.WriteLine("Is the cat hungry?" + isHumgry);
        }
    }

}
