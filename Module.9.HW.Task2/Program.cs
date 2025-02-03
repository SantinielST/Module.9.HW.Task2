namespace Module._9.HW.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество фамилий:");
            var n = Cheker.InsertInt();

            var arrCreator = new ArrayCreator();
            var arrSorter = new ArraySorter();

            arrCreator.ArraySort += arrSorter.ChooseTypeSort;
            arrCreator.AddLastNames(n);
        }
    }
}
