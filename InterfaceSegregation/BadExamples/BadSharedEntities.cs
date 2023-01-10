using InterfaceSegregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.BadExamples
{
    public class BadUserOne : IUser, IBadUserInterfaces
    {
        public int badID { get; private set; }
        public BadUserOne(int badID)
        {
            this.badID = badID;
        }

        public void methodOne()
        {
                Console.WriteLine($"Method One Called By bad User: {badID}");
        }

        public void methodTwo()
        {
                Console.WriteLine($"Method Two Called By bad User: {badID}");
        }

        public void methodThree()
        {
            throw new NotImplementedException();
        }



    }

    public class BadUserTwo : IUser, IBadUserInterfaces

    {
        public int badID { get; private set; }
        public BadUserTwo(int badID)
        {
            this.badID = badID;
        }

        public void methodOne()
        {
            throw new NotImplementedException();
        }

        public void methodTwo()
        {
            Console.WriteLine($"Method Two Called By bad User {badID}");
        }

        public void methodThree()
        {
            Console.WriteLine($"Method Three Called By bad User: {badID}");
        }



    }

    public class BadUserThree : IUser, IBadUserInterfaces
    {
        public int badID { get; private set; }
        public BadUserThree(int badID)
        {
            this.badID = badID;
        }

        public void methodOne()
        {
            Console.WriteLine($"Method One Called By bad User: {badID}");
        }

        public void methodTwo()
        {
            throw new NotImplementedException();
        }

        public void methodThree()
        {
            Console.WriteLine($"Method Three Called By bad User {badID}");
        }



    }
}
