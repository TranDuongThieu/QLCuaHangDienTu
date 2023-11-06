using System;
using System.Text;

public class RandomIdGenerator
{
    private static Random random = new Random();
    private const string AllowedChars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

    public static string GenerateRandomId(int length = 10)
    {
        StringBuilder idBuilder = new StringBuilder(length);

        for (int i = 0; i < length; i++)
        {
            int index = random.Next(AllowedChars.Length);
            idBuilder.Append(AllowedChars[index]);
        }

        return idBuilder.ToString();
    }

    public static string GenerateUniqueIdentifier()
    {
        string randomId = GenerateRandomId(10); // Fixed length of 10 for the random part
        string timestamp = DateTime.Now.ToString("ddHHmmss"); // Format timestamp as "yyyyMMddHHmmss"
        return (timestamp + randomId).Substring(0, 10);
    }

}
