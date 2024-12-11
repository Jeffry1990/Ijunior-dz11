namespace ConsoleApp51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            string userImput;
            const string CommandShowPoem = "1";
            const string CommandShowDescriptionOfFilm = "2";
            const string CommandShowRandomNumbers = "3";
            const string CommandClearConsole = "4";
            const string CommandExit = "5";
            int randomNumber;
            int minRandomNumber = 0; ;
            int maxRandomNumber = 10;

            Random rand = new Random();
            randomNumber = rand.Next(minRandomNumber, maxRandomNumber);

            while (isWork)
            {
                Console.WriteLine($"Выберете необходимое действие для начала работы!\n \n{CommandShowPoem} - посмотреть отрывок" +
                    $" стихотворения синим цветом. \n{CommandShowDescriptionOfFilm} - посмотреть описание фильма желтым цветом. \n{CommandShowRandomNumbers} - показать" +
                    $" случайное число. \n{CommandClearConsole} - очистить консоль. \n{CommandExit} - выход из приложения");
                Console.Write("\n");
                userImput = Console.ReadLine();
                
                switch(userImput)
                {
                    case CommandShowPoem:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Ветер, ветер! Ты могуч,\nТы гоняешь стаи туч,\nТы волнуешь сине море," +
                            "\nВсюду веешь на просторе.\nНе боишься никого,\nКроме бога одного.\nАль откажешь мне" +
                            " в ответе?\nНе видал ли где на свете\nТы царевны молодой?\nЯ жених ее. — Постой, —" +
                            "\nОтвечает ветер буйный, —\nТам за речкой тихоструйной\nЕсть высокая гора," +
                            "\nВ ней глубокая нора;\nВ той норе, во тьме печальной,\nГроб качается хрустальный" +
                            "\nНа цепях между столбов.\nНе видать ничьих следов\nВкруг того пустого места," +
                            "\nВ том гробу твоя невеста.\n");
                        break;

                    case CommandShowDescriptionOfFilm:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Фильм Дюна. \nНаследник знаменитого дома Атрейдесов Пол отправляется вместе" +
                            " с семьей на одну из самых опасных планет во Вселенной — Арракис." +
                            "Здесь нет ничего, кроме песка, палящего солнца, гигантских чудовищ и основной причины" +
                            " межгалактических конфликтов — невероятно ценного ресурса, который называется меланж." +
                            "В результате захвата власти Пол вынужден бежать и скрываться, и это становится началом" +
                            " его эпического путешествия.Враждебный мир Арракиса приготовил для него множество" +
                            " тяжелых испытаний, но только тот, кто готов взглянуть в глаза своему страху, достоин" +
                            " стать избранным.");
                        break;

                    case CommandShowRandomNumbers:
                        Console.WriteLine($"Случайное число - {randomNumber}");
                        break;

                    case CommandClearConsole:
                        Console.Clear();
                        Console.WriteLine("Консоль очищена");
                        break;

                    case CommandExit:
                        Console.WriteLine("Выход из программы");
                        isWork = false;
                        break;

                    default:
                        Console.WriteLine("Ошибка! Попробуйте снова!");
                        break ;
                }
            }
        }
    }
}
