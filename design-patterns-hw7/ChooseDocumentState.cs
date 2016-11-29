using System;

namespace design_patterns_hw7
{
    internal class ChooseDocumentState : IState
    {
        public void PutMoney(CopyMachine machine, int money)
        {
            Console.WriteLine("Внесено " + money + " рублей");
            machine.Sum += money;
        }

        public void ChooseDevice(CopyMachine machine, string device)
        {
            Console.WriteLine("Выбрано устройство " + device);
        }

        public void ChooseDocument(CopyMachine machine, string document)
        {
            Console.WriteLine("Выбран документ " + document);
            machine.State = new PrintDocumentState();
        }

        public void PrintDocument(CopyMachine machine)
        {
            Console.WriteLine("Выбeрите документ");
        }

        public void TakeMoney(CopyMachine machine)
        {
            Console.WriteLine("Деньги возвращены");
            machine.Sum = 0;
            machine.State = new InitialState();
        }
    }
}