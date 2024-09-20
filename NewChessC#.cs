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
    Console.WriteLine("Введите название фигуры и её координаты");
    string figure = Console.ReadLine();
        if ((figure == "Слон") ^ (figure == "Конь") ^ (figure == "Пешка") ^ 
        (figure == "Ладья") ^ (figure == "Ферзь") ^ (figure == "Король"))
    {
        // Считывает первую координату (букву и число)
        int x1 = digit(Convert.ToChar(Console.ReadLine())); // Преобразует букву в число
        int y1 = Convert.ToInt32(Console.ReadLine()); // Преобразует строку в число

        // Считывает вторую координату (букву и число)
        int x2 = digit(Convert.ToChar(Console.ReadLine())); // Преобразует букву в число
        int y2 = Convert.ToInt32(Console.ReadLine()); // Преобразует строку в число

        // Проверяет, являются ли координаты ходом фигуры
        
        if (figure == "Конь")
        {
            // Ход коня: двигается либо на одну клетку по горизонтали и на две по вертикали, 
            // либо на две клетки по горизонтали и на одну по вертикали
            if (Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) == 2 || 
            Math.Abs(x1 - x2) == 2 && Math.Abs(y1 - y2) == 1)
            {
                Console.WriteLine("YES"); // Вывод YES, если координаты соответствуют ходу коня
            }
            else
            {
                Console.WriteLine("NO"); // Вывод NO, если координаты не соответствуют ходу коня
            }
        }


        if (figure == "Король")
        {
            // Ход короля: двигается на одну клетку в любом направлении
             if (Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1)
             {
                Console.WriteLine("YES"); // Вывод YES, если координаты соответствуют ходу короля
             }
             else
             {
                Console.WriteLine("NO"); // Вывод NO, если координаты не соответствуют ходу короля
             }
        }


        if (figure == "Ферзь")
        {
            // Ход ферзя/королевы: двигается на любое количество клеток по диагонали, горизонтали или вертикали
            if (x1 == x2 ^ y1 == y2 ^ Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
            {
                Console.WriteLine("YES"); // Вывод YES, если координаты соответствуют ходу ферзя/королевы
            }
            else
            {
                Console.WriteLine("NO"); // Вывод NO, если координаты не соответствуют ходу ферзя/королевы
            }
        }


        if (figure == "Слон")
        {
            // Ход слона: двигается на любое количество клеток по диагонали
            if (Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
            {
                Console.WriteLine("YES"); // Вывод YES, если координаты соответствуют ходу слона
            }
            else
            {
                Console.WriteLine("NO"); // Вывод NO, если координаты не соответствуют ходу слона  
            }
        }
        

        if (figure == "Ладья")
        {
            // Ход ладьи: двигается на любое количество клеток по вертикали или горизонтали
            if (x1 == x2 ^ y1 == y2)
            {
                Console.WriteLine("YES"); // Вывод YES, если координаты соответствуют ладьи
            }
            else
            {
                Console.WriteLine("NO"); // Вывод NO, если координаты соответствуют ладьи
            }
        }


        if (figure == "Пешка")
        {
            // Ход пешки: двигается на 1 клетку по вертикали
            if (x1 == x2 && y2 - y1 == 1)
            {
                Console.WriteLine("YES"); // Вывод YES, если координаты соответствуют ладьи
            }
            else
            {
                Console.WriteLine("NO"); // Вывод NO, если координаты соответствуют ладьи
            }
        }
    }
        
        else Console.WriteLine("Эта фигура не поддерживается или вы ввели неверные координаты");

    }
}
