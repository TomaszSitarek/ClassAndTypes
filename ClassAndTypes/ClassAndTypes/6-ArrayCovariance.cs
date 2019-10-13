namespace ClassAndTypes
{
    class ArrayCovariance
    {
        static void HandleArray(object[] arr)
        {
            arr[0] = 0;//System.ArrayTypeMismatchException
        }

        public static void Test()
        {
            string[] strArr = new string[] { "a", "b", "c" };
            HandleArray(strArr);
        }
    }
}
