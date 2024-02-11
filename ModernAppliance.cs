/***********************************************************************************

IMPLEMENTATION OF THE MODERN_APPLIANCES CLASS

***********************************************************************************/



using Modern_Appliances.Abstract_Class;
using Modern_Appliances.ProblemDomain;
using Modern_Appliances;
using System;



namespace Modern_Appliances
{

    internal class ModernAppliance : Modernappliances
    {

        // OVERRIDDEN METHODS->

        public override void Checkout()
        {
            long item_num = 0;
            Console.WriteLine("Enter item number of an Appliance:");

            string input_str = Console.ReadLine();
            long inp = long.Parse(input_str);

            bool flag = false;  

            List<Appliances> appliances = ReadAppliances();
            //DisplayAppliancesFromList(appliances, 26);

            for (int i = 0; i < appliances.Count; i++)
            {
                if (appliances[i].get_ItemNumber == inp)
                {
                    Console.WriteLine("Matching Appliances: ");
                    Console.WriteLine(appliances[i]);
                    Console.WriteLine("Appliance has been checked out!");
                    appliances[i].Checkout();
                    flag = true;
                    
                }
            }
            if (flag == false) Console.WriteLine("No appliances found with that item number.");
        }

        public override void Find()
        {

            Console.WriteLine("Enter brand to search for:");

            string input_str = Console.ReadLine();

            bool flag = false;

            List<Appliances> appliances = ReadAppliances();

            bool isEqual = false;

            for (int i = 0; i < appliances.Count; i++)
            {
                isEqual = string.Equals(appliances[i].get_BrandName, input_str, StringComparison.OrdinalIgnoreCase);

                if(isEqual){
                    Console.WriteLine("Matching Appliances: ");
                    Console.WriteLine(appliances[i]);
                    Console.WriteLine('\n');
                    flag = true;

                }
            }
            if (flag == false) Console.WriteLine("No appliances found with that brand name.");
    }

        public override void DisplayRefrigerators()
        {

            Console.WriteLine("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors):");
            string str = Console.ReadLine();
            int numdoors = int.Parse(str);


            List<Appliances> appliances = ReadAppliances();

            bool flag = false;

            for (int i = 0; i < appliances.Count; i++)
            {
                    
                if (appliances[i].determine_application(appliances[i].get_ItemNumber) == 1)
                {
                    Refrigerator refrigerator = (Refrigerator)appliances[i];
                    if (refrigerator.Doors == numdoors)
                    {

                        Console.WriteLine("Matching Appliances: ");
                        Console.WriteLine(appliances[i]);
                        Console.WriteLine('\n');
                        flag = true;
                    }
                }
            }
            if (flag == false) Console.WriteLine("No amount of doors you entered exists.");
        }

        public override void DisplayVacuums()
        {
            Console.WriteLine("Enter battery voltage value. 18 V (low) or 24 V (high)");
            string str = Console.ReadLine();
            int volt = int.Parse(str);
            
            List<Appliances> appliances = ReadAppliances();

            bool flag = false;

            for (int i = 0; i < appliances.Count; i++)
            {

                if (appliances[i].determine_application(appliances[i].get_ItemNumber) == 2)
                {
                    Vacuum vacuum= (Vacuum)appliances[i];
                    if (vacuum.BatteryVoltage == volt)
                    {

                        Console.WriteLine("Matching Appliances: ");
                        Console.WriteLine(appliances[i]);
                        Console.WriteLine('\n');
                        flag = true;
                    }
                }
            }
            if (flag == false) Console.WriteLine("No amount of voltage you entered exists.");
        }


        public override void DisplayMicrowaves()
        {

            Console.WriteLine("Room where the microwave will be installed: K (kitchen) or W (work site):");
            string str = Console.ReadLine();


            List<Appliances> appliances = ReadAppliances();

            bool flag = false;
            bool isEqual = false;
            string temp = "";

            for (int i = 0; i < appliances.Count; i++)
            {

                if (appliances[i].determine_application(appliances[i].get_ItemNumber) == 3)
                {
                    Microwave microwave = (Microwave)appliances[i];
                    temp = microwave.RoomType + "";

                    isEqual = string.Equals(temp, str, StringComparison.OrdinalIgnoreCase);
                    if (isEqual)
                    {

                        Console.WriteLine("Matching Appliances: ");
                        Console.WriteLine(appliances[i]);
                        Console.WriteLine('\n');
                        flag = true;
                    }
                }
            }
            if (flag == false) Console.WriteLine("You entered the wrong type of room!");

        }

        public override void DisplayDishwashers()
        {

            Console.WriteLine("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu(Quiet) or M (Moderate):");
            string str = Console.ReadLine();


            List<Appliances> appliances = ReadAppliances();

            bool flag = false;
            bool isEqual = false;
            string temp = "";

            for (int i = 0; i < appliances.Count; i++)
            {
                if (appliances[i].determine_application(appliances[i].get_ItemNumber) == 4 || appliances[i].determine_application(appliances[i].get_ItemNumber) == 5)
                {
                    Dishwasher dishwasher = (Dishwasher)appliances[i];
                    temp = dishwasher.get_Rating+ "";

                    isEqual = string.Equals(temp, str, StringComparison.OrdinalIgnoreCase);
                    if (isEqual)
                    {

                        Console.WriteLine("Matching Appliances: ");
                        Console.WriteLine(appliances[i]);
                        Console.WriteLine('\n');
                        flag = true;
                    }
                }
            }
            if (flag == false) Console.WriteLine("You entered the wrong type of rating!");
        }

        public override void RandomList()
        {

            Console.WriteLine("Enter number of appliances:");
            string str = Console.ReadLine();
            int num = int.Parse(str);

            Random random = new Random();
            List<Appliances> appliances = ReadAppliances();

            Console.WriteLine(appliances.Count);
            for (int i = 0; i < num; i++)
            {
                int random_num = random.Next(1, 25);
                Console.WriteLine(appliances[random_num]);
                Console.WriteLine();
            }

        }
    }
}
