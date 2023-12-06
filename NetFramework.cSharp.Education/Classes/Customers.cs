using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.cSharp.Education.Classes
{
    public class Customers
    {
        #region VirtualDataBase
        static ArrayList dBase;
        #endregion
        #region Static Ctor Method
        static Customers()
        {
            dBase = new ArrayList();
        }
        #endregion
        #region Fields
        public int id { get; set; }
        public string? cusName { get; set; }
        public string? cusSurname { get; set; }
        public string? cusEmail { get; set; }
        string? cusUName;
        string? cusPassword;
        #endregion
        #region Capsulation
        public string password
        {
            get { return cusPassword; }
            set { cusPassword = value; }
        }
        public string userName
        {
            get { return cusUName; }
            set
            {
                bool userNameControl = CustomerUserNameControl(value);
                if (userNameControl)
                {
                    Console.WriteLine("System already have The username what you want to add");
                    this.cusUName = string.Empty;
                }
                else
                {
                    this.cusUName = value;
                }
            }
        }
        #endregion
        #region Static Methods
        static bool CustomerUserNameControl(string userName)
        {
            bool control = false;
            for (int i = 0; i < dBase.Count; i++)
            {
                Customers Temp = (Customers)dBase[i];
                if (Temp.cusUName == userName)
                {
                    control = true;
                    break;
                }
            }
            return control;
        }
        public static void CustomerAdd(Customers C)
        {
            #region Parameter Control
            if (C != null && !string.IsNullOrEmpty(C.cusUName) && !string.IsNullOrEmpty(C.cusEmail))
            {
                bool eMailAdressControl = CustomerEmailAdreesControl(C.cusEmail);
                if (eMailAdressControl)
                {
                    Console.WriteLine("Database already have the user what do you want to add");
                }
                else
                {
                    dBase.Add(C);
                    Console.WriteLine("Successfuly Add");
                }
            }
            #endregion
        }

        static bool CustomerEmailAdreesControl(string _eMailAdress)
        {
            bool control = false;
            for (int i = 0; i < dBase.Count; i++)
            {
                Customers temp = (Customers)dBase[i];
                if (temp.cusEmail == _eMailAdress)
                {
                    control = true;
                    break;
                }
            }
            return control;
        }
        #endregion
    }
}
