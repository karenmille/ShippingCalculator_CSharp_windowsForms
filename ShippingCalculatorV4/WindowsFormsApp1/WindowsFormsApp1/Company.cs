using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Company
    {
        private string name;

        // constructor
        public Company(string name)
        {
            this.name = name;
        }

        // setter and getter properties
        public string Name
        {
            get => name;
        }

        // abstract method
        public abstract double Price();
    }
}
