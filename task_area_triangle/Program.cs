// task Площадь треугольника

// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) 
// требуется вычислить его площадь.

// Входные данные:
// Входной файл INPUT.TXT содержит 6 целых чисел x1,y1,x2,y2,x3,y3 – координаты вершин треугольника. 
// Все числа не превышают 106 по абсолютной величине.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите точное значение площади заданного треугольника.

Console.Clear();
Console.Write("Введите координату x1 первой вершины треугольника: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1 первой вершины треугольника: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2 второй вершины треугольника: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2 второй вершины треугольника: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x3 третьей вершины треугольника: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y3 третьей вершины треугольника: ");
int y3 = Convert.ToInt32(Console.ReadLine());

int s = Math.Abs(((x1 - x3) * (y2 - y3) - (x2 - x3) * (y1 - y3)) / 2);

Console.WriteLine($"S△ = {s}");