Console.Write("Введите трёхзначное число:");
int number =  Convert.ToInt32(Console.ReadLine());
if (number < 100 | number > 999) {
    Console.WriteLine("Данное число не является трёхзначным");
}
else {
    int secondNumber = (number % 100 - number % 10) / 10;
    Console.Write("Вторая цифра введённого числа: " + secondNumber);
}