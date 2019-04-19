namespace DigitsRecogniszer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class FunctionalExample
    {
        public FunctionalExample(Func<int[], int[], int> distance)
        {
            this.distance = distance;
        }
        
        private IEnumerable<Observation> data;

        private readonly Func<int[], int[], int> distance;

        public Func<int[], int[], int> Distance
        {
            get => this.distance;
        }

        public void Train(IEnumerable<Observation> trainingSet) =>
            this.data = trainingSet;

        public string Predict(int[] pixels)
        {
            Observation currentBest = null;
            var shortest = Double.MaxValue;

            foreach (Observation obs in this.data)
            {
                var dist = this.Distance(obs.Pixels, pixels);
                if (dist < shortest)
                {
                    shortest = dist;
                    currentBest = obs;
                }
            }

            return currentBest.Label;
        }
    }
}
