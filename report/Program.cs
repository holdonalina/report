//Ви розробляєте програму для генерації текстового звіту. Ваше завдання - створити текстовий звіт, який містить заголовок, дату та список подій. Використайте StringBuilder, щоб зберегти пам’ять та оптимізувати об’єднання рядків. Користувач у циклi буде вводити подiї, треба додавати їх у загальний список подiй типу StringBuilder .


using System.Text;

StringBuilder report = new StringBuilder();

string report = "Daily Report\n";
report += DateTime.Now.ToShortDateString() + "\n";
report += "Events:\n";

Console.WriteLine("Enter events (type 'done' to finish): ");

while (true)
{
  string input = Console.ReadLine();

  if (input == "done")
    break;

  report.AppendLine(input);
}

Console.WriteLine(report);