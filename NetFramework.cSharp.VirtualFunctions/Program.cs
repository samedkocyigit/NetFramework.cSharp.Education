namespace NetFramework.cSharp.VirtualFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1= new Customer() ;
            test t1= new test() ;
            baseClass b1= new baseClass() ;

            c1.scanScreen("any");
            t1.scanScreen("any");
            b1.scanScreen("any");// output => Customer =>any
                                 //           Customer =>any
                                 //           any
        }
    }
}