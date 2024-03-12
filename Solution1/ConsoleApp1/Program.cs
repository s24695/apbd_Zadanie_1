// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Console.WriteLine("mod");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i + 2);
    
}
// commit on branch


    static int FindMax(int[] arr)
    {
        int mmaxx = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i]>mmaxx)
            {
                mmaxx = arr[i];
            }
        }
        return mmaxx;
    }
    
    
        int[] numbers = { 1, 5, 3, 8, 2, 7 };
        int maxValue = FindMax(numbers);
        Console.WriteLine("Max: " + maxValue);
    

