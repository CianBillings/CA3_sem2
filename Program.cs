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
            int inputChoice = a.GetChoice();

            while (inputChoice != Options.Length)
            {
                switch (inputChoice)
                {
                    case 1:
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
        }
            static private void ShipReports()
            {
                string filepath = @"C:\Users\billy\OneDrive - Atlantic TU\my programs\CA3_sem2\faminefile.csv";
                List<Passengerinfo> passengers = fileinfo(filepath);
                int i = 0;
                string[] shipOptions = { "Mary Harrington", "Lincoln", "Clare", "Disbatch" };
                Menu b = new Menu(shipOptions);
                int inputChoice = b.GetChoice();
                                
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
                        else if (lineIn.Contains("Tanner or Gerber"))
                        { tanner++; }
                        else if (lineIn.Contains("Infant"))
                        { infant++; }
                        else if (lineIn.Contains("Carpenter"))
                        { carpenter++; }
                        else if (lineIn.Contains("Student"))
                        { student++; }
                        else if (lineIn.Contains("Clerk"))
                        { clerk++; }
                        else if (lineIn.Contains("Coachman/Coach Driver or Driver"))
                        { coachman++; }
                        else if (lineIn.Contains("immigrant"))
                        { immigrant++; }

                    Console.WriteLine($"The number of passengers who are spinsters : {spinster}");
                    Console.WriteLine($"The number of passengers who are Cultivator or Farmers : {cultivatorAndFarmer}");
                    Console.WriteLine($"The number of passengers who are Matrons : {matron}");
                    Console.WriteLine($"The number of passengers who are Dressmakers : {dressMaker}");
                    Console.WriteLine($"The number of passengers who are Laborers : {labourer}");
                    Console.WriteLine($"The number of passengers who are children : {child}");
                    Console.WriteLine($"The number of passengers who are unemployed : {none}");
                    Console.WriteLine($"The number of passengers who are maids : {maid}");
                    Console.WriteLine($"The number of passengers who are Smiths : {smith}");
                    Console.WriteLine($"The number of passengers who are Masons : {mason}");
                    Console.WriteLine($"The number of passengers who are Bakers : {baker}");
                    Console.WriteLine($"The number of passengers who are tanners : {tanner}");
                    Console.WriteLine($"The number of passengers who are infants : {infant}");
                    Console.WriteLine($"The number of passengers who are carpenters : {carpenter}");
                    Console.WriteLine($"The number of passengers who are students : {student}");
                    Console.WriteLine($"The number of passengers who are clerks : {clerk}");
                    Console.WriteLine($"The number of passengers who are coachmen : {coachman}");
                    Console.WriteLine($"The number of passengers who are immigrants : {immigrant}");
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