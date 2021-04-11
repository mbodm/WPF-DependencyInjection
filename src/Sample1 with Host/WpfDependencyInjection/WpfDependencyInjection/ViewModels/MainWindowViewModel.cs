using System;
using System.Windows.Input;

namespace WpfDependencyInjection
{
    public sealed class MainWindowViewModel : ObservableModel
    {
        private readonly IBusinessLogic businessLogic;

        public MainWindowViewModel(IBusinessLogic businessLogic)
        {
            this.businessLogic = businessLogic ?? throw new ArgumentNullException(nameof(businessLogic));
        }

        private string input1 = "10";
        public string Input1
        {
            get => input1;
            set => SetProperty(ref input1, value);
        }

        private string input2 = "20";
        public string Input2
        {
            get => input2;
            set => SetProperty(ref input2, value);
        }

        private string status = "Status:";
        public string Status
        {
            get => status;
            set => SetProperty(ref status, value);
        }

        public ICommand Calc
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (!int.TryParse(Input1, out int value1) || !int.TryParse(Input2, out int value2))
                    {
                        Status = "Status: Input error";

                        return;
                    }

                    var sum = businessLogic.DoSomeComplexCalculationStuff(value1, value2);

                    Status = $"Status: Sum is {sum}";
                });
            }
        }
    }
}
