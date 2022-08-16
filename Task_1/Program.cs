//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.Write("Введите пятизначное число: ");
string numbers = Console.ReadLine();
if (numbers[0] == numbers[4] && numbers[1] ==numbers[3])
Console.WriteLine("Число " + numbers + " является палиндромом");
else
{
   Console.WriteLine("Число " + numbers + " не является палиндромом"); 
}






