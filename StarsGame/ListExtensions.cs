public static class ListExtensions
{
    public static void Swap<T>(this IList<T> list, int i, int j)
    {
        (list[j], list[i]) = (list[i], list[j]);
    }
}