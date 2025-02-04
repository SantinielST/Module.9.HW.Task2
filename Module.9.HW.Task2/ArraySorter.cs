namespace Module._9.HW.Task2
{
    class ArraySorter
    {
        /// <summary>
        /// Choose type sort array method
        /// </summary>
        /// <param name="lastNames"></param>
        public virtual void ChooseTypeSort(string[] lastNames)
        {
            Console.WriteLine("Сортировка происходит при введении: либо числа 1 (сортировка А-Я), либо числа 2 (сортировка Я-А):");

            var type = Cheker.CheckLine();

            switch (type)
            {
                case 1: SortByIncrease(lastNames); break;
                case 2: SortByDescending(lastNames); break;
            }
        }

        /// <summary>
        /// Private method sort array by descending
        /// </summary>
        /// <param name="lastNames"></param>
        private void SortByDescending(string[] lastNames)
        {
            var sortedByDescending = lastNames.OrderDescending().ToArray();

            foreach (var lastName in sortedByDescending)
            {
                Console.WriteLine(lastName);
            }
        }

        /// <summary>
        /// Private method sort array by increase
        /// </summary>
        /// <param name="lastNames"></param>
        private void SortByIncrease(string[] lastNames)
        {
            var sortedByIncrease = lastNames.Order().ToArray();

            foreach (var lastName in sortedByIncrease)
            {
                Console.WriteLine(lastName);
            }
        }
    }
}
