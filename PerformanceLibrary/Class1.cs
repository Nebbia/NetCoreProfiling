using System.Text;

namespace PerformanceLibrary
{
    public static class Class1
    {
        public static string TightLoopConcatenate()
        {
            var source = "test";
            var result = string.Empty;

            for (var i = 0; i < 50000; i++)
            {
                result += source;
            }

            return result;
        }

        public static string TightLoopStringBuilder()
        {
            var source = "test";
            var sb = new StringBuilder();

            for (var i = 0; i < 50000; i++)
            {
                sb.Append(source);
            }

            return sb.ToString();
        }
    }
}
