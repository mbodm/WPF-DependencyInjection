using System;
using System.Diagnostics;

namespace WpfDependencyInjection
{
    public sealed class DefaultWriter : IWriter
    {
        public void Write(string s)
        {
            Debug.WriteLine($"[Shibby {DateTime.Now:HH:mm:ss}]: {s}");
        }
    }
}
