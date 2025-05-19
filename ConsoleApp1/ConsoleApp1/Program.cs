using System;
using System.IO;

class ConsoleFileExplorer
{
    static string currentPath = null;

    static void Main()
    {
        Console.WriteLine("=== Консольный Проводник Файловой Системы ===");
        while (true)
        {
            if (currentPath == null)
            {
                ShowDrives();
                Console.WriteLine("Введите букву диска для выбора или 'exit' для выхода:");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                    break;

                if (input.Length == 1)
                {
                    string drive = input.ToUpper() + @":\";
                    if (Directory.Exists(drive))
                    {
                        currentPath = drive;
                    }
                    else
                    {
                        Console.WriteLine("Диск не найден. Попробуйте снова.");
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Попробуйте снова.");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Текущий каталог: {currentPath}");
                ShowDirectoryContents(currentPath);
                ShowMenu();

                Console.Write("Введите команду: ");
                string command = Console.ReadLine().Trim();

                if (command.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;
                else if (command.Equals("up", StringComparison.OrdinalIgnoreCase))
                    GoUpDirectory();
                else if (command.StartsWith("cd ", StringComparison.OrdinalIgnoreCase))
                    ChangeDirectory(command.Substring(3).Trim());
                else if (command.StartsWith("open ", StringComparison.OrdinalIgnoreCase))
                    OpenFile(command.Substring(5).Trim());
                else if (command.StartsWith("mkdir ", StringComparison.OrdinalIgnoreCase))
                    CreateDirectory(command.Substring(6).Trim());
                else if (command.StartsWith("mkfile ", StringComparison.OrdinalIgnoreCase))
                    CreateFile(command.Substring(7).Trim());
                else if (command.StartsWith("del ", StringComparison.OrdinalIgnoreCase))
                    DeleteItem(command.Substring(4).Trim());
                else if (command.Equals("info", StringComparison.OrdinalIgnoreCase))
                    ShowDriveInfo(currentPath);
                else
                    Console.WriteLine("Неизвестная команда. Попробуйте снова.");

                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
        Console.WriteLine("Выход из приложения. До свидания!");
    }

    static void ShowDrives()
    {
        Console.WriteLine("Доступные диски:");
        DriveInfo[] drives = DriveInfo.GetDrives();
        foreach (var drive in drives)
        {
            if (drive.IsReady)
                Console.WriteLine($" {drive.Name} - {drive.VolumeLabel} ({drive.DriveFormat})");
            else
                Console.WriteLine($" {drive.Name} - не готов");
        }
    }

    static void ShowDriveInfo(string path)
    {
        try
        {
            DriveInfo drive = new DriveInfo(Path.GetPathRoot(path));
            if (!drive.IsReady)
            {
                Console.WriteLine("Диск не готов.");
                return;
            }
            Console.WriteLine($"Информация о диске {drive.Name}:");
            Console.WriteLine($"  Метка тома: {drive.VolumeLabel}");
            Console.WriteLine($"  Файловая система: {drive.DriveFormat}");
            Console.WriteLine($"  Общий размер: {FormatBytes(drive.TotalSize)}");
            Console.WriteLine($"  Свободное пространство: {FormatBytes(drive.AvailableFreeSpace)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при получении информации о диске: {ex.Message}");
        }
    }

    static string FormatBytes(long bytes)
    {
        string[] sizes = { "B", "KB", "MB", "GB", "TB" };
        double len = bytes;
        int order = 0;
        while (len >= 1024 && order < sizes.Length - 1)
        {
            order++;
            len /= 1024;
        }
        return $"{len:0.##} {sizes[order]}";
    }

    static void ShowDirectoryContents(string path)
    {
        try
        {
            Console.WriteLine("Содержимое каталога:");

            string[] directories = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            if (directories.Length == 0 && files.Length == 0)
            {
                Console.WriteLine("  Папка пуста.");
            }
            else
            {
                foreach (var dir in directories)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("  [DIR] " + Path.GetFileName(dir));
                }
                Console.ResetColor();

                foreach (var file in files)
                {
                    Console.WriteLine("  " + Path.GetFileName(file));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при чтении каталога: {ex.Message}");
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("\nДоступные команды:");
        Console.WriteLine("  cd <папка>    - войти в подкаталог");
        Console.WriteLine("  up            - подняться на уровень выше");
        Console.WriteLine("  open <файл>   - открыть текстовый файл");
        Console.WriteLine("  mkdir <имя>   - создать новый каталог");
        Console.WriteLine("  mkfile <имя>  - создать новый текстовый файл");
        Console.WriteLine("  del <имя>     - удалить файл или каталог");
        Console.WriteLine("  info          - информация о текущем диске");
        Console.WriteLine("  exit          - выход из программы");
    }

    static void ChangeDirectory(string folderName)
    {
        if (string.IsNullOrWhiteSpace(folderName))
        {
            Console.WriteLine("Имя папки не может быть пустым.");
            return;
        }

        string newPath = Path.Combine(currentPath, folderName);
        if (Directory.Exists(newPath))
        {
            currentPath = newPath;
        }
        else
        {
            Console.WriteLine("Папка не найдена.");
        }
    }

    static void GoUpDirectory()
    {
        string parent = Directory.GetParent(currentPath)?.FullName;
        if (parent != null)
            currentPath = parent;
        else
            Console.WriteLine("Вы находитесь в корне диска.");
    }

    static void OpenFile(string fileName)
    {
        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("Имя файла не может быть пустым.");
            return;
        }

        string filePath = Path.Combine(currentPath, fileName);
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Файл не найден.");
            return;
        }

        try
        {
            string extension = Path.GetExtension(filePath).ToLower();
            if (extension != ".txt" && extension != ".log" && extension != ".csv" && extension != ".json" && extension != ".xml")
            {
                Console.WriteLine("Открытие поддерживается только для текстовых файлов.");
                return;
            }

            Console.WriteLine($"\nСодержимое файла {fileName}:\n");
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при открытии файла: {ex.Message}");
        }
    }

    static void CreateDirectory(string dirName)
    {
        if (string.IsNullOrWhiteSpace(dirName))
        {
            Console.WriteLine("Имя каталога не может быть пустым.");
            return;
        }

        string dirPath = Path.Combine(currentPath, dirName);
        if (Directory.Exists(dirPath))
        {
            Console.WriteLine("Каталог с таким именем уже существует.");
            return;
        }

        try
        {
            Directory.CreateDirectory(dirPath);
            Console.WriteLine("Каталог успешно создан.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при создании каталога: {ex.Message}");
        }
    }

    static void CreateFile(string fileName)
    {
        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("Имя файла не может быть пустым.");
            return;
        }

        string filePath = Path.Combine(currentPath, fileName);
        if (File.Exists(filePath))
        {
            Console.WriteLine("Файл с таким именем уже существует.");
            return;
        }

        try
        {
            Console.WriteLine("Введите содержимое файла. Для окончания ввода введите пустую строку:");
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                while (true)
                {
                    string line = Console.ReadLine();
                    if (string.IsNullOrEmpty(line))
                        break;
                    writer.WriteLine(line);
                }
            }
            Console.WriteLine("Файл успешно создан.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при создании файла: {ex.Message}");
        }
    }

    static void DeleteItem(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Имя файла или каталога не может быть пустым.");
            return;
        }

        string pathToDelete = Path.Combine(currentPath, name);

        if (File.Exists(pathToDelete))
        {
            Console.Write($"Вы уверены, что хотите удалить файл '{name}'? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
            {
                try
                {
                    File.Delete(pathToDelete);
                    Console.WriteLine("Файл удалён.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при удалении файла: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Удаление отменено.");
            }
        }
        else if (Directory.Exists(pathToDelete))
        {
            Console.Write($"Вы уверены, что хотите удалить каталог '{name}' и всё его содержимое? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
            {
                try
                {
                    Directory.Delete(pathToDelete, true);
                    Console.WriteLine("Каталог удалён.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при удалении каталога: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Удаление отменено.");
            }
        }
        else
        {
            Console.WriteLine("Файл или каталог не найден.");
        }
    }
}
