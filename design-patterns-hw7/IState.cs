namespace design_patterns_hw7
{
    internal interface IState
    {
        void PutMoney(CopyMachine machine, int money);
        void ChooseDevice(CopyMachine machine, string device);
        void ChooseDocument(CopyMachine machine, string document);
        void PrintDocument(CopyMachine machine);
        void TakeMoney(CopyMachine machine);
    }
}
