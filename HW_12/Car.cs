using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12
{
    public abstract class Car
    {
        public event EventHandler MoveEvent;

        public string Model { get; set; }
        public double Speed { get; set; }
        public int Position { get; private set; }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        /// <summary>
        /// Метод для передвижения автомобиля
        /// </summary>
        public virtual void Move()
        {
            int distance = 5;
            Position += distance;

            OnMove();
        }

        protected virtual void OnMove()
        {
            MoveEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
