namespace Module._9.HW.Task2
{
    class ArrayCreator
    {
        public delegate void Sort(string[] lastNames);
        public event Sort? ArraySort;

        private string[]? LastNames { get; set; }

        public void AddLastNames(int n)
        {
            Console.WriteLine($"Сортировка списка фамилий из {n} человек:");

            LastNames = new string[n];

            for (int i = 0; i < LastNames.Length; i++)
            {
                LastNames[i] = Cheker.InsertString();
            }

            ArraySortStarted(LastNames);
        }

        protected virtual void ArraySortStarted(string[] lastNames)
        {
            ArraySort?.Invoke(lastNames);
        }
    }
}
