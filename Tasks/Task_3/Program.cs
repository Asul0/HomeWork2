using static System.Console;
Clear();

WriteLine("Введите номер дня недели ");
int numDay = Convert.ToInt32(ReadLine());

if (numDay == 1)
{
    WriteLine("нет");
}
if (numDay == 2)
{
    WriteLine("нет");
} 
if (numDay == 3)
{
    WriteLine("нет");
} 
if (numDay == 4)
{
    WriteLine("нет");
} 
if (numDay == 5)
{
    WriteLine("нет");
} 
if (numDay == 6)
{
    WriteLine("да");
} 
if (numDay == 7)
{
    WriteLine("да");
}
if (numDay > 7)
{
    WriteLine("по данному номеру нет дня недели");
}