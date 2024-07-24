using System;

class Option
{
    private readonly int momo_pin = 1234;
    private readonly double account_balance = 978.87;
    private int tries = 1;
    private int amount_tries = 1;
    private long first_number;
    private long last_number;
    private double amount;
    private int menu_tries = 1;
    private int pin_retries = 1;
    private int first_num_retries = 1;
    private int first_num_retries_ = 1;
    private int transfer_decision = 0;
    private readonly string[] first_names = ["Stephen",
        "Williams",
        "Ruth",
        "Amofa",
        "Elton",
        "Mary",
        "Raphael",
        "Faustina",
        "Emmanuel",
        "Dennis",
        "Kelvin",
        "Jaden",
        "Frednard",
        "Peters",
        "Mohammed",
        "Benedict",
        "Buckman",
        "Yvette",
        "Dorcas",
        "Collins",
        "Dregen",
        "Jessica",
        "Martha",
        "Stanley",
        "Haizel",
        "Frank",
        "Geoffrey",
        "Daniel",
        "Justice",
        "Christoper",
        "Constance",
        "Bright",
        "Mills",
        "Evans",
        "Azizu",
        "Isaac",
        "Ibrahim",
        "James",
        "Benjamin",
        "Loretta",
        "Felicia",
        "Justina",
        "Gifty"
    ];
    private readonly string[] last_names = ["Okyere",
        "Yamoah",
        "Kyeremeh",
        "Boakye",
        "Boateng",
        "Osei",
        "Asamoah",
        "Addai",
        "Sarkodie",
        "Twumasi",
        "Agyapong",
        "Sablah",
        "Appiah",
        "Manu",
        "Antwi",
        "Boadu",
        "Ayeyi",
        "Obeng",
        "Anning",
        "Elliot",
        "Amponsah",
        "Nyarko",
        "Arhin",
        "Gyan",
        "Frimpong",
        "Oppong",
        "Adjei",
        "Mensah",
    ];
    public string check_balance_input = "\nFee is GHS 0.00.\nEnter MM PIN";
    private int get_input;


    // This method prints the My Wallet menu to the user and asks the returns an integer
    public int MyWallet (int option)
    {
        string[] options = ["Check Balance", "Allow Cashout", "My Approvals", "Report Fraud", "Statements", "Change & Reset Pin", "Reversals"];
        Console.WriteLine("\nMy Wallet");
        for (int i = 0; i < options.Length; i++)
        {
            int j = i +1;
            Console.WriteLine($"{j}. {options[i]}");
        }
        try
        {
            int take_input = Convert.ToInt32(Console.ReadLine());
            get_input = take_input;
        }
        catch (Exception)
        {
            Console.WriteLine("Sorry, Wrong Input");
        }
        
        return get_input;
    }


    // This method checks the account balance for the user
    public void BalanceEnquiry()
    {
        Console.WriteLine(check_balance_input);
        while (tries < 4)
        {
            try
            {
                while (tries < 4)
                {
                    int pin = Convert.ToInt32(Console.ReadLine());
                    if (Convert.ToString(pin).Length == 4)
                    {
                        if (pin == momo_pin)
                        {
                            Console.WriteLine($"\nCurrent Balance: GHS {account_balance}. \nAvailable Balance: GHS {account_balance}");
                            tries = 1;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nIncorrect Mobile Money PIN");
                            break;
                        }
                    }

                    else
                    {
                        if (tries != 3)
                        {
                            Console.WriteLine("\nInvalid PIN code length. Enter 4 digit PIN");
                        }
                        else
                        {
                            Console.WriteLine("\nThe maximum amount of allowed retries has been exceeded");
                            Environment.Exit(0);
                        }
                    }
                    tries++;
                }
                break;

            }

            catch (Exception)
            {
                if (tries != 3)
                {
                    Console.WriteLine("\nInvalid PIN code. Enter 4 digit PIN");
                }
                else
                {
                    Console.WriteLine("\nThe maximum amount of allowed retries has been exceeded");
                    Environment.Exit(0);
                }

            }
            tries++;
        }
    }

