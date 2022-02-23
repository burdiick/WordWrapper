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
            String[] words = text.Trim().Split(new char[] { ' ' });
            StringBuilder sb = new StringBuilder();
            var nextLine = "";

            for (int i = 0; i < words.Count(); i++)
            {
                if ((nextLine.Length + (words[i].Length + 1) <= maxLineLength))
                {
                    if (nextLine.Length > 0)
                    {
                        nextLine += " ";
                    }
                    nextLine += words[i];
                } else
                {
                    if (words[i].Length > maxLineLength)
                    {
                        String firstHalf = words[i].Substring(0, words[i].Length / 2);
                        String secondHalf = words[i].Substring(firstHalf.Length, words[i].Length - firstHalf.Length);

                        nextLine += (firstHalf + "-");
                        sb.Append(nextLine + "\n");
                        nextLine = secondHalf;
                    }
                    else
                    {
                        sb.Append(nextLine + "\n");
                        nextLine = words[i];
                    }
                }
                if (i == words.Count() - 1)
                {
                    sb.Append(nextLine);
                }
            }

            Console.WriteLine(sb);
            return sb.ToString();
        }
    }
}