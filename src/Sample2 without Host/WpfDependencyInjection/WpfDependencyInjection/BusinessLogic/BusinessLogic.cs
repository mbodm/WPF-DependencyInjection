using System;

namespace WpfDependencyInjection
{
    public sealed class BusinessLogic : IBusinessLogic
    {
        private readonly IWriter writer;
        private readonly ICalculator calculator;

        public BusinessLogic(IWriter writer, ICalculator calculator)
        {
            this.writer = writer ?? throw new ArgumentNullException(nameof(writer));
            this.calculator = calculator ?? throw new ArgumentNullException(nameof(calculator));
        }

        public int DoSomeComplexCalculationStuff(int value1, int value2)
        {
            writer.Write("BusinessLogic starting now some complex stuff");

            // Do some complex BL stuff...

            var sum = calculator.Add(value1, value2);

            // Do some complex BL stuff...

            return sum;
        }
    }
}
