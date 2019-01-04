using FaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ServiceDo.start();//调用
                Thread.Sleep(1000 * 60 * 2);
            }

        }
    }
}
