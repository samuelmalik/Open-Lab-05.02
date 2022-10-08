using System;

namespace Open_Lab_05._02
{
    public class StringTools
    {
        public string NoYelling(string sentence)
        {
            while (sentence[sentence.Length - 2] == '?' || sentence[sentence.Length - 2] == '!')
            {
                sentence = sentence.Substring(0, sentence.Length - 1);
            }
            return sentence;
        }
    }
}
