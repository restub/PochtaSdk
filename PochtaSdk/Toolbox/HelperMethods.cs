using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PochtaSdk.Toolbox
{
    /// <summary>
    /// Helper extension methods.
    /// </summary>
    public static class HelperMethods
    {
        /// <summary>
        /// Returns the first non-null and non-empty string.
        /// </summary>
        /// <param name="s">The first string.</param>
        /// <param name="others">Other strings.</param>
        public static string Coalesce(this string s, params string[] others)
        {
            var index = 0;

            while (string.IsNullOrWhiteSpace(s) && others != null && others.Length > index)
            {
                s = others[index++];
            }

            return s;
        }
    }
}
