// Not fake, its clickbait
using System;
using System.Threading.Tasks.Dataflow;

// INTENTIONAL TYPO
public class Clicbkait {
  private bool _isClickbait = true; // Unfortunately
  public bool IsThisClickbait {
    get { return _isClickbait; }
  }
}

class Program {
  static Clicbkait b = new Clicbkait();
  static void Main(string[] args) {
    Console.WriteLine(b.IsThisClickbait);
  }
}
