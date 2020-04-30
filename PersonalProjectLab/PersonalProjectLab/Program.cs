using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Minecraft Furnace Calcuator ###");

           //Settind default values
            bool Cont = true;
            String FuelName = "Coal";
            Double FuelEff = 8;

            while(Cont)
            {
                Console.WriteLine("Currently the Fuel is " + FuelName);

                Console.WriteLine("Do you want to change fuel type? yes or no");
                string choice = Console.ReadLine();
                if (choice == "yes")
                {
                    //Chosing Fuel type
                    bool error = true;

                    while (error) 
                    {
                        Console.WriteLine("The Fuel choices are: Coal / Block of Coal");
                        choice = Console.ReadLine();
                        //Chosing Coal
                        if (choice == "Coal")
                        {
                            FuelName = "Coal";
                            FuelEff = 8;
                            error = false;
                        }
                        //Chosing Block of Coal
                        if (choice == "Block of Coal")
                        {
                            FuelName = "Block of Coal";
                            FuelEff = 80;
                            error = false;
                        }
                        //No Choice
                        if (error == true) Console.WriteLine("Error, make sure to copy properly");


                    }
                   
                }

                //Asking what Calcuation to preform
                Console.WriteLine("Do you want to find how much fuel is needed?");
                choice = Console.ReadLine();
                if (choice == "yes") 
                {
                    //Checking 
                    Console.WriteLine("How many items do you want to smelt?");
                    string reply = Console.ReadLine();
                    Double NumItemUnits = Double.Parse(reply);
                    Calcuations Smelt = new Calcuations();
                    Console.WriteLine("Fuel required " + Smelt.CalculateFuel(NumItemUnits, FuelEff));
                }
                else 
                {
                    Console.WriteLine("Do you want to find how much your fuel can cook?");
                    choice = Console.ReadLine();
                    if (choice == "yes")
                    {
                        Console.WriteLine("How much fuel do you want to use?");
                        string reply = Console.ReadLine();
                        Double NumFuelUnits = Double.Parse(reply);
                        Calcuations Smelt = new Calcuations();
                        Console.WriteLine("Items required " + Smelt.CalculateItems(NumFuelUnits,FuelEff));
                    }

                }
      
                Console.WriteLine("do you wish to continue? type no to stop.");
                choice = Console.ReadLine();
                if (choice == "no")
                    Cont = false;

            }

        }
    }
}