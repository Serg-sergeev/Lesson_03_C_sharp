// Напишите программу, которая по заданному номеру четверти, показывает диапозон возможных координат точек в этой четверти (х и у).

void PrintCoordinatRange (int number)
{
    if (number == 4)
    {
        Console.WriteLine("Диапозон координат: x = [0; infinity], y = [0; -infinity]");
    }
    else if (number == 3)
    {
        Console.WriteLine("Диапозон координат: x = [0; -infinity], y = [0; -infinity]");
    }
    else if (number == 2)
    {
        Console.WriteLine("Диапозон координат: x = [0; -infinity], y = [0; infinity]");
    }
    else if (number == 1)
    {
        Console.WriteLine("Диапозон координат: x = [0; infinity], y = [0; infinity]");
    }
    else 
    {
        Console.WriteLine("Введено некорректное число");
    }
}

int number = int.Parse(Console.ReadLine()!);

PrintCoordinatRange(number);