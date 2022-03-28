using System;

namespace GenericTask
{
    internal static class Program
    {
        private static readonly string FileLocation = ".\\test.txt";
        public static void Main(string[] args)
        {
            LocalFileLogger<int> intLogger = new LocalFileLogger<int>(FileLocation);
            intLogger.LogInfo("Hi Im int-Info from Rome!");
            intLogger.LogWarning("Hi Im int-Warning from Rome!");
            intLogger.LogError("Hi Im int-Exception from Rome!", 
                new Exception("Hi Im exception from int"));
            
            LocalFileLogger<double> doubleLogger = new LocalFileLogger<double>(FileLocation);
            intLogger.LogInfo("Hi Im double-Info from Rome!");
            intLogger.LogWarning("Hi Im double-Warning from Rome!");
            intLogger.LogError("Hi Im double-Exception from Rome!", 
                new Exception("Hi Im exception from double"));
            
            LocalFileLogger<Car> carLogger = new LocalFileLogger<Car>(FileLocation);
            intLogger.LogInfo("Hi Im car-Info from Rome!");
            intLogger.LogWarning("Hi Im car-Warning from Rome!");
            intLogger.LogError("Hi Im car-Exception from Rome!", 
                new Exception("Hi Im exception from car"));
        }
    }
}