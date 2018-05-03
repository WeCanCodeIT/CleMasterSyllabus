
# Travel OOP

## Overview

In this assignment, you will be tasked with building a Destination class which is derived from a Travel base class. You MUST use TDD to accomplish this assignment. 
There MUST be a test for every item in your Travel class. You MUST test your derived Destination class.

## Submission

You must submit a screen shot showing your sucessful tests. When you take your screen shot you will put your name and date as shown in the following example

![Submission Screen Shot](Submissionexample2.png)

## Prerequisites
- OOP
- Inheritance
- TDD
- Unit Testing
- Methods
- Basic C# principles

### Required Tasks

- [ ] Set Up VS project. The project MUST contain the following classes
	- Travel (Base Class)
	- Destination (Derived from Travel)
	- TravelTests

        
- [ ] The TravelTests class must have the following tests
	- public void Test_Default_CTR()
		- This will test the instantiation of the Travel class with one value parameter.
		- This test MUST use a property to take in the string "FName" and return the same.
	- public void Test_LastName_Prop()
		- This will test the instantiation of the Travel class with one value parameter.
		- This test MUST use a property to take in the string "LName" and return the same.
	- public void Test_Address_Prop()
		- This will test the instantiation of the Travel with one value parameter.
		- This test MUST use a property to take in the string " " and return the same.
	- public void Test_Address_Email()
		- This will test the instantiation of the Travel with one value parameter.
		- This test MUST use a property to take in the string " " and return the same.
	- public void Test_Date_Travel_Method()
		- This will test the function of the GetDate method.
		- This test MUST accept the following value parementer as integers 9, 8, 2018.
		- The test MUST return a value in the following string format "9/8/2018".
	- public void Test_Total_Travel_Time_Method()
		- This will test the function of the TtlTravel method.
		- This test MUST accept the following value parementer as integers 9, 13, 2018 and return the integer 5.
		- This test MUST calculate the total number of days the user will spend on vacation.
		- The method MUST use 2 arrays, Split() method, int.Parse() method, for loop, 2 if statments to perform the calculations.
		- Hint: You MUST set a var equal to "9/8/2018" and use this date for the start date.
	- public void Selection_Method()
		- This will test the function of the GetSelection method.
		- This test MUST accept the following value parementer as integer 5.
		- The test MUST return a value in the following string format "Cali"
    - public void Selection_Method_4_Georgia()
		- This will test the function of the GetSelection method.
		- This test MUST accept the following value parementer as integer 4.
		- The test MUST return a value in the following string format "Georgia".
	- public void Selection_Method_3_Florida()
		- This will test the function of the GetSelection method.
		- This test MUST accept the following value parementer as integer 3.
		- The test MUST return a value in the following string format "Florida".
	- public void Selection_Method_2_Nashville()
		- This will test the function of the GetSelection method.
		- This test MUST accept the following value parementer as integer 2.
		- The test MUST return a value in the following string format "Nashville".
	- public void Selection_Method_1_Put_in_Bay()
		- This will test the function of the GetSelection method.
		- This test MUST accept the following value parementer as integer 1.
		- The test MUST return a value in the following string format "Put in Bay".
	- public void Selection_Method_0_Stay_Home()
		- This will test the function of the GetSelection method.
		- This test MUST accept the following value parementer as integer 0.
		- The test MUST return a value in the following string format "Stay Home".
	- public void Selection_Method_Greater_Than_5()
		- This will test the function of the GetSelection method.
		- This test MUST accept the following value parementer as integer 6.
		- The test MUST return a value in the following string format "The World is Yours".
	- public void Selection_Method_Greater_Than_5_Destination()
		- This will test the instantiation of the Destination class.
		- This will test the function of the GetSelection method.
		- This test MUST accept the following value parementer as integer 6.
		- The test MUST return a value in the following string format "The World is Yours".
	- public void Selection_Method_5_Destination_TTT_Method_Input()
		- This will test the instantiation of the Destination class.
		- This will test the function of the GetSelection method.
		- This test MUST accept the following method as a parameter TtlTravel(9, 14, 2018).
		- The test MUST return a value in the following string format "The World is Yours".
	- public void Selection_Method_5_Destination_TTT_Method_Input()
		- This will test the instantiation of the Destination class.
		- This will test the function of the GetSelection method.
		- This test MUST accept the following method as a parameter TtlTravel(9, 13, 2018).
		- The test MUST return a value in the following string format "Cali".

- [ ] The Vehicle class MUST contain the following properties, constructors, and methods.
	- string FName
	- string LName
	- string Address
	- string Email
	- string DateTravel

- [ ] The Vehicle class will not contain any predefined constructors.
	

- [ ] The Vehicle class MUST contain the following methods:
    - public string GetDate(int month, int day, int year)
		- The method must instantiate a instance of the DateTime class.
		- The method must set the DateTravel property with the following string value "9/8/2018".
    - public int TtlTravel(int month, int day, int year)
		- The method MUST use 2 arrays, Split() method, int.Parse() method, for loop, 2 if statments to perform the calculations.
		- Hint: You MUST set a var equal to "9/8/2018" and use this date for the start date.
	- public virtual string GetSelection(int num)

### Hints

- You will need to become familiar with the Split() funtion.
- You will need to become familliar with the DateTime class.

### Copyright &copy; 2017, We Can Code IT, LLC. All rights reserved.
