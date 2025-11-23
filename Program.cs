using System;

namespace GeometryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Koju operaciju zelite da izvedete: ");
            Console.WriteLine("1) Pitagorina teorema");
            Console.WriteLine("2) Povrsina pravouglog trougla");
            Console.WriteLine("3) Povrsina jednakokrakog trougla");
            Console.WriteLine("4) Povrsina kvadrata");
            Console.WriteLine("5) Povrsina sestougla");
            int.TryParse(Console.ReadLine(), out int izbor);

            switch (izbor)
            {
                case 1:
                    int a = 0;
                    int b = 0;
                    Console.WriteLine("Unesite duzinu prve stranice broj: ");
                    try
                    {
                        int.TryParse(Console.ReadLine(), out a);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Doslo je do greske: " + ex.Message);
                        return;
                    }
                    Console.WriteLine("Unesi duzinu druge stranice broj: ");
                    try
                    {
                        int.TryParse(Console.ReadLine(), out b);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Doslo je do greske: " + ex.Message);
                        return;
                    }
                    double c = a * a + b * b;
                    Console.WriteLine("Hipotenuza iznosi: " + Math.Sqrt(c));
                    break;
                case 2:
                    Console.WriteLine("Unesite duzinu prve stranice broj: ");
                    try
                    {
                        int.TryParse(Console.ReadLine(), out a);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Doslo je do greske: " + ex.Message);
                        return;
                    }
                    Console.WriteLine("Unesi duzinu druge stranice broj: ");
                    try
                    {
                        int.TryParse(Console.ReadLine(), out b);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Doslo je do greske: " + ex.Message);
                        return;
                    }
                    Console.WriteLine("Povrsina pravouglog trougla iznosi: " + (a * b) / 2);
                    break;
                case 3:
                    int hb = 0;
                    Console.WriteLine("Unesi duzinu  bazne stranice broj: ");
                    try
                    {
                        int.TryParse(Console.ReadLine(), out b);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Doslo je do greske: " + ex.Message);
                        return;
                    }
                    Console.WriteLine("Unesi visinu bazne stranice broj: ");
                    try
                    {
                        int.TryParse(Console.ReadLine(), out hb);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Doslo je do greske: " + ex.Message);
                        return;
                    }
                    Console.WriteLine("Povrsina jednakokrakog trougla iznosi: " + (b * hb) / 2);
                    break;
                case 4:
                    Console.WriteLine("Unesite duzinu prve stranice broj: ");
                    try
                    {
                        int.TryParse(Console.ReadLine(), out a);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Doslo je do greske: " + ex.Message);
                        return;
                    }
                    Console.WriteLine("Povrsina kvadrata iznosi: " + (a * a));
                    break;
                case 5:
                    Console.WriteLine("Unesite duzinu prve stranice broj: ");
                    try
                    {
                        int.TryParse(Console.ReadLine(), out a);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Doslo je do greske: " + ex.Message);
                        return;
                    }
                    Console.WriteLine("Povrsina sestougla iznosi: " + ((3 * Math.Sqrt(3)) / 2) * (a * a));
                    break;
                default:
                    Console.WriteLine("Nepostojeca operacija.");
                    break;
            }
        }
    }
}