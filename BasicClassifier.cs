namespace DigitsRecogniszer
{
    using System.Collections.Generic;

    public class BasicClassifier : IClassifier<int>
    {
        public BasicClassifier(IDistance<int> distance)
        {
            this.distance = distance;
        }
        private IEnumerable<Observation<int>> data;

        private readonly IDistance<int> distance;

        public string Predict(int[] pixels)
        {
            Observation<int> currentBest = null;
            var shortest = double.MaxValue;

            foreach (Observation<int> obs in this.data)
            {
                var dist = this.distance.Between(obs.Pixels, pixels);
                if (dist < shortest)
                {
                    shortest = dist;
                    currentBest = obs;
                }
            }
            return currentBest.Label;
        }

        public void Train(IEnumerable<Observation<int>> trainingSet)
        {
            this.data = trainingSet;
        }
    }
}