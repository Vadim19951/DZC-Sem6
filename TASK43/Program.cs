double b1 = InputInt("Введите координаты точки b1: ");
double k1 = InputInt("Введите координаты точки k1: ");
double b2 = InputInt("Введите координаты точки b2: ");
double k2 = InputInt("Введите координаты точки k2: ");


double x = (k1 - k2)/(b2 - b1);
double y = k1 * x + b1;

if(b1 == b1)
{
    Console.WriteLine("Прямые паралельны!");
}
else
{
Console.WriteLine("Координаты точки пересечения прямых " + x + "," + y);
}














double InputInt(string output)
{
    Console.Write(output);
    return Convert.ToDouble(Console.ReadLine());
}



