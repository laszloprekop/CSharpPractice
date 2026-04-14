namespace TutorialTopLevelStatements;

public static class Utilities
{
    public static async Task ShowProgressAnimation()
    {
        const int delay = 100;
        for (var i = 0; i < 10; i++)
        {
            Console.Write("|");
            await Task.Delay(delay);
            Console.Write("\b");
            Console.Write("/");
            await Task.Delay(delay);
            Console.Write("\b");
            Console.Write("-");
            await Task.Delay(delay);
            Console.Write("\b");
            Console.Write("\\");
            await Task.Delay(delay);
            Console.Write("\b");
        }
    }
}