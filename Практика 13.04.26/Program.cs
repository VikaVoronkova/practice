namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //contains - содержит ли строка подстроку (bool)
            string word = "Hello";
            //Console.WriteLine(word.Contains("ll")); //true
            //Console.WriteLine(word.Contains("oll")); //false

            if (word.Contains("lo"))
            {
                //Console.WriteLine("success");
            }
            char[] example = { 'a', '.', '0' };
            //Console.WriteLine(example.Contains('a'));

            char[] punc = new char[] { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' };
            char x = 'a';
            if (punc.Contains(x))
            {
                //Console.WriteLine("The symbol is punc");
            }
            else
            {
                //Console.WriteLine("It is not punc");
            }

            //reaplace - замена подстроки в строке
            string text = "cat dog catastrophe love";
            string newText = text.Replace("dog", "more cats");
            //Console.WriteLine(newText);
            //Console.WriteLine(text.Replace("dog", "more cats "));

            //trim - отрезать необходимый символ
            string word2 = "! cat,";
            //Console.WriteLine(word2);
            string word3 = word2.Trim(punc);
            //Console.WriteLine(word3.Trim(' '));

            //split
            string text2 = "Hello, my dear, 2 friends.";
            string[] dirtywords = text2.Split(punc);
            for (int i =0; i < dirtywords.Length; i++)
            {
                //Console.WriteLine(dirtywords[i]);
            }

            //join
            string text3 = string.Join(" ", dirtywords);
            //Console.WriteLine(text3);

            // IsDigit/IsLetter
            char s = 'a';
            int count = 0;
            //Console.WriteLine(char.IsDigit(s));
            //Console.WriteLine(char.IsLetter(s));
            //Console.WriteLine(char.IsUpper(s));
            if (char.IsLower(s))
            {
                count++;
            }
            //Console.WriteLine(count);

            //ToUpper/ToLower
            string word1 = "Hello";
            //Console.WriteLine(word1.ToLower());

            string vowels = "уеыаоэяию";
            vowels += vowels.ToUpper();
            //Console.WriteLine(vowels);

            //вынести в массив все слова в тексте
            string text1 = "Hello, my dear, 2 friends.";
            string[] dirtywords1 = text1.Split(' ');
            int count1 = 0;
            string[] cleanWords = new string[0];
            for (int i =0; i <dirtywords1.Length; i++)
            {
                string trimWords = dirtywords1[i].Trim(punc);
                Console.WriteLine(trimWords);

                bool f = true;
                foreach (char symbol in trimWords)
                {
                    if (char.IsDigit(symbol) || punc.Contains(symbol))
                    {
                        f = false;
                    }
                    if (f && trimWords != " ")
                    {
                        count1++;
                        Array.Resize(ref cleanWords, cleanWords.Length + 1);
                        cleanWords[cleanWords.Length - 1] = trimWords.ToLower();
                    }
                }
            }

        }
    }
}
