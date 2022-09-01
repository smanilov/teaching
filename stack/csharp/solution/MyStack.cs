using System;
using System.Collections.Generic;

class MyStack : IntegerStack {
  private List<int> list = new List<int>();

  public void push(int x) {
    list.Add(x);
  }

  public int pop() {
    if (isEmpty()) {
      throw new Exception("Cannot pop from stack, because it's empty.");
    }
    
    int index = list.Count - 1;
    int result = list[index];
    list.RemoveAt(index);
    return result;
  }

  public int peek() {
    if (isEmpty()) {
      throw new Exception("Cannot peek at stack, because it's empty.");
    }

    return list[list.Count - 1];
  }

  public bool isEmpty() {
    return list.Count == 0;
  }
}
