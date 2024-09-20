using System;

class Program
{
    // Функция Digit преобразует букву в число от 1 до 8, 
    // если буква не из A-H, возвращает 0
    static int Digit(char letterX)
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

    static void Main()
    {
    Console.WriteLine("Enter the name of the figure and its coordinates");
    string figure = Console.ReadLine().ToUpper();
        // Считывает первую координату (букву и число)
        int x1 = Digit(Convert.ToChar(Console.ReadLine())); // Преобразует букву в число
        int y1 = Convert.ToInt32(Console.ReadLine()); // Преобразует строку в число

        // Считывает вторую координату (букву и число)
        int x2 = Digit(Convert.ToChar(Console.ReadLine())); // Преобразует букву в число
        int y2 = Convert.ToInt32(Console.ReadLine()); // Преобразует строку в число
    // Если фигура стоит на месте, хода нет
    if (x1 == x2) 
    {
        Console.WriteLine("NO");
    }
    else if (y1 == y2)
    {
        Console.WriteLine("NO");
    }
    else
    // В ином случае ход зависит от фигуры
    {
        switch (figure)
        {
        case "KNIGHT":
            // Конь ходит на 1 клетку по гоизонтали и на 2 по вертикали
            // Или на 2 клетки по гоизонтали и 1 по вертикали
            if (Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) == 2 || 
                Math.Abs(x1 - x2) == 2 && Math.Abs(y1 - y2) == 1)
                Console.WriteLine("YES"); 
            else
                Console.WriteLine("NO"); 
            break;
        case "KING":
            // Король ходит на 1 клетку по горизонтали или по вертикали
            if (Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1)
                Console.WriteLine("YES"); 
            else
                Console.WriteLine("NO"); 
            break;
        case "QUEEN":
            // Королева ходит на любое количество клеток по диагонали, горизонтали или вертикали
            if (x1 == x2 ^ y1 == y2 ^ Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
                Console.WriteLine("YES"); 
            else
                Console.WriteLine("NO"); 
            break;
        case "BISHOP":
            // Слон ходит на любое количество клеток по диагонали
            if (Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
                 Console.WriteLine("YES"); 
            else
                Console.WriteLine("NO"); 
            break;
        case "ROOK":
            // Ладья ходит на любое количество клеток по вертикали или горизонтали
            if (x1 == x2 ^ y1 == y2)
                Console.WriteLine("YES"); 
            else
                Console.WriteLine("NO");
            break;
        case "PAWN":
            // Пешка ходит на 1 клетку по вертикали
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
