// See https://aka.ms/new-console-template for more information
Console.WriteLine("Решение квадратного уравнения");
Console.WriteLine("Уравнение вида A*x^2+B*x+C=0");
char stopKey =' ';
double a,b,c, discriminant, doubleA = 0;
double[] roots = new double [2];
while (stopKey!='s')
{
    Console.WriteLine("Введите коэффициенты"); 
    Console.Write("Введите коэффициент А: ");
    
    try
    {
        a = Double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
    }
    catch(Exception ex)
    {
        Console.WriteLine("Некорректный коэффициент А");
        return;
    }
    if (a.Equals(0))
    {
        Console.WriteLine("Коэффициент А должен быть не равен 0");
        return;
    }

    try
    {
        Console.Write("Введите коэффициент B: ");
        b = Double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
    }
    catch(Exception ex)
    {
        Console.WriteLine("Некорректный коэффициент B");
        return;
    }
    
    try
    {
        Console.Write("Введите коэффициент C: ");
        c = Double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
    }
    catch(Exception ex)
    {
        Console.WriteLine("Некорректный коэффициент C");
        return;
    }
    
    discriminant = b*b - 4*a*c;

    if (discriminant<0)
    {
        Console.Write("Действительные корни отсутствуют");
        return;
    }
    discriminant = Math.Sqrt(discriminant);
    doubleA = 2*a;
    roots[0]=(-b-discriminant)/doubleA;
    roots[1]=(-b+discriminant)/doubleA;

    Console.WriteLine("x1 = "+roots[0]);
    Console.WriteLine("x2 = "+roots[1]);

    Console.Write("Для завершения работы введите s: ");
    stopKey = Console.ReadKey(false).KeyChar;
    Console.WriteLine();
}
