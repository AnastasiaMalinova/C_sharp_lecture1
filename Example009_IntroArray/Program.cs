// // Задача 1
// // функция максимума из трех
// int Max (int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2> result) result = arg2;
//     if(arg3> result) result = arg3;
//     return result;
// }
// //добавляем массив
// //              0   1   2   3   4   5   6   7  8    индексы массивов
// int[] array = {15, 24, 36, 74, 85, 16, 57, 28, 19};
// // присваиваем массиву под индексом 0 новое значение
// // обращаемся к массиву и записываем в него новое значение
// array[0] = 12;
// Console.WriteLine(array[0]); // обращаемя к массиву и получаем новое значение



// Задача 2
int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2> result) result = arg2;
    if(arg3> result) result = arg3;
    return result;
}

int[] array = {15, 24, 36, 74, 85, 16, 57, 28, 19};
int result = Max(
    Max (array[0], array[1], array[2]),
    Max (array[3], array[4], array[5]), 
    Max (array[6], array[7], array[8])
    ); 
Console.WriteLine(result);
