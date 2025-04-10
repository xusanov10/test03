// See https://aka.ms/new-console-template for more information
static void Main(string[] args)
{
    int[] ints = new int[10];
    for (int i = 0; i < 10; i++)
    {
        ints[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    int counter = 0;
    for (int i = 0; i < ints.Length; i++)
    {
        counter += ints[i];
    }
    Console.WriteLine(counter / 10);
}