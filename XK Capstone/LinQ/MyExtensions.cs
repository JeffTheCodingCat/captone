using LinQ;

public static class MyExtensions
{
    public static string stripVowels(this string str)
    {
        string result = "";
        foreach (char c in str)
        {
            if (!"aeiouAEIOU".Contains(c))
            {
                result += c;
            }
        }
        return result;
    }

    public static Product markDown(this Product product, float percentage)
    {
        product.Price -= product.Price * percentage;
        return product;
    }
}