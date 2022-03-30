# C# & .NET
This repository stores the C# & .NET projects I completed while progressing through the Tech Academy's cirriculum, beginning with the fundamentals and their "Daily Report" project, then continuing into a deep dive of topics covering Branching, Loops, Strings, & Arrays, Exception Handling, Abstract Classes, Inheritance, Polymorphism, Debugging, Lambda Expressions, and finally, an updated Portfolio project.
  - All created using C# 7.0 (or newer)

## Projects:
 - [x] [Daily Report project](Daily%20Report/Program.cs)
 - [x] [Math/Comparision Console App](Math%20and%20Comparision%20Operator%20Console%20App/Program.cs)
 - [x] [Boolean Logic ("Insurance Approval")](Boolean%20Logic%20(Project%20-%20Insurance%20Approval)/Program.cs)
 - [x] [Branching ("Price-Quote App")](Branching%20Price%20Quote%20App/Program.cs)
 - [x] [Loops/Strings/Arrays ("Console App Pt.1-6")](Console%20App%20Pt1/Program.cs)
 - [x] [Exception Handling ("Console App/Strings & Integers")](Exception%20Handling%20(Console%20App-Strings%20%2B%20Integers)/Program.cs)
 - [x] [Method Fundamentals](Method%20Submission/Program.cs)
 - [x] [Inheritance ("Methods & Objects")](Inheritance/Program.cs)
 - [x] [Abstract Classes](Abstract%20Class/Person.cs)
 - [x] [Polymorphism](Polymorphism/Employee.cs)
 - [x] [Debugging ("Operators Submission")](Debugging/Program.cs)
 - [x] [Parsing Enums](Parsing%20Enums/Program.cs)
 - [x] [Lambda Expressions](Lambda%20Expressions/Program.cs)
 - [x] [Date/Time](DateTime%20Submission%20Assignment/Program.cs)
 - [x] [Constructors](Constructor%20Submission/Business.cs)
 - [x] [ASP.Net MVC Entity Framework ("Car Insurance App")](CarInsurance/Controllers/InsureeController.cs)
 - [x] [Final Challenge](FinalChallengeSubmission/Program.cs)
 - [x] [Portfolio](https://douglasforeman.me)

### Daily Report Project:
A replica of the daily standup form used by The Tech Academy to gauge its students' progresses & roadblocks:
- An introduction to WriteLine() & ReadLine()
  - Conversions: string data type -> int & bool

### Math/Comparision Console App:
A usable Human Resources-type console app for comparing different salaries:
- Collects string data provided by users
  - Conversions: string data type -> decimal
- Annual Salary comparision is made; result is assigned to boolean's T/F answer

### Boolean Logic ("Insurance Approval"):
A functioning Auto Insurance console app to help determine eligibility:
- Collects string data from required questions
  - Conversions: string -> int & bool
- Boolean logic is applied across multiple combined conditions

### Branching ("Price Quote App"):
A workable Logistics console app to calculate shipping costs:
- Collects string data from required questions
  - If outside parameters, relevant error messages will display before program auto-exits
- If within parameters, product's volume x weight ÷ 100 == desired price quote
  -  Conversions: string -> int

### Loops/Strings/Arrays ("Console App Pt.1-6"):
Examples of working with loops:
- Part 1: Concatenates User's text to each index of an array & prints the results on a new line
- Part 2: *Purposely* creates an infinite loop (switch Lines 31 & 32)
- Part 3: Examples of less than (<) & greater than (>) loops
- Part 4: Checks each index of a list for a User's guessed word (singular or plural):
  - If correct, displays index of User's guess
  - If incorrect, displays an error message
- Part 5: Checks each index of a list for *duplicates* of User's guessed word:
  - If found, the index is added to an empty list & a counter is incremented by 1
  - A switch compares guesses found at single & multiple indexes:
  - Single guesses display one index
  - Multiple guesses display both indexes
  - The default advises of no matches
- Part 6: Displays how many times duplicate words occur within a given list:
  -  Loops through the 1st list, adding each word (and its index) to a 2nd list
  -  Declares & initializes a counter of how many times 1st list's words are found within the 2nd list
  -  Loops through 2nd list, incrementing counter by 1 for each duplicate
  -  Displays the duplicates and how many times they occur in the 1st list

### Exception Handling ("Console App/Strings & Integers"):
An exercise in handling exceptions when dividing dividends by a User-chosen divisor:
  - If User attempts dividing by zero, try/catch block throws appropriate error message
  - If User enters the divisor as a word, try/catch block throws appropriate error message
  - All other exceptions are caught & displayed
  - Conversions: string -> int

### Method Fundamentals:
A typical case for instantiating new classes: 
  - Logic applied to two User-submitted numbers
    -  Two nested try/catch blocks handle any exceptions with *either* User-submitted number
  - Conversions: string -> int

### Inheritance ("Methods & Objects"):
An example of a class inheriting from another class:
  - Class *Employee* inherits from base class *Person*
  - *Employee* class is instantiated & a new object is initalized (with values)

### Abstract Classes:
An exercise in working with abstract classes:
  - Abstract modifier is used on *Person* class, making it the base class of other classes
    - *Person* class can't be used to create objects; must be inherited from another class instead

### Polymorphism:
A case of overriding a method's base implementation:
  - Class *Person* has a virtual method
    - SayName() is implementable only by overriding it (Person.cs, Line 17)
  - Class *Employee* implements SayName() by overriding it (Line 11)

### Debugging ("Operators Submission"):
A workable Human Resources-type console app that determines if any employee Ids are duplicates:
  - Employee objects are created, each with an Id property
  - A comparision is made among the Ids, displaying all matches or any mismatches

### Parsing Enums:
An example of parsing values:
  - User's input is parsed into a newly-created datatype

### Lambda Expressions:
Using lambda expressions in lieu of foreach loops:
  - An employee list is created
  - Commented-out "foreach loops" show the conciseness of lambda expressions
    - A specific name is searched for; employees with that name are added to a new list
    - An Id range is searched for; employees matching the range are added to a new list

### Date/Time:
A useful app that utilizes C#'s date/time feature:
  - Displays current date/time
    - Advances current time by a User-chosen number
    - try/catch block alerts when non-int values are entered
  - Conversions: string -> int

### Constructors:
A typical case of using Constructors to create an object:
  - An object's constructor & its three parameters are defined
  - The object's second constructor inherits from its first constructor
    - Two parameters are assigned default values

### ASP.Net MVC Entity Framework ("Car Insurance App"):
A MVC application that supplies a custom price quote based on User-submitted data:
  - Conditional statements evaluate single (Lines 78 & 82), dual (Line 67), & *triple* (Lines 64 & 71) scenarios
  - Conversions: string -> int (using int.Parse)

### Final Challenge:
A Code-First school-related app that creates a basic student database, then adds one student:
  - The *Student* class is populated with seven properties
  - The *Grade* class is populated with three properties
