using System;

int retries = 1;
Console.WriteLine("Your Pin is 1234");
Console.WriteLine("Welcome Back");
Console.WriteLine("Please select an option");
string[] main_vendors = ["Balance Enquiry", "Deposit", "Withdrawal", "Transfer"];
for (int i = 0; i < main_vendors.Length; i++)
{
    int j = i + 1;
    Console.WriteLine($"{j}. {main_vendors[i]}");
}


while (retries < 4)
{
    string vendor_choose = Console.ReadLine();
    Option mtn = new();

    if (vendor_choose == "1")
    {
        mtn.BalanceEnquiry();
        break;
    }
    else if (vendor_choose == "2")
    {
        Console.WriteLine("\nMTN to MTN money deposit");
        mtn.FirstNumInput();
        break;
    }
    else if (vendor_choose == "3")
    {
        mtn.CashOut();
        break;
    }
    else if (vendor_choose == "4")
    {
        //mtn.TransferMenu();
        mtn.Transfer();
        break;
    }
    else if (vendor_choose == "0")
    {
        Environment.Exit(0);
        break;
    }
    else
    {
        if (retries != 3)
        {
            Console.WriteLine("\nIncorrect choice, try again");
            Console.WriteLine("Please select an option");
            string[] vendors = ["Balance Enquiry", "Deposit", "Withdrawal", "Transfer"];
            for (int i = 0; i < main_vendors.Length; i++)
            {
                int j = i + 1;
                Console.WriteLine($"{j}. {main_vendors[i]}");
            }
            //retries++;
        }
        else
        {
            Console.WriteLine("\nThe amount of maximum allowed entries have been exceeded");
            Environment.Exit(0);
        }
    }
}


