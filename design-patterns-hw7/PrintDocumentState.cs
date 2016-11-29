using System;

namespace design_patterns_hw7
{
    class PrintDocumentState : IState
    {
        public const int PriceDocument = 5;
        public void PutMoney(CopyMachine machine, int money)
        {
            Console.WriteLine("Внесено " + money + " рублей");
        }

        public void ChooseDevice(CopyMachine machine, string device)
        {
            Console.WriteLine("Выбрано устройство " + device);
            machine.State = new ChooseDocumentState();
        }

        public void ChooseDocument(CopyMachine machine, string document)
        {
            Console.WriteLine("Выбран документ " + document);
        }

        public void PrintDocument(CopyMachine machine)
        {
            if (machine.Sum >= PriceDocument)
            {
                Console.WriteLine("Печатаем документ");
                machine.Sum -= PriceDocument;
                machine.State = new ChooseDocumentState();
            }
            else
                Console.WriteLine("Недостаточно денег");
        }

        public void TakeMoney(CopyMachine machine)
        {
            Console.WriteLine("Деньги возвращены");
            machine.Sum = 0;
            machine.State = new InitialState();
        }
    }
}