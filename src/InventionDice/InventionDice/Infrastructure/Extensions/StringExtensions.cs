namespace InventionDice.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNotEmpty(this string value)
        {
            return value != null && value.Trim().Length > 0;
        }
    }
}
