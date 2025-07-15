//Ви розробляєте програму для генерації текстового звіту. Ваше завдання - створити текстовий звіт, який містить заголовок, дату та список подій. Використайте StringBuilder, щоб зберегти пам’ять та оптимізувати об’єднання рядків. Користувач у циклi буде вводити подiї, треба додавати їх у загальний список подiй типу StringBuilder .


using System.Text;

StringBuilder report = new StringBuilder();

report.AppendLine("Daily Report");
report.AppendLine(DateTime.Now.ToShortDateString());
report.AppendLine("Events:");

Console.WriteLine("Enter events (type 'done' to finish): ");

while (true)
{
  string input = Console.ReadLine();

  if (input == "done")
    break;

  report.AppendLine(input);
}

Console.WriteLine(report);