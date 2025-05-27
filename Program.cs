public class Program
{
    private static void Main(string[] args)
    {
        int[] arrays = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.Write("Nhap phan tu can xoa: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Funtionexample(x, arrays);
    }
    public static void Funtionexample(int x, int[] arrays)
    {
        int index = 0;
        for (int i = 0; i < arrays.Length; i++)
        {
            if (arrays[i] == x)
            {
                index = i;
            }
        }
        for (int j = index; j < arrays.Length - 1; j++)
        {
            arrays[j] = arrays[j + 1];
        }
        for (int i = 0; i < arrays.Length - 1; i++)
        {
            Console.Write(arrays[i] + "; ");
        }
    }
}