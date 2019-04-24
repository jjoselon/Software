using System;

namespace StringLibreria
{
    public static class Class1
    {
        public static bool IniciaConMayuscula(this String str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return false;
            }
            Char ch = str[0];
            return Char.IsUpper(ch);
        }
    }
}
