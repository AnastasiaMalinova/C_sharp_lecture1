﻿Console.Clear(); // очистка console

// команда SetCursorPosition позволяет рисовать. 
// в скобках можно указать аргументы (отступ от левого края(кол-во символов), отступ от верхнего края)
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+"); // то, что будет рисоваться
int xa = 40; // для первой точки a указываем значения отсупов. Отсуп слева 1 символ.
int ya = 1; // отступ сверху тоже 1 символ слева
int xb = 1; // для второй точки b отсуп слева 1 символ
int yb = 30; // для второй точки b отсуп сверху 10 символов
int xc = 80;
int yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

// определим случайную точку x в которую положим первую точку
int x = xa, y = xb;
// счетчик, будет определять какое кол-во раз нужно мы проделали нахождение отрезков и деление его пополам
int count = 0; 

// генерируем случайное число what при помощи генератора псевдослучайных чисел
// мы будет выбирать одну из трех точек, поэтому диапозон в скобках указываем (0, 3). Получается полинтервал [0,3) выдаются числа 0 1 2
while(count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x+xa)/2;
        y = (y+yb)/2;
    }
    if (what == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }
    if (what == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }
    // теперь рисуем, сначала устанавливаем курсор в нужную позицию
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count +1; // аналогичная запись count +=1 или если увеличение всегда только на еденицу используется запись count++
}