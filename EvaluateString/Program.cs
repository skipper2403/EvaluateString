namespace evaluateString
{
    public class Evaluation
    {

        static char evaluation(char operand1 , char operand2 , Char opr)
        {
            int t = Convert.ToInt32(operand1 == 'T');
            int f = Convert.ToInt32(operand2 == 'T');

            bool result;

            if(opr == '&')
            {
                result = Convert.ToBoolean(t&f);
            }
            else
            {
                result = Convert.ToBoolean(t | f);
                
            }
            return result ? 'T' : 'F';
        }
        static void Main()
        {
            string givenString;
            givenString = Console.ReadLine();

            Stack<char> myStack = new Stack<char>();
            if (givenString.Length == 0)
            {
                Console.WriteLine("Your string was empty. please provide a valid string.");return;
            }
            try
            {
                myStack.Push(givenString[0]);
                char operand1, operand2, opr, result;
                int stringLength = givenString.Length;

                for(int i = 1; i < stringLength; i++)
                {
                    if (givenString[i] == ')')
                    {
                        operand1 = myStack.Pop();
                        opr = myStack.Pop();
                        
                        operand2 = myStack.Pop();
                        
                        myStack.Pop();
                        result = evaluation(operand1, operand2, opr);
                        myStack.Push(result);
                    }
                    else
                    {
                        switch (givenString[i])
                        {
                            case 'T':
                                break;
                            case 'F':
                                break;
                            case '&':
                                break;
                            case '|':
                                break;
                            default:
                                Console.WriteLine("please enter a valid string");
                                break;
                        }
                        myStack.Push(givenString[i]);
                    }
                }
                if (myStack.Count == 1)
                {
                    Console.WriteLine(myStack.Peek());
                }
                else
                {
                    throw new Exception(string.Format("you missed some braces in string."));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            
        }
    }

}
