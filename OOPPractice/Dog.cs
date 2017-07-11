using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Dog
    {

        //fields

        private string furColor;
        private int age;
        private string eyeColor;
        private bool isBite = false;

        //Properties
        public string FurColor
        {
            get { return this.furColor; }//used by the main to retrieve the current value of the object being accessed
        }

        public string EyeColor
        {
            get { return this.eyeColor; }
        }

        public int Age
        {
            get { return this.age; }
        }

        public bool IsBite
        {
            get { return this.isBite; }
        }

        public Dog()
        {
            //default constructor
        }

        //Loaded constructor
        public Dog(int age, string furColor, string eyeColor, bool isBite)
        {
            this.age = age; //Be sure to chose the fields not the properties. Properties are shown with a wrench
            this.furColor = furColor;
            this.eyeColor = eyeColor;
            this.isBite = isBite;
        }
   
        public int DogAge()
        {
            int adultYears = this.age * 7; ;
            

            return adultYears;
        }
    }

}
