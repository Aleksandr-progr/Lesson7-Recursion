// Основной файл программы
namespace Tasks
{
    // Класс, содержащий точку входа в программу и выполнение задач
    static class Program
    {
        // Главный метод программы
        public static void Main(string[] args)
        {
            // Очистка консоли перед выполнением задачи
            Console.Clear();
            // Вывод приглашения для выбора задачи
            Console.Write(TaskSelectionPrompt);
            // Получение номера выбранной задачи от пользователя и выполнение соответствующей задачи
            int selectedTask = NumberInTerminal(3, TaskSelectionPrompt, 1);
            ExecuteTask(selectedTask);
        }

        // Метод для выполнения выбранной задачи
        static void ExecuteTask(int taskNumber)
        {
            switch (taskNumber)
            {
                case 1:
                    // Выполнение задачи 1
                    Task1.Execute();
                    break;
                case 2:
                    // Выполнение задачи 2
                    Task2.Execute();
                    break;
                case 3:
                    // Выполнение задачи 3
                    Task3.Execute();
                    break;
                default:
                    // Вывод сообщения об ошибке при неверном выборе задачи
                    Console.WriteLine("Неверный номер задачи.");
                    break;
            }
        }

        // Другие методы программы и константы здесь
    }
}