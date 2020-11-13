using System;
using System.Collections.Generic;

namespace Insulter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] insults = new string[] {
                "You look like what morning breath smells like.",
                "If you tried to give me cpr I would probably throw myself back under water",
                "I am not a fan of you",
                "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
                "I'd rather walk than be on the same plane as you",
                "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
                "Do you have to be so... like that?"
            };

            // List<string> insults = new List<string> {
            //     "You look like what morning breath smells like.",
            //     "If you tried to give me cpr I would probably throw myself back under water",
            //     "I am not a fan of you",
            //     "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
            //     "I'd rather walk than be on the same plane as you",
            //     "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
            //     "Do you have to be so... like that?"
            // };


            List<int> indexes = new List<int>();

            while (indexes.Count < 3)
            {
                int candidate = getRandomInt(0, insults.Length);
                if (indexes.Contains(candidate) == false)
                {
                    indexes.Add(candidate);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                int index = indexes[i];
                Console.WriteLine(insults[index]);
            }


        }


        static int getRandomInt(int min, int max)
        {
            int randomValue = new Random().Next(min, max);
            return randomValue;
        }




        // public class insults
        // {
        //     public int Value { get; set; }

        //     public insults(int value)
        //     {
        //         this.Value = value;
        //     }

        //     public override string ToString()
        //     {
        //         string insultString = "unknown";

        //         switch (this.value)
        //         {
        //             case 1:
        //                 insultString = "You look like what morning breath smells like.";
        //                 break;
        //             case 2:
        //                 insultString = "If you tried to give me cpr I would probably throw myself back under water";
        //                 break;
        //             case 3:
        //                 insultString = "I am not a fan of you";
        //                 break;
        //             case 4:
        //                 insultString = "You think you're so special...and you are. The fact of your existence is nearly impossible to believe";
        //                 break;
        //             case 5:
        //                 insultString = "I'd rather walk than be on the same plane as you";
        //                 break;
        //             case 6:
        //                 insultString = "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy";
        //                 break;
        //             case 7:
        //                 insultString = "Do you have to be so... like that?";
        //         }
        //         return insultString;
        //     }
        // }
    }
}
