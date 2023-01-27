using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Employee
    {
        int Eno;
        double Salary;
        string Ename, Job, Dname, Location;

        public Employee(int eno, double salary, string ename, string job, string dname, string location)
        {
            Eno = eno;
            Salary = salary;
            Ename = ename;
            Job = job;
            Dname = dname;
            Location = location;
        }

        public object this[int index]
        {
            get
            {
                if(index  == 0)
                {
                    return this.Eno;
                }else if(index == 1)
                {
                    return this.Salary;
                }else if(index == 2)
                {
                    return this.Ename;
                }else if(index == 3)
                {
                    return this.Job;
                }else if(index == 4)
                {
                    return this.Dname;
                }else if(index == 5)
                {
                    return this.Location;
                }

                return null;
            }

            set
            {
                if (index == 0)
                    Eno = (int)value;
                else if(index == 1)
                    Salary = (double)value;
                else if(index == 2)
                    Ename = (string)value;
                else if(index == 3)
                    Job = (string)value;
                else if(index == 4)
                    Dname = (string)value;
                else if(index == 5)
                    Location= (string)value;
            }
        }

        // another way of implementing indexers
        public object this[string name]
        {
            get
            {
                if (name == "Eno")
                    return Eno;
                return null;
            }
            set
            {
                if (name == "Eno")
                    Eno = (int)value;
            }
        }
    }
}
    