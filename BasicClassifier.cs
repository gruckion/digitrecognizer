﻿namespace DigitsRecogniszer
{
    using System;
    using System.Collections.Generic;

    public class BasicClassifier : IClassifier
    {
        public BasicClassifier(IDistance distance)
        {
            this.distance = distance;
        }
        
        private IEnumerable<Observation> data;

        private readonly IDistance distance;

        public string Predict(int[] pixels)
        {
            Observation currentBest = null;
            var shortest = Double.MaxValue;

            foreach (Observation obs in this.data)
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
        
        public void Train(IEnumerable<Observation> trainingSet)
        {
            this.data = trainingSet;
        }
    }
}
