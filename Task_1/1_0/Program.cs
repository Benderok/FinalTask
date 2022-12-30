// Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] MassToSize(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4) count++;
    }
    string[] newArray = new string[count];

    int j = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintMassiv(string[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

string[] array_a = {"451", "=)", "still", "waiting", "for"};
PrintMassiv(array_a);
string [] array_b = MassToSize(array_a);
PrintMassiv(array_b);

//===========================================================
//===========================================================

void Words(string[] args)
    {
      string[] massive;
      int count;
      string s;
      string[] massive_2;
      string[] massive_3;

      Console.WriteLine("Enter any words or symbols: ");

      count = 0;
      massive = new string[count];

      do
      {
        s = Console.ReadLine();
        if (s!="")
        {
          count++;
          massive_2 = new string[count];
          for (int i = 0; i < massive_2.Length - 1; i++)
            massive_2[i] = massive[i];
          massive_2[count - 1] = s;
          massive = massive_2;
        }
        }
      while (s != "");

    int size = massive.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{massive[i]}, ");
    }
    Console.WriteLine();

    for (int i = 0; i < massive.Length; i++)
        {
        count = 0;
        if (massive[i].Length <= 3)
        count++;
        massive_3 = new string[count];
        for (int j = 0; j < massive_3.Length; j++)
        massive_3[j] = massive[i];

        int size_2 = massive_3.Length;
        for (int j = 0; j < size_2; j++)
        Console.Write($"{massive_3[j]}, ");
        }
        Console.WriteLine();
    }

Words(args);