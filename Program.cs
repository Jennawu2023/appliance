/***********************************************************************************

NAME: Grantly
ID:000830439
DATE: FEB 07



***********************************************************************************/


using Modern_Appliances;

namespace ModernAppliances
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Modernappliances modernAppliances = new ModernAppliance();
            Modernappliances.Options option = Modernappliances.Options.None;

            while (option != Modernappliances.Options.SaveExit)
            {
                modernAppliances.DisplayMenu();

                option = Enum.Parse<Modernappliances.Options>(Console.ReadLine());

                switch (option)
                {
                    case Modernappliances.Options.Checkout:
                        {
                            modernAppliances.Checkout();

                            break;
                        }
                    case Modernappliances.Options.Find:
                        {
                            modernAppliances.Find();

                            break;
                        }
                    case Modernappliances.Options.DisplayType:
                        {
                            modernAppliances.DisplayType();

                            break;
                        }

                    case Modernappliances.Options.RandomList:
                        {
                            modernAppliances.RandomList();
                            break;
                        }
                    case Modernappliances.Options.SaveExit:
                        {
                            modernAppliances.Save();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong choice! Please try again.");
                            break;
                        }
                }
            }


        }
    }
}