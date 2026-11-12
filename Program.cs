using System.Diagnostics;
using System.Runtime.InteropServices;

Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}");
Console.WriteLine($"Архитектура процесса: :{RuntimeInformation.ProcessArchitecture}");
Console.WriteLine($"64-битный процесс: {Environment.Is64BitOperatingSystem}");


//using System.Diagnostics;

Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}");
Console.WriteLine($"Запуск вычислений...");

Stopwatch timer = Stopwatch.StartNew();
long result = 0;
while (timer.Elapsed.TotalSeconds < 5)
{
    for (int i = 0; i < 1_000_000; i++)
    {
        result += i * i;
    }
}


Console.WriteLine($"Результат: {result}");
Console.WriteLine($"Готово.");