using System.Text.RegularExpressions;

class SymmetricWordsProgram
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string inputText = Console.ReadLine();

        // Разбиваем текст на слова, используя регулярное выражение для разделения по пробелам и знакам пунктуации.
        MatchCollection words = Regex.Matches(inputText, @"\b[\w']+\b");

        foreach (Match word in words)
        {
            string currentWord = word.Value;
            if (IsSymmetric(currentWord))
            {
                Console.WriteLine(currentWord);
            }
        }
    }

    // Метод проверяет, является ли слово симметричным.
    static bool IsSymmetric(string word)
    {
        int left = 0;
        int right = word.Length - 1;

        while (left < right)
        {
            if (word[left] != word[right])
                return false; // Слово несимметрично
            left++;
            right--;
        }
        return true; // Слово симметрично
    }
}