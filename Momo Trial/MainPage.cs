class MainPage
{
    private readonly int momo_pin = 1234;
    private readonly double account_balance = 978.87;
    private int tries = 1;
    private int amount_tries = 1;
    private int first_number = 0;
    private int last_number = 0;
    private double amount = 0;
    private bool state = true;
    private readonly string[] first_names = [
        "Stephen",
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



    public MainPage()
    {
        MainCode();
    }




    public void MainCode()
    {
        Console.WriteLine("Welcome Back");

        Console.WriteLine("Please select your network carrier");
        string[] main_vendors = ["Balance Enquiry", "Deposit", "Withdrawal", "Transfer"];
        for (int i = 0; i < main_vendors.Length; i++)
        {
            int j = i + 1;
            Console.WriteLine($"{j}. {main_vendors[i]}");
        }




        int vendor_choose = Convert.ToInt32(Console.ReadLine());
        var mtn = new Option();

        if (vendor_choose == 1)
        {
            mtn.BalanceEnquiry();
        }
        else if (vendor_choose == 2)
        {
            mtn.FirstNumInput();
        }
        else if (vendor_choose == 3)
        {
            mtn.CashOut();
        }
    }




































    // This method prints the main MTN Menu to the user and returns an integer
    public int MainMenu()
    {
        int flag = 0;
        string[] menuOptions = ["My Wallet", "Transfer Money", "Allow Cashout"];
        Console.WriteLine("\nMenu");
        for (int i = 0; i < menuOptions.Length; i++)
        {
            int j = i + 1;
            Console.WriteLine($"{j}. {menuOptions[i]}");
        }
        while (state)
        {
            try
            {
                int get_input = Convert.ToInt32(Console.ReadLine());
                while (state)
                {
                    if (get_input >= 1 && get_input < menuOptions.Length)
                    {
                        flag = get_input;
                        state = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nIncorrect choice, try again");
                        for (int i = 0; i < menuOptions.Length; i++)
                        {
                            int j = i + 1;
                            Console.WriteLine($"{j}. {menuOptions[i]}");
                        }
                        int ask_again = Convert.ToInt32(Console.ReadLine());
                        flag = ask_again;
                        if (flag >= 1 && flag <= menuOptions.Length)
                        {
                            break;
                        }
                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("\nIncorrect choice, try again");
                for (int i = 0; i < menuOptions.Length; i++)
                {
                    int j = i + 1;
                    Console.WriteLine($"{j}. {menuOptions[i]}");
                }
            }
        }
        return flag;
    }



    // This method prints the My Wallet menu to the user and asks the returns an integer
    public int MyWallet(int option)
    {
        string[] options = ["Check Balance", "Allow Cashout", "My Approvals", "Report Fraud", "Statements", "Change & Reset Pin", "Reversals"];
        Console.WriteLine("\nMy Wallet");
        for (int i = 0; i < options.Length; i++)
        {
            int j = i + 1;
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


    public void CheckBalance()
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
                    Console.WriteLine("Invalid PIN code. Enter 4 digit PIN");
                }
                else
                {
                    Console.WriteLine("The maximum amount of allowed retries has been exceeded");
                }

            }
            tries++;
        }
    }


    // OPTION 2
    //##########################################################################################################################################################

    public int TransferMenu()
    {
        int option = 0;
        string[] items = ["Non Momo User", "Other Networks", "Bank Accounts"];
        Console.WriteLine("\nTransfer Money");
        for (int i = 0; i < items.Length; i++)
        {
            int j = i + 1;
            Console.WriteLine($"{j}. {items[i]}");
        }

        while (tries < 4)
        {
            try
            {
                int transfer_menu_input = Convert.ToInt32(Console.ReadLine());
                if (transfer_menu_input >= 1 && transfer_menu_input < items.Length)
                {
                    option = transfer_menu_input;
                    break;
                }

            }
            catch (Exception)
            {
                if (tries != 3)
                {
                    Console.WriteLine("\nIncorrect choice, try again.");
                    Console.WriteLine("Transfer Money");
                    for (int i = 0; i < items.Length; i++)
                    {
                        int j = i + 1;
                        Console.WriteLine($"{j}. {items[i]}");
                    }
                }
                else
                {
                    Console.WriteLine("The maximum amount of allowed retries has been exceeded");
                }
            }
            tries++;
        }

        return option;
    }



    // Asking the user to enter the number of the recipient and check for errors as well. 
    public int FirstNumInput()
    {
        Console.WriteLine("\nEnter mobile number");
        int option = 0;
        while (tries < 4)
        {
            string first_ask = Console.ReadLine();

            if (first_ask.Length == 10 && first_ask.StartsWith('0'))
            {
                try
                {
                    int num1 = Convert.ToInt32(first_ask);
                    Console.WriteLine("\nConfirm Number");
                    option = num1;
                    first_number = num1;
                    SecondNumInput();
                }
                catch (Exception)
                {
                    if (tries != 3)
                    {
                        Console.WriteLine("\nInvalid mobile number. Please try again.");
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
                if (tries != 3)
                {
                    Console.WriteLine("\nInvalid mobile number. Please try again.");
                }
                else
                {
                    Console.WriteLine("\nThe maximum amount of allowed retries has been exceeded");
                }

                tries++;
            }
        }
        return option;
    }


    // Checking and the confirming if the second number is the same as the first number and has no errors
    public int SecondNumInput()
    {
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
                    Console.WriteLine("Invalid Amount");
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
        string transaction_id = real_Id.Substring(0, 11);

        Console.WriteLine($"\nPayment made for GHS {amount} to {first_name} {last_name}. " +
            $"\nCurrent Balance: GHS {account_balance - amount}. Available Balance: GHS {account_balance - amount}. Reference: {reference}. " +
            $"\nTransaction ID: {transaction_id}. Fee charged: GHS {CalculateElevy()} TAX charged: GHS {CalculateElevy()}");
    }



    // A method to calculate the E levy charges

    public double CalculateElevy()
    {
        double tax = 0.00;
        double show = amount;

        if (amount > 100 && amount <= 2000)
        {
            double calc = show * (1 / 100);
            return calc;
        }
        else if (amount > 2000)
        {
            double fee = 20;
            return fee;
        }
        else
        {
            return tax;
        }
    }


    public void CashOut()
    {
        Console.WriteLine("\nAllow Cash Out \n1. Yes \n2. No \n0. Back");
        //Incorrect choice, try again.
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
}