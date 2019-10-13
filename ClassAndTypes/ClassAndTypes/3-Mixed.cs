namespace ClassAndTypes
{
    interface IMy<in T1, out T2>
    {
        T2 SomeMethod(T1 t);
    }

    class Mixed
    {
        public static void Test()
        {
            IMy<Derived, Base> @base = null;
            IMy<Base, Derived> derived = null;
            @base = derived;//OK
            //derived = @base;//Cannot implicitly convert type...
        }
    }
}
