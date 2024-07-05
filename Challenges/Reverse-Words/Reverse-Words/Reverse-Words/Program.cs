namespace Reverse_Words
{
    public class Program
    {
        static string[] Split(string input)
        {
            List<string> result = new List<string>();
            string word = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                    word += input[i];
                else if (word != "" && word != " ")
                {
                    result.Add(word);
                    word = "";
                }

            }
            if (word != "")
                result.Add(word);
            return result.ToArray();
        }
        static public string ReverseWords(string input)
        {
            string[] splitInput= Split(input);
            string result = "";
            for (int i = 0; i < splitInput.Length; i++)
            {
                if (i == splitInput.Length - 1)
                    result += splitInput[splitInput.Length - i - 1];
                else
                    result += splitInput[splitInput.Length-i-1] + " ";
            }
            return result;
        }
        static void Main(string[] args)
        {
            string  s1 = "csharp is programming language";
            //foreach (string item in Split(s1))
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(ReverseWords(s1));

        }
    }
}
