using System.Collections.Generic;

namespace ClassAndTypes
{
    class Covariance
    {
        public static void Test()
        {
            IEnumerable<Base> @base = null;
            IEnumerable<Derived> derived = null;
            @base = derived;//OK
            //derived = @base;//Cannot implicitly convert type...
        }
    }
}
