// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello world!");

Console.WriteLine("Здравствуйте!");
Console.WriteLine("Владислав Андреевич");
Console.WriteLine("исп-243");
Console.WriteLine("15.10.26, 10:58");

Console.WriteLine("1 - Показать ФИО");
Console.WriteLine("2 - Показать группу");
Console.WriteLine("3 - Показать дату");
Console.WriteLine("4 - Выход");

Console.WriteLine("Введите номер пункта: ");
int choice = int.Parse(Console.ReadLine());

switch (choice)
    {
        case 1:
            Console.WriteLine("ФИО: Владислав Андреевич");
            break;
        case 2:
            Console.WriteLine("Группа: исп-243");
            break;
        case 3:
            Console.WriteLine("Дата: 15.10 10:51");
            break;
        case 4:
            Console.WriteLine("Выход из программы.");
            break;
        default:
            Console.WriteLine("Пункта с таким номером не существует.");
            break;
    }