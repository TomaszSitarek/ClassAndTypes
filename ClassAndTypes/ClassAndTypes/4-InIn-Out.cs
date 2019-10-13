namespace ClassAndTypes
{
    public interface X_in<in T>
    {
        void F(T x);
    }

    public interface Y1<in T>
    {
        X_in<T> F();
    }

    public interface Y2<out T>
    {
         void F(X_in<T> x);
    }






    public interface X_out<out T>
    {
        T F();
    }

    public interface Y3<out T>
    {
        X_out<T> F();
    }

    public interface Y4<in T>
    {
        void F(X_out<T> x);
    }



    public interface Y5<out T>
    {
        X_out<T> F(X_in<X_out<T>> x);
        X_out<T> G(X_out<X_in<T>> x);
    }

    public interface Y6<in T>
    {
        X_in<X_out<T>> F(X_out<T> x);
    }
}
