using System;

// 1. Define Delegate
public delegate void ThresholdReachedHandler(int count);

// 2. Counter Class (Producer)
public class Counter
{
    private int _count = 0;
    private int _threshold;

    // 3. Define Event
    public event ThresholdReachedHandler OnThresholdReached;

    public Counter(int threshold)
    {
        _threshold = threshold;
    }

    // Method to increment counter
    public void Increment()
    {
        _count++;
        Console.WriteLine($"Current Count: {_count}");

        // 4. Raise event when threshold is reached
        if (_count == _threshold)
        {
            RaiseEvent();
        }
    }

    // Method to safely raise event
    protected virtual void RaiseEvent()
    {
        OnThresholdReached?.Invoke(_count);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Counter counter = new Counter(5);

        // 5. Subscribe handlers
        counter.OnThresholdReached += ShowMessage;
        counter.OnThresholdReached += LogMessage;
        counter.OnThresholdReached += AlertUser;

        Console.WriteLine("Starting Counter...\n");

        // 6. Main loop
        for (int i = 0; i < 7; i++)
        {
            counter.Increment();
        }

        Console.WriteLine("\nFinished.");
    }

    static void ShowMessage(int count)
    {
        Console.WriteLine($"[MESSAGE] Threshold reached at {count}");
    }

    static void LogMessage(int count)
    {
        Console.WriteLine($"[LOG] Logging threshold event: {count}");
    }

    static void AlertUser(int count)
    {
        Console.WriteLine($"[ALERT] Take action! Count = {count}");
    }
}