using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;
using System;
using System.ComponentModel;
using System.Diagnostics;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "

            // Create long variable to hold item number

            // Get user input as string and assign to variable.
            // Convert user input from string to long and store as item number variable.

            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)

            // Loop through Appliances
                // Test appliance item number equals entered item number
                    // Assign appliance in list to foundAppliance variable

                    // Break out of loop (since we found what need to)

            // Test appliance was not found (foundAppliance is null)
                // Write "No appliances found with that item number."

            // Otherwise (appliance was found)
                // Test found appliance is available
                    // Checkout found appliance

                    // Write "Appliance has been checked out."
                // Otherwise (appliance isn't available)
                    // Write "The appliance is not available to be checked out."
          
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

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
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

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write Write "4 - Four doors"
            Console.WriteLine("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors): ");

            // Create variable to hold entered number of doors           
            // Get user input as string and assign to variable           
            // Convert user input from string to int and store as number of doors variable.
            int number_doors = Convert.ToInt32(Console.ReadLine());

            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();

            // Iterate/loop through Appliances
                // Test that current appliance is a refrigerator
                    // Down cast Appliance to Refrigerator
                    // Refrigerator refrigerator = (Refrigerator) appliance;

                    // Test user entered 0 or refrigerator doors equals what user entered.
                        // Add current appliance in list to found list
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Refrigerator)
                {
                    Refrigerator refrigerator = (Refrigerator)appliance;
                    if (number_doors == 0 || refrigerator.Doors == number_doors)
                    {
                        found.Add(refrigerator);
                    }
                }
            }

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            //// Write "Possible options:"
            //Console.WriteLine("Possible options:");
            //// Write "0 - Any"
            //// Write "1 - Residential"
            //// Write "2 - Commercial"
            //Console.WriteLine("0 - Any");
            //Console.WriteLine("1 - Residential");
            //Console.WriteLine("2 - Commercial");

            //// Write "Enter grade:"
            //Console.WriteLine("Enter battery voltage value. 18 V (low) or 24 V (high) ");

            //// Get user input as string and assign to variable
            //string input_grade = Console.ReadLine();
            //// Create grade variable to hold grade to find (Any, Residential, or Commercial)

            //string grade;


            //// Test input is "0"
            //// Assign "Any" to grade
            //// Test input is "1"
            //// Assign "Residential" to grade
            //// Test input is "2"
            //// Assign "Commercial" to grade
            //// Otherwise (input is something else)
            //// Write "Invalid option."

            //// Return to calling (previous) method
            //// return;
            //if (input_grade == "0")
            //{
            //    grade = "Any";
            //}
            //else if (input_grade == "1")
            //{
            //    grade = "Residential";
            //}
            //else if (input_grade == "2")
            //{
            //    grade = "Commercial";
            //}
            //else
            //{
            //    Console.WriteLine("Invalid option.");
            //    return;
            //}

            // Write "Possible options:"
            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"          
            // Write "Enter voltage:"
            Console.WriteLine("Enter battery voltage value. 18 V (low) or 24 V (high)");


            // Get user input as string
            // Create variable to hold voltage
            string voltage= Console.ReadLine();

            // Test input is "0"
            // Assign 0 to voltage
            // Test input is "1"
            // Assign 18 to voltage
            // Test input is "2"
            // Assign 24 to voltage
            // Otherwise
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;
           
            // Create found variable to hold list of found appliances.
            List<Appliance> found = new List<Appliance>();

            // Loop through Appliances
            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            // Vacuum vacuum = (Vacuum)appliance;

            // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
            // Add current appliance in list to found list
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Vacuum)
                {
                    Vacuum vacuum = (Vacuum)appliance;
                    if (voltage.Equals(vacuum.BatteryVoltage))
                    {
                        found.Add(vacuum);
                    }
                }
            }

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);

            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            //// Write "Possible options:"
            //Console.WriteLine("Possible options:");

            //// Write "0 - Any"
            //// Write "1 - Kitchen"
            //// Write "2 - Work site"
            //Console.WriteLine("0 - Any");
            //Console.WriteLine("1 - Kitchen");
            //Console.WriteLine("2 - Work sit");

            // Write "Enter room type:"
            Console.WriteLine("Room where the microwave will be installed: K (kitchen) or W (work site): ");

            // Get user input as string and assign to variable
            string room_type = Console.ReadLine();

            // Create character variable that holds room type
            //string room_type;

            // Test input is "0"
            // Assign 'A' to room type variable
            // Test input is "1"
            // Assign 'K' to room type variable
            // Test input is "2"
            // Assign 'W' to room type variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            // return;
            //if (input_room == "0")
            //{
            //    room_type = "A";
            //}
            //else if (input_room == "1")
            //{
            //    room_type = "K";
            //}
            //else if (input_room == "2")
            //{
            //    room_type = "W";
            //}
            //else
            //{
            //    Console.WriteLine("Invalid option.");
            //    return;
            //}

            // Create variable that holds list of 'found' appliances
            List<Appliance> found = new List<Appliance>();

            // Loop through Appliances
            // Test current appliance is Microwave
            // Down cast Appliance to Microwave

            // Test room type equals 'A' or microwave room type
            // Add current appliance in list to found list
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Microwave)
                {
                    Microwave microwave = (Microwave)appliance;
                    if (room_type.Equals(microwave.RoomType))
                    {
                        found.Add(microwave);
                    }
                }
            }

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"
            //Console.WriteLine("Possible options:");

            //// Write "0 - Any"
            //// Write "1 - Quietest"
            //// Write "2 - Quieter"
            //// Write "3 - Quiet"
            //// Write "4 - Moderate"
            //Console.WriteLine("0 - Any");
            //Console.WriteLine("1 - Quietest");
            //Console.WriteLine("2 - Quieter");
            //Console.WriteLine("3 - Quiet");
            //Console.WriteLine("4 - Moderate");

            // Write "Enter sound rating:"
            Console.WriteLine("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu(Quiet) or M (Moderate):");

            // Get user input as string and assign to variable
            string sound_rating = Console.ReadLine();
            // Create variable that holds sound rating
            //string sound_rating;

            // Test input is "0"
            // Assign "Any" to sound rating variable
            // Test input is "1"
            // Assign "Qt" to sound rating variable
            // Test input is "2"
            // Assign "Qr" to sound rating variable
            // Test input is "3"
            // Assign "Qu" to sound rating variable
            // Test input is "4"
            // Assign "M" to sound rating variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            //if (input_rating == "0")
            //{
            //    sound_rating = "Any";
            //}
            //else if (input_rating == "1")
            //{
            //    sound_rating = "Qt";
            //}
            //else if (input_rating == "2")
            //{
            //    sound_rating = "Qr";
            //}
            //else if (input_rating == "3")
            //{
            //    sound_rating = "Qu";
            //}
            //else if (input_rating == "4")
            //{
            //    sound_rating = "M";
            //}
            //else
            //{
            //    Console.WriteLine("Invalid option.");
            //    return;
            //}


            // Create variable that holds list of found appliances
            List<Appliance> found = new List<Appliance>();

            // Loop through Appliances
            // Test if current appliance is dishwasher
            // Down cast current Appliance to Dishwasher

            // Test sound rating is "Any" or equals soundrating for current dishwasher
            // Add current appliance in list to found list
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Dishwasher)
                {
                    Dishwasher dishwasher = (Dishwasher)appliance;
                    if (sound_rating.Equals(dishwasher.SoundRating))
                    {
                        found.Add(dishwasher);
                    }
                }
            }

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
            {
            // Write "Appliance Types"
            //Console.WriteLine("Appliance Types:\n0 - Any\n1 – Refrigerators\n2 – Vacuums\n3 – Microwaves\n4 – Dishwashers");
            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"

            // Write "Enter type of appliance:"
            // Console.WriteLine("Enter type of appliance:");
            // Get user input as string and assign to appliance type variable
            //string app_type = Console.ReadLine();
            // Write "Enter number of appliances: "
            Console.WriteLine("Enter number of appliances: ");
            // Get user input as string and assign to variable
            int app_number = int.Parse(Console.ReadLine());
            //a list to save random number
            List<int> random_number = new List<int>();
            //the length of the Appliance list
            int list_length = Appliances.Count();
            // Convert user input from string to int
            for (int i = 0; i <= app_number; i++)
                {
                int random_no = new Random().Next(0, list_length);
                random_number.Add(random_no);
                }
            // Create variable to hold list of found appliances
            List<Appliance> found_appliances = new List<Appliance>();

            // Loop through appliances

            foreach (var number in random_number)
                {
                found_appliances.Add(Appliances[number]);
                }
            // Test inputted appliance type is "0"
            // Add current appliance in list to found list
            //if(app_type == "0")
            //    {
            //    found_appliances.Add(appliance);
            //    }else if(app_type == "1")
            //    {
            //        if(appliance is Refrigerator)
            //            {
            //                found_appliances.Add(appliance);
            //            }
            //    }else if(app_type == "2")
            //    {
            //        if(appliance is Vacuum) 
            //            { 
            //                found_appliances.Add(appliance);
            //            }
            //    }else if(app_type == "3")
            //    {
            //    if (appliance is Microwave)
            //        {
            //        found_appliances.Add(appliance);
            //        }
            //    }else if(app_type == "4")
            //    {
            //     if (appliance is Dishwasher)
            //        {
            //        found_appliances.Add(appliance);
            //        }
            //    }


            // Test inputted appliance type is "1"
            // Test current appliance type is Refrigerator
            // Add current appliance in list to found list
            // Test inputted appliance type is "2"
            // Test current appliance type is Vacuum
            // Add current appliance in list to found list
            // Test inputted appliance type is "3"
            // Test current appliance type is Microwave
            // Add current appliance in list to found list
            // Test inputted appliance type is "4"
            // Test current appliance type is Dishwasher
            // Add current appliance in list to found list

            // Randomize list of found appliances
            // found.Sort(new RandomComparer());
            found_appliances.Sort(new RandomComparer());
            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, num);
            DisplayAppliancesFromList(found_appliances, app_number);
            }
        }
    }
}
