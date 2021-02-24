using System;

namespace Business.Demo_CrossCuttingConcerns
{
    public class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to fatabase..");
        }
    }
}
