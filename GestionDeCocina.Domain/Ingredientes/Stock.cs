using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCocina.Domain.Ingredientes
{
    public class Stock
    {
        public int Value { get; private set; }

        public Stock(int value)
        {
            if (value < 0)
                throw new ArgumentException("Stock value cannot be negative.");

            Value = value;
        }

        public Stock Add(int amount)
        {
            if (amount < 0)
                throw new ArgumentException("Amount to add must be non-negative.");

            return new Stock(Value + amount);
        }

        public Stock Subtract(int amount)
        {
            if (amount < 0)
                throw new ArgumentException("Amount to subtract must be non-negative.");

            if (amount > Value)
                throw new InvalidOperationException("Cannot subtract more than the available stock.");

            return new Stock(Value - amount);
        }

        public override bool Equals(object obj)
        {
            if (obj is Stock other)
                return Value == other.Value;

            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