    // Asking the user to enter the number of the recipient and check for errors as well. 
    public int FirstNumInput()
    {
        Console.WriteLine("Enter mobile number");
        int option = 0;
        while (first_num_retries < 4)
        {
            string first_ask = Console.ReadLine();

            if (first_ask.Length == 10)
            {
                try
                {
                    int num1 = Convert.ToInt32(first_ask);
                    option = num1;
                    first_number = num1;
                    SecondNumInput();
                    tries = 1;
                    break;
                }
                catch (Exception)
                {
                    if (first_num_retries != 3)
                    {
                        Console.WriteLine("\nInvalid mobile number. Please try again.");
                        tries++;
                    } 
                    else
                    {
                        Console.WriteLine("\nThe maximum amount of allowed retries has been exceeded");
                        Environment.Exit(0);
                        break;
                    }
                    
                }
                break;
            }
            else
            {
                if (first_num_retries != 3)
                {
                    Console.WriteLine("\nInvalid mobile number. Please try again.");
                }
                else
                {
                    Console.WriteLine("\nThe maximum amount of allowed retries has been exceeded");
                    Environment.Exit(0);
                }
                
                first_num_retries++;
            }
        }
        return option;
    }


    // Checking and the confirming if the second number is the same as the first number and has no errors
    public int SecondNumInput()
    {
        Console.WriteLine("\nConfirm number");
        int option = 0;
        while (tries < 4)
        {
            string first_ask = Console.ReadLine();

            if (first_ask.Length == 10)
                                                                             {
                try
                {
                    int num2 = Convert.ToInt32(first_ask);
                    option = num2;
                    last_number = num2;
                    if (first_number == last_number)
                    {
                        Console.WriteLine("\nEnter Amount");
                        tries = 1;
                        AmountEnter();
                        
                    }
                    else
                    {
                        Console.WriteLine("\nNumber Mismatch");
                    }
                    break;


                }
                catch (Exception)
                {
                    if (tries != 3)
                    {
                        Console.WriteLine("\nInvalid mobile number. Please try again.");
                        // SecondNumInput();
                        tries++;
                    }
                    else
                    {
                        Console.WriteLine("\nThe maximum amount of allowed retries has been exceeded");
                        Environment.Exit(0);
                        break;
                    }

                }
                break;
            }
            else
            {
                if (tries != 3)
                {
                    Console.WriteLine("\nInvalid mobile number. Please try again.");
                }
                else
                {
                    Console.WriteLine("\nThe maximum amount of allowed retries has been exceeded");
                    Environment.Exit(0);
                    break;
                }

                tries++;
            }
        }
        return option;
    }


    // Validating the amount the user wants to send
    public double AmountEnter()
    {
        while (amount_tries < 4)
        {
            try
            {
                double ask = Convert.ToDouble(Console.ReadLine());
                double amount_entered = ask;
                amount = amount_entered;
                if (amount_entered < account_balance)
                {
                    ConfirmTransaction();
                }
                else
                {
                    Console.WriteLine("\nNot enough funds to perform this transaction");
                }
                break;
            }

            catch (Exception)
            {
                if (amount_tries != 3)
                {
                    Console.WriteLine("\nInvalid amount. Please try again.");
                    // SecondNumInput();
                    //tries++;
                }
                else
                {
                    Console.WriteLine("\nThe maximum amount of allowed retries has been exceeded");
                    break;
                }
                amount_tries++;
            }
        }
        return amount;
        
    }


