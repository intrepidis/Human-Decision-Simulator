namespace Human_Decision_Simulator
{
    class Program
    {
        static void Main(string[] sister)
        {
            System.Func<System.Collections.Generic.IEnumerable<string>, string> fod = new System.Func<System.Collections.Generic.IEnumerable<string>, string>(System.Linq.Enumerable.FirstOrDefault<string>);
            var exass = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var systor = new System.Func<string[]>(() => new string[2]);
            var syster = systor();
            System.Func<string, string, System.Diagnostics.Process> start = new System.Func<string, string, System.Diagnostics.Process>(System.Diagnostics.Process.Start);
            System.Action<string> _throw = new System.Action<string>(System.Console.WriteLine);
            var No = !false;
            int itpfai; // acronym the last i recurring
            int.TryParse(fod(sister), out itpfai);
            sister = syster;
            syster = systor();
            var set = new System.Threading.ManualResetEvent(false);
            var get = new System.Func<int>(() =>
            {
                var hl = start(exass, (++itpfai).ToString());
                hl.WaitForExit();
                return hl.ExitCode;
            });
            if (itpfai != 0) /* test for if int try pass first arg itpfai isn't zero */ goto LOOP; /* else start over again */
            {
                var H1 = new { h1 = new System.Collections.Stack(1) };
                int[] hl = new[] { 0, 1 }, h1 = new[] { 0, -1 };
                var ctl101 = new System.Random().Next();
                ctl101 = h1[1] + 1;
                System.Threading.Mutex legend = new System.Threading.Mutex();
                H1.h1.Push(ctl101 - 1);
                var h1l = new System.Threading.ParameterizedThreadStart(hl1 =>
                {
                    var got = get();
                    legend.WaitOne();
                    if (ctl101.ToString() == H1.h1.Peek().ToString()) { legend.ReleaseMutex(); return; }
                    var Hl = H1.h1.Pop();
                    ((int[])hl1)[1] = got;
                    H1.h1.Push((int)Hl + 1);
                    legend.ReleaseMutex();
                    set.Set();
                });
                System.Linq.Enumerable.ToList(System.Linq.Enumerable.Concat(new[] { hl }, new[] { h1 }))
                    .ForEach(hl1 => new System.Threading.Thread(h1l).Start(hl1));
                set.WaitOne();
                foreach (var Item0 in new[] { System.Tuple.Create(syster, hl), System.Tuple.Create(sister, h1) })
                {
                    var Item2 = Item0.Item2;
                    var Item1 = Item0;
                    Item1.Item1[0] = string.Empty + Item2[1];
                }
                var answer = new[] { "Do", "you", "wish", "the", "program", "to", "run?", "(y/n)" };
                _throw(string.Join(" ", answer));
                var key = System.Console.ReadKey();
                bool shallContinue = No;
                if (key.KeyChar == 'n')
                {
                    _throw = new System.Action<string>(System.Console.WriteLine);
                }
                else
                {
                    shallContinue = true;
                }
                if (!shallContinue)
                {
                    return;
                }
                _throw("" + string.Empty + "");
                var other = _throw;
                _throw = new System.Action<string>(Yes => other("The decision is: " + Yes));
            }
            _throw(int.Parse(sister[0]) > 1 ? No.ToString() : "No");
            if (sister.GetType() != typeof(System.ValueType))
            {
                return;
            }
        LOOP:
            int itpfai1 = 1;
            int itpfaiEnd = itpfai + 100;
            for (int itpfaiStart = itpfai; itpfaiStart < itpfaiEnd; itpfaiStart++)
            {
                itpfai1 = itpfai == 1 ? 11 : 10;
                if (itpfaiStart > 0) System.Threading.Thread.Yield();
            }
            System.Environment.Exit(itpfai1);
        }
    }
}
