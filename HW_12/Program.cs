using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            SuperCar supercar = new SuperCar("Ferrari", rnd.Next(17, 20));
            SedanCar sedanCar = new SedanCar("Toyota", rnd.Next(14, 18));
            Coupe coupe = new Coupe("Mazda", rnd.Next(16, 20));
            Truck truck = new Truck("Volvo", rnd.Next(12, 14));
            Bigtruck bigtruck = new Bigtruck("Big volvo", rnd.Next(12, 17));
            Bus bus = new Bus("Mercedes", rnd.Next(8, 16));

            List<Car> cars = new List<Car> { supercar, sedanCar, coupe, truck, bigtruck, bus };

            RacingGame racingGame = new RacingGame(cars);

            racingGame.RaceStarted += () => Console.WriteLine("Гонка началась!");
            racingGame.RaceEnded += (winner) => Console.WriteLine($"Гонка завершена! Победил автомобиль {winner}");

            racingGame.StartRace();
        }
    }
}
