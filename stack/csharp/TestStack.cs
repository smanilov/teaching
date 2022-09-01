using System;

/// Tests implementations of IntegerStack.
class TestStack {
  static void testStack_isLifo() {
    Console.WriteLine("testStack_isLifo");
    IntegerStack s = new MyStack();

    s.push(3);
    s.push(1);
    s.push(4);

    testEqual(s.pop(), 4);
    testEqual(s.pop(), 1);
    testEqual(s.pop(), 3);
  }

  static void testStackPeek_returnsLastPushed() {
    Console.WriteLine("testStackPeek_returnsLastPushed");
    IntegerStack s = new MyStack();

    s.push(3);
    testEqual(s.peek(), 3);

    s.push(1);
    testEqual(s.peek(), 1);

    s.push(4);
    testEqual(s.peek(), 4);
  }

  static void testStackPeek_doesNotRemoveElements() {
    Console.WriteLine("testStackPeek_doesNotRemoveElements");
    IntegerStack s = new MyStack();

    s.push(3);
    s.push(1);
    s.push(4);

    testEqual(s.peek(), 4);
    testEqual(s.peek(), 4);
    testEqual(s.peek(), 4);
  }

  static void testStack_poppingEmptyThrowsException() {
    Console.WriteLine("testStack_poppingEmptyThrowsException");
    IntegerStack s = new MyStack();
    bool testPassed = false;
    try {
      s.pop();
    } catch (Exception) {
      testPassed = true;
    }

    if (!testPassed) {
      throw new Exception("Calling stack.pop() on an empty stack did not throw an exception."); 
    }
  }

  static void testStack_peekingEmptyThrowsException() {
    Console.WriteLine("testStack_peekingEmptyThrowsException");
    IntegerStack s = new MyStack();
    bool testPassed = false;
    try {
      s.peek();
    } catch (Exception) {
      testPassed = true;
    }

    if (!testPassed) {
      throw new Exception("Calling stack.peek() on an empty stack did not throw an exception."); 
    }
  }

  static void testEqual(int a, int b) {
    if (a != b) {
      throw new Exception("Expected {b}, but got {a}.");
    }
  }

  static void testStack() {
    testStack_isLifo();
    testStackPeek_returnsLastPushed();
    testStackPeek_doesNotRemoveElements();
    testStack_poppingEmptyThrowsException();
    testStack_peekingEmptyThrowsException();

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
