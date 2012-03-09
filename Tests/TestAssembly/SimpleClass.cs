using System;

namespace TestAssembly
{
    public class SimpleClass
    {
        public string Field1;

        public string Property1 { get; set; }

        public void Method1() { }

        public void MethodThrowsInvalidOperationException()
        {
            throw new InvalidOperationException();
        }

        public void MethodThrowsException()
        {
            
            throw new Exception("This is an exception");
        }

        public void MethodWithArguments(string stringArg, int intArg)
        {
            
        }
    }
}