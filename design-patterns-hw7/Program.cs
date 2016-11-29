namespace design_patterns_hw7
{
    class Program
    {
        static void Main()
        {
            var copyMachine = new CopyMachine();
            copyMachine.PutMoney(25);
            copyMachine.ChooseDevice("Flashcard");
            copyMachine.ChooseDocument("text1.doc");
            copyMachine.PrintDocument();
            copyMachine.ChooseDocument("text2.txt");
            copyMachine.PrintDocument();
            copyMachine.TakeMoney();
        }
    }
}
