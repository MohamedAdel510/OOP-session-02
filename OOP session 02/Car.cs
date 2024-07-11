using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_02
{
    internal class Car
    {
        #region Prperties
        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }
        #endregion

        #region Constructors
        public Car()
        {
            Model = string.Empty;
        }

        public Car(int Id, string Model, double Speed)
        {
            this.Id = Id;
            this.Model = Model;
            this.Speed = Speed;
            Console.WriteLine("I am Constructor 1.");
        }

        public Car(int Id, string Model) : this(Id, Model, 200)
        {
            Console.WriteLine("I am Constructor 2.");
        }

        public Car(int Id) : this(Id, "BMW", 290)
        {
            Console.WriteLine("I am Constructor 3.");
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"ID: {Id}\nModel: {Model}\nSpeed: {Speed}";
        }
        #endregion

    }
}
