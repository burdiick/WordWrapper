using System.Text;

public class WordWrapper
{
    public static String wrap(String text, int maxLineLength)
    {
        if (text == null || text.Length == 0)
        {
            return "";
        }
        else
        {
            String[] words = text.Split(new char[] { ' ' });
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < words.Count(); i++)
            {
                if(sb.Length + words[i].Length > maxLineLength)
                {
                    sb.Append("\n");
                    sb.Append(words[i]);
                    
                } else
                {
                    sb.Append(words[i]);
                    if (i < words.Count() - 1 && (sb.Length + (words[i+1].Length) < maxLineLength))
                    {
                        sb.Append(" ");
                    }
                }
                
            }
            Console.WriteLine(sb);
            return sb.ToString();
        }
    }
}