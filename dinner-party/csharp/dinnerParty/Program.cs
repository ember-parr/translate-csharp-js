using System;
using System.Collections.Generic;

namespace dinnerParty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Guest> guests = GetGuests();

            foreach (Guest dinnerGuest in guests)
            {
                Console.WriteLine($"{dinnerGuest.name}");
            }
        }


        public static List<Guest> GetGuests()
        {
            List<Guest> guests = new List<Guest> {
                new Guest {
                    name= "Marilyn Monroe",
                    occupation= "entertainer",
                    bio= "(1926 - 1962) American actress, singer, model"
                },
                new Guest {
                    name= "Abraham Lincoln",
                    occupation= "politician",
                    bio= "(1809 - 1865) US President during American civil war"
                },
                new Guest {
                    name= "Martin Luther King",
                    occupation= "activist",
                    bio= "(1929 - 1968)  American civil rights campaigner"
                },
                new Guest {
                    name= "Rosa Parks", 
                    occupation= "activist",
                    bio= "(1913 - 2005)  American civil rights activist"
                },
                new Guest {
                    name= "Peter Sellers",
                    occupation= "entertainer",
                    bio= "(1925 - 1980) British actor and comedian"
                },
                new Guest {
                    name= "Alan Turing",
                    occupation= "computer scientist",
                    bio= "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
                },
                new Guest {
                    name= "Admiral Grace Hopper (1906–1992) – developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds",
                    occupation= "computer scientist",
                    bio= "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
                },
                new Guest {
                    name= "Indira Gandhi",
                    occupation= "politician",
                    bio= "(1917 - 1984) Prime Minister of India 1966 - 1977"
                }
            };
            return guests;
        }

        
    }


    public class Guest{
        public string name { get; set; }
        public string occupation { get; set; }
        public string bio { get; set; }
    }
}
