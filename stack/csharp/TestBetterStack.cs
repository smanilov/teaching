using System;

/// Tests implementations of BetterIntegerStack.
class TestBetterStack {
  static void testStackIsEmpty_returnsTrueForNewStack() {
    Console.WriteLine("testStackIsEmpty_returnsTrueForNewStack");
    BetterIntegerStack s = new MyBetterStack();
    if (!s.isEmpty()) {
      throw new Exception("stack.isEmpty() returned false on a new stack.");
    }
  }

  static void testStackIsEmpty_returnsFalseAfterPush() {
    Console.WriteLine("testStackIsEmpty_returnsFalseAfterPush");
    BetterIntegerStack s = new MyBetterStack();

    s.push(3);

    if (s.isEmpty()) {
      throw new Exception("stack.isEmpty() returned true after pushing an element.");
    }
  }

  static void testStackIsEmpty_returnsTrueAfterTwoPushesAndPops() {
    Console.WriteLine("testStackIsEmpty_returnsTrueAfterTwoPushesAndPops");
    BetterIntegerStack s = new MyBetterStack();

    s.push(3);
    s.push(1);

    s.pop();
    s.pop();

    if (!s.isEmpty()) {
      throw new Exception("stack.isEmpty() returned false after two pushes and pops.");
    }
  }

  static void testStackIsEmpty_returnsFalseWhenPushingMoreThanPopping() {
    Console.WriteLine("testStackIsEmpty_returnsFalseWhenPushingMoreThanPopping");
    BetterIntegerStack s = new MyBetterStack();

    s.push(3);
    s.push(1);
    s.push(4);
    s.push(1);
    s.push(5);

    s.pop();
    s.pop();
    s.pop();
    s.pop();

    if (s.isEmpty()) {
      throw new Exception("stack.isEmpty() returned true after pushing more than popping.");
    }
  }

  static void testEqual(int a, int b) {
    if (a != b) {
      throw new Exception("Expected {b}, but got {a}.");
    }
  }

  static void testStack() {
    testStackIsEmpty_returnsTrueForNewStack();
    testStackIsEmpty_returnsFalseAfterPush();
    testStackIsEmpty_returnsTrueAfterTwoPushesAndPops();
    testStackIsEmpty_returnsFalseWhenPushingMoreThanPopping();

    printGreen("Success!");
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
