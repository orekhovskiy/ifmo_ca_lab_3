﻿using System;
using System.Collections.Generic;

using ifmo_ca_lab_3.Lexical;

namespace ifmo_ca_lab_3
{
    class Program
    {
        static string str = "add(pow(1, x), 2)";

        // Список найденных лексером токенов
        static List<Token> Tokens = new List<Token>();

        static void Main()
        {
            NormalizeString(ref str);
            Console.WriteLine(Lexer.Tokenize(str, ref Tokens));
            Console.WriteLine(Parser.Validate(Tokens));
        }

        static void NormalizeString(ref string str)
        {
            str = str.ToLower().Replace(" ", String.Empty);
        }
    }
}
