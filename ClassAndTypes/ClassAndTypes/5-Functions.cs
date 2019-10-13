namespace ClassAndTypes
{
    class Functions
    {
        delegate void BaseAsInput(Base x);
        delegate void DerivedAsInput(Derived x);

        delegate Base BaseAsOutput();
        delegate Derived DerivedAsOutput();



        static void BaseAsInputFunc(Base x) { }
        static void DerivedAsInputFunc(Derived x) { }

        static Base BaseAsOutputFunc() { return null; }
        static Derived DerivedAsOutputFunc() { return null; }

        public static void Test()
        {
            BaseAsInput a1 = BaseAsInputFunc;//OK
            //BaseAsInput a2 = DerivedAsInputFunc;//No overload for 'DerivedAsInputFunc' matches delegate...

            DerivedAsInput b1 = BaseAsInputFunc;//OK, podtypowanie
            DerivedAsInput b2 = DerivedAsInputFunc;//OK

            BaseAsOutput c1 = BaseAsOutputFunc;//OK
            BaseAsOutput c2 = DerivedAsOutputFunc;//OK, podtypowanie

            //DerivedAsOutput d1 = BaseAsOutputFunc;//'BaseAsOutputFunc()' has the wrong return type
            DerivedAsOutput d2 = DerivedAsOutputFunc;//OK
        }
    }
}
