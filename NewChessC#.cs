using System;

class Program
{
    // Функция digit преобразует букву в число от 1 до 8, 
    // если буква не из A-H, возвращает 0
    static int digit(char letterX)
    {
        switch (letterX)
        {
            case 'A': return 1;
            case 'B': return 2;
            case 'C': return 3;  
            case 'D': return 4;
            case 'E': return 5;
            case 'F': return 6;
            case 'G': return 7;
            case 'H': return 8;
            default: return 0; // Возвращает 0 для неверных букв
        }
    }

    // Главная функция, которая выполняется при запуске программы
    static void Main()
    {
    Console.WriteLine("Enter the name of the figure and its coordinates");
    string figure = Console.ReadLine().ToUpper();
        // Считывает первую координату (букву и число)
        int x1 = digit(Convert.ToChar(Console.ReadLine())); // Преобразует букву в число
        int y1 = Convert.ToInt32(Console.ReadLine()); // Преобразует строку в число

        // Считывает вторую координату (букву и число)
        int x2 = digit(Convert.ToChar(Console.ReadLine())); // Преобразует букву в число
        int y2 = Convert.ToInt32(Console.ReadLine()); // Преобразует строку в число
    if (x1 == x2) 
    {
        Console.WriteLine("NO");
    }
    else if (y1 == y2)
    {
        Console.WriteLine("NO");
    }
    else
    {
        switch (figure)
        {
        case "KNIGHT":
            if (Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) == 2 || 
                Math.Abs(x1 - x2) == 2 && Math.Abs(y1 - y2) == 1)
                Console.WriteLine("YES"); 
            else
                Console.WriteLine("NO"); 
            break;
        case "KING":
            if (Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1)
                Console.WriteLine("YES"); 
            else
                Console.WriteLine("NO"); 
            break;
        case "QUEEN":
            if (x1 == x2 ^ y1 == y2 ^ Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
                Console.WriteLine("YES"); 
            else
                Console.WriteLine("NO"); 
            break;
        case "BISHOP":
            if (Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
                 Console.WriteLine("YES"); 
            else
                Console.WriteLine("NO"); 
            break;
        case "ROOK":
            if (x1 == x2 ^ y1 == y2)
                Console.WriteLine("YES"); 
            else
                Console.WriteLine("NO");
            break;
        case "PAWN":
            if (x1 == x2 && y2 - y1 == 1)
                Console.WriteLine("YES"); 
            else
                Console.WriteLine("NO"); 
            break;
        default:
            Console.WriteLine("This figure is not supported");
            break;
        }
    }
    }
}
