public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of elements in the array: ");
        int numberElement = Convert.ToInt32(Console.ReadLine());
        int[] arrays = new int[numberElement];
        Console.WriteLine();
        Console.WriteLine("Enter the element.");

        //Enter the element
        for (int i = 0; i < arrays.Length; i++)
        {
            Console.Write($"Element {i + 1}: ");
            arrays[i] = Convert.ToInt32(Console.ReadLine());
        }

        //Display the array on the screen
        Console.WriteLine();
        Console.Write("Arrays: ");
        foreach (int element in arrays)
        {
            Console.Write(element + ", ");
        }

        //Delete Element
        Console.WriteLine();
        Console.Write("Enter the element you want to delete: ");
        int numberDelete = Convert.ToInt32(Console.ReadLine());

        int index = 0;
        for (int i = 0; i < arrays.Length; i++)
        {
            if (arrays[i] == numberDelete)
            {
                Console.WriteLine($"The element to be deleted is at position {i + 1}.");
                index = i;
                break;
            }
            else
            {
                continue;
            }
        }

        //New Arrays
        int[] newArrays = new int[numberElement - 1];
        for (int i = 0; i < index; i++)
        {
            newArrays[i] = arrays[i];
        }
        for (int j = index; j < newArrays.Length; j++)
        {
            newArrays[j] = arrays[j + 1];
        }

        Console.WriteLine();
        Console.Write("New arrays after deletion: ");
        foreach (int element in newArrays)
        {
            Console.Write(element + ", ");
        }
    }
}