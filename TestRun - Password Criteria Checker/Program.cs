/** 

This purpose of this program is to have the user input a password to check it for adherenace to the criteria listed under Criteria Declaration

More criteria will be added as the program grows.

**/

// Criteria Declaration
// This space is used to declare criteria to be followed for each given password
string criteria1 = "[1] The password must be 9 to 25 digits long";
string criteria2 = "[2] The password must contain atleast 1 of the following characters : !,@,#,$,%,^,&,*,(,),-,=,_,+";
string criteria3 = "[3] The password must contain atleast 1 number character";
string criteria4 = "[4] The password must contain atleast 1 upper case letter";


// User Directons
// This space outputs to console screen, giving the user information regarding which criteria the given password will be tested against. The criteria output will be the same as the criteria 1-4 strings in the above section.
Console.WriteLine("This application will test a given Password against the following criteria \n");
Console.WriteLine(criteria1);
Console.WriteLine(criteria2);
Console.WriteLine(criteria3);   
Console.WriteLine(criteria4);   


// Request user password
// This space requests a password from the user to be tested against established criteria
Console.WriteLine("Please submit password for testing against criteria : \n");
string userPass = Console.ReadLine();

// Criteria Compliance Counter
// This space initiates variables to count the number of criteria to be adhered to (criteriaCounter), as well as the number of criteria that has been adhered to following each check (complianceCounter).
int complianceCounter = 0;
int criteriaCounter = 0;

// Compliance Checker Header
// Cosmetic output to Console
Console.WriteLine("");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("         PASSWORD CRITERIA CHECKER         ");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

// criteria1
// Begins testing of criteria1.
// Adds 1 to criteriaCounter, indicating that there is now 1 additional rule to comply to.
criteriaCounter++;

// initiates variables denoting the minimum and maximum number of characters in the given password.
int passLengthMin = 9;
int passLengthMax = 25;
// initiates an integer that measures the length of the given password.
int passLength = userPass.Length;
// intiates a boolean that confirms the length of the given password to be greater than or equal to the minimum, and less than or equal to the maximum.
bool passLengthCheck = (passLength >= passLengthMin && passLength <= passLengthMax);
// according to resulting true or false regard the last boolean check, outputs to console.
// if true, adds 1 to complianceCounter to indicate passing score within this criteria
if (passLengthCheck == true ) {
    complianceCounter++;
    Console.WriteLine(criteria1 + " : PASS");
}
else 
{ Console.WriteLine(criteria1 + " : FAIL"); }

// criteria2
// Begins testing of criteria2.
// Adds 1 to criteriaCounter, indicating that there is now 1 additional rule to comply to.
criteriaCounter++;
// initiates a boolean that confirms if any special characters exist within the given password.
bool passSpecChar = (
   userPass.Contains("!") ||
   userPass.Contains("@") ||
   userPass.Contains("#") ||
   userPass.Contains("$") ||
   userPass.Contains("%") ||
   userPass.Contains("^") ||
   userPass.Contains("&") ||
   userPass.Contains("*") ||
   userPass.Contains("(") ||
   userPass.Contains(")") ||
   userPass.Contains("-") ||
   userPass.Contains("_") ||
   userPass.Contains("=") ||
   userPass.Contains("+") ||
   userPass.Contains("[") ||
   userPass.Contains("{") ||
   userPass.Contains("]") ||
   userPass.Contains("}") ||
   userPass.Contains("\\") ||
   userPass.Contains("|"));

// according to results, outputs to console.
// if true, adds 1 to complianceCounter to indicate passing score within this criteria.
if (passSpecChar == true){
    complianceCounter++;
    Console.WriteLine(criteria2 + " : PASS");
}
else
{
    Console.WriteLine(criteria2 + " : FAIL");
}

// criteria3
// begins testing of criteria3
// Adds 1 to criteriaCounter, indicating that there is now 1 additional rule to comply to.
criteriaCounter++;
// initiates a boolean that confirms if any numerical characters are found within the given password.
bool passNumChar =
                    (
   userPass.Contains("1")
   || userPass.Contains("2")
   || userPass.Contains("3")
   || userPass.Contains("4")
   || userPass.Contains("5")
   || userPass.Contains("6")
   || userPass.Contains("7")
   || userPass.Contains("8")
   || userPass.Contains("9")
   || userPass.Contains("0")
                    );

// according to results, outputs to console.
// if true, adds 1 to complianceCounter to indicate passwing score within this criteria.

if(passNumChar = true){
    complianceCounter++;
    Console.WriteLine(criteria3 + " : PASS");
}
else{
    Console.Write(criteria3 + " : FAIL");
};


// criteria4
// Begins testing of criteria4
// Adds 1 to criteriaCounter, indicating that there is now 1 additional rule to comply to.
criteriaCounter++;
// Initiaites a boolean that confirms if any characters within the given password are uppercase
bool upperCaseCheck = userPass.Any(char.IsUpper);
// according to results, outputs to console.
// if true, adds 1 to complianceCounter to indicate passing score within this criteria.
if (upperCaseCheck == true) {
    complianceCounter++;
    Console.WriteLine(criteria4 + " : PASS");
}
else{
    Console.WriteLine(criteria4 + " : FAIL");
}


// Compliance Result Header
// Cosmetic output to Console
Console.WriteLine("");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("               R E S U L T S               ");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

// Final confirmation if all criteria met.
// Confirms that accumulated compliance points meet accumulated criteria points.
// according to results, outputs to console.
if (complianceCounter == criteriaCounter)
{
    Console.Write("SUCCESS: PASSWORD MATCHES ALL CRITERIA");
}
else
{
    Console.Write("FAILURE: PASSWORD DOES NOT MATCH ALL CRITERIA");
}

// Program End
// Cosmetic Only
Console.WriteLine("");

/* END */