using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SingletonBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetChocolateSingleton();
            //GetThreadSafetySingleton();

            GetLogger("This is how we do it!");
        }

        private static void GetLogger(string message)
        {
            string filePath = Directory.GetCurrentDirectory() + "/text-files";
            string fileName = $"Demo instance - {DateTime.Now.ToFileTime()} .log";
            string logFilePaths = $"{filePath}/{fileName}";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('*', 20));
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);
            MemoryStream mStrm = new MemoryStream(Encoding.UTF8.GetBytes(logFilePaths));
            using (StreamWriter writer = new StreamWriter(mStrm))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }

            Console.WriteLine("All is logged!");
        }

        private static void GetThreadSafetySingleton()
        {
            Parallel.Invoke(
                 () => PrintOrangeDetails(),
                 () => PrintBananaDetails()
             );
        }

        private static void GetChocolateSingleton()
        {
            SingleThreatedSingleton whiteChocolate = SingleThreatedSingleton.GetInstance;
            whiteChocolate.PrintDetails("This is white chocolate");
            SingleThreatedSingleton darkChocolate = SingleThreatedSingleton.GetInstance;
            darkChocolate.PrintDetails("This is dark chocolate");
        }



        private static void PrintBananaDetails()
        {
            ThreadSafetySingleton bananas = ThreadSafetySingleton.GetInstance;
            bananas.PrintDetails("This is bananas instance!");
        }

        private static void PrintOrangeDetails()
        {
            ThreadSafetySingleton oranges = ThreadSafetySingleton.GetInstance;
            oranges.PrintDetails("This is oranges instance!");
        }
    }
}
