int length = 0;
int[] array = new int[0];
int NP = 0;
for (; ; )
{
    int i = 0;
    Console.WriteLine("Введите число, либо введите stop для окончания вывода");
    var input = Console.ReadLine();
    if (input.Equals("stop", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine($"Количество положительных чисел - {NP}");
        break;
    }
    else
    {
        length = array.Length; //5
        Array.Resize(ref array, array.Length + 1);
        length = array.Length;
        array[i] = Convert.ToInt32(input);
        if (array[i] < 0)
        {
            i = i++;
        }
        else
        {
            i = i++;
            NP = NP + 1;
        }
    }
}


