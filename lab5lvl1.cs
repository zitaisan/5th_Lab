class homew6lvl1
{
    static public int fact(int n)
    {
        int f = 1;
        for (int i = 2; i <= n; i++)
            f *= i;
        return f;
    }
    static public double comb(int n, int k)
    {
        return (fact(n)/(fact(k)*fact(n-k)));
    }
    static public double p(double a, double b, double c)
    {
        return (a + b + c) / 2;
    }
    static public double s(double a, double b, double c)
    {
        return Math.Sqrt(p(a, b, c) * (p(a, b, c) - a) * (p(a, b, c) - b) * (p(a, b, c) - c));
    }
    static public bool be(double a, double b, double c)
    {
        
        if ((a<(b+c)) && (b<(a+c)) && (c<(a+b)) && (a > 0) && (b > 0) && (c > 0))
            return true;
        else
            return false;
    }
    static void Main()
    {
        
        Console.WriteLine("введите номер задания(1,2)");
        int numb=0;
        try
        {
            numb = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("введите снова");
        }
        if (numb == 1)
        {
            Console.WriteLine($"команда из 8 человек 5 кандидатов вариантов -> {comb(8,5)}");
            Console.WriteLine($"команда из 11 человек 10 кандидатов вариантов -> {comb(11, 10)}");

        }
        else if (numb == 2)
        {
            double a =0, b=0, c=0;
            try
            {
                Console.WriteLine("введите одну сторону");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("введите вторую сторону");
                b = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("введите третью сторону");
                c = Convert.ToDouble(Console.ReadLine());
                if ((be(a, b, c) == true))
                    Console.WriteLine($"площадь треугольна со сторонами {a}, {b}, {c}, = {s(a, b, c)} ");
                else
                    Console.WriteLine("fantastic");

            }
            catch
            {
                Console.WriteLine("введите заново");
                
            }
            

        }
        else Console.WriteLine("выберите из списка");
    }
}
