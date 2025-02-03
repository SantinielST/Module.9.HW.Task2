namespace Module._9.HW.Task2
{
    static class Cheker
    {
        private static InsertValueException insertValueException = new InsertValueException("Некорректное значение! Попробуйте снова!");

        public static int InsertInt()// Метод проверки ввода на число
        {
            try
            {
                var n = int.Parse(Console.ReadLine());

                return n;
                throw insertValueException;
            }
            catch (Exception)
            {
                Console.WriteLine(insertValueException.Message);
                return InsertInt();
            }
        }

        public static string InsertString() // Метод проверки на пустую строку
        {
            try
            {
                var insert = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(insert))
                {
                    foreach (var ch in insert)
                    {
                        if (char.IsNumber(ch))
                        {
                            throw insertValueException;
                        }
                    }
                    return insert;
                }

                throw insertValueException;
            }
            catch (Exception)
            {
                Console.WriteLine(insertValueException.Message);
                return InsertString();
            }
        }

        public static int CheckLine() // Метод проверки ответа для продолжения/завершения заказа
        {
            var answer = InsertInt();
            var validAnswers = new int[] { 1, 2 };

            if (answer == validAnswers[0] || answer == validAnswers[1])
            {
                return answer;
            }
            else
            {
                Console.WriteLine("Уточните, (\"1\" или \"2\"):");
                return CheckLine();
            }
        }
    }
}
