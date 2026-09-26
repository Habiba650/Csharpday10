// Problem1: Implement a Generic Sorting Algorithm for Employee Objects
using System;

public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }
}

public class SortingAlgorithm<T>
{
    public void Sort(T[] array, Comparison<T> comparison)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (comparison(array[i], array[j]) > 0)
                {
                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Employee[] employees =
        {
            new Employee("Ali", 8000),
            new Employee("Mona", 5000),
            new Employee("Omar", 10000),
            new Employee("Sara", 7000)
        };

        SortingAlgorithm<Employee> sorter = new SortingAlgorithm<Employee>();

        sorter.Sort(employees, (e1, e2) => e1.Salary.CompareTo(e2.Salary));

        foreach (Employee employee in employees)
        {
            Console.WriteLine($"{employee.Name} - {employee.Salary}");
        }
    }
}

//Problem2: Modify SortingTwo<T>.Sort to Sort Integers in Descending Order

using System;

public class SortingTwo<T>
{
    public void Sort(T[] array, Comparison<T> comparison)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (comparison(array[i], array[j]) > 0)
                {
                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 2, 8, 1, 9, 3 };

        SortingTwo<int> sorter = new SortingTwo<int>();

        sorter.Sort(numbers, (x, y) => y.CompareTo(x));

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}

//Problem3: Sort Strings by Length in Ascending Order Using SortingTwo<T>.Sort

using System;

public class SortingTwo<T>
{
    public void Sort(T[] array, Comparison<T> comparison)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (comparison(array[i], array[j]) > 0)
                {
                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        string[] words = { "Apple", "Hi", "Programming", "Cat", "Hello" };

        SortingTwo<string> sorter = new SortingTwo<string>();

        sorter.Sort(words, (x, y) => x.Length.CompareTo(y.Length));

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}

//Problem4: Add Manager Class and Implement IComparable<Manager>

using System;

public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }
}

public class Manager : Employee, IComparable<Manager>
{
    public Manager(string name, double salary)
        : base(name, salary)
    {
    }

    public int CompareTo(Manager other)
    {
        return Salary.CompareTo(other.Salary);
    }
}

public class SortingTwo<T> where T : IComparable<T>
{
    public void Sort(T[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i].CompareTo(array[j]) > 0)
                {
                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Manager[] managers =
        {
            new Manager("Ali", 10000),
            new Manager("Mona", 7000),
            new Manager("Omar", 12000),
            new Manager("Sara", 8000)
        };

        SortingTwo<Manager> sorter = new SortingTwo<Manager>();

        sorter.Sort(managers);

        foreach (Manager manager in managers)
        {
            Console.WriteLine($"{manager.Name} - {manager.Salary}");
        }
    }
}

// Problem5: Create a Func<T, T, bool> Delegate to Compare Employees by Name Length

using System;

public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }
}

public class SortingTwo<T>
{
    public void Sort(T[] array, Func<T, T, bool> comparer)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (comparer(array[i], array[j]))
                {
                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Employee[] employees =
        {
            new Employee("Ali", 8000),
            new Employee("Mohamed", 9000),
            new Employee("Sara", 7000),
            new Employee("Hassan", 8500)
        };

        SortingTwo<Employee> sorter = new SortingTwo<Employee>();

        Func<Employee, Employee, bool> compareByNameLength =
            (e1, e2) => e1.Name.Length > e2.Name.Length;

        sorter.Sort(employees, compareByNameLength);

        foreach (Employee employee in employees)
        {
            Console.WriteLine($"{employee.Name} - {employee.Name.Length}");
        }
    }
}

//Problem6: Sort an Integer Array Using Anonymous Function and Lambda Expression

using System;

