using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DigitsRecogniszer
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataDirectory = @".\data\";
            var distance = new ManhattanDistance();
            var classifier = new BasicClassifier(distance);

            var training = DataReader.ReadObservations(dataDirectory + "trainingsample" + ".csv");
            classifier.Train(training);

            var validation = DataReader.ReadObservations(dataDirectory + "validationsample" + ".csv");

            var correct = Evaluator.Correct(validation, classifier);
            Console.WriteLine("Correctly classified: {0:P2}", correct);

            Console.ReadLine();
        }
    }
}
