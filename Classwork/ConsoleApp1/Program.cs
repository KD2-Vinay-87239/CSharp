using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public abstract class Report
        {
            protected abstract void CreateReport();
            protected abstract void ParseReport();
            protected abstract void ValidateReport();
            protected abstract void SaveReport();

            public virtual void GenerateReport()
            {
                CreateReport();
                ParseReport();
                ValidateReport();
                SaveReport();
            }
        }

        //PDF extends Report base class
        public class PDF : Report
        {
            protected override void CreateReport()
            {
                Console.WriteLine("PDF created");
            }

            protected override void ParseReport()
            {
                Console.WriteLine("PDF parsed");
            }

            protected override void ValidateReport()
            {
                Console.WriteLine("PDF validated");
            }

            protected override void SaveReport()
            {
                Console.WriteLine("PDF saved");
            }
        }


        //XML extends Report base class
        public class XML : Report
        {
            protected override void CreateReport()
            {
                Console.WriteLine("XML created");
            }

            protected override void ParseReport()
            {
                Console.WriteLine("XML parsed");
            }

            protected override void ValidateReport()
            {
                Console.WriteLine("XML validated");
            }

            protected override void SaveReport()
            {
                Console.WriteLine("XML saved");
            }
        }

        //JSON extends Report base class
        public class JSON : Report
        {
            protected override void CreateReport()
            {
                Console.WriteLine("JSON created");
            }

            protected override void ParseReport()
            {
                Console.WriteLine("JSON parsed");
            }

            protected override void ValidateReport()
            {
                Console.WriteLine("JSON validated");
            }

            protected override void SaveReport()
            {
                Console.WriteLine("JSON saved");
            }
        }

        //TXT extends Report base class
        public class TXT : SpecialReport
        {
            protected override void CreateReport()
            {
                Console.WriteLine("TXT created");
            }

            protected override void ParseReport()
            {
                Console.WriteLine("TXT parsed");
            }

            protected override void ValidateReport()
            {
                Console.WriteLine("TXT validated");
            }

            protected override void ReValidateReport()
            {
                Console.WriteLine("TXT re-validated");
            }

            protected override void SaveReport()
            {
                Console.WriteLine("TXT saved");
            }
        }

        //DOCX extends Report base class
        public class DOCX : SpecialReport
        {
            protected override void CreateReport()
            {
                Console.WriteLine("DOCX created");
            }

            protected override void ParseReport()
            {
                Console.WriteLine("DOCX parsed");
            }

            protected override void ValidateReport()
            {
                Console.WriteLine("DOCX validated");
            }

            protected override void ReValidateReport()
            {
                Console.WriteLine("DOCX re-validated");
            }

            protected override void SaveReport()
            {
                Console.WriteLine("DOCX saved");
            }
        }

        public abstract class SpecialReport : Report
        {

            protected abstract void ReValidateReport();


            public override void GenerateReport()
            {
                CreateReport();
                ParseReport();
                ValidateReport();
                ReValidateReport();             //new method added
                SaveReport();
            }

        }

        //common 
        public class ReportFactory
        {
            public Report GetReport(int choice)
            {
                if (choice == 1)
                {
                    return new DOCX();
                }
                else if (choice == 2)
                {
                    return new XML();
                }
                else if (choice == 3)
                {
                    return new TXT();
                }
                else
                {
                    return new PDF();
                }
            }

            public class Logger
            {
                private static Logger logger = new Logger();

                private Logger()
                {
                    Console.WriteLine("NEW Logger Object Created");
                }

                public static Logger CurrentLogger
                {
                    get { return logger; }
                }

                public void Log(string message)
                {
                    Console.WriteLine("Logged at " + DateTime.Now.ToString() +
                                       " : " + message);
                }
            }
            static void Main(string[] args)
            {


                ReportFactory reportFactory = new ReportFactory();
                Console.WriteLine("1.DOCX, \n 2.XML ,\n3.TXT, \n4.PDF\n");
                Console.WriteLine("Enter your choice :");
                int choice = Convert.ToInt32(Console.ReadLine());

                Logger.CurrentLogger.Log("choice is" + choice);
                Report report = reportFactory.GetReport(choice);
                Logger.CurrentLogger.Log("Calling generate Report");
                report.GenerateReport();
                Console.ReadLine();
            }
        }
    }
}

