using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCFServices1.BusinessLayer
{
    public class GettingMockDataServices
    {

        public static List<Record> GetData(int numberOfRecords = 10)
        {
            var result = new List<Record>();

            for (int i = 0; i < numberOfRecords; i++)
            {
                result.Add(new Record()
                {
                    Id = i,
                    Name = "Name of " + i + 1,
                    Mobile = 9999 + i
                });
            }

            return result;
        }

    }
}
