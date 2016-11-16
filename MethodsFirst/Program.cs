using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* public "- visability" static "Must put" int "Var" name of the method (inputs of the method   "name and type");
 * public static int ToInt32(string s); 
 * if you want the method not to returnt a value you should put :   void 
 * 
 * 
 * to get the answare 
 * return value;
 * return x; 
 * if it doent have "Void" you must have a return; 
 * And can only give you one value 
 * Sqrt, Sin, Cos, Tan, Log, Pow; 
 * 
 
*/
namespace MethodsFirst
{
    class Program
    {
        public static void DisplayMenu()
        {
            /* 1.	Write a method with the following specifications:
                        name: DisplayMenu
                        arguments: none
                        return value: none
                        tasks: display the following menu choice on the screen

                        Calculation Menu
                        1) Calculate Sum 
                        2) Calculate Sum of Squares
                        3) Calculate Sum of Cubes
                        0) To Exit

                        Enter the number that corresponds to your choice: 

                        You may beautify the output to your own likings. You don’t have to implement the functionalities of the various menu choices at this stage
                        Call this method from your main.
            */
             Console.WriteLine("*******************************");
             Console.WriteLine("*        Calculation Menu     *");
             Console.WriteLine("* 1) Calculate Sum            *");
             Console.WriteLine("* 2) Calculate Sum of Squares *");
             Console.WriteLine("* 3) Calculate Sum of Cubes   *");
             Console.WriteLine("* 4) Calculate the avarage    *");
             Console.WriteLine("* 0) To Exit                  *");
             Console.Write("* Enter the number that corresponds to your choice: ");
        }




        #region CalculateSum, Question 3
        /* 	 3.	Write a method with the following specifications:
                        name: CalculateSum
                        arguments: int representing the number of input that will constitute the sum
                        return value: int representing the sum of its input
                        tasks: prompt and accepts inputs (as many as specified by the argument), and sum them, Finally the method will return the sum of all the inputs (the sum) 

                        In your main you will call this method when the user enters 1 in response to the menu choices. You will invoke this method with argument 5 and display the resulting value.  */
        public static int CalculateSum(int _sum)
        {
            int _start = 0, _stop, _firstNumber;
           
            string _input = " ";
            while (_input != "0")
            {
                Console.Write("# Enter how many operations you want to make: ");
                _stop = Convert.ToInt32(Console.ReadLine());
                while (_start < _stop)
                {
                    _start++;
                    Console.Write("# Enter {0} number: ", _start);
                    _firstNumber = Convert.ToInt32(Console.ReadLine());
                    _sum += _firstNumber;
                }
                Console.WriteLine("# The sum is: {0} \n \n", _sum);
                Console.Write("# Type <0> to get back to the main Menu: ");
                _start = 0; _sum = 0; _firstNumber = 0;
                _input = Convert.ToString(Console.ReadLine());
            }
            Console.Clear();
            return _sum;
            
        }
        #endregion





        #region CalculateSumOfSquares, Question 4
        /* 
        * 4. Write a method with the following specifications:
            name: CalculateSumOfSquares
            arguments: int representing the number of input that will constitute the sum
            return value: int representing the sum of the squares of its input
            tasks: prompt the user for inputs and accumulates the sum of the squares of the input. This is repeated as specified by the argument. Returns the final sum 
            In your main when the user enters 2 in response to the menu choices, you will prompt the user for the number of inputs that she will be working with. You will invoke this method with this 
            value and display the resulting value.*/

