// Найти максимум из 9 чисел
// 1-ый метод

//int a1 = 11;
//int b1 = 33;
//int c1 = 44;
//int a2 = 56;
//int b2 = 7;
//int c2 = 45;
//int a3 = 13;
//int b3 = 40;
//int c3 = 70;

//int max = a1;
//if (b1 > max) max = b1;
//if (c1 > max) max = c1;

//if (a2 > max) max = a2;
//if (b2 > max) max = b2;
//if (c2 > max) max = c2;

//if (a3 > max) max = a3;
//if (b3 > max) max = b3;
//if (c3 > max) max = c3;

//Console.WriteLine(max);

// 2-й метод. Максимум из трех чисел с помощью функции
// задали функции тип данных int тк мы будем использовать целые числа, положили значения
// ниже кусочек кода отвечает за макисумум из трех
int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2> result) result = arg2;
    if(arg3> result) result = arg3;
    return result;
}

int a1 = 11;
int b1 = 33;
int c1 = 44;
int a2 = 56;
int b2 = 7;
int c2 = 45;
int a3 = 13;
int b3 = 40;
int c3 = 70;

// создадим переменную max1 и скажем, что результатом работ фунукции Max будет максимальное из трех чисел a1 b1 c 1
// int max1 = Max (a1, b1, c1);
// int max2 = Max (a2, b2, c2);
// int max3 = Max (a3, b3, c3);
// int max = Max(max1, max2, max3);
//альтернативный вариант:
int max = Max(Max (a1, b1, c1), Max (a2, b2, c2), Max (a3, b3, c3)); // + в том, что одна срока
Console.WriteLine(max);