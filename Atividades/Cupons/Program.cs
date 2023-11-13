using System;
using System.Collections.Generic;

HashSet<int> usedCoupons = new HashSet<int>();

while (true)
{
    Console.WriteLine("Digite o número do cupom: ");
    string? couponString = Console.ReadLine();
    if (int.TryParse(couponString, out int coupon))
    {
        if (usedCoupons.Contains(coupon))
        {
            Console.WriteLine("This has already been used.");
        }
        else
        {
            usedCoupons.Add(coupon);
            Console.WriteLine("First time coupon.");
        }
    }
    else
        break;
}

Console.WriteLine("List of coupons:");
foreach (int c in usedCoupons)
{
    Console.WriteLine($"{c}");
}