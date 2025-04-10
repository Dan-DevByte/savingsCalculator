using System;
using System;

Console.WriteLine("=== Savings Calculator ===");

Console.Write("Enter the total amount you have: $");
double totalAmount = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the percentage you want to save: ");
double savePercentage = Convert.ToDouble(Console.ReadLine());

// 🔧 Use your SavingsCalculator class
savingsCalculator calc = new savingsCalculator();

double saved = calc.CalculateSavings(totalAmount, savePercentage);
double remaining = calc.CalculateRemaining(totalAmount, savePercentage);

Console.WriteLine($"\nYou chose to save {savePercentage}% of ${totalAmount:0.00}");
Console.WriteLine($"Saved amount: ${saved:0.00}");
Console.WriteLine($"Remaining amount: ${remaining:0.00}");

Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();
