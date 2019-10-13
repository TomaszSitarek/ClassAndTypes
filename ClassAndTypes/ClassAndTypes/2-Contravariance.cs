using System.Collections.Generic;

namespace ClassAndTypes
{
    class Contravariance
    {
        public static void Test()
        {
            IComparer<Base> @base = null;
            IComparer<Derived> derived = null;
            //@base = derived;//Cannot implicitly convert type...
            derived = @base;//OK



            IComparer<IComparer<Base>> @base2 = null;
            IComparer<IComparer<Derived>> derived2 = null;
            @base2 = derived2;//OK
            //derived2 = @base2;//Cannot implicitly convert type...
        }
    }
}
