using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LabShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv siffran 0 för att slumpa utförandet - skriv siffran 1 för att själv mata in variablerna:");
            int answer;
            bool parseSuccesful = false;
            do
            {
                parseSuccesful = int.TryParse(Console.ReadLine(), out answer);
                if (!parseSuccesful || answer > 1 || answer < 0)
                {
                    Console.WriteLine("Icke giltigt svar. Försök igen!");
                    Console.WriteLine("Skriv siffran 0 för att slumpa utförandet - skriv siffran 1 för att själv mata in variablerna:");
                }

            } while (!parseSuccesful || answer < 0 || answer > 1);

            var shapes = new List<Shape>();

            int x = 0, y = 0, z = 0;

            if (answer == 1)
            {
                Console.WriteLine("Skriv koordinaten x:");

                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Ingen giltig koordinat. Försök igen!");
                    Console.WriteLine("Skriv koordinaten x:");
                }

                Console.WriteLine("Skriv koordinaten x:");

                while (!int.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Ingen giltig koordinat. Försök igen!");
                    Console.WriteLine("Skriv koordinaten y:");
                }
                Console.WriteLine("Skriv koordinaten :y");

                while (!int.TryParse(Console.ReadLine(), out z))
                {
                    Console.WriteLine("Ingen giltig koordinat. Försök igen!");
                    Console.WriteLine("Skriv koordinaten z:");
                }         
            }

            var cord = new Vector3(x,y,z);
            float sumCircTriangle = 0;
            float totArea = 0;
            float biggestVolume = 0;

            for (int i = 0; i < 20; i++)
            {
                if (answer == 1)
                    shapes.Add(Shape.GenerateShape(cord));
                else
                    shapes.Add(Shape.GenerateShape());

                bool isTriangle = shapes[i] is Triangle;
                if (isTriangle)
                {
                    Triangle triangle = (shapes[i] as Triangle);
                    sumCircTriangle += triangle.Circumference;
                    //sumCircTriangle = sumCircTriangle + (shapes[i] as Triangle).Circumference;

                }

                totArea += shapes[i].Area;

                bool isShape3D = shapes[i] is Shape3D;
                if (isShape3D)
                {
                    Shape3D shape3D = (shapes[i] as Shape3D);
                    if (biggestVolume < shape3D.Volume)
                    {
                        biggestVolume = shape3D.Volume;
                    }
                }
                
            }


            foreach (Shape s in shapes)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n\nSumman av alla trianglar = {0:0.0}", (sumCircTriangle));

            Console.WriteLine("\nAlla objekts genomsnittliga area = {0:0.0}", (totArea / 20f));

            Console.WriteLine("\nObjektet med störst volym = {0:0.0}", (biggestVolume));

            Console.Write("\nPress any key to continue . . .");
            Console.ReadKey();
        }
    }
}
