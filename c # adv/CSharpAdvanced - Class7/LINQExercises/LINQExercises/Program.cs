using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExercises
{
    class Program
    {
        public static void PrintDogs(List<Dog> dogs)
        {
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.Name);
            }
        }

        public static bool CheckIfDogsSame(Person p)
        {
            bool allSame = false;
            if (p.Dogs.Count > 0)
            {
                //var firstDog = p.Dogs[0];
                for (var i = 0; i < p.Dogs.Count; i++)
                {
                    for (var j = i+1; j < p.Dogs.Count; j++)
                    {
                        if (p.Dogs[i].Race == p.Dogs[j].Race)
                        {
                            allSame = true;
                        }
                    }
                }
                if (allSame ==true)
                {
                    Console.WriteLine(p.FirstName + p.LastName + p.Occupation);
                }
            }

            //Console.WriteLine(allSame);
            return allSame;

        }

        public static void GroupBySinglePropertyDog(List<Dog>dogs)
        {
            Console.WriteLine("Group by a single property in an object:");

            var queryDogs =
                from dog in dogs
                group dog by dog.Race into newGroup
                orderby newGroup.Key
                select newGroup;

            foreach (var nameGroup in queryDogs)
            {
                Console.WriteLine($"Key: {nameGroup.Key}");
                foreach (var dog in nameGroup)
                {
                    Console.WriteLine($"\t{dog.Name}, {dog.Race}");
                }
            }
        }

        public static void GroupByColorDog(List<Dog> dogs)
        {
            Console.WriteLine("Group by a single property in an object:");

            var queryDogs =
                from dog in dogs
                group dog by dog.Color into newGroup
                orderby newGroup.Key
                select newGroup;

            foreach (var nameGroup in queryDogs)
            {
                Console.WriteLine($"Key: {nameGroup.Key}");
                foreach (var dog in nameGroup.OrderBy(dog=>dog.Name))
                {
                    Console.WriteLine($"\t{dog.Name}, {dog.Color}");
                }
            }
        }

        public static void GroupBySinglePropertyPerson(List<Person> persons)
        {
            Console.WriteLine("Group by a single property in an object:");
                var queryPersons =
                from person in persons
                group person by person.Age into newGroup
                orderby newGroup.Key
                select newGroup;

            foreach (var nameGroup in queryPersons)
            {
                Console.WriteLine($"Key: {nameGroup.Key}");
                foreach (var person in nameGroup)
                {
                    Console.WriteLine($"\t{person.FirstName}, {person.Age}");
                }
            }
        }


        static void Main(string[] args)
        {
            var people = new List<Person>()
            {
                new Person("Nathanael", "Holt", 20, Job.Choreographer),
                new Person("Jabari", "Chapman", 35, Job.Designer),
                new Person("Oswaldo", "Wilson", 19, Job.Developer),
                new Person("Kody", "Walton", 43, Job.Sculptor),
                new Person("Andreas", "Weeks", 17, Job.Developer),
                new Person("Kayla", "Douglas", 28, Job.Designer),
                new Person("Xander", "Campbell", 19, Job.Waiter),
                new Person("Soren", "Velasquez", 33, Job.Interpreter),
                new Person("August", "Rubio", 21, Job.Developer),
                new Person("Malakai", "Mcgee", 57, Job.Barber),
                new Person("Emerson", "Rollins", 42, Job.Choreographer),
                new Person("Everett", "Parks", 39, Job.Sculptor),
                new Person("Amelia", "Moody", 24, Job.Waiter),
                new Person("Emilie", "Horn", 16, Job.Waiter),
                new Person("Leroy", "Baker", 44, Job.Interpreter),
                new Person("Nathen", "Higgins", 60, Job.Archivist),
                new Person("Erin", "Rocha", 37, Job.Developer),
                new Person("Freddy", "Gordon", 26, Job.Interpreter),
                new Person("Valeria", "Reynolds", 26, Job.Dentist),
                new Person("Cristofer", "Stanley", 22, Job.Dentist),
                new Person("William", "Favorite", 29, Job.Waiter),
                new Person("James", "Ferguson", 34, Job.Tattooist),
                new Person("Julian", "Stanley", 47, Job.Auctioneer),
                new Person("Tom", "Barnes", 19, Job.Barber),
                new Person("James", "Rodriguez", 55, Job.Dentist),
                new Person("Jean", "Gaylord", 23, Job.Archivist),
                new Person("Erika", "Lawrence", 67, Job.Sculptor),
                new Person("Vanessa", "Braman", 33, Job.Lecturer),
                new Person("Donna", "Snider", 36, Job.Sculptor),
                new Person("Larry", "Ellington", 41, Job.Dietician)
            };

            var dogs = new List<Dog>()
            {
                new Dog("Charlie", Color.Black, 3, Race.Collie),
                new Dog("Buddy", Color.Brown, 1, Race.Doberman),
                new Dog("Max", Color.Olive, 1, Race.Plott),
                new Dog("Archie", Color.Black, 2, Race.Doberman),
                new Dog("Oscar", Color.Mix, 1, Race.Mudi),
                new Dog("Toby", Color.Silver, 3, Race.Bulldog),
                new Dog("Ollie", Color.Golden, 4, Race.Husky),
                new Dog("Bailey", Color.White, 4, Race.Pointer),
                new Dog("Frankie", Color.Olive, 2, Race.Retriever),
                new Dog("Jack", Color.Black, 5, Race.Dalmatian),
                new Dog("Chanel", Color.White, 1, Race.Pug),
                new Dog("Henry", Color.Black, 7, Race.Plott),
                new Dog("Bo", Color.Maroon, 3, Race.Boxer),
                new Dog("Scout", Color.Mix, 2, Race.Boxer),
                new Dog("Ellie", Color.Brown, 6, Race.Doberman),
                new Dog("Hank", Color.Silver, 2, Race.Collie),
                new Dog("Shadow", Color.Brown, 3, Race.Mudi),
                new Dog("Diesel", Color.Golden, 1, Race.Bulldog),
                new Dog("Abby", Color.Mix, 1, Race.Dalmatian),
                new Dog("Trixie", Color.Maroon, 6, Race.Mudi),
                new Dog("Alfi", Color.Black, 3, Race.Chihuahua),
                new Dog("Benji", Color.Brown, 2, Race.Cocker),
                new Dog("Ava", Color.Golden, 4, Race.Bulldog),
                new Dog("Chet", Color.Olive, 1, Race.Boxer),
                new Dog("Rigby", Color.Mix, 5, Race.Collie),
                new Dog("Sam", Color.Silver, 1, Race.Inu),
                new Dog("Tilly", Color.White, 3, Race.Retriever),
                new Dog("Yumi", Color.White, 4, Race.Retriever),
                new Dog("Zoe", Color.Brown, 9, Race.Husky),
                new Dog("Gonzo", Color.Mix, 1, Race.Doberman),
            };

            #region Exercises

            //==============================
            // TODO LINQ expressions :)
            // Your turn guys...
            //==============================

            //PART 1
            // 1. Structure the solution (create class library and move classes and enums accordingly)

            //PART 2
            // 1. Take person Cristofer and add Jack, Ellie, Hank and Tilly as his dogs.
            // 2. Take person Freddy and add Oscar, Toby, Chanel, Bo and Scout as his dogs.
            // 3. Add Trixie, Archie and Max as dogs from Erin.
            // 4. Give Abby and Shadow to Amelia.
            // 5. Take person Larry and Zoe, Ollie as his dogs.
            // 6. Add all retrievers to Erika.
            // 7. Erin has Chet and Ava and now give Diesel to August thah previously has just Rigby

            //1.
            var cristofer = people.Where(n => n.FirstName == "Cristofer").FirstOrDefault();
            var CristoferDogs = dogs.Where(d => d.Name == "Jack" || d.Name == "Ellie" || d.Name == "Hank" || d.Name == "Tilly").ToList();


            cristofer.Dogs.AddRange(CristoferDogs);


            //foreach (var dog in cristofer.Dogs)
            //{
            //  Console.WriteLine(dog.Name);

            //}

            //2. 
            var Freddy = people.Where(n => n.FirstName == "Freddy").FirstOrDefault();
            var FreddyDogs = dogs.Where(d => d.Name == "Oscar" || d.Name == "Toby" || d.Name == "Chanel" || d.Name == "Bo" || d.Name == "Scout").ToList();
            Freddy.Dogs.AddRange(FreddyDogs);

            //3

            var Erin = people.Where(n => n.FirstName == "Erin").FirstOrDefault();
            var ErinDogs = dogs.Where(d => d.Name == "Trixie" || d.Name == "Max" || d.Name == "Archie").ToList();
            Erin.Dogs.AddRange(ErinDogs);

            //4

            var Amelia = people.Where(n => n.FirstName == "Amelia").FirstOrDefault();
            var AmeliaDogs = dogs.Where(d => d.Name == "Abby" || d.Name == "Shadow").ToList();
            Amelia.Dogs.AddRange(AmeliaDogs);

            //5 

            var Larry = people.Where(n => n.FirstName == "Larry").FirstOrDefault();
            var LarryDogs = dogs.Where(d => d.Name == "Zoe" || d.Name == "Ollie").ToList();
            Larry.Dogs.AddRange(LarryDogs);

            // 6

            var Erika = people.Where(n => n.FirstName == "Erika").FirstOrDefault();
            var ErikaDogs = dogs.Where(d => d.Race == Race.Retriever).ToList();
            Erika.Dogs.AddRange(ErikaDogs);

            Console.WriteLine("erikas dogs check ");
            foreach (var dog in Erika.Dogs)
            {
                Console.WriteLine(dog.Name + dog.Race);

            }
            Console.WriteLine("erikas dogs check ");

            //7 // 7. Erin has Chet and Ava and now give Diesel to August thah previously has just Rigby

            var ErinDogs2 = dogs.Where(d => d.Name == "Chet" || d.Name == "Ava").ToList();
            var diseldog = dogs.Where(d => d.Name == "Diesel").ToList();
            Erin.Dogs.AddRange(ErinDogs2);
            Erin.Dogs.AddRange(diseldog);
            Erin.Dogs.RemoveAll(r => r.Name == "Diesel");

            Console.WriteLine("kucinjata na erin gledaj tuka dali e dizelo");

            foreach (var dog in Erin.Dogs)
            {
                Console.WriteLine(dog.Name);

            }


            Console.WriteLine("kucinjata na august");


            var August = people.Where(n => n.FirstName == "August").FirstOrDefault();
            var AugustDogs = dogs.Where(d => d.Name == "Diesel" || d.Name == "Rigby").ToList();
            August.Dogs.AddRange(AugustDogs);

            foreach (var item in August.Dogs)
            {
                Console.WriteLine(item.Name);
            }





            //PART 3 - LINQ
            // 1. Find and print all persons firstnames starting with 'R', ordered by age - DESCENDING ORDER.

            var personStartWithR = people.Where(n => n.FirstName.StartsWith("E")).OrderByDescending(n => n.Age).ToList();

            foreach (var item in personStartWithR)
            {
                Console.WriteLine(item.FirstName + item.Age);
            }



            // 2. Find and print all brown dogs names and ages older than 3 years, ordered by age - ASCENDING ORDER.


            var brownDogs = dogs.Where(c => c.Color == Color.Brown || c.Age > 3).OrderBy(c => c.Age);
            foreach (var dog in brownDogs)
            {
                Console.WriteLine(dog.Name + dog.Age);
            }




            // 3. Find and print all persons with more than 2 dogs, ordered by name - DESCENDING ORDER.

            var personsWithMoreDogs = people.Where(n => n.Dogs.Count > 2).OrderByDescending(n => n.FirstName).ToList();

            foreach (var item in personsWithMoreDogs)
            {
                Console.WriteLine(item.FirstName + item.Dogs.Count);
            }

            // 4. Find and print all persons names, last names and job positions that have just one race type dogs.

            //another way 
            // using distinct method - metod sto gi trgnuva duplikatite i so selekt da se kreiran nov anonimen objekt so propertija sto ni trebat na nas 
            // another way
            Console.WriteLine("gledaj tuka za kucinja so edna rasa");
            foreach (var item in people)
            {
                CheckIfDogsSame(item);
                
                
            }
                Console.WriteLine("gledaj tuka za kucinja so edna rasa");






            // 5. Find and print all Freddy`s dogs names older than 1 year, grouped by dogs race.

            Console.WriteLine("printing task 5 part 3");
            var fredyOlderDogs = Freddy.Dogs.Where(p => p.Age > 1).ToList();


            GroupBySinglePropertyDog(fredyOlderDogs);

            //var groupedFredyList = fredyOlderDogs
            //        .GroupBy(u => u.Race)
            //     .Select(grp => grp.ToList())
            //        .ToList();
            //foreach (var group in groupedFredyList)
            //{
            //    foreach (var user in group)
            //    {
            //        Console.WriteLine("  {0}", user.Name + "" + user.Race);
            //    }
            //}

            // 6. Find and print last 10 persons grouped by their age.

            Console.WriteLine("Find and print last 10 persons grouped by their age");

            var lastTen = people.Skip(20).ToList();

            GroupBySinglePropertyPerson(lastTen);

            // Pls hints da gi napravam genericki ovie funkcii 



            // 7. Find and print all dogs names from Cristofer, Freddy, Erin and Amelia, grouped by color and ordered by name - ASCENDING ORDER.

            var allDogsFromSomePeop = people.Where(x => x.FirstName == "Freddy" || x.FirstName == "Cristofer" || x.FirstName == "Erin" || x.FirstName == "Amelia").Select(x => x.Dogs).ToList();


            foreach (var item in allDogsFromSomePeop)
            {
                GroupByColorDog(item);
            }
            
            


            // 8. Find and persons that have same dogs races and order them by name length ASCENDING, then by age DESCENDING.
            // try with intersec method i check the link query from the class ?????
            // 9. Find the last dog of Amelia and print all dogs form other persons older than Amelia, ordered by dogs age DESCENDING.
            // 10. Find all developers older than 20 with more than 1 dog that contains letter 'e' in the name and print their names and job positions.


            Console.ReadLine();
                #endregion
            }
        }
    }
