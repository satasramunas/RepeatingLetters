using System.Text;

const string data = "C:/Users/ramun/Repeating_Letters/RepeatingLetters/bin/Debug/net6.0/data.txt";

string text = File.ReadAllText(data);

char[] chars = text.ToCharArray();

void SplitCharacters(string text)
{
    foreach (char c in text)
    {
        Console.WriteLine(c);
    }
}

char[] FindRepeatingLetters(string input)
{
    char[] result = new char[input.Length];

    StringBuilder letters = new StringBuilder();

    int count = 0;

    for (int i = 0; i <= input.Length; i++)
    {
        char c = input[i];
        if (result.Contains(c))
        {
            Console.WriteLine(c);
        }
        else
        {
            result.Append(c);
        }

        if ((char)input[i] == input[i - 1])
        {
            letters.Append(input[i]);
        }
    }

    return result;
}

SplitCharacters(text);
FindRepeatingLetters(text);

