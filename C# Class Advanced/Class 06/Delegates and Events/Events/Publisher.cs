using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Publisher
    {
        public delegate void DataProcessingDelegate(string message);
        public event DataProcessingDelegate DataProcessingHandler;

        public void ProcessData(string message)
        {
            Console.WriteLine("Processing data...");
            Thread.Sleep(3000);
            WhenDataIsProcessed(message);
        }

        private void WhenDataIsProcessed(string message)
        {
            if(DataProcessingHandler != null)
            {
                DataProcessingHandler(message);
            }
        }
    }
}
