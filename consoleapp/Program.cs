﻿using Humanizer;
using System;

Console.WriteLine("Por favor ingrese un nombre:");
var nombre = Console.ReadLine();
Console.WriteLine("Por favor ingrese su cargo:");
var cargo = Console.ReadLine();
Console.WriteLine("Por favor ingrese su edad:");
var edad = int.Parse(Console.ReadLine());

Console.WriteLine($"Hola, mi nombre es {nombre}, mi cargo es {cargo} y tengo {edad.ToWords(new System.Globalization.CultureInfo("es"))} años.");