namespace CSharpBasics
{
    // Parent Class
    internal class Program
    {

        // Your project will always begin execution from Main method
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); // This line prints "Hello, World!" text in console window

            // Initialise an object
            Child childObj = new Child();

            // Use object to call method of another class
            int addResult = childObj.add(10, 20);
            Console.WriteLine(addResult);
            int subResult = childObj.sub(100, 50);
            Console.WriteLine(subResult);
        }

        // Declaring and initialising variables at class level, can be used inside any method of the same class
        String name = "James";
        int age = 50;
        Boolean isTester = true;

        // User defined method with no return type
        public void noReturnType()
        {
            // Declaring and initialising variables at method level, can only be accessed inside the method
            int result = 10 + 20;
            Console.WriteLine(result);
        }

        // User defined method with return type
        public int withReturnType()
        {
            int result = 10 + 20;
            Console.WriteLine(result);
            return result;
        }


    }
}