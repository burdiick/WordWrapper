public class WordWrapper
{
    public static String wrap(String text, int maxLineLength)
    {
        if (text != null && text.Length > 0)
        {
            return text;
        }
        else
        {
            return "";
        }
    }
}