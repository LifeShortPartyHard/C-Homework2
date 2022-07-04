//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int [] number2;
if (number < 100) {
    Console.WriteLine("В данном числе нет третьей цифры.");
}
else {
    number2 = number.ToString().Select(b => b - '0').ToArray();
    number = number2[2];
    Console.WriteLine("Третья цифра числа:" + number);
}
