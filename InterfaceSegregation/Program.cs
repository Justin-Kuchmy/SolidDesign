// See https://aka.ms/new-console-template for more information
using InterfaceSegregation.BadExamples;
using InterfaceSegregation.GoodExamples;
using InterfaceSegregation.Interfaces;

IBadUserInterfaces badUserOne = new BadUserOne(1);
IBadUserInterfaces badUserTwo = new BadUserTwo(2);
IBadUserInterfaces badUserThree = new BadUserThree(3);


badUserOne.methodOne();
//badUserOne.methodTwo(); //This method is forced becuase of the bad interface but isnt needed will throw an exception when ran but wont cause a compile error
//badUserOne.methodThree(); //This method is forced becuase of the bad interface but isnt needed will throw an exception when ran but wont cause a compile error

//badUserTwo.methodOne(); //This method is forced becuase of the bad interface but isnt needed will throw an exception when ran but wont cause a compile error
badUserTwo.methodTwo(); 
//badUserTwo.methodThree(); //This method is forced becuase of the bad interface but isnt needed will throw an exception when ran but wont cause a compile error

//badUserThree.methodOne(); //This method is forced becuase of the bad interface but isnt needed will throw an exception when ran but wont cause a compile error
//badUserThree.methodTwo(); //This method is forced becuase of the bad interface but isnt needed will throw an exception when ran but wont cause a compile error
badUserThree.methodThree(); 




Console.WriteLine(new String('=', 50));
GoodUserOne goodUserOne = new GoodUserOne(1);
GoodUserTwo goodUserTwo = new GoodUserTwo(2);
GoodUserThree goodUserThree = new GoodUserThree(3);

goodUserOne.methodOne();
goodUserTwo.methodTwo();
goodUserThree.methodThree();

//goodUserOne.methodThree(); //this is a compile error becuase that method doesnt exist,
//it omitted because the interface doesnt force it, 
