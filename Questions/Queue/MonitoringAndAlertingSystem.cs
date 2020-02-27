using Algorithms.Contracts;
using System;
using System.IO;
using System.Text;

namespace Queue
{
    public class MonitoringAndAlertingSystem : Question
    {
        readonly System.Collections.Queue queue = new System.Collections.Queue();

        private void MonitorAndAlertApiFailures()
        {
            using (var fileStream = File.OpenRead("ApiResponses.txt"))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    var data = line.Split(' ');
                    if (int.Parse(data[1]) >= 500)
                    {
                        var httpResponse = new HttpResponse(TimeSpan.FromSeconds(long.Parse(data[0])), uint.Parse(data[1]));
                        if (queue.Count == 10)
                        {
                            var dequeuedItem = queue.Dequeue() as HttpResponse;
                            var timeSpan = httpResponse.Timespan.Subtract(dequeuedItem.Timespan);

                            if (timeSpan.TotalMinutes <= 5)
                            {
                                Console.WriteLine("Alert: API failures are more than 10 in the last 5 mins.");
                            }

                            queue.Enqueue(httpResponse);
                        }
                        else
                        {
                            queue.Enqueue(httpResponse);
                        }
                    }
                }
            }
        }

        public override void Run()
        {
            MonitorAndAlertApiFailures();
        }

        public class HttpResponse
        {
            public HttpResponse(TimeSpan timespan, uint statusCode)
            {
                Timespan = timespan;
                StatusCode = statusCode;
            }

            public TimeSpan Timespan { get; }
            public uint StatusCode { get; }
        }
    }
}
