using System;

class Program
{
    static void Main(string[] args)
    {
        string playerName;
        bool hasArtifact1 = false;
        bool hasArtifact2 = false;
        bool hasArtifact3 = false;
        bool hasKey = false;
        bool hasLockpick = false;

        Console.WriteLine("Вы приходите в себя в комнате после потери сознания,вам надо вспомнить ваше имя. Как вас зовут?");
        playerName = Console.ReadLine();

        while (true)
        {
            Console.WriteLine("\nЧто вы хотите сделать?");
            Console.WriteLine("1. Открыть дверь");
            Console.WriteLine("2. Заглянуть под кровать");
            Console.WriteLine("3. Открыть ящик в углу комнаты");
            Console.WriteLine("4. Открыть вентиляцию");
            Console.WriteLine("5. Взглянуть на тумбочку");
            Console.WriteLine("6. Взглянуть на статую рядом с дверью");
            Console.WriteLine("0. Выйти из игры");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // Открыть дверь
                    if (hasLockpick)
                    {
                        Console.WriteLine($"{playerName}, вам удалось сбежать!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{playerName}, дверь заперта. Вам нужна отмычка.");
                    }
                    break;

                case "2": // Заглянуть под кровать
                    if (!hasArtifact1)
                    {
                        Console.WriteLine($"{playerName}, вы нашли артефакт 1!");
                        hasArtifact1 = true;
                    }
                    else
                    {
                        Console.WriteLine($"{playerName}, вы уже искали под кроватью.");
                    }
                    break;

                case "3": // Открыть ящик
                    if (hasKey)
                    {
                        Console.WriteLine($"{playerName}, вы нашли отмычку от двери!");
                        hasLockpick = true;
                    }
                    else
                    {
                        Console.WriteLine($"{playerName}, ящик заперт. Вам нужен ключ.");
                    }
                    break;

                case "4": // Открыть вентиляцию
                    if (!hasArtifact2)
                    {
                        Console.WriteLine($"{playerName}, вы пытаетесь открыть вентиляцию...");
                        Console.WriteLine($"{playerName}, вы нашли артефакт 2!");
                        hasArtifact2 = true;
                    }
                    else
                    {
                        Console.WriteLine($"{playerName}, вы уже искали в вентиляции.");
                    }
                    break;

                case "5": // Взглянуть на тумбочку
                    if (!hasArtifact3)
                    {
                        Console.WriteLine($"{playerName}, вы нашли артефакт 3!");
                        hasArtifact3 = true;
                    }
                    else
                    {
                        Console.WriteLine($"{playerName}, вы уже смотрели на тумбочку.");
                    }
                    break;

                case "6": // Взглянуть на статую
                    if (hasArtifact1 && hasArtifact2 && hasArtifact3)
                    {
                        Console.WriteLine($"{playerName}, вы активировали статую и получили ключ от ящика!");
                        hasKey = true;
                    }
                    else
                    {
                        Console.WriteLine($"{playerName}, вам нужно больше артефактов для активации статуи.");
                    }
                    break;

                case "0": // Выйти из игры
                    Console.WriteLine("Спасибо за игру!");
                    return;

                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
                    break;
            }
        }
    }
}

