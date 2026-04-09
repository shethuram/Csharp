using System;
using System.IO;

class Program
{
    static void Main()
    {
        // File paths (can be relative or absolute)
        string inputPath = "input.txt";
        string outputPath = "output.txt";

        try
        {
            // Check if file exists before reading
            if (!File.Exists(inputPath))
            {
                Console.WriteLine("Input file not found.");
                return;
            }

            // Read entire file content
            string text = File.ReadAllText(inputPath);

            // Count lines
            string[] lines = File.ReadAllLines(inputPath);
            int lineCount = lines.Length;

            // Count words (handling spaces, newlines, tabs)
            string[] words = text.Split(
                new char[] { ' ', '\n', '\t' , '\r' },
                StringSplitOptions.RemoveEmptyEntries
            );
            
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }


            int wordCount = words.Length;

            // Prepare result content
            string result =
                "File Analysis Result\n" +
                "---------------------\n" +
                $"Total Lines: {lineCount}\n" +
                $"Total Words: {wordCount}\n";

            // Write result to output file (overwrites if exists)
            File.WriteAllText(outputPath, result);

            Console.WriteLine("Processing completed successfully.");
            Console.WriteLine("Results written to output.txt");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: Access denied.");
        }
        catch (IOException)
        {
            Console.WriteLine("Error: File operation failed.");
        }
        catch (Exception ex)
        {
            // General fallback for unexpected errors
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }
}