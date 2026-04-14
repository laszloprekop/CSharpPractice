namespace TutorialTopLevelStatements;

public static class Utilities
{
    public static async Task ShowProgressAnimation()
    {
        const int delay = 100;
        char[] animation = ['|', '/', '-', '\\'];
        for (var i = 0; i < 10; i++)
        {
            foreach (char frame in animation)
            {
                Console.Write(frame);
                await Task.Delay(delay);
                Console.Write("\b");
            }
        }
    }
}