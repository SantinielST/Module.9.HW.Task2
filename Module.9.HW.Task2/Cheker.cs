namespace Module._9.HW.Task2
{
    static class Cheker
    {
        public static int InsertInt()// Метод проверки ввода на число
        {
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }

            Console.WriteLine("Введите значение цифрами:");
            return InsertInt();
        }

        public static string InsertString() // Метод проверки на пустую строку
        {
            var insert = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(insert))
            {
                return insert;
            }

            Console.WriteLine("Поле не должно быть пустым. Попробуйте ещё раз:");
            return InsertString();
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
