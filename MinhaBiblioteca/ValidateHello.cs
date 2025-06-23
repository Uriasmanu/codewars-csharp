using System;
using System.Collections.Generic;

public class Kata
{
    public static bool ValidateHello(string greetings)
    {
        // Lista de sauda��es (todas em min�sculas para compara��o case insensitive)
        var greetingsList = new HashSet<string>
        {
            "hello",    // english
            "ciao",     // italian
            "salut",    // french
            "hallo",   // german
            "hola",     // spanish
            "ahoj",    // czech republic
            "czesc"     // polish
        };

        // Converter a string de entrada para min�sculas para compara��o case insensitive
        string lowerGreetings = greetings.ToLower();

        // Verificar se alguma das sauda��es est� contida na string
        foreach (string greeting in greetingsList)
        {
            if (lowerGreetings.Contains(greeting))
            {
                return true;
            }
        }

        return false;
    }
}