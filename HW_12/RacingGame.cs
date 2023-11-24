using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12
{
    public class RacingGame
    {
        // Делегат для события начала гонки
        public delegate void StartRaceHandler();
        public event StartRaceHandler RaceStarted;

        // Делегат для события завершения гонки
        public delegate void EndRaceHandler(string winner);
        public event EndRaceHandler RaceEnded;

        // Список участвующих автомобилей
        private readonly List<Car> cars;

        public RacingGame(List<Car> cars)
        {
            this.cars = cars;
        }

        /// <summary>
        ///Метод для запуска гонок
        /// </summary>
        public void StartRace()
        {
            OnRaceStarted();

            while (true)
            {
                foreach (var car in cars)
                {
                    car.Move();

                    if (car.Position >= 100)
                    {
                        OnRaceEnded(car.Model);
                        return;
                    }
                }
            }
        }

        protected virtual void OnRaceStarted()
        {
            RaceStarted?.Invoke();
        }

        protected virtual void OnRaceEnded(string winner)
        {
            RaceEnded?.Invoke(winner);
        }
    }
}
