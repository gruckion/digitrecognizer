namespace DigitsRecogniszer
{
    using System;
    using System.IO;
    using System.Linq;

    public class DataReader
    {
        private static Observation<int> ObservationFactory(string data)
        {
            System.Console.WriteLine("data: ", data);
            var commaSeparated = data.Split(",");
            var label = commaSeparated[0];
            var pixels = commaSeparated
                .Skip(1)
                .Take(5)
                .Select(x => Convert.ToInt32(x))
                .ToArray();

            return new Observation<int>(label, pixels);
        }

        public static Observation<int>[] ReadObservations(string dataPath)
        {
            var array = File.ReadAllLines(dataPath)
                .Skip(1)
                .Select(ObservationFactory)
                .ToArray();

            return array;
        }

    }
}