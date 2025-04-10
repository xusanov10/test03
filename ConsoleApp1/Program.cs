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

static void Main1(string[] args)
{
    int[] ints = new int[10];

    for (int i = 0; i < 10; i++)
    {
        Random rnd = new Random();

        ints[i] = rnd.Next(1, 15);
    }

    int max = 0;

    int min = 20;

    for (int i = 0; i < ints.Length; i++)
    {
        Console.WriteLine(ints[i]);

        if (ints[i] > max) max = ints[i];

        if (ints[i] < min) min = ints[i];
    }
    Console.WriteLine(" eng katta " + max);

    Console.WriteLine(" eng kichik " + min);
}

static void Main3(string[] args)
{
    int[] ints = new int[20];

    for (int i = 0; i < 10; i++)
    {
        Random rnd = new Random();

        ints[i] = rnd.Next(1, 100);
    }

    for (int i = 0; i < ints.Length; i++)
    {
        Console.Write(ints[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();

    for (int i = 0; i < ints.Length; i++)
    {
        if (ints[i] % 2 == 0)
        {
            Console.Write(ints[i] + " ");
        }
    }
}

static void Main4(string[] args)
{
    int[] ints = { 1, 2, 3, 4, 5 };

    string counter = "";
    for (int i = 0; i < ints.Length; i++)
    {
        counter = Convert.ToString(ints[i] + " ") + counter;
    }
    Console.WriteLine(counter);
}

static void Main5(string[] args)
{
    string[] str = { "Malika", "Akbar", "Ilhom", "Javohir", "Ali" };

    string s = Console.ReadLine();
    bool b = false;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].ToLower() == s.ToLower()) b = true; break;
    }
    Console.WriteLine(b);
}