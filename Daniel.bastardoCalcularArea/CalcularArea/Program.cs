class Program
{
    static double CalcularAreaRectangulo(double baseRectangulo, double alturaRectangulo)
    {
        return baseRectangulo * alturaRectangulo;
    }
    static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
    {
        return 0.5 * baseTriangulo * alturaTriangulo;
    }
     static double CalcularAreaCirculo(double radioCirculo)
    {
        return Math.PI * Math.Pow(radioCirculo, 2);
    }

    static void Main()
    {
        Console.WriteLine("¿Qué figura deseas calcular?");
        Console.WriteLine("1. Rectángulo");
        Console.WriteLine("2. Triángulo");
        Console.WriteLine("3. Círculo");

        int opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                Console.Write("Ingresa la base del rectángulo: ");
                double baseRectangulo = double.Parse(Console.ReadLine());
                Console.Write("Ingresa la altura del rectángulo: ");
                double alturaRectangulo = double.Parse(Console.ReadLine());
                Console.WriteLine($"El área del rectángulo es: {CalcularAreaRectangulo(baseRectangulo, alturaRectangulo)}");
                break;

            case 2:
                Console.Write("Ingresa la base del triángulo: ");
                double baseTriangulo = double.Parse(Console.ReadLine());
                Console.Write("Ingresa la altura del triángulo: ");
                double alturaTriangulo = double.Parse(Console.ReadLine());
                Console.WriteLine($"El área del triángulo es: {CalcularAreaTriangulo(baseTriangulo, alturaTriangulo)}");
                break;

            case 3:
                Console.Write("Ingresa el radio del círculo: ");
                double radioCirculo = double.Parse(Console.ReadLine());
                Console.WriteLine($"El área del círculo es: {CalcularAreaCirculo(radioCirculo)}");
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}
