using System;
using System.Diagnostics;


// 1. Информация о компьютере
// Console.WriteLine("1. ИНФОРМАЦИЯ О КОМПЬЮТЕРЕ");
// Console.WriteLine($"Компьютер: {Environment.MachineName}");
// Console.WriteLine($"Пользователь: {Environment.UserName}");
// Console.WriteLine($"Дата и время: {DateTime.Now:dd.MM.yyyy HH:mm}");

// // 2. Информация об операционной системе
// Console.WriteLine("2. ОПЕРАЦИОННАЯ СИСТЕМА");
// Console.WriteLine($"ОС: {Environment.OSVersion}");
// Console.WriteLine($"64-битная ОС: {Environment.Is64BitOperatingSystem}");

// 3. Логические процессоры
// Console.WriteLine("3. ПРОЦЕССОР");
// Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}");

// 4. Память процесса
// Console.WriteLine("4. ПАМЯТЬ ПРОЦЕССА");

Process currentProcess = Process.GetCurrentProcess();

// Console.WriteLine($"PID процесса: {Environment.ProcessId}");

// long memory = Environment.WorkingSet / 1024 / 1024;
// Console.WriteLine($"Память процесса: {memory} МБ");

// Дополнительное задание
Console.WriteLine("=== МИНИ-МОНИТОР СИСТЕМЫ ===");

Console.WriteLine($"Компьютер: {Environment.MachineName}");
Console.WriteLine($"Пользователь: {Environment.UserName}");
Console.WriteLine($"ОС: {Environment.OSVersion}");
Console.WriteLine($"64-битная ОС: {Environment.Is64BitOperatingSystem}");
Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}");
Console.WriteLine($"PID процесса: {currentProcess.Id}\n");

Console.WriteLine("Измерение памяти процесса:");

for (int i = 1; i <= 3; i++)
{
    currentProcess.Refresh();

    long processMemory =
        currentProcess.WorkingSet64 / 1024 / 1024;

    Console.WriteLine($"{i} измерение: {processMemory} МБ");

    if (i < 3)
    {
        Console.WriteLine("Обновите окно через несколько секунд...");
        Console.ReadLine();
    }
}

Console.WriteLine("Исследование завершено.");