    // Confirming the Momo to Momo User transaction
    public void ConfirmTransaction()
    {
        var random = new Random();
        string first_name = first_names[random.Next(0, first_names.Length)];
        string last_name = last_names[random.Next(0, last_names.Length)];

        Console.WriteLine("\nEnter Reference");
        string reference = Console.ReadLine();
        double balance_left = account_balance - amount;

        // Generating the Transaction ID
        long trans_Id = random.NextInt64();
        string real_Id = Convert.ToString(trans_Id);
        string transaction_id = real_Id[..11];
        Console.WriteLine("\nEnter MM PIN");

        while (pin_retries < 4)
        {
            try
            {
                while (pin_retries < 4)
                {
                    int pin = Convert.ToInt32(Console.ReadLine());
                    if (Convert.ToString(pin).Length == 4)
                    {
                        if (pin == momo_pin)
                        {
                            Console.WriteLine($"\nPayment made for GHS {amount} to {first_name} {last_name}. " +
                            $"\nCurrent Balance: GHS {account_balance - amount}. Available Balance: GHS {account_balance - amount}. Reference: {reference}. " +
                            $"\nTransaction ID: {transaction_id}.");
                            break;
                            //Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("\nIncorrect Mobile Money PIN");
                            Environment.Exit(0);
                            break;
                        }
                    }

                    else
                    {
                        if (pin_retries != 3)
                        {
                            Console.WriteLine("\nInvalid PIN code length. Enter 4 digit PIN");
                            pin_retries++;
                        }
                        else
                        {
                            Console.WriteLine("\nThe maximum amount of allowed retries has been exceeded");
                            Environment.Exit(0);
                        }
                    }
                    tries++;
                }
                break;

            }

            catch (Exception)
            {
                if (pin_retries != 3)
                {
                    Console.WriteLine("Invalid PIN code. Enter 4 digit PIN");
                }
                else
                {
                    Console.WriteLine("The maximum amount of allowed retries has been exceeded");
                    Environment.Exit(0);
                }

            }
            tries++;
        }
    }


    public void CashOut ()
    {
        Console.WriteLine("\nAllow Cash Out \n1. Yes \n2. No \n0. Back");
        while (tries < 4)
        {
            string ask_input = Console.ReadLine();
            if (ask_input == "1")
            {
                Console.WriteLine("\nCash out is allowed");
                break;
            }
            else if (ask_input == "2")
            {
                Console.WriteLine("\nCash out is not allowed");
                break;
            }
            else if (ask_input == "0")
            {
                break;
            }
            else
            {
                Console.WriteLine("\nIncorrect choice, try again. ");
                Console.WriteLine("Allow Cash Out \n1. Yes \n2. No \n0. Back");
            }
        }
    }

    public void Transfer ()
    {
        string[] items = ["AitelTigo", "Vodafone", "Bank Accounts"];
        Console.WriteLine("\nTransfer Money");
        for (int i = 0; i < items.Length; i++)
        {
            int j = i + 1;
            Console.WriteLine($"{j}. {items[i]}");
        }
        
        while (menu_tries < 4)
        {
            while (menu_tries < 4)
            {
                string ask_input = Console.ReadLine();
                if (ask_input == "1")
                {
                    Console.WriteLine("\n");
                    AirtelTigo();
                    break;
                }
                else if (ask_input == "2")
                {
                    Console.WriteLine("\n");
                    Vodafone();
                    break;
                }
                else if (ask_input == "3")
                {
                    BankTransfer();
                    break;
                }
                else
                {
                    if (menu_tries != 3)
                    {
                        Console.WriteLine("\nIncorrect choice, try again");
                        Console.WriteLine("Transfer Money");
                        for (int i = 0; i < items.Length; i++)
                        {
                            int j = i + 1;
                            Console.WriteLine($"{j}. {items[i]}");
                        }
                        menu_tries++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nThe maximum amount of allowed entries has been exceeded.");
                        Environment.Exit(0);
                        break;
                    }
                }
            }
            
            
        }
        
        
        
    }


    public void Vodafone()
    {
        FirstNumInput();
    }

    public void AirtelTigo ()
    {
        FirstNumInput();
    }

