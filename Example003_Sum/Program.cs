// указываем тип данных для целых чисел int
int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.WriteLine(numberA); // прописываем, чтобы видеть какие случайные числа используются
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
// могли использовать промежуточную переменную
int result = numberA + numberB;
Console.WriteLine(result);

