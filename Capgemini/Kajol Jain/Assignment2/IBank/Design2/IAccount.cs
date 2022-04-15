using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design2
{
    /// <summary>
    /// creating an Interface
    /// </summary>
    internal interface IAccount
    {
        //declaring abstract classes
        public abstract void openAccount1(double amount);

        public abstract void closeAccount1();
        public abstract void deposit1(double amount);

    }
}
