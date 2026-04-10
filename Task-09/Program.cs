using System;
using System.Reflection;

// 1. Custom Attribute
[AttributeUsage(AttributeTargets.Method)]
public class RunnableAttribute : Attribute
{
}

// 2. Sample Classes
public class TaskOne
{
    [Runnable]
    public void SayHello()
    {
        Console.WriteLine("Hello from TaskOne!");
    }
}

public class TaskTwo
{
    [Runnable]
    public void ShowTime()
    {
        Console.WriteLine($"Current Time: {DateTime.Now}");
    }

    public void NotRunnable()
    {
        Console.WriteLine("You should NOT see this");
    }
}

// 3. Main Program
class Program
{
    static void Main()
    {
        // STEP 1: Get current assembly
        Assembly assembly = Assembly.GetExecutingAssembly();

        // STEP 2: Get all types (classes)
        Type[] types = assembly.GetTypes();

        foreach (Type type in types)
        {
            // STEP 3: Get all methods of the class
            MethodInfo[] methods = type.GetMethods();

            foreach (MethodInfo method in methods)
            {
                // STEP 4: Check if method has [Runnable]
                var attribute = method.GetCustomAttribute<RunnableAttribute>();

                if (attribute != null)
                {
                    Console.WriteLine($"Executing: {type.Name}.{method.Name}");

                    // STEP 5: Create instance of class
                    object instance = Activator.CreateInstance(type);

                    // STEP 6: Invoke method
                    method.Invoke(instance, null);
                }
            }
        }
    }
}