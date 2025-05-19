using System;

class Program
{
    static void Main()
    {
       
        string[] parts = Console.ReadLine().Split();
        int a = int.Parse(parts[0]);
        int b = int.Parse(parts[1]);
        int c = int.Parse(parts[2]);

        double D = b * b - 4 * a * c;

        if (D < 0)
        {
            
            Console.WriteLine(0);
        }
        else if (D == 0)
        {
            
            double x = -b / (2.0 * a);
            Console.WriteLine(1);
            Console.WriteLine(x.ToString("F6"));
        }
        else
        {
            
            double sqrtD = Math.Sqrt(D);
            double x1 = (-b - sqrtD) / (2.0 * a);
            double x2 = (-b + sqrtD) / (2.0 * a);

            if (x1 > x2)
            {
                var temp = x1;
                x1 = x2;
                x2 = temp;
            }

            Console.WriteLine(2);
            Console.WriteLine($"{x1:F6} {x2:F6}");
        }
    }
}
