namespace Module._9.HW.Task2
{
    class ArraySorter
    {
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

        private void SortByDescending(string[] lastNames)
        {
            var sortedByDescending = lastNames.OrderDescending().ToArray();

            foreach (var lastName in sortedByDescending)
            {
                Console.WriteLine(lastName);
            }
        }

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
