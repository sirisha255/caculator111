namespace caculator111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepLooping = false;
            string value;
            while (!keepLooping)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("enter 1 for Addition"
                                      + "\n enter 2 for subtraction"
                                      + "\n enter 3 for multiplication"
                                      + "\n enter 4 for division\n");
                    Console.WriteLine("Enter the action to be performed");
                    int action = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter 1st input");
                    int input1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter 2nd input");
                    int input2 = Convert.ToInt32(Console.ReadLine());
                    int result = 0;
                    switch (action)
                    {
                        case 1:
                            {
                                // result = input1 + input2;
                                result = Addition(input1, input2);
                                break;
                            }
                        case 2:
                            {
                                //result = input1 - input2;
                                result = Subtraction(input1, input2);
                                break;
                            }
                        case 3:
                            {
                                //result = input1 * input2;
                                result = Multiplication(input1, input2);
                                break;
                            }
                        case 4:
                            {
                                //result = input1 / input2;
                                while (input2 == 0)
                                {
                                    Console.WriteLine("enter a non-zero divisor");
                                    input2 = Convert.ToInt32(Console.ReadLine());
                                }
                                result = Division(input1, input2);
                                break;
                            }
                        default:
                            Console.WriteLine("try again");
                            Console.ReadLine();
                            break;
                    }
                    Console.WriteLine("the result is {0}", result);
                    Console.WriteLine("Do you want to continue(y/n)");
                    Console.ReadKey();
                    value = Console.ReadLine();

                } while (value == "y" || value == "Y");

               
            }
            return;

        }


        static int Addition(int input1, int input2)
        {
            int result = input1 + input2;
            return result;
        }
        static int Subtraction(int input1, int input2)
        {
            int result = input1 - input2;
            return result;
        }
        static int Multiplication(int input1, int input2)
        {
            int result = input1 * input2;
            return result;
        }
        static int Division(int input1, int input2)
        {
            int result = input1 / input2;
            return result;
        }

    }
}
        