namespace DigitsRecogniszer
{
    using System.Collections;
    using System.Collections.Generic;
    public interface IClassifier<T>
    {
        void Train(IEnumerable<Observation<T>> trainingSet);
        string Predict(T[] pixels);
    }
}