namespace evaluateString
{
    public class Evaluation
    {

        static char evaluation(char T , char F , Char Op)
        {
            int t = Convert.ToInt32(T == 'T');
            int f = Convert.ToInt32(F == 'T');

            bool result;

            if(Op == '&')
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
                char T, F, Op, result;
                int stringLength = givenString.Length;

                for(int i = 1; i < stringLength; i++)
                {
                    if (givenString[i] == ')')
                    {
                        T = myStack.Peek();
                        myStack.Pop();
                        Op = myStack.Peek();
                        myStack.Pop();
                        F = myStack.Peek();
                        myStack.Pop();
                        myStack.Pop();
                        result = evaluation(T, F, Op);
                        myStack.Push(result);
                    }
                    else
                    {
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
