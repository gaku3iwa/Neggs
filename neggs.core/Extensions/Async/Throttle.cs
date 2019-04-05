using System;
using System.Threading;
using System.Threading.Tasks;

namespace neggs.core
{
  public sealed class Throttle<T>
  {
    private readonly int millisec;
    private readonly Action<T> action;
    private long signalSequence;

    public Throttle(int millisec, Action<T> action)
    {
      this.millisec = millisec;
      this.action = action;
    }

    public async void Signal(T input)
    {
      var id = Interlocked.Increment(ref signalSequence);
      await Task.Delay(millisec);
      var current = Interlocked.Read(ref signalSequence);
      if (current == id)
      {
        action(input);
      }
    }
  }
}
