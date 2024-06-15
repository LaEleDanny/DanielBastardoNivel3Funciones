class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido al analizador de texto!");
        Console.Write("Por favor, ingresa un texto: ");
        string texto = Console.ReadLine();

        int cantidadPalabras = ContarPalabras(texto);
        int cantidadVocales = ContarVocales(texto);
        string textoInvertido = InvertirTexto(texto);

        Console.WriteLine($"Número de palabras: {cantidadPalabras}");
        Console.WriteLine($"Número de vocales: {cantidadVocales}");
        Console.WriteLine($"Texto invertido: {textoInvertido}");
    }

    static int ContarPalabras(string texto)
    {
        string[] palabras = texto.Split(' ');
        return palabras.Length;
    }

    static int ContarVocales(string texto)
    {
        texto = texto.ToLower();
        int contadorVocales = 0;

        foreach (char caracter in texto)
        {
            if ("aeiouáéíóú".Contains(caracter))
            {
                contadorVocales++;
            }
        }

        return contadorVocales;
    }

    static string InvertirTexto(string texto)
    {
        char[] caracteres = texto.ToCharArray();
        Array.Reverse(caracteres);
        return new string(caracteres);
    }
}

