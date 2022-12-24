using static System.Console;
Clear();

WriteLine("Введите трёхзначное  число ");
int number = Convert.ToInt32(ReadLine());

int secomd = number/10;
int secomd2 = secomd%10;

WriteLine(secomd2);