public class SortingTwo<T>
{
    public void Sort(T[] array, Func<T, T, bool> comparer)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (comparer(array[i], array[j]))
                {
                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        int[] numbers1 = { 5, 2, 8, 1, 9, 3 };

        SortingTwo<int> sorter = new SortingTwo<int>();

        // Anonymous Function
        sorter.Sort(numbers1, delegate (int x, int y)
        {
            return x > y;
        });

        Console.WriteLine("Anonymous Function:");
        foreach (int number in numbers1)
        {
            Console.Write(number + " ");
        }

        int[] numbers2 = { 5, 2, 8, 1, 9, 3 };

        // Lambda Expression
        sorter.Sort(numbers2, (x, y) => x > y);

        Console.WriteLine("\nLambda Expression:");
        foreach (int number in numbers2)
        {
            Console.Write(number + " ");
        }
    }
}

//Problem7: Implement a Generic Swap<T> Method and Swap Integer Array Elements
using System;

public class SortingAlgorithm<T>
{
    // Standalone Generic Swap Method
    public static void Swap<T>(ref T first, ref T second)
    {
        T temp = first;
        first = second;
        second = temp;
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Before Swap:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        // Swap the first and last elements
        SortingAlgorithm<int>.Swap(ref numbers[0], ref numbers[4]);

        Console.WriteLine("\nAfter Swap:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}

// Problem8: Sort Employee Objects by Salary and Name

using System;

public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }
}

public class SortingTwo<T>
{
    public void Sort(T[] array, Comparison<T> comparer)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (comparer(array[i], array[j]) > 0)
                {
                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Employee[] employees =
        {
            new Employee("Omar", 8000),
            new Employee("Ali", 5000),
            new Employee("Mona", 8000),
            new Employee("Sara", 5000),
            new Employee("Hassan", 10000)
        };

        SortingTwo<Employee> sorter = new SortingTwo<Employee>();

        sorter.Sort(employees, (e1, e2) =>
        {
            // First criterion: Salary
            int salaryResult = e1.Salary.CompareTo(e2.Salary);

            if (salaryResult != 0)
                return salaryResult;

            // Second criterion: Name
            return string.Compare(e1.Name, e2.Name, StringComparison.Ordinal);
        });

        foreach (Employee employee in employees)
        {
            Console.WriteLine($"{employee.Name} - {employee.Salary}");
        }
    }
}


//Problem9: Implement GetDefault<T> Using default(T)

using System;

public class GenericHelper
{
    public static T GetDefault<T>()
    {
        return default(T);
    }
}

class Program
{
    static void Main()
    {
        // Value Type
        int defaultInt = GenericHelper.GetDefault<int>();

        // Reference Type
        string defaultString = GenericHelper.GetDefault<string>();

        Console.WriteLine($"Default int: {defaultInt}");
        Console.WriteLine($"Default string: {defaultString ?? "null"}");
    }
}

// Problem10: Add an ICloneable Constraint and Clone an Employee Array Before Sorting

using System;

public class Employee : ICloneable
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public object Clone()
    {
        return new Employee(Name, Salary);
    }
}

public class SortingAlgorithm<T> where T : ICloneable
{
    public void Sort(T[] array, Comparison<T> comparer)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (comparer(array[i], array[j]) > 0)
                {
                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }

    public T[] CloneArray(T[] array)
    {
        T[] clonedArray = new T[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            clonedArray[i] = (T)array[i].Clone();
        }

        return clonedArray;
    }
}

class Program
{
    static void Main()
    {
        Employee[] employees =
        {
            new Employee("Ali", 8000),
            new Employee("Mona", 5000),
            new Employee("Omar", 10000),
            new Employee("Sara", 7000)
        };

        SortingAlgorithm<Employee> sorter = new SortingAlgorithm<Employee>();

        // Clone the original array before sorting
        Employee[] clonedEmployees = sorter.CloneArray(employees);

        // Sort the cloned array by Salary
        sorter.Sort(clonedEmployees,
            (e1, e2) => e1.Salary.CompareTo(e2.Salary));

        Console.WriteLine("Original Array:");
        foreach (Employee employee in employees)
        {
            Console.WriteLine($"{employee.Name} - {employee.Salary}");
        }

        Console.WriteLine("\nCloned and Sorted Array:");
        foreach (Employee employee in clonedEmployees)
        {
            Console.WriteLine($"{employee.Name} - {employee.Salary}");
        }
    }
}

