using System.Diagnostics.CodeAnalysis;

namespace RudimentaryCryptography.Library
{
    public class KeyComparer : IEqualityComparer<char>
    {
        public bool Equals(char x, char y) => char.ToLowerInvariant(x).Equals(char.ToLowerInvariant(y));

        public int GetHashCode([DisallowNull] char obj) => char.ToLowerInvariant(obj).GetHashCode();
    }
}
