namespace Runner
{
    public abstract class Problem : IProblem
    {
        public abstract object Solve();

        public virtual void Initialize()
        {
        }
    }
}