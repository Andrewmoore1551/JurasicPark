using System;
using System.Collections.Generic;
using System.Linq;

namespace JurasicPark
{
    class Dino
    {
        public string Name { get; set; }
        public string DietType { get; set; }
        public int EnclosureNumber { get; set; }
        public int Weight { get; set; }



    }
    class Program


    {
        static void BannerMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine();


        }


        static void Main(string[] args)

        {
            var sadie = new Dino();


            sadie.Name = "Sadie";
            sadie.DietType = "herbivore";
            sadie.EnclosureNumber = 5;
            sadie.Weight = 200;


            var russell = new Dino()
            {
                Name = "Russell",
                DietType = "carnivore",
                EnclosureNumber = 3,
                Weight = 150,
            };

            var kodak = new Dino()
            {
                Name = "Kodak",
                DietType = "herbivore",
                EnclosureNumber = 2,
                Weight = 300,
            };
            var dinos = new List<Dino>();
            dinos.Add(sadie);
            dinos.Add(russell);
            dinos.Add(kodak);

            BannerMessage("Welcome to JurasicPark");

            var userHasChosenToQuit = false;

            while (userHasChosenToQuit == false)
            {




                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("ADD - Add a new dino");
                Console.WriteLine("SEE - See all the dinos");
                Console.WriteLine("TRANSFER - Transfer a dino");
                Console.WriteLine("REMOVE - Remove a dino");
                Console.WriteLine("SUMMARY - View amount of carnivores and herbivores");



                Console.WriteLine("QUIT _ Quit the app");
                Console.WriteLine();
                Console.Write("What is your choice?");
                var choice = Console.ReadLine().ToUpper().Trim();


                if (choice == "QUIT")
                {
                    userHasChosenToQuit = true;
                }
                if (choice == "ADD")
                {
                    var dino = new Dino();
                    Console.Write("What is the dinos Name? ");
                    dino.Name = Console.ReadLine();
                    Console.Write("What is the diet type? ");
                    dino.DietType = Console.ReadLine();
                    Console.Write("What is the enclosureNumber? ");
                    dino.EnclosureNumber = int.Parse(Console.ReadLine());
                    Console.Write("What is the weight? ");
                    dino.Weight = int.Parse(Console.ReadLine());
                    dinos.Add(dino);



                }
                if (choice == "REMOVE")
                {
                    Console.Write("Whats the name of the dino you want to delete? ");
                    var dinoToDeleteName = Console.ReadLine();
                    var dinoToDelete = dinos.First(firstDino => firstDino.Name == dinoToDeleteName);
                    dinos.Remove(dinoToDelete);
                }
                if (choice == "TRANSFER")
                {
                    Console.Write("What is the name of the dino you want to transfer? ");
                    var dinoToTransferName = Console.ReadLine();
                    var dinoToTransfer = dinos.FindIndex(firstdino => firstdino.Name == dinoToTransferName);
                    Console.WriteLine("Where would you like to transfer this dino to? ");
                    var newEnclosureNumber = int.Parse(Console.ReadLine());
                    dinos[dinoToTransfer].EnclosureNumber = newEnclosureNumber;




                }
                if (choice == "SEE")
                {
                    Console.WriteLine("list of dinos");
                    foreach (var dino in dinos)
                    {
                        Console.WriteLine($"{dino.Name} is a {dino.DietType} and is in enclosure number {dino.EnclosureNumber} weighing {dino.Weight} lbs");
                    }


                }
                if (choice == "SUMMARY")
                {
                    var carnivores = dinos.Where(dino => dino.DietType == "carnivore");
                    var numberOfCarnivores = carnivores.Count();
                    var numberOfDinos = dinos.Count();
                    var numberOfHerbivores = numberOfDinos - numberOfCarnivores;
                    Console.WriteLine($"There are {numberOfCarnivores} number of carnivores. There are {numberOfHerbivores} number of herbivores");

                }

            }






            //List<Dinosaur>

            // 


            //view
            // add
            // remove
            // transfer
            // summary
            // quit



            BannerMessage("Goodbye");
        }

    }

}
