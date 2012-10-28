using System;
using System.Collections.Generic;
using System.Linq;

namespace Sep.Git.Tfs.Util
{
    public static class ComparisonExtensions
    {
        public static bool Contains(this IEnumerable<string> list, string toCheck, StringComparison comp)
        {
            return list.Any(listMember => listMember.IndexOf(toCheck, comp) >= 0);
        }
    }
}