namespace Runner
{
    public interface IProblem
    {
        object Solve();

        void Initialize();
    }
}