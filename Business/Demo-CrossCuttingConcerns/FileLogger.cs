using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Demo_CrossCuttingConcerns
{
    public class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file..");
        }
    }
}
