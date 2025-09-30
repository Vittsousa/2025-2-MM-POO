// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

CultureInfo.CurrentCulture = new CultureInfo("en-GB");

Cartao cartaoBase = new Cartao();
cartaoBase.Debitar(100);