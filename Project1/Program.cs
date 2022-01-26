using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {

        static void Main(string[] args)
        {
            // Defining the names of the items on the menu
            const string FruitSalad = "Fruit Salad";
            const string PastaSalad = "Pasta Salad";
            const string Smoothie = "Smoothie";
            const string FruitJuice = "Fruit Juice";
            const string Cupcake = "Cupcake";
            const string Shortcake = "Shortcake";

            const double FruitSaladPrice = 9.95;
            const double PastaSaladPrice = 12.00;
            const double SmoothiePrice = 4.95;
            const double FruitJuicePrice = 3.95;
            const double CupcakePrice = 3.00;
            const double ShortcakePrice = 6.00;

            // Creating the Menu 
            Console.WriteLine("----------------MENU------------------");
            Console.WriteLine("|Menu Item: " + FruitSalad + "| Price: $" + FruitSaladPrice + "|");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("|Menu Item: " + PastaSalad + "| Price: $" + PastaSaladPrice + "  |");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("|Menu Item: " + Smoothie + "   | Price: $" + SmoothiePrice + "|");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("|Menu Item: " + FruitJuice + "| Price: $" + FruitJuicePrice + "|");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("|Menu Item: " + Cupcake + "    | Price: $" + CupcakePrice + "   |");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("|Menu Item: " + Shortcake + "  | Price: $" + ShortcakePrice + "   |");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\n-----------ENTER YOUR ORDER-----------");

            Console.WriteLine("How many Fruit Salads? -- $" + FruitSaladPrice);
            // Taking string input and converting to int 
            int FruitSaladAmount = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("How many Pasta Salads? -- $" + PastaSaladPrice);
            int PastaSaladAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many Smooties? -- $" + SmoothiePrice);
            int SmootiesAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many Fruit Juice? -- $" + FruitJuicePrice);
            int FruitJuiceAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many Cupcake? -- $" + CupcakePrice);
            int CupcakeAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many Shortcake? -- $" + ShortcakePrice);
            int ShortcakeAmount = Convert.ToInt32(Console.ReadLine());


            // Calculating the total amount for each item entered 
            double FruitSaladTotal = (FruitSaladAmount * 9.95);
            double PastaSaladTotal = (PastaSaladAmount * 12.00);
            double SmoothiesTotal = (SmootiesAmount * 4.95);
            double FruitJuiceTotal = (FruitJuiceAmount * 3.95);
            double CupcakeTotal = (CupcakeAmount * 3.00);
            double ShortcakeTotal = (ShortcakeAmount * 6.00);

            // Defining the tax amount 
            const double TaxAmount = 0.095;

            // Calculating the amount of tax per item 
            double FruitSaladTax = (FruitSaladTotal * TaxAmount);
            // Adding the tax to the price 
            double TaxedFruitSalad = (FruitSaladTotal + FruitSaladTax);

            double PastaSaladTax = (PastaSaladTotal * TaxAmount);
            double TaxedPastaSalad = (PastaSaladTotal + PastaSaladTax);

            double SmoothieTax = (SmoothiesTotal * TaxAmount);
            double TaxedSmoothie = (SmoothiesTotal + SmoothieTax);

            double FruitJuiceTax = (FruitJuiceTotal * TaxAmount); 
            double TaxedFruitJuice = (FruitJuiceTotal + FruitJuiceTax);

            double CupcakeTax = (CupcakeTotal * TaxAmount);
            double TaxedCupcake = (CupcakeTotal + CupcakeTax);

            double ShortcakeTax = (ShortcakeTotal * TaxAmount);
            double TaxedShortcake = (ShortcakeTotal + ShortcakeTax);

            // Calculating the sub total 
            double SubTotal = (FruitSaladTotal + PastaSaladTotal + SmoothiesTotal + FruitJuiceTotal + CupcakeTotal + ShortcakeTotal);
            // Calculating the tax from all the items 
            double TotalTax = (FruitSaladTax + PastaSaladTax + SmoothieTax + FruitJuiceTax + CupcakeTax + ShortcakeTax);
            // Calculating the taxed items 
            double Total = (TaxedFruitSalad + TaxedPastaSalad + TaxedSmoothie + TaxedFruitJuice + TaxedCupcake + TaxedShortcake);
            
            // Printing the sub total rounding to the second decimal
            Console.WriteLine("\nSub-Total: $" + Convert.ToDouble(Math.Round(SubTotal, 2, MidpointRounding.ToEven)).ToString("N"));
            // Printing the total tax rounding to the second decimal
            Console.WriteLine("Total Tax: $" + Convert.ToDouble(Math.Round(TotalTax, 2, MidpointRounding.ToEven)).ToString("N"));
            // Printing the total after tax rounding to the second decimal 
            Console.WriteLine("Total Price After Tax: $" + Convert.ToDouble(Math.Round(Total, 2, MidpointRounding.ToEven)).ToString("N"));

            Console.WriteLine("\nPress Enter To Exit");
            string Exit = Console.ReadLine();
        }
 

    }
}
