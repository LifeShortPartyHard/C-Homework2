//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 | number > 7) {
    Console.WriteLine("Введённое число не удовлетворяет условию ввода.");
}
else {if (number > 0 & number < 6) {
        Console.WriteLine("День недели не является выходным.");
    }
    else {
        Console.WriteLine("День недели является выходным.");
    }
}