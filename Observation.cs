namespace DigitsRecogniszer
{
    public class Observation<T>
    {
        public Observation(string label, T[] pixels)
        {
            this.Label = label;
            this.Pixels = pixels;
        }

        public string Label { get; set; }
        public T[] Pixels { get; set; }
    }
}