using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static void MethodA()
    {
        for (int i = 0; i < 5; i++)
        {
            Thread.Sleep(Random.Shared.Next(2000));
            SharedObjects.Message += "A";
            Write(".");
        }
    }

    static void MethodB()
    {
        for(int i = 0;i < 5;i++)
        {
            Thread.Sleep(Random.Shared.Next(2000));
            SharedObjects.Message += "B";
            Write(".");
        }
    }
}
