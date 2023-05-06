using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static void MethodA()
    {
        TaskTitle("Starting Method A...");
        OutputThreadInfo();
        Thread.Sleep(3000); // simulate three seconds of work
        TaskTitle("Finished Method A.");
    }
    static void MethodB()
    {
        TaskTitle("Starting Method B...");
        OutputThreadInfo();
        Thread.Sleep(2000); // simulate two seconds of work
        TaskTitle("Finished Method B.");
    }
    static void MethodC()
    {
        TaskTitle("Starting Method C...");
        OutputThreadInfo();
        Thread.Sleep(1000); // simulate one seconds of work
        TaskTitle("Finished Method C.");
    }



}
