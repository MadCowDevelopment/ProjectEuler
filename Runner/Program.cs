using System;
using System.Diagnostics;
using Runner.Problems;


namespace Runner
{
    class Program
    {
        static void Main()
        {
            SolveProblem<Problem0018>();
        }

        private static void SolveProblem<TProblem>() where TProblem : IProblem
        {
            var problem = Activator.CreateInstance<TProblem>();
            problem.Initialize();

            var stopWatch = Stopwatch.StartNew();
            var solution = problem.Solve();
            stopWatch.Stop();

            Console.WriteLine("The solution is : " + solution);
            Console.WriteLine($"Execution took: {stopWatch.Elapsed.TotalMilliseconds} ms");
        }
    }
}
