using System.ComponentModel.Design;
using System.IO;
using static CA3_sem2.Ship;

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
                        ShipReports();
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
        static List<Passengerinfo> fileinfo(string filepath)
        {
            List<Passengerinfo> passengers = new List<Passengerinfo>();
            using (StreamReader sr = File.OpenText(filepath))
            {

                string? lineIn = sr.ReadLine();
                while (lineIn != null)
                {
                    string[] splitString = lineIn.Split(',');

                    Passengerinfo passenger = new Passengerinfo(splitString[0], splitString[1], splitString[2], splitString[3], splitString[4], splitString[5], splitString[6], splitString[7], splitString[8], splitString[9]);
                    passengers.Add(passenger);

                    lineIn = sr.ReadLine();
                }
                return passengers;
            }

            static void ShipReports()
            {
                string filepath = @"C:\Users\billy\OneDrive - Atlantic TU\my programs\CA3_sem2\faminefile.csv";
                List<Passengerinfo> passengers = fileinfo(filepath);

            }
            static void OccupationReport()
            {
                string filepath = @"C:\Users\billy\OneDrive - Atlantic TU\my programs\CA3_sem2\faminefile.csv";

                int spinster = 0;
                int cultivatorAndFarmer = 0;
                int matron = 0;
                int dressMaker = 0;
                int labourer = 0;
                int child = 0;
                int fisherman = 0;
                int none = 0;
                int maid = 0;
                int smith = 0;
                int mason = 0;
                int baker = 0;
                int tanner = 0;
                int infant = 0;
                int carpenter = 0;
                int student = 0;
                int clerk = 0;
                int coachman = 0;
                int immigrant = 0;

                using (StreamReader sr= File.OpenText(filepath))
                {
                    string lineIn = sr.ReadLine();
                    while(lineIn!=null)
                    {
                        string[] splitString = lineIn.Split(',');
                        if (lineIn.Contains("Spinster"))
                        { spinster++; }
                        else if (lineIn.Contains("Cultivator or Farmer"))
                        { cultivatorAndFarmer++; }
                        else if (lineIn.Contains("Matron"))
                        { matron++; }
                        else if (lineIn.Contains("Dressmaker"))
                        { dressMaker++; }
                        else if (lineIn.Contains("Laborer (Ital. 'operaia') or Workman/Woman"))
                        { labourer++; }
                        else if (lineIn.Contains("Child"))
                        { child++; }
                        else if (lineIn.Contains("Fisher Man"))
                        { fisherman++; }
                        else if (lineIn.Contains("None"))
                        { none++; }
                        else if (lineIn.Contains("Chamber Maid or Maid or Servant"))
                        { maid++; }
                        else if (lineIn.Contains("Smith"))
                        { smith++; }
                        else if (lineIn.Contains("Mason"))
                        { mason++; }
                        else if (lineIn.Contains("Baker or Macaroni Maker"))
                        { baker++; }
                    }
                }

            }
            static void AgeReport()
            {

            }
            static void Exit()
            {

            }
        }
    }
}