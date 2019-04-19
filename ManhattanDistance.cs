namespace DigitsRecogniszer
{
    using System;
    using System.Threading.Tasks;

    public class ManhattanDistance : IDistance<int>
    {
        public double Between(int[] pixels1, int[] pixels2)
        {
            if (pixels1.Length != pixels2.Length)
            {
                throw new ArgumentException("Inconsistent image sizes.");
            }

            var length = pixels1.Length;
            var distance = 0;

            Parallel.For(0, distance, i => { Math.Abs(pixels1[i] -= pixels2[i]); });

            return distance;
        }
    }
}