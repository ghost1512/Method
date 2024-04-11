internal class Program
{
    private static void Main(string[] args)
    {
        int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] myArray2 = { 10, 11, 12, 13, 14, 15, 16 };
        Console.WriteLine($"Gia tri lon nhat: {maxvalue(myArray)}");
        Console.WriteLine($"Gia tri lon nhat: {maxvalue(myArray2)}");
    }
    private static int maxvalue(int[] arrayValue)
    {
        int MaxValue = 0;
        for (int i = 0; i < arrayValue.Length; i++)
        {
            if (arrayValue[i] > MaxValue)
            {
                MaxValue = arrayValue[i];
            }
        }
        return MaxValue;
    }
}