using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}





// for(let n=1; n<=100; n++) {
//     if (n % 15 === 0) {
//       console.log("fizzbuzz");
//     } else if (n % 3 === 0) {
//       console.log("fizz");
//     } else if (n % 5 === 0) {
//       console.log("buzz");
//     } else {
//       console.log(n);
//     }
//   }