    public void BankTransfer()
    {
        Console.WriteLine("\nChoose Bank");
        string[] items = ["STANCHART", "ABSA", "GCB", "FIDELITY", "ADB", "UMB", "REPUBLIC", "ZENITH", "CAL BANK", "PRUDENTIAL"];
        for (var i = 0; i < items.Length; i++)
        {
            int j = i + 1;
            Console.WriteLine($"{j}. {items[i]}");
        }

        while (tries < 4)
        {
            try
            {
                while (tries < 4)
                {
                    string ask_input = Console.ReadLine();
                    if (Convert.ToInt32(ask_input) >= 1 && Convert.ToInt32(ask_input) <= items.Length)
                    {
                        BankAccountNumber1();
                        //Console.WriteLine("\nEnter amount");
                        //AmountEnter();
                        break;
                    }
                    else
                    {
                        if (tries != 3)
                        {
                            Console.WriteLine("\nIncorrect choice, try again");
                            for (var i = 0; i < items.Length; i++)
                            {
                                int j = i + 1;
                                Console.WriteLine($"{j}. {items[i]}");
                            }
                            tries++;
                        }
                        else
                        {
                            Console.WriteLine("\nThe maximum amount of allowed entries have been exceeded.");
                            Environment.Exit(0);
                        }
                    }
                    break;
                }
                
            }
            catch (Exception)
            {
                if(tries != 3)
                {
                    Console.WriteLine("\nInvalid choice, try again");
                    for (var i = 0; i < items.Length; i++)
                    {
                        int j = i + 1;
                        Console.WriteLine($"{j}. {items[i]}");
                    }
                    tries++;
                }
                else
                {
                    Console.WriteLine("\nThe maximum amount of allowed entries have been exceeded.");
                    break;
                }
            }
        }
        



    }

    public int BankAccountNumber1()
    {
        Console.WriteLine("\nEnter account number");
        long option = 0;
        while (first_num_retries < 4)
        {
            string first_ask = Console.ReadLine();

            if (first_ask.Length > 10)
            {
                try
                {
                    long num1 = Convert.ToInt64(first_ask);
                    option = num1;
                    first_number = (int)num1;
                    BankAccountNumber2();
                    break;
                }
                catch (Exception)
                {
                    if (first_num_retries != 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("\nInvalid account number. Please try again.");
                        tries++;
                    }
                    else
                    {
                        Console.WriteLine("\nThe maximum amount of allowed retries has been exceeded");
                        break;
                    }

                }
                break;
            }
            else
            {
                if (first_num_retries != 3)
                {
                    Console.WriteLine("\nInvalid account number. Please try again.");
                }
                else
                {
                    Console.WriteLine("\nThe maximum amount of allowed retries has been exceeded");
                }

                first_num_retries++;
            }
        }
        return (int)option;
    }




    public int BankAccountNumber2()
    {
        Console.WriteLine("\nConfirm account number");
        long option = 0;
        while (first_num_retries_ < 4)
        {
            string first_ask = Console.ReadLine();

            if (first_ask.Length > 10)
            {
                try
                {
                    long num2 = Convert.ToInt64(first_ask);
                    option = num2;
                    last_number = (int)num2;
                    if (first_number == last_number)
                    {
                        Console.WriteLine("\nEnter Amount");
                        AmountEnter();

                    }
                    else
                    {
                        Console.WriteLine("\nAccount Number Mismatch");
                    }
                    break;


                }
                catch (Exception)
                {
                    if (first_num_retries_ != 3)
                    {
                        Console.WriteLine("\nInvalid account number. Please try again.");
                        // SecondNumInput();
                        tries++;
                    }
                    else
                    {
                        Console.WriteLine("\nThe maximum amount of allowed retries has been exceeded");
                        break;
                    }

                }
                break;
            }
            else
            {
                if (first_num_retries_ != 3)
                {
                    Console.WriteLine("\nIncorrect account number. Please try again.");
                }
                else
                {
                    Console.WriteLine("\nThe maximum amount of allowed retries has been exceeded");
                }

                first_num_retries_++;
            }
        }
        return (int)option;
    }
}