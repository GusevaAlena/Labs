using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace target
{
    class TargShoot
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество выстрелов по мишени: ");
            int N = Int32.Parse(Console.ReadLine());
            int RadMin = 1; //радиус наименьшей окружности мишени
            int RadMed = 2; //радиус средней окружности мишени
            int RadMax = 3; //радиус наибольшей окружности мишени
            int Scores = 0;
            int SumScores = 0;
            for (int i=1; i<=N;i++)
            {
                Console.Write("Введите координату выстрела {0} х: ",i);
                double x = Double.Parse(Console.ReadLine());
                Console.Write("Введите координату выстрела {0} y: ",i);
                double y = Double.Parse(Console.ReadLine());
                double DistToDot = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (DistToDot <= RadMin)
                {
                    Scores = 10;
                }
                else if (DistToDot>RadMin&&DistToDot<=RadMed)
                {
                    Scores = 5;
                }
                else if (DistToDot > RadMed && DistToDot <= RadMax)
                {
                    Scores = 1;
                }
                else if (DistToDot>RadMax)
                {
                    Scores = 0;
                }
                    SumScores = SumScores+Scores;           
            }
            Console.WriteLine("Суммарное количество набранных очков составляет: {0}",SumScores);
            Console.ReadLine();
           
        }
    }
}
