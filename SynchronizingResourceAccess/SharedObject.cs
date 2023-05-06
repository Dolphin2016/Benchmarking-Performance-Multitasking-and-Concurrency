using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class SharedObjects
{
    public static object Conch = new();

    public static string? Message; // a shared resource

    public static int Counter; // another shared resource
}
