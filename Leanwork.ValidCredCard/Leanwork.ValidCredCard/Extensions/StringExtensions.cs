using System;

namespace Leanwork.ValidCredCard
{
    public static class StringExtensions
    {        
        public static string RemoveCharacters(this string value, params string[] characters)
        {
            if (String.IsNullOrWhiteSpace(value) || characters == null)
            {
                return value;
            }

            foreach (var character in characters)
            {
                value = value.Replace(character, "");
            }

            return value;
        }
    }
}