// Problem11: Create a String Transformation Delegate

using System;
using System.Collections.Generic;

public delegate string StringTransformer(string text);

class Program
{
    static List<string> TransformStrings(
        List<string> strings,
        StringTransformer transformer)
    {
        List<string> result = new List<string>();

        foreach (string text in strings)
        {
            result.Add(transformer(text));
        }

        return result;
    }

    static string ReverseString(string text)
    {
        char[] characters = text.ToCharArray();
        Array.Reverse(characters);
        return new string(characters);
    }

    static void Main()
    {
        List<string> words = new List<string>
        {
            "hello",
            "world",
            "csharp"
        };

        // Uppercase transformation
        List<string> upperCase = TransformStrings(
            words,
            text => text.ToUpper()
        );

        // Reverse transformation
        List<string> reversed = TransformStrings(
            words,
            ReverseString
        );

        Console.WriteLine("Uppercase:");
        foreach (string word in upperCase)
        {
            Console.WriteLine(word);
        }

        Console.WriteLine("\nReversed:");
        foreach (string word in reversed)
        {
            Console.WriteLine(word);
        }
    }
}

// Problem12: Create a Delegate for Mathematical Operations
using System;

public delegate int MathOperation(int x, int y);

class Program
{
    static int Calculate(int x, int y, MathOperation operation)
    {
        return operation(x, y);
    }

    static void Main()
    {
        int a = 20;
        int b = 5;

        int addition = Calculate(a, b, (x, y) => x + y);
        int subtraction = Calculate(a, b, (x, y) => x - y);
        int multiplication = Calculate(a, b, (x, y) => x * y);
        int division = Calculate(a, b, (x, y) => x / y);

        Console.WriteLine($"Addition: {addition}");
        Console.WriteLine($"Subtraction: {subtraction}");
        Console.WriteLine($"Multiplication: {multiplication}");
        Console.WriteLine($"Division: {division}");
    }
}

// Problem13: Create a Generic Delegate to Transform a List from T to R

using System;
using System.Collections.Generic;

public delegate R Transformer<T, R>(T value);

class Program
{
    static List<R> TransformList<T, R>(
        List<T> list,
        Transformer<T, R> transformer)
    {
        List<R> result = new List<R>();

        foreach (T item in list)
        {
            result.Add(transformer(item));
        }

        return result;
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40 };

        // Convert integers to strings
        List<string> stringNumbers = TransformList(
            numbers,
            number => number.ToString()
        );

        foreach (string number in stringNumbers)
        {
            Console.WriteLine(number);
        }
    }
}

//Problem14: Use Func<T, TResult> to Calculate the Square of Integers
using System;
using System.Collections.Generic;

class Program
{
    static List<int> ApplyFunction(List<int> numbers, Func<int, int> function)
    {
        List<int> results = new List<int>();

        foreach (int number in numbers)
        {
            results.Add(function(number));
        }

        return results;
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        Func<int, int> square = number => number * number;

        List<int> results = ApplyFunction(numbers, square);

        foreach (int result in results)
        {
            Console.WriteLine(result);
        }
    }
}

// Problem15: Use Action<T> to Print Strings
using System;
using System.Collections.Generic;

class Program
{
    static void ApplyAction(List<string> strings, Action<string> action)
    {
        foreach (string text in strings)
        {
            action(text);
        }
    }

    static void Main()
    {
        List<string> words = new List<string>
        {
            "Hello",
            "CSharp",
            "Programming"
        };

        Action<string> print = text => Console.WriteLine(text);

        ApplyAction(words, print);
    }
}

// Problem16: Use Predicate<T> to Filter Even Numbers

using System;
using System.Collections.Generic;

