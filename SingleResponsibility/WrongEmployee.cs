using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class WrongEmployee
    {
        //Single Reponsibility violation because these methods are all uses for different purposes.
        //(used by different departments in a company)

        //used by Accounting to determine an employees pay
        public double calculatePay(){ double pay = 25.50; return regularHours() * pay; }


        //used by HR to determine an employees Hours worked
        public int reportHours() { return regularHours(); }


        //used by database admins to save everything.
        public void save() {}


        //Two different departments both use this method, changes for one department could effect the other in a negative way, 
        //if both departments makes changes, there could be a merge conflict
        public int regularHours() { return 0; }
    }
}
