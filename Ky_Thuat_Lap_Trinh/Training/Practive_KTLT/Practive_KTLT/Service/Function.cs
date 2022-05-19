namespace Practive_KTLT.Service;

public class Function
{
    public static bool IsTextContainChar(string keyword, string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i]==keyword[0])
            {
                return true;
            }
        }

        return false;
    }
}