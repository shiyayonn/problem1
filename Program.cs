// See https://aka.ms/new-console-template for more information

class Problem1
{
    static void Main(string[] args)
    {
        int size = 0;
        
        size = Int32.Parse(Console.ReadLine().Trim());

        int space = size;

        for (int i = 1; i <= size; i++)
        {
            Console.WriteLine($"{new String(' ',--space)}{new String('#',i)}");
        }
    }
}