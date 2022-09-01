/// A stack of integers.
interface IntegerStack
{
  /// Pushes a number on the top of the stack.
  void push(int x);

  /// Removes a number from the top of the stack and returns it.
  int pop();

  /// Returns the number stored at the top of the stack, without popping it.
  int peek();
}

