using System;
using Proyecto1; // Asegúrate de que el namespace coincida con AudioAnalyzer

class Program
{
    static void Main(string[] args)
    {
        try
        {
            using var audioAnalyzer = new AudioAnalyzer();
            audioAnalyzer.Load("musica/musica.mp3");
            Console.WriteLine("Archivo cargado con éxito.");

            string opcion = "";
            do
            {
                Console.WriteLine("\n¿Qué deseas hacer?");
                Console.WriteLine("1. Reproducir");
                Console.WriteLine("2. Pausar");
                Console.WriteLine("3. Detener");
                Console.WriteLine("4. Ver amplitudes (FFT)");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        audioAnalyzer.Play();
                        Console.WriteLine("Reproduciendo...");
                        break;
                    case "2":
                        audioAnalyzer.Pause();
                        Console.WriteLine("Pausado.");
                        break;
                    case "3":
                        audioAnalyzer.Stop();
                        Console.WriteLine("Detenido.");
                        break;
                    case "4":
                        var amplitudes = audioAnalyzer.GetAmplitudes();
                        Console.WriteLine("Amplitudes:");
                        for (int i = 0; i < amplitudes.Length; i++)
                        {
                            Console.WriteLine($"Banda {i + 1}: {amplitudes[i]:0.000}");
                        }
                        break;
                    case "0":
                        audioAnalyzer.Stop();
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != "0");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al cargar el archivo de audio: {ex.Message}");
        }
    }
}
