#include <iostream>
using namespace std;

// Function to add two numbers
int addTwoNumbers(int a, int b)
{
  return a + b;
}

int main()
{
  int num1 = 5;
  int num2 = 10;

  int sum = addTwoNumbers(num1, num2);

  cout << "The sum of " << num1 << " and " << num2 << " is: " << sum << endl;

  return 0;
}