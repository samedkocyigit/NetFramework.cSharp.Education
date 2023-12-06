namespace NetFramework.cSharp.PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            student customer = new student();
            customer.Id = 1;
            customer.Email = "sss@gsadf.com";
            customer.Name = "Test";
            //------------------------------//
            customer.RemoveRegister();
            customer.updateRegister();
            customer.addRegister();

        }
    }
}