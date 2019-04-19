using System;

namespace DigitsRecogniszer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application started");

            var trainingPath = "training.csv";
            var training = DataReader.ReadObservations(trainingPath);
            Console.ReadLine();
            
            Console.WriteLine("Application finished");
        }
    }
}
