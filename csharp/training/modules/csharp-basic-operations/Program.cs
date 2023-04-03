// basic print
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

// math operations
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

// using decimal data
decimal decimalQuotient = 7.0m / 5;
// decimal decimalQuotient = 7.0m / 5.0m;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");


int first = 7;
int second = 5;
decimal quotient2 = (decimal)first / (decimal)second;
Console.WriteLine(quotient2);

// determine the remainder
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

// order the operations
int value11 = 3 + 4 * 5;
int value22 = (3 + 4) * 5;
Console.WriteLine(value11);
Console.WriteLine(value22);

// Increment and decrement
int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.

int value1 = 0;     // value is now 0.
value1 = value1 + 1; // value is now 1.
value1++;           // value is now 2.

int value2 = 1;

value2 = value2 + 1;
Console.WriteLine("First increment: " + value2);

value2 += 1;
Console.WriteLine("Second increment: " + value);

value2++;
Console.WriteLine("Third increment: " + value2);

value2 = value2 - 1;
Console.WriteLine("First decrement: " + value2);

value2 -= 1;
Console.WriteLine("Second decrement: " + value2);

value2--;
Console.WriteLine("Third decrement: " + value2);


int value3 = 1;
value3++;
Console.WriteLine("First: " + value3);
Console.WriteLine("Second: " + value3++);
Console.WriteLine("Third: " + value3);
Console.WriteLine("Fourth: " + (++value3));


int result = 3 + 1 * 5 / 2;
Console.WriteLine(result);

Console.WriteLine(5 / 10);