#region basic operators
/*int x = 15;
x = 15 + 3;
Console.WriteLine(x);
x = 15 - 3;
Console.WriteLine(x);
x = 15 * 3;
Console.WriteLine(x);
x = 15 / 3;
Console.WriteLine(x);*/
#endregion


#region float operators
//have to put an least ONE f after one of the int's below:
/*float z = 1f / 3;*/
//Console.WriteLine(z);
//also if you do dividing..always use **float** because of the decimals
#endregion


#region advance math
//works like math
int a = 2 + 3 * 5 + 1;
//Console.WriteLine(a);

//works like math
//int y = 2 * (1 + ((2 + 2) * (1 + 1)));
//Console.WriteLine(y);

//dont use {} [] for using the above calculations

int c = 3;
int b = 5;
int d = 2 + c * 5 + b;
//Console.WriteLine(d);
#endregion


#region shorter ways with operators
/*x = 5;
x = x + 5;
x += 5;
x -= 5;
x++;
x--;*/
#endregion


# region logical operators
//logical operators
string pw = "abc123";
bool isPwCorrect = pw == "myCatIsNamedBob14!";
//isPwCorrect value will be false now or if pw was the equal it will be true
//Console.WriteLine(isPwCorrect);
// != checks if they are NOT the same so above
// isPwCorrect value will be true or if they were equal it will be false
isPwCorrect = pw != "myCatIsNamedBob14!";
//Console.WriteLine(isPwCorrect);

bool isHappy = true;
// is Happy was true but below reverted using !isHappy is now false;
isHappy = !isHappy;
//Console.WriteLine(isHappy);
# endregion


# region combine/append string
//combine / append strings
string playerName1 = "Bob";
string enemyName = "Kitler";
string output = playerName1 + " attacked " + enemyName;
//Console.WriteLine(output);
#endregion


#region Working with numbers as strings
/*string num1 = "3";
string num2 = "2";
string sum = num1 + num2;*/ //pitfall is it will be 32(if you want to actually math equations I have use a conversition)
//Console.WriteLine(sum);
#endregion


#region NewLines
string demoText = "Glumanda dealt 5 damage to Shiggy\nIt was supereffective";
//the \n wont be printed but will start a new line with the same string/\/\/\/\
//Console.WriteLine(demoText);
//on Visual Studio comments
//comment: Ctrl + K + C
//uncomment: Ctrl + K + U
//hashtag region: # name(name of hashtag region) and # endregion(have to use
//beginning of region
#endregion


# region Combat(quick #region tutorial)
//lawls #region notes
//use # region to structure your code a little bit better and orginize your code better
string combat = "attack";
# endregion //end of region


#region Geting input using .ReadLine()
/*Console.WriteLine("Please enter your name");
//string input = "Bob";
//Console.WriteLine("Hello " + input);//hard coded
string input = Console.ReadLine(); //enter a name so its interactive and it also stores the typed word to input
Console.WriteLine("Hello " + input);*/
#endregion


#region Converting Data Types
/*float x = 1.832f;
int y = Convert.ToInt32(x);
Console.WriteLine(y);*/

/*Console.WriteLine("Please enter your age!");
string age = Console.ReadLine();
//coverts "age" to int below..age is still a string but the method
//Convert.ToInt32() coverts age to int so it can correctly add age + 1 
//correctly ex: age = "30" then coverts to int 30 + 1
int nextYearsAge = Convert.ToInt32(age) + 1;
Console.WriteLine("Next year you will be " + nextYearsAge + " years old");*/
#endregion


#region Explicit vs Implicit + Casting
//Explicit Coversion
/*float floatVar1 = 1.854f;
int intVar1 = Convert.ToInt32(floatVar1);

//Implicit Conversion
int intVar2 = 2;
float floatVar2 = intVar2;
double dobuleVar2 = 1.75;
//below, it is the same as using Covert.ToString()
string stringVar = intVar2.ToString();

//Casting
//Casting is also basically converting some data type into another.
int x = (int)1.956f;//this casting, it will covert float to int and int cuts off everything after decimal
// very important that it WILL NOT round the number 2
Console.WriteLine(x);*/

#endregion


#region RNG (Random Number Generator)

/*Random rng = new Random();
//Returns a non-negative random integer that is less than the specified maximum 
//ex: only with generates 0-2 not 3
int n1 = rng.Next(3);
Console.WriteLine(n1);

int n2 = rng.Next(10, 16);

float n3 = rng.NextSingle();//0.0f...0.9999999f
float n4 = rng.NextSingle() * 10;
float n5 = rng.NextSingle() * 5;*/

#endregion


#region Swapping variables
/*int x = 5;
int y = 9;
int tmp = x; ////hard-coded and cheating way(its ok for now)
x = y;
y = tmp;

Console.WriteLine("x: " + x);
Console.WriteLine("y: " + y);*/

/*Console.WriteLine("Enter the name of your favourite Food");
string bestFood = Console.ReadLine();
Console.WriteLine("Enter the name of your most hated Food");
string worstFood = Console.ReadLine();

//TODO: Invert Tastes
string tmp = bestFood; //hard-coded and cheating way(its ok for now)
bestFood = worstFood;
worstFood = tmp;



Console.WriteLine("Whooshh a Magician suddenly inverts your taste");
Console.WriteLine("Your new favourite food is: " + bestFood);
Console.WriteLine("Your new most hated food is: " + worstFood);
*/
#endregion

#region excerise 3(folder i opened on VS does not open the command prompt/terminal thingy
//A) Bugfixing
//Look at the following Code and check its output. 2+3 is normally not 23. Pretty strange right...
//Try to figure out why it happens and fix it
/*string num1 = "2";
string num2 = "3";
int sum = Convert.ToInt32(num1) + Convert.ToInt32(num2);
Console.WriteLine("A) " + sum);*/


//B) Simple Calculator
//The Player should be able to input two Values which are multiplied
//and then the result should be output
/*Console.WriteLine("Enter first Number");
string input1 = Console.ReadLine();//TODO: Player should be able to enter a number. Hint: you need to conert it! 
*//*int input1ConvertToNum = int.Parse(input1);*//*
Console.WriteLine("Enter second Number");
string input2 = Console.ReadLine();//TODO: Player should be able to enter a number.
int result = Convert.ToInt32(input1) * Convert.ToInt32(input2);
Console.WriteLine("B) " + input1 + "*" + input2 + "=" + result);*/


//C) Random Damage
//Change the Code, so that the players deals
//between 10 and 15 damage to the enemy
int enemyHp = 100;
Random rng = new Random();
int dmg = rng.Next(10, 16);//put 16 so 15 is possible in this rng( 1 number higher try to keep remembing that ;) )
enemyHp -= dmg;
Console.WriteLine("C) You dealt " + dmg + " to the enemy. It now has " + enemyHp + "hp left.");
#endregion
