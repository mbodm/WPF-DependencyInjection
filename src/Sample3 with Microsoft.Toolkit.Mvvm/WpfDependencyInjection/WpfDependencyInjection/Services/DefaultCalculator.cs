using System;

namespace WpfDependencyInjection
{
    public sealed class DefaultCalculator : ICalculator
    {
        private readonly IWriter writer;

        public DefaultCalculator(IWriter writer)
        {
            this.writer = writer ?? throw new ArgumentNullException(nameof(writer));
        }

        public int Add(int value1, int value2)
        {
            writer.Write($"Calculator.Add() method called with {value1} and {value2}");

            var sum = value1 + value2;

            return sum;
        }

        // Todo: Subtract()

        // Todo: Divide()

        // Todo: Multiply()
    }
}
