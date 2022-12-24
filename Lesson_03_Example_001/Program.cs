int GetNumberOfQuater(int x, int y)
{
    if (x == 0 || y == 0){
        return -1;
    }

    if (x > 0 && y > 0){
        return 1;
    }
    else if (x < 0 && y > 0){
        return 2;
    }
    else if (x < 0 && y < 0){
        return 3;
    }
    else if (x > 0 && y < 0){
        return 4;
    }
    else {
        return -1;
    }
}

void PrintNumberOfQuater(int x, int y)
{
    if (x == 0 || y == 0){
        Console.WriteLine($"Номер четверти не определен для точки ({x}, {y})");
    }

    if (x > 0 && y > 0){
        Console.WriteLine($"Номер четверти координаты ({x}, {y}) равен {1}");
    }
    else if (x < 0 && y > 0){
        Console.WriteLine($"Номер четверти координаты ({x}, {y}) равен {2}");
    }
    else if (x < 0 && y < 0){
        Console.WriteLine($"Номер четверти координаты ({x}, {y}) равен {3}");
    }
    else if (x > 0 && y < 0){
        Console.WriteLine($"Номер четверти координаты ({x}, {y}) равен {4}");
    }
    else {
        Console.WriteLine($"Номер четверти не определен для точки ({x}, {y})");
    }
}

int x = 5;
int y = -10;

int quater = GetNumberOfQuater(x, y);

if (quater == -1)
{
    Console.WriteLine($"Номер четверти не определен для точки ({x}, {y})");
} 
else 
{
    Console.WriteLine($"Номер четверти координаты ({x}, {y}) равен {GetNumberOfQuater(x, y)}");
}

PrintNumberOfQuater(x, y);
