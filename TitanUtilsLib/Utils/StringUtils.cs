namespace TitanUtilsLib.Utils
{
    public static class StringUtils
    {
        public static string Reverse(string str) => new string(str.Reverse().ToArray());

        public static bool IsPalindrome(string str) => str.SequenceEqual(str.Reverse());

        public static string ToTitleCase(string str) =>
            System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
    }
}
