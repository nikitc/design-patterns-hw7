namespace design_patterns_hw7
{
    internal class CopyMachine
    {
        public int Sum;
        public IState State { get; set; }

        public CopyMachine()
        {
            State = new InitialState();
        }

        public void PutMoney(int money)
        {
            State.PutMoney(this, money);
        }

        public void ChooseDevice(string device)
        {
            State.ChooseDevice(this, device);
        }

        public void ChooseDocument(string document)
        {
           State.ChooseDocument(this, document);
        }

        public void PrintDocument()
        {
            State.PrintDocument(this);
        }

        public void TakeMoney()
        {
            State.TakeMoney(this);
        }
    }
}
