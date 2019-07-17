using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Exeptions;

namespace WildFarm.Model.Food
{
    public abstract class Food
    {
        private int quantity;

        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExeptionMessage.CannotBeNegative);
                }

                this.quantity = value;
            }
        }
    }
}
