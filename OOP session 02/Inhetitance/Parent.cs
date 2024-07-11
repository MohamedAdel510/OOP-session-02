using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_02.Inhetitance
{
    internal class Parent
    {
        #region Attributes
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Constructors
        public Parent()
        {

        }

        public Parent(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"X: {X}\nY: {Y} ";
        }
        #endregion
    }
}
