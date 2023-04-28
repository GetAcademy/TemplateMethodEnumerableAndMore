using System.Collections;

namespace TemplateMethodEnumerableAndMore.Enumerable
{
    internal class MyNumbers : IEnumerable<int>, IEnumerator<int>
    {
        // 1 - 2 - 4 - 8 - 16 - 32 ... < 2000
        public MyNumbers()
        {
            Current = 0;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool MoveNext()
        {
            if (Current == 0)
            {
                Current = 1;
            }
            else
            {
                Current *= 2;
            }

            return Current < 2000;
        }

        public void Reset()
        {
            Console.WriteLine("Reset");
            Current = 0;
        }

        public int Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
