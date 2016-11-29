using System;

namespace design_patterns_hw7
{
    internal class ChooseDeviceState : IState
    {
        public void PutMoney(CopyMachine machine, int money)
        {
            Console.WriteLine("Внесено " + money + " рублей");
            machine.Sum += money;
        }

        public void ChooseDevice(CopyMachine machine, string device)
        {
            Console.WriteLine("Выбрано устройство " + device);
            machine.State = new ChooseDocumentState();
        }

        public void ChooseDocument(CopyMachine machine, string document)
        {
            Console.WriteLine("Выберите устройство");
        }

        public void PrintDocument(CopyMachine machine)
        {
            Console.WriteLine("Выберите устройство");
        }

        public void TakeMoney(CopyMachine machine)
        {
            Console.WriteLine("Деньги возвращены");
            machine.Sum = 0;
            machine.State = new InitialState();
        }
    }
}