using System;
using System.Collections.Generic;
using System.Linq;

namespace dinnerParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Guest> dinnerGuests = GetGuests();
            List<Table> tables = new List<Table>() {
                new Table() {
                    Name= "Table 1",
                    TableOfGuests= new List<Guest> {}
                },
                new Table() {
                    Name= "Table 2",
                    TableOfGuests= new List<Guest> {}
                }
            };


            foreach (Guest guest in dinnerGuests)
            {
                List<string> table1Occupations = tables[0].TableOfGuests.Select(g => g.occupation).ToList();
                if (table1Occupations.Contains(guest.occupation))
                {
                    tables[1].TableOfGuests.Add(guest);
                }
                else
                {
                    tables[0].TableOfGuests.Add(guest);
                }
            }

            foreach (Table singleTable in tables) 
            {
                Console.WriteLine($"{singleTable.Name}");
                foreach (Guest singleGuest in singleTable.TableOfGuests)
                {
                    Console.WriteLine($"{singleGuest.name}");
                }
            }


            // foreach (string job in jobs) 
            // {
            // Console.WriteLine($"table: {job}");
            // }
            // foreach (Guest dinnerGuest in guests);
            // {
                
            //     Console.WriteLine($"{dinnerGuest.name}");
            //     Console.WriteLine($"table: {table}");
            // }
        }


        static List<Guest> GetGuests()
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


    public class Guest
    {
        public string name { get; set; }
        public string occupation { get; set; }
        public string bio { get; set; }
    }


    public class Table
    {
        public string Name { get; set; }
        public List<Guest> TableOfGuests { get; set; }
    }
}
