namespace Module._9.HW.Task2
{
    class ArrayCreator
    {
        public delegate void Sort(string[] lastNames);
        public event Sort? ArraySort;

        private string[]? LastNames { get; set; }

        /// <summary>
        /// Method is will create array
        /// </summary>
        /// <param name="n"></param>
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

        /// <summary>
        /// Method is will start event ArraySort
        /// </summary>
        /// <param name="lastNames"></param>
        protected virtual void ArraySortStarted(string[] lastNames)
        {
            ArraySort?.Invoke(lastNames);
        }
    }
}
