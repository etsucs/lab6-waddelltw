/**       
 *--------------------------------------------------------------------
 * 	   File name: Homework6 (Or Lab 6)
 * 	Project name: Lab 6 
 *--------------------------------------------------------------------
 * Author’s name and email:	Tyler Waddell : waddelltw@etsu.edu				
 *          Course-Section: CSCI-1250-001
 *           Creation Date:	3/23/2022		
 * -------------------------------------------------------------------
 */

// Method 1

// This section of the program asks the user to enter a word. ONce the user does this it is stored in the 'word' variable.
// Then the program asks the user to enter a number to pick what letter they want to see. This is stored in the 'position' variable.
// Next, the program calls the ShowCharacter method. This method displays the letter the user wanted to see. Then, this part ends with an empty line.

Console.Write("Please enter a word: ");

string word = Console.ReadLine();

Console.Write("What number position of the word would you like to see. (Enter an integer) ");

int position = Convert.ToInt32(Console.ReadLine());

ShowCharacter(word, position);

Console.WriteLine("");

// Method #2

// This section calculates the retail price for an item. First, the program asks the user to enter an item's wholesale cost. Once the user does this, it is stored in the 'price' variable.
// Then, the program asks the user to enter that item's markup percentage. That value is stored in the 'percentage' variable.
// Next, the program calls the CalculateRetail method. This method will return the retail price in the 'retailPrice' variable.
// Finally, the program prints out the item's retail price. Also, this section ends with an empty line for spacing.

Console.Write("Please enter the item's wholesale cost: $");

double price = Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter that item's markup percentage: ");

double percentage = Convert.ToDouble(Console.ReadLine());

double retailPrice = CalculateRetail(price, percentage);

Console.WriteLine($"That item's retail price is ${Math.Round(retailPrice,2)}.");

Console.WriteLine("");

// Method 3 

// This section of the program converts fahrenheit to celsius, from the numbers 80 to 100. It starts by initializing the 'celcius' variable.
// The program then says that it will display a table of temperaature from 80 to 100. These values will be converted to celsius.
// Next, a for loop will start. It will begin at 80 and end as soon as 100 has been converted an displayed as celsius.
// In this loop, the Celsius method is called. This method has the variable 'fahrenheit' as an agruement. This method will return a value back to the 'celsius variable.
// Then, a table of temperatures is displayed. This section ends with an empty line.

double celsius;

Console.WriteLine("Here is a table of temperatures from 80 to 100 in fahrenheit and celsius.");

Console.WriteLine("Fahrenheit | Celcius");

Console.WriteLine("---------------------");

for (int fahrenheit = 80; fahrenheit <= 100 ; fahrenheit ++)
{
    celsius = Celsius(fahrenheit);

    Console.WriteLine($"    {fahrenheit}     |   {Math.Round(celsius,2)}");
}

Console.WriteLine("");

// Method #4

// This section will determine if an entered number is a prime number or not. First, the program asks the user to enter an integer.
// Once the user does this, that number is stored in the 'number' variable.  Next, the IsPrime method is called. 'number' is passed as an arguement. This will return a value back to the 'boolean' variable with the bool data type.
// After the method has reutrned a value, an if statement is started. If 'boolean' is true, the program will say that number is a prime number.
// If not, the program will say that it is not a prime number.

Console.Write("Please enter an integer. ");

int number = Convert.ToInt32(Console.ReadLine());

bool boolean = IsPrime(number);

if(boolean == true)
{
    Console.WriteLine("That is a Prime Number!");
}

else
{
    Console.WriteLine("That is not a Prime Number!");
}


// This section is for Method #1:

// This passes on the the variables used in method #1 as 'word' and 'position'. This method has an if - else if- else statement.
// If the numbered entered is greater than the number of words, the program says that that position in that word doesn't exist.
// If the user entered a 0 or negative number, the program says that the user entered an invalid position.
// If neither of these are the case, the program gives the letter the user wanted to see.

static void ShowCharacter(string word, int position)
{
    if (position > word.Length)
    {
        Console.WriteLine("The position you are looking for doesn't exist.");
    }
    else if(position <= 0)
    {
        Console.WriteLine("You entered an invalid position.");
    }
    else
    {
        Console.WriteLine(word[position-1]);
    }
    
}

// This section is for Method #2:

// This takes the variables 'price' and 'percentage' from section 2. 
// This performs a calculation to get the retail price and returns it to the 'retailPrice' variable.

static double CalculateRetail(double price, double percentage)
{
    return price + (price * (percentage/100));
}

// This section is for Method #3:

// This takes the variable 'fahrenheit' from section 3. This converts fahrenheit to celsius. 
// Once that is done, that value is returned back to the 'celsius' variable.

static double Celsius(int fahrenheit)
{
    return ((5.0/9.0) * (fahrenheit-32.0));  
}

// This section is for Method #4:

// This takes the 'number' variable from section 4. This determines whether a number is prime or not. 
// First, the 'divisors' variable is intiatlized. Next, a for loop is started. This loop tests to see how many divisors a number has by dividing that number by 1 and going up to the number itself. 
// If the number divided by something has a remained of 0, then the 'divisors' variable goes up by 1.
// Once the for loop is done, an if statement is stared. 
// If the number of divisors is equal to 2, then the value 'true' is returned to the 'boolean' variable.
// If not, then the value of 'false' is returned back.

static bool IsPrime(int number)
{
    int divisors = 0;

    for(int x = 1; x<=number; x++)
    {
        if(number % x == 0)
        {
            divisors++;
        }
    }
    if(divisors == 2)
    {
        return true;
    }
    else
    {
        return false; 
    }

}