        public static int CalculateSumOfSquares()
        {
            int _SumOfSquares = 0, _start = 0, _stop, _square = 0, _square1 = 0;
         
            string _input = " ";
            while (_input != "0")
            {
                Console.Write("# Enter how many operations you want to make: ");
                _stop = Convert.ToInt32(Console.ReadLine());
                while (_start < _stop)
                {
                    _start++;
                    Console.Write("# Enter {0} number: ", _start);
                    _square = Convert.ToInt32(Console.ReadLine());
                    _square1 = _square * _square;
                    Console.WriteLine("# You entered {0} the squere of {0} is {1}", _square, _square1);
                    _SumOfSquares += _square1;
                    
                }
                Console.WriteLine("# Sum Of Squares = {0}  \n \n", _SumOfSquares);
                Console.Write("# Type <0> to get back to the main Menu: ");
                _start = 0; _SumOfSquares = 0; _square1 = 0; _square = 0;
                _input = Convert.ToString(Console.ReadLine());
            }
            Console.Clear();
            return _SumOfSquares;
            
        }
        #endregion
        #region CalculateSumOfCubes Question 5
        /* 
             * 5.	Write a method with the following specifications:
            name: CalculateSumOfCubes
            arguments: none
            return value: int representing the sum of the cubes of its input
            tasks: prompt the user for the number of inputs that she will be working with. Prompts the user for the required number of inputs. Accumulates the sum of the cubes input. 
            Returns the final sum 
            
            In your main when the user enters 3 in response to the menu choices, you will invoke this method and display the resulting value.
              */
        public static int CalculateSumOfCubes()
        {
            int _SumOfCubes = 0, _start = 0, _stop, _cube1 = 0, cube2 = 0;
           
            string _input = " ";
            while (_input != "0")
            {
                Console.Write("# Enter how many operations you want to make: ");
                _stop = Convert.ToInt32(Console.ReadLine());
                while (_start < _stop)
                {
                    _start++;
                    Console.Write("# Enter {0} number: ", _start);
                    _cube1 = Convert.ToInt32(Console.ReadLine());
                    cube2 = _cube1 * _cube1 * _cube1;
                    Console.WriteLine("# You entered {0} the cube of {0} is {1}", _cube1, cube2);
                    _SumOfCubes += cube2;

                }
                Console.WriteLine("# Sum Of Cubes = {0}  \n \n", _SumOfCubes);
                Console.Write("# Type <0> to get back to the main Menu: ");
                _start = 0; _SumOfCubes = 0; cube2 = 0; _cube1 = 0;
                _input = Convert.ToString(Console.ReadLine());
            }
            Console.Clear();
            return _SumOfCubes;

        }
        #endregion
        #region CalculateAverage Question 7 

                   /* 7.	Write a method with the following specifications:
            name: CalculateAverage
            arguments: none
            return value: double representing the mathematical average of its inputs
            tasks: prompt the user for the number of inputs that she will be working with.Prompts the user for the required number of inputs.Calculate and return the average of the inputs.

            Modify your DisplayMenu method by adding another choice below CalculateSumOfCubes  to In your main when the user enters the appropriate choice in response to the menu choices, you will invoke this method and display the resulting value.

                */
        public static double CalculateAverage ()
        {
         double _avarage = 0, _number = 0, _number1 = 0;
            int _start = 0, _stop;
            
            string _input = " ";
            while (_input != "0")
            {
                Console.Write("# Enter how many operations you want to make: ");
                _stop = Convert.ToInt32(Console.ReadLine());
                while (_start < _stop)
                {
                    _start++;
                    Console.Write("# Enter {0} number: ", _start);
                    _number = Convert.ToInt32(Console.ReadLine());
                    _number1 += _number; 

                }
                _avarage = _number / _start; 
                Console.WriteLine("# {0} / {1} = {2}, the avarage is {2} \n \n", _number1, _start, _avarage);
                Console.Write("# Type <0> to get back to the main Menu: ");               
                _start = 0; _number1 = 0; _number = 0; _avarage = 0; // Reset all the vlues 
                _input = Convert.ToString(Console.ReadLine());
            }
            Console.Clear();
            return _avarage;
        }
        #endregion
        static void Main(string[] args)
        {
            string  _input = " "; 
         while(_input != "0") {
               

                        DisplayMenu();
                        _input = Convert.ToString(Console.ReadLine());
                        Console.WriteLine();
                switch (_input)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":

                        switch (_input)
                        {
                            case "1":
                                CalculateSum(0);

                                break;
                            case "2":
                                CalculateSumOfSquares();
                                break;
                            case "3":
                                CalculateSumOfCubes();
                                break;
                            case "4":
                                CalculateAverage();
                                break;
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("********************************");
                        Console.WriteLine("*                              *");
                        Console.WriteLine("* Please enter a valid number! *");
                        Console.WriteLine("*                              *");
                        Console.WriteLine("********************************");

                                            
                        break;
                }
                }

            }

        }
    }

