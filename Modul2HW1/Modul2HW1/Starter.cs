using System;

namespace Modul2HW1
{
    public class Starter
    {
        public void Run()
        {
            var message = string.Empty;
            var result = new Result();
            var actions = new Actions();
            var randomMethod = new Random();
            var maxRandomValue = 3;
            var iterNum = 100;
            for (var i = 0; i < iterNum; i++)
            {
                switch (randomMethod.Next(maxRandomValue))
                {
                    case 0:
                        result = actions.FirstMethod();
                        break;
                    case 1:
                        result = actions.SecondMethod();
                        break;
                    case 2:
                        result = actions.ThirdMethod();
                        break;
                    default:
                        Console.WriteLine("Что-то пошло не так");
                        break;
                }

                message = $"Action failed by a reason: {result.Message}";
                if (result.Status == false)
                {
                    Logger.Instance.Print(LogType.Error, message);
                }
            }
        }
    }
}
