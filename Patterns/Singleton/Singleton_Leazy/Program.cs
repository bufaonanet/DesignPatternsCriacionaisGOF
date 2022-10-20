using Singleton_Leazy;
using static System.Console;

Parallel.Invoke(
    () => AcessoThread1(),
    () => AcessoThread2()
    );

ReadLine();

static void AcessoThread1()
{
    WriteLine("Thread 1 ");
    Singleton s1 = Singleton.Instance;
}
static void AcessoThread2()
{
    Singleton s2 = Singleton.Instance;
    WriteLine("Thread 2 ");
}