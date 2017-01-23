using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetProject3
{
    class KhaleesiTheDragon
    {

        private int hunger;
        private int mood;
        private int activity;
        //fields//


        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Mood
        {
            get { return this.mood; }
            set { this.mood = value; }
        }

        public int Activity
        {
            get { return this.activity; }
            set { this.activity = value; }
        }
        //Properties//

        public KhaleesiTheDragon(int hunger, int mood, int activity)
        {
            this.hunger = hunger;
            this.mood = mood;
            this.activity = activity;
        }



        //methods//

        public void khaleesiTheDragon()
        {
            Console.WriteLine("hunger:" + hunger);
            Console.WriteLine("mood:" + mood);
            Console.WriteLine("activity:" + activity);
        }
        public void ChoicesForK()
        {
           
            {
                Console.WriteLine("a. Do you want to feed me?");
                Console.WriteLine("b. Do you want to play with me?");
                Console.WriteLine("c. Do you want to know how I feel?");

                string result = Console.ReadLine();

                if (result == "a")
                {
                    Console.WriteLine(" Thank you I was so hungry I could eat a Tree");
                   
                }


                else if (result == "b")
                {
                    Console.WriteLine("Do you want to play with fire?");
                }

                else if (result == "c")
                {
                    Console.WriteLine("I am HAPPY you are my mom!");
                }
                else 
                {
                    Console.WriteLine("If you don't want to do anything with me then I will go and feed myself");
                }

            }

        }
    }
}


