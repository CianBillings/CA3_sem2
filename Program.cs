using System.ComponentModel.Design;

namespace CA3_sem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static private void Menu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("============");
            Console.WriteLine("1. Ship Reports");
            Console.WriteLine("2. Occupation Report");
            Console.WriteLine("3. Age Report");
            Console.WriteLine("4. Exit");
            Console.Write("Please enter choice : ");
            int menuchoice = int.Parse(Console.ReadLine());

            if (menuchoice == 1)
            {
                ShipReports();
            }

            else if (menuchoice == 2)
            {
                OccupationReport();
            }

            else if (menuchoice == 3)
            {
                AgeReport();
            }

            else if (menuchoice == 4)
            {
                Exit();
            }

            else
            {
                Console.WriteLine("Invalid Entry");
            }

        }
        static private void ShipReports()
        {

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