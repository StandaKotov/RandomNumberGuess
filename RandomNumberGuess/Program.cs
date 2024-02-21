using System.Text;

class RandomNumberGenerator
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        Console.WriteLine("Я загадал число между: 1 и 100.");
        Console.WriteLine("Попробуйте угадать.");

        // Создаем объект для генерации случайных чисел
        Random random = new Random();

        // Создаем переменную для хранения случайного числа
        int randomNumber = random.Next(1, 101); // Генерируем случайное число от 1 до 100

        // Создаем переменную для хранения числа попыток
        int attempts = 0;

        // Создаем цикл, который будет выполняться до тех пор, пока не будет угадано число
        while (true)
        {
            // Увеличиваем счетчик попыток на 1
            attempts++;

            // Считываем число с клавиатуры и сохраняем в переменную
            Console.Write("Введите ваше предположение: ");
            string input = Console.ReadLine();

            int guessedNumber;
            // Проверяем ввод пользователя на корректность
            if (!int.TryParse(input, out guessedNumber))
            {
                Console.WriteLine("Ошибка: Введите целое число от 1 до 100.");
                continue;
            }

            // Сравниваем загаданное число с введенным пользователем
            if (guessedNumber == randomNumber)
            {
                Console.WriteLine($"Поздравляю! Вы угадали число {randomNumber} за {attempts} попыток.");
                break;
            }
            else if (guessedNumber > randomNumber)
            {
                Console.WriteLine("Ваше число больше загаданного.");
            }
            else
            {
                Console.WriteLine("Ваше число меньше загаданного.");
            }

            // Проверяем число попыток
            if (attempts == 10)
            {
                Console.WriteLine($"Извините, вы исчерпали все попытки. Загаданное число было {randomNumber}.");
                break;
            }
        }
    }
}
        
    

