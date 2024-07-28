// UNTESTED!!! Too lazy to test also not fake but clickbait
using System;

// INTENTIONAL TYPO
class Clicbkait {
  private bool _isClickbait = true; // Unfortunately
  public bool IsThisClickbait {
    get { return _isClickbait }
  }
}

class Program {
  internal Clicbkait bait = new Clicbkait();
  static void Main(string[] args) {
    Console.WriteLine(bait.IsThisClickbait);
  }
}
