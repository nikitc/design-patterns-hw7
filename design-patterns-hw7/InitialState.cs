using System;

namespace design_patterns_hw7
{
    internal class InitialState : IState
    {
        public void PutMoney(CopyMachine machine, int money)
        {
            Console.WriteLine("Внесено " + money + " рублей");
            machine.Sum += money;
            machine.State = new ChooseDeviceState();
        }

        public void ChooseDevice(CopyMachine machine, string device)
        {
            Console.WriteLine("Нужно внести деньги");
        }

        public void ChooseDocument(CopyMachine machine, string document)
        {
            Console.WriteLine("Нужно внести деньги");
        }

        public void PrintDocument(CopyMachine machine)
        {
            Console.WriteLine("Нужно внести деньги");
        }

        public void TakeMoney(CopyMachine machine)
        {
            Console.WriteLine("Деньги возвращены");
            machine.Sum = 0;
        }
    }
}
