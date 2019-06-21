using System;
using System.Diagnostics;

using Debug = UnityEngine.Debug;

public static class ProcessChecker
{
  public static void Check(string processTitleA, Action a, string processTitleB, Action b, int trials = 10000000)
  {
    Stopwatch stopwatch = Stopwatch.StartNew();
    for (int i = 0; i < trials; i++)
    {
      a();
    }

    stopwatch.Stop();
    Debug.Log(processTitleA + " : " + stopwatch.ElapsedMilliseconds + "ms");
    stopwatch.Restart();
    for (int i = 0; i < trials; i++)
    {
      b();
    }

    stopwatch.Stop();
    Debug.Log(processTitleB + " : " + stopwatch.ElapsedMilliseconds + "ms");
  }
}