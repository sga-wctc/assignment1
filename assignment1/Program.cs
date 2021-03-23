using System;
using System.Collections;

namespace assignment1
{
    class Program
    {


        static void Main(string[] args)
        {
            ArrayList ListOfPets = new ArrayList();
            String petName = "";
            int petType;
            Program p = new Program();

            Console.WriteLine("Hello World!");

            // Test animals
            Dog dog = new Dog(true, "Sam");
            Cat cat = new Cat(6, "Stealth");
            Bird bird = new Bird(true, "Tweety");
            ListOfPets.Add(dog);
            ListOfPets.Add(cat);
            ListOfPets.Add(bird);
            // Test animals

            // Enter pet information
            // Select pet type
            var done = false;
            while (!done)
            {
                Console.Write("Enter type of Pet (1 = Dog, 2 = Cat, 3 = Bird, 0=EXITs: ");
                try
                {
                    petType = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("invalid entry ");
                    continue;
                }
                petName = "";
                switch (petType)
                    {
                        case 0:
                            done = true;
                            continue;
                        case 1:  
                            // Enter name for Dog
                            petName = p.enterPetName();
                            // Ask if Dog is Friendly 
                            Console.Write("Is your dog friendly (Y = Yes, else no) ? ");
                            String friendly = Console.ReadLine();
                            if (string.Equals(friendly, "Y", StringComparison.OrdinalIgnoreCase))
                            {
                                ListOfPets.Add(new Dog(true, petName));
                            }
                            else
                            {
                                ListOfPets.Add(new Dog(false, petName));
                            }

                        break;
                        case 2:
                            // Enter name for Cat
                            petName = p.enterPetName();
                            // Ask how many mice has the cat caught
                            Console.Write("How many mice has your cat caught ? ");
                            var mice = 0;
                            try
                            {
                                mice = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                mice = 0;
                            }
                            ListOfPets.Add(new Cat(mice, petName));
                            break;
                        case 3:
                            // Enter name for Bird
                            petName = p.enterPetName();
                            // Ask if bird can fly 
                            Console.Write("Can your Pet fly (Y = Yes, else no) ? ");
                            String canFly = Console.ReadLine();
                            if (string.Equals(canFly , "Y", StringComparison.OrdinalIgnoreCase))
                            {
                                ListOfPets.Add(new Bird(true, petName));
                            }
                            else
                            {
                                ListOfPets.Add(new Bird(false, petName));
                            }

                        break;
                        default:
                            Console.WriteLine("invalid entry ");
                            break;
                    }

            }

            // Display list of pets; including the test pets
            Console.WriteLine("List of Pets entered.");
            foreach (Pet pet in ListOfPets)
            {
                Console.WriteLine(pet.getName() + " says " + pet.talk());
            }

            // test code
            //Console.ReadLine();

        }

        private String enterPetName()
        {
            Console.Write("Enter name of your pet: ");
            String petName = Console.ReadLine();
            return petName;
        }

    }
}
