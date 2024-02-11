/***********************************************************************************

ABSTRACT CLASS FOR MAIN RUNNING OF THE PROGRAM

***********************************************************************************/


using Modern_Appliances.Abstract_Class;
using Modern_Appliances.ProblemDomain;

namespace Modern_Appliances
{

    internal abstract class Modernappliances
    {
        public const string APPLIANCES_TEXT_FILE = @"C:\Users\tgonb\Desktop\Lab_1\Lab 1\appliances.txt";

        public enum Options
        {
            None,
            Checkout = 1,
            Find = 2,
            DisplayType = 3,
            RandomList = 4,
            SaveExit = 5,
        }

        private List<Appliances> appliances;
        public List<Appliances> Appliances
        {
            get
            {
                return new List<Appliances>(appliances);
            }
        }
        public Modernappliances()
        {
            this.appliances = this.ReadAppliances();
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to Modern Appliances!");
            Console.WriteLine("How May We Assist You ?");
            Console.WriteLine("1 – Check out appliance");
            Console.WriteLine("2 – Find appliances by brand");
            Console.WriteLine("3 – Display appliances by type");
            Console.WriteLine("4 – Produce random appliance list");
            Console.WriteLine("5 – Save & exit");
        }
        public abstract void Checkout();
        public abstract void Find();
        public void DisplayType()
        {
            Console.WriteLine("Appliance Types");
            Console.WriteLine("1 – Refrigerators");
            Console.WriteLine("2 – Vacuums");
            Console.WriteLine("3 – Microwaves");
            Console.WriteLine("4 – Dishwashers");

            Console.Write("Enter type of appliance:");

            int applianceTypeNum;
            bool parsedApplianceType = int.TryParse(Console.ReadLine(), out applianceTypeNum);

            if (!parsedApplianceType || applianceTypeNum < 0 || applianceTypeNum > 4)
            {
                Console.WriteLine("Invalid appliance type entered.");
                return;
            }

            switch (applianceTypeNum)
            {
                case 1:
                    {
                        this.DisplayRefrigerators();

                        break;
                    }

                case 2:
                    {
                        this.DisplayVacuums();

                        break;
                    }

                case 3:
                    {
                        this.DisplayMicrowaves();

                        break;
                    }

                case 4:
                    {
                        this.DisplayDishwashers();

                        break;
                    }

                default:
                    {
                        Console.WriteLine("Invalid appliance type entered.");

                        break;
                    }
            }
        }

        public abstract void DisplayRefrigerators();
        public abstract void DisplayVacuums();
        public abstract void DisplayMicrowaves();
        public abstract void DisplayDishwashers();
        public abstract void RandomList();
        public void Save()
        {
            StreamWriter fileStream = File.CreateText(APPLIANCES_TEXT_FILE);

            foreach (var appliance in appliances)
            {
                fileStream.WriteLine(appliance.FormatForFile() + ';');
            }

            fileStream.Close();

            Console.WriteLine("DONE!");
        }
        protected List<Appliances> ReadAppliances()
        {
            List<Appliances> appliances = new List<Appliances>();
            string[] lines = File.ReadAllLines(@"C:\Users\tgonb\Desktop\Winter 2024\Object-Oriented Programming 2\appliances.txt");


            foreach (string line in lines)
            {
                Appliances? appliance = this.CreateApplianceFromLine(line);

                if (appliance != null)
                {
                    appliances.Add(appliance);
                }
            }

            return appliances;
        }
        private Appliances? CreateApplianceFromLine(string line)
        {
            string[] parts = line.Split(';');

            string firstDigitStr = line.Substring(0, 1);
            short firstDigit = short.Parse(firstDigitStr);

            Appliances? appliance;

            if (firstDigit == 1)
            {
                // Refrigerator
                appliance = CreateRefrigeratorFromParts(parts);
            }
            else if (firstDigit == 2)
            {
                // Vacuum
                appliance = CreateVacuumFromParts(parts);
            }
            else if (firstDigit == 3)
            {
                // Microwave
                appliance = CreateMicrowaveFromParts(parts);
            }
            else if (firstDigit == 4 || firstDigit == 5)
            {
                // Dishwasher
                appliance = CreateDishwasherFromParts(parts);
            }
            else
            {
                appliance = null;
            }

            return appliance;
        }

        private Refrigerator? CreateRefrigeratorFromParts(string[] parts)
        {
            if (((parts.Length) - 1)!= 9)
                return null;

            long itemNumber = long.Parse(parts[0]);
            string brand = parts[1];
            int quantity = int.Parse(parts[2]);
            double  wattage = double.Parse(parts[3]);
            string color = parts[4];
            double price = double.Parse(parts[5]);
            short doors = short.Parse(parts[6]);
            int width = int.Parse(parts[7]);
            int height = int.Parse(parts[8]);

            Refrigerator refrigerator = new Refrigerator(itemNumber, brand, quantity, wattage, color, price, doors, width, height);

            return refrigerator;
        }
        private Vacuum? CreateVacuumFromParts(string[] parts)
        {
            if (parts.Length - 1 != 8)
                return null;

            long itemNumber = long.Parse(parts[0]);
            string brand = parts[1];
            int quantity = int.Parse(parts[2]);
            double wattage = double.Parse(parts[3]);
            string color = parts[4];
            double price = double.Parse(parts[5]);
            string grade = parts[6];
            short batteryVoltage = short.Parse(parts[7]);

            Vacuum vacuum = new Vacuum(itemNumber, brand, quantity, wattage, color, price, grade, batteryVoltage);

            return vacuum;
        }
        private Microwave? CreateMicrowaveFromParts(string[] parts)
        {
            if (parts.Length - 1 != 8)
                return null;

            long itemNumber = long.Parse(parts[0]);
            string brand = parts[1];
            int quantity = int.Parse(parts[2]);
            double wattage = double.Parse(parts[3]);
            string color = parts[4];
            double price = double.Parse(parts[5]);
            float capacity = float.Parse(parts[6]);
            char roomType = char.Parse(parts[7]);

            Microwave microwave = new Microwave(itemNumber, brand, quantity, wattage, color, price, capacity, roomType);

            return microwave;
        }
        private Dishwasher? CreateDishwasherFromParts(string[] parts)
        {
            if (parts.Length - 1 != 8)
                return null;

            long itemNumber = long.Parse(parts[0]);
            string brand = parts[1];
            int quantity = int.Parse(parts[2]);
            double wattage = double.Parse(parts[3]);
            string color = parts[4];
            double price = double.Parse(parts[5]);
            string feature = parts[6];
            string soundRating = parts[7];

            Dishwasher dishwasher = new Dishwasher(itemNumber, brand, quantity, wattage, color, price, feature, soundRating);

            return dishwasher;
        }
        public void DisplayAppliancesFromList(List<Appliances> appliances, int max)
        {
            if (appliances.Count > 0)
            {
                Console.WriteLine("Found appliances:");
                Console.WriteLine();

                // Display found appliances until either end of list is reached or number of appliances requested is shown.
                for (int i = 0; i < appliances.Count && (max == 0 || i < max); i++)
                {
                    Appliances appliance = appliances[i];
                    Console.WriteLine(appliance);
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("No appliances found.");
            }

            Console.WriteLine();
        }
    }
}
