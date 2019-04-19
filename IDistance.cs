namespace DigitsRecogniszer
{
    public interface IDistance<T>
    {
        double Between(T[] pixels1, T[] pixels2);
    }
}