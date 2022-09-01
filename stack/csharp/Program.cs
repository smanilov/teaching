using System;

class Program {
  static void testStack() {
    IntegerStack s = new MyStack();

    s.push(3);
    s.push(1);
    s.push(4);

    testEqual(s.pop(), 4);
    testEqual(s.pop(), 1);
    testEqual(s.pop(), 3);

    printGreen("Success!");
  }

  static void testEqual(int a, int b) {
    if (a != b) {
      throw new Exception("Expected {b}, but got {a}.");
    }
  }

  static void Main(string[] args) {
    try {
      testStack();
    } catch (Exception e) {
      printRed("Fail");
      throw e;
    }
  }

  static void printRed(String text) {
    ConsoleColor previous = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ForegroundColor = previous;
  }

  static void printGreen(String text) {
    ConsoleColor previous = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(text);
    Console.ForegroundColor = previous;
  }
}
