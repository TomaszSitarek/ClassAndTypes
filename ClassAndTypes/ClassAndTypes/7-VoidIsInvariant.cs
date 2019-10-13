namespace ClassAndTypes
{
    class VoidIsInvariant
    {
        delegate void VoidAsOutput();
        delegate bool BoolAsOutput();


        static void VoidAsOutputFunc() {  }
        static bool BoolAsOutputFunc() { return true; }

        public static void Test()
        {
            VoidAsOutput t1 = VoidAsOutputFunc;//OK
            //VoidAsOutput t2 = BoolAsOutputFunc;//WRONG

            BoolAsOutput t3 = BoolAsOutputFunc;//OK
            //BoolAsOutput t4 = VoidAsOutputFunc;//WRONG
        }
    }
}
