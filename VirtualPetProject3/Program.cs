using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetProject3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Mommy! I am Khaleesi your new Baby Dragon.");
            Console.WriteLine("I am going to tell you what I need to take care of me and how I can take care of myself.");

            KhaleesiTheDragon pet1 = new KhaleesiTheDragon(45, 72, 65);
            pet1.khaleesiTheDragon();

            
            {
                Console.WriteLine("Hey Mommy! What do you want to do with me? ");

                pet1.ChoicesForK();
            }

        }
    }
    }

