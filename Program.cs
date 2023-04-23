using System.ComponentModel.Design;

namespace CA3_sem2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\billy\OneDrive - Atlantic TU\my programs\CA3_sem2\faminefile.csv";
            string[] Options = { "Ship Reports", "Occupation Reports", "Age Reports", "Exit" };
            Menu a = new Menu(Options);
            Console.WriteLine("Main Menu");
            Console.WriteLine("=====================");
            int inputChoice = a.GetChoice();

            while (inputChoice != Options.Length)
            {
                switch (inputChoice)
                {
                    case 1:
                        Console.WriteLine("Ship Reports: ");
                        Console.WriteLine("==============");
                        ShipReports(filepath);
                        break;

                    case 2:
                        Console.WriteLine("Occupation Report");
                        OccupationReport();
                        break;

                    case 3:
                        Console.WriteLine("Age Report");
                        AgeReport();
                        break;

                    case 4:
                        Console.WriteLine("Exit Program");
                        Exit();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice, please enter one of the choices numbered 1-4");
                        break;
                }
            }
            
       
        }
        static void ShipReports(string filepath)
        {
            string[] shipReprt = { };
        }
        static private void OccupationReport()
        {

        }
        static private void AgeReport()
        {

        }
        static private void Exit()
        {

        }
    }
}