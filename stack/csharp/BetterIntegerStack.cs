/// A stack of integers.
interface BetterIntegerStack
{
  /// Pushes a number on the top of the stack.
  void push(int x);

  /// Checks if the stack is empty.
  bool isEmpty();

  /// Removes a number from the top of the stack and returns it.
  int pop();

  /// Returns the number stored at the top of the stack, without popping it.
  int peek();
}

