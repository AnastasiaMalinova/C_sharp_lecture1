// Найти максимум из 9 чисел
// 1-ый метод

int a1 = 11;
int b1 = 33;
int c1 = 44;
int a2 = 56;
int b2 = 7;
int c2 = 45;
int a3 = 13;
int b3 = 40;
int c3 = 70;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);
