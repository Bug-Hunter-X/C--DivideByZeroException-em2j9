public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 5;
        int y = 0;
        try
        {
            int z = x / y; 
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Divide by zero error: {ex.Message}");
            // Handle the error appropriately, e.g., set a default value or log the error.
        }
    }
}