﻿using MonApp;

Console.WriteLine("Bienvenue dans FizzBuzz, à votre tour, entrez soit un chiffre soit 'fizz' soit 'buzz' en respectant les règles du jeu FizzBuzz");
var input = Console.ReadLine();
var fb = new FizzBuzz(1);
if(fb.IsValidInput(input))
{
    Console.WriteLine("Correct, tour suivant !");
}
else
{
    Console.WriteLine("Incorrect, c'est perdu");
}
