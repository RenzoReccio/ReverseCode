using System.Text;

public class Program
{
    public static void Main()
    {

    }
    public static string MysteryFunc(string str)
    {
        var finalWord = new StringBuilder();
        var strArray = str.ToCharArray();
        for (int i = 0; i < str.Length; i = i + 2)
        {
            var number = strArray[i + 1].ToString();
            var letter = strArray[i].ToString();

            if (i % 2 == 0 && int.TryParse(number, out var numberRepeat) && !int.TryParse(letter, out var letterNotNumber))
            {
                finalWord.Append(new String(strArray[i], numberRepeat));
            }
            else
            {
                finalWord.Clear();
                break;
            }
        }
        return finalWord.ToString();
    }
}