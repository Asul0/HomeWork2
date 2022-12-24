using static System.Console;
Clear();

WriteLine("Введите число ");
int number = Convert.ToInt32(ReadLine());
int result = number%10;

if (number > 99)
{
    WriteLine(result);
}
else
{
    WriteLine("третьей цифры нет");
}