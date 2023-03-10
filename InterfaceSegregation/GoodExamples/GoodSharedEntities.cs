using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation.GoodExamples
{
    public class GoodUserOne : IUser, IGoodUserInterfaceOne, IGoodUserInterfaceThree
    {
        public int goodID { get; private set; }
        public GoodUserOne(int badID)
        {
            this.goodID = badID;
        }

        public void methodOne()
        {
            Console.WriteLine($"Method One Called By good User {goodID}");
        }

        public void methodThree()
        {
            Console.WriteLine($"Method Three Called By good User {goodID}");
        }


    }

    public class GoodUserTwo : IUser, IGoodUserInterfaceTwo
    {
        public int goodID { get; private set; }
        public GoodUserTwo(int badID)
        {
            this.goodID = badID;
        }
        public void methodTwo()
        {
            Console.WriteLine($"Method Two Called By good User {goodID}");
        }



    }
    public class GoodUserThree : IUser, IGoodUserInterfaceThree
    {
        public int goodID { get; private set; }
        public GoodUserThree(int badID)
        {
            this.goodID = badID;
        }

        public void methodThree()
        {
            Console.WriteLine($"Method Three Called By good User {goodID}");
        }


    }
}
