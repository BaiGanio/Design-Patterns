using System;

namespace DataSaviour
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = new LocalFileDataSource("data-saviour.txt");
            //string data = source.ReadData();
            //Console.WriteLine(data);
            source.WriteData("I'm another line!!");
            Console.WriteLine(source.ReadData());
        }
    }
}