class Program
{
    static List<int> FilterNumbers(List<int> numbers, Predicate<int> predicate)
    {
        List<int> result = new List<int>();

        foreach (int number in numbers)
        {
            if (predicate(number))
            {
                result.Add(number);
            }
        }

        return result;
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        Predicate<int> isEven = number => number % 2 == 0;

        List<int> evenNumbers = FilterNumbers(numbers, isEven);

        foreach (int number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}

// Problem17: Filter Strings Using an Anonymous Function
using System;
using System.Collections.Generic;

class Program
{
    static List<string> FilterStrings(
        List<string> strings,
        Predicate<string> condition)
    {
        List<string> result = new List<string>();

        foreach (string text in strings)
        {
            if (condition(text))
            {
                result.Add(text);
            }
        }

        return result;
    }

    static void Main()
    {
        List<string> words = new List<string>
        {
            "Apple",
            "Application",
            "Banana",
            "Apricot",
            "Orange",
            "Pineapple"
        };

        // Condition 1: Starts with 'A'
        List<string> startsWithA = FilterStrings(
            words,
            delegate (string text)
            {
                return text.StartsWith("A");
            });

        Console.WriteLine("Starts with A:");
        foreach (string word in startsWithA)
        {
            Console.WriteLine(word);
        }

        // Condition 2: Contains "app"
        List<string> containsApp = FilterStrings(
            words,
            delegate (string text)
            {
                return text.ToLower().Contains("app");
            });

        Console.WriteLine("\nContains 'app':");
        foreach (string word in containsApp)
        {
            Console.WriteLine(word);
        }
    }
}

// Problem18: Perform Mathematical Operations Using an Anonymous Function

using System;

class Program
{
    static int Calculate(int x, int y, Func<int, int, int> operation)
    {
        return operation(x, y);
    }

    static void Main()
    {
        int a = 20;
        int b = 5;

        // Addition
        int addition = Calculate(a, b, delegate (int x, int y)
        {
            return x + y;
        });

        // Subtraction
        int subtraction = Calculate(a, b, delegate (int x, int y)
        {
            return x - y;
        });

        // Multiplication
        int multiplication = Calculate(a, b, delegate (int x, int y)
        {
            return x * y;
        });

        Console.WriteLine($"Addition: {addition}");
        Console.WriteLine($"Subtraction: {subtraction}");
        Console.WriteLine($"Multiplication: {multiplication}");
    }
}

// Problem19: Filter Strings Using a Lambda Expression

using System;
using System.Collections.Generic;

class Program
{
    static List<string> FilterStrings(
        List<string> strings,
        Predicate<string> condition)
    {
        List<string> result = new List<string>();

        foreach (string text in strings)
        {
            if (condition(text))
            {
                result.Add(text);
            }
        }

        return result;
    }

    static void Main()
    {
        List<string> words = new List<string>
        {
            "Hello",
            "CSharp",
            "World",
            "Code",
            "Apple",
            "Programming"
        };

        // Condition 1: Length greater than 3
        List<string> longerThan3 = FilterStrings(
            words,
            text => text.Length > 3
        );

        Console.WriteLine("Length greater than 3:");
        foreach (string word in longerThan3)
        {
            Console.WriteLine(word);
        }

        // Condition 2: Contains the letter 'e'
        List<string> containsE = FilterStrings(
            words,
            text => text.Contains('e')
        );

        Console.WriteLine("\nContains 'e':");
        foreach (string word in containsE)
        {
            Console.WriteLine(word);
        }
    }
}

// Problem20: Perform Mathematical Operations on Doubles Using Lambda Expressions

using System;

class Program
{
    static double Calculate(double x, double y, Func<double, double, double> operation)
    {
        return operation(x, y);
    }

    static void Main()
    {
        double a = 10;
        double b = 2;

        // Division
        double division = Calculate(a, b, (x, y) => x / y);

        // Exponentiation
        double power = Calculate(a, b, (x, y) => Math.Pow(x, y));

        Console.WriteLine($"Division: {division}");
        Console.WriteLine($"Exponentiation: {power}");
    }
}

