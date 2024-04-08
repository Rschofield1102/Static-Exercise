namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var celsius = TempConverter.FahrenheitToCelsius(50);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(10);
            Console.WriteLine($"If you convert Fahrenheit of 50 to Celsius. Your answer would be celsius {celsius}");
            Console.WriteLine($"If you convert Celsius of 10 to Fahrenheit. Your answer would be Fahrenheit {fahrenheit}") ;
            
            



        }




    }
}
