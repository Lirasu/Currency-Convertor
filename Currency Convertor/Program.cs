using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;

namespace currencyConvertor
{
    public static class Program
    {

        class Conversion
        {
            public Conversion(double beforeConversion, double afterConversion)
            {
                BeforeConversion = beforeConversion;
                AfterConverion = afterConversion;
            }

            public double BeforeConversion { get; set; }
            public double AfterConverion { get; set; }
        }

        public static void CurrencyConversion()
        {

        }
        public static void Main(string[] args)
        {
            // Réglages de couleurs de la console
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // Définir les valeurs par rapport a l'USD
            double EUR = 0.95;
            double GBP = 0.81;
            double JPY = 130.47;
            double RUB = 66.43;
            double CAD = 1.29;
            double CNY = 6.67;
            double KRW = 1271.14;

            // Demander le menu a l'utilisateur
            Console.WriteLine("=======================");
            Console.WriteLine("Veuillez selectionner votre menu : ");
            Console.WriteLine("1 : Afficher la liste des monnaies ");
            Console.WriteLine("2 : Utiliser la calculatrice de conversion");
            Console.WriteLine("=======================");
            int optionSelection = Convert.ToInt32(Console.ReadLine());

            // Execution du prgramme suivant le choix de l'utilisateur
            if (optionSelection == 1)
            {
                Console.Clear();

                // Instanciation du dictionnaire des monnaies
                IDictionary<string, string> Countries = new Dictionary<string, string>();
                Countries.Add("USD", "Dollar Américain");
                Countries.Add("EUR", "Euro");
                Countries.Add("GBP", "Penny Anglais");
                Countries.Add("JPY", "Yen Japonais");
                Countries.Add("RUB", "Rouble Russe");
                Countries.Add("CAD", "Dollar Canadien");
                Countries.Add("CNY", "Yen Chinois");
                Countries.Add("KRW", "Won Corréen");

                Console.WriteLine("=======================");

                // Affichage des valeurs du dictionnaire
                foreach (KeyValuePair<string, string> kvp in Countries)
                {
                    Console.WriteLine("Acronyme : {0}, Devise: {1}", kvp.Key, kvp.Value);
                }

                // Menu de séléction 
                Console.WriteLine("");
                Console.WriteLine("Entrer : Fermer la console");
                Console.WriteLine("Espace : Aller a la calculatrice de conversion");
                Console.WriteLine("=======================");

                while (Console.ReadKey().Key != ConsoleKey.Enter || Console.ReadKey().Key != ConsoleKey.Spacebar)
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 2);
                    Console.WriteLine("Appuyez sur entrer pour fermer la console");
                    Console.WriteLine("Appuyez sur espace pour aller a la calculatrice de conversion");
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Environment.Exit(0);
                    }
                }
            }
            else if (optionSelection == 2)
            {
                Console.Clear();

                // Demander les informations a l'utilisateur
                Console.WriteLine("=======================");
                Console.WriteLine("Bienvenue dans le convertisseur de monnaie v1.0 by Lyras");
                Console.WriteLine("Veuillez indiquer le montant a convertir : ");
                double parseToConvert = Convert.ToDouble(Console.ReadLine());
                double baseCurrency = parseToConvert;

                Console.WriteLine("Veuillez indiquer votre monnaie de base : (USD,EUR,GBP,JPY,RUB,CAD,CNY,KRW)");
                string currency = Console.ReadLine();

                Console.WriteLine("Veuillez indiquer la monnaie vers laquelle vous voulez convertir : (USD,EUR,GBP,JPY,RUB,CAD,CNY,KRW)");
                string finalCurrency = Console.ReadLine();

                // Convertir la monnaie en USD en fonction de l'entrée
                switch (currency)
                {
                    case "USD":
                        break;

                    case "EUR":
                        parseToConvert /= EUR;
                        break;

                    case "GBP":
                        parseToConvert /= GBP;
                        break;

                    case "JPY":
                        parseToConvert /= JPY;
                        break;

                    case "RUB":
                        parseToConvert /= RUB;
                        break;

                    case "CAD":
                        parseToConvert /= CAD;
                        break;

                    case "CNY":
                        parseToConvert /= CNY;
                        break;

                    case "KRW":
                        parseToConvert /= KRW;
                        break;

                    default:
                        throw new ArgumentOutOfRangeException("Monnaie invalide, veuillez en selectionner une parmi la liste.");
                }

                // Conversion finale de la monnaie
                switch (finalCurrency)
                {
                    case "USD":
                        break;

                    case "EUR":
                        parseToConvert *= EUR;
                        break;

                    case "GBP":
                        parseToConvert *= GBP;
                        break;

                    case "JPY":
                        parseToConvert *= JPY;
                        break;

                    case "RUB":
                        parseToConvert *= RUB;
                        break;

                    case "CAD":
                        parseToConvert *= CAD;
                        break;

                    case "CNY":
                        parseToConvert *= CNY;
                        break;

                    case "KRW":
                        parseToConvert *= KRW;
                        break;

                    default:
                        throw new ArgumentOutOfRangeException("Monnaie invalide, veuillez en séléctionner une parmis la liste."); break;
                }
                // Affichage du résultat de la conversion
                Console.WriteLine("Résultat de votre conversion :");
                Console.WriteLine("" + baseCurrency + " " + currency + " to " + finalCurrency + " = " + parseToConvert + "" + finalCurrency + "");
                Console.WriteLine("=======================");
                Console.WriteLine("Appuyez sur une entrer pour fermer la console");
                Console.ReadKey();
                while(Console.ReadKey().Key != ConsoleKey.Enter)
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.WriteLine("Appuyez sur une entrer pour fermer la console");
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Environment.Exit(0);
            } else
            {
                Console.WriteLine("Saisie Inccorecte, fermeture de la console.");
                Environment.Exit(0);
            }
        }
    }
}
