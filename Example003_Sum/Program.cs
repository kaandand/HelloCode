int numberA = 31;
int numberB = 15;
// вводим промежуточное значение result, можно сразу записать ConsoleWriteLine(numberA + numberB)
int result = numberA + numberB;
Console.WriteLine(result);

// Случаности 
// new Random().Next(min,max)
// Следующие случайное число от min до max
// даст случайное целое число от min до max-1 [min,max-1] или [min,max)

int numberC = new Random().Next(1,10); // 1,2,3,...,9
Console.WriteLine(numberC);
int numberD = new Random().Next(1,10);
Console.WriteLine(numberD);
Console.WriteLine(numberC + numberD);


