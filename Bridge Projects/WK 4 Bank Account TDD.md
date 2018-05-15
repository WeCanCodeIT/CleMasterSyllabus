
# Bank Account OOP TDD

## Overview

In this assignment, you will be tasked with building a Bank Account. You MUST use TDD to accomplish this assignment. 
There MUST be a test for every item in your base and derived classes class.

## Prerequisites
- OOP
- Inheritance
- TDD
- Unit Testing
- Methods
- Basic C# principles

### Required Tasks

- [ ] Set Up VS project. The project MUST contain the following classes
	- Account (Base Class)
	- Checking (Derived from Account)
	- Saving (Derived from Account)
	- Client
	- AccountTests
	- Program 

- [ ] The AccountTests class must have the following tests at a minimum
    - [ ] public void Test_Client_CTR()
		- [ ] This will test the instantiation of the Client class with three value parameters.
		- [ ] This test MUST use a constructor to take in three strings " ", " " and " " and return " ".
	- [ ] public void Test_LName_Prop()
		- [ ] This will test the instantiation of the Client class.
		- [ ] This test MUST use a property to take in the string "LName" and return the same.
	- [ ] public void Test_FName_Prop()
		- [ ] This will test the instantiation of the Client class.
		- [ ] This test MUST use a property to take in the string "FName" and return the same.
	- [ ] public void Test_LName_Prop()
		- [ ] This will test the instantiation of the Client class.
		- [ ] This test MUST use a property to take in the string "LName" and return the same.
    - [ ] public void Test_AccountNum_Prop()
		- [ ] This will test the instantiation of the Client class.
		- [ ] This test MUST use a property to take in the string "AccountNum" and return the same.
	- [ ] public void Test_Client_Menu_CTR()
		- [ ] This will test the instantiation of the Client class with three value parameters.
		- [ ] This test MUST use a constructor to take in three string "FName", "LName", "0101010" and return "Welcome FName LName.Your account number is 0101010".
	- [ ] public void Test_Account_CTR()
		- [ ] This will test the instantiation of the Account class.
		- [ ] This test MUST use a AcctBal property to take in the double 0 and return the same.
	- [ ] public void Test_Account_CTR_1_Para()
		- [ ] This will test the instantiation of the Client class with one value parameter.
		- [ ] This test MUST accept the following value parementer to take in the double AcctBal witha value of 0 and return the same.
	- [ ] public void Test_Deposit_Prop()
		- [ ] This will test the instantiation of the Account class.
		- [ ] This test MUST use a Deposit property to take in the double 0 and return the same.
	- [ ] public void Test_Withdraw_Prop()
		- [ ] This will test the instantiation of the Account class.
		- [ ] This test MUST use a Withdraw property to take in the double 0 and return the same.
    - [ ] public void Test_WithDraw_Method()
		- [ ] This will test the function of the GetWithdraw method.
		- [ ] This test MUST accept the following value parementer as double 0 and return the same.
	- [ ] public void Test_Deposit_Method()
		- [ ] This will test the function of the GetDeposit method.
		- [ ] This test MUST accept the following value parementer as double 0 and return the same.
	- [ ] public void Test_Account_Type_Prop()
		- [ ] This will test the instantiation of the Account class.
		- [ ] This test MUST use a AcctType property to take in the string " " and return the same.
	- [ ] public void Test_Checking_Account_CTR()
		- [ ] This will test the instantiation of the Account class.
		- [ ] This test MUST use a AcctBal property to take in the double 110 and return the same.
	- [ ] public void Test_Checking_Deposit_Method()
		- [ ] This will test the function of the GetDeposit method.
		- [ ] The test must set the AcctBal equal to 5.
		- [ ] This test MUST accept the following value parementer as double 110 and return 115.
	- [ ] public void Test_Checking_Withdraw_Method()
		- [ ] This will test the function of the GetWithdraw method.
		- [ ] The test must set the AcctBal equal to 200.
		- [ ] This test MUST accept the following value parementer as double 100 and return 100.
	- [ ] public void Test_Saving_Min_Balance_Prop()
		- [ ] This will test the instantiation of the Saving class.
		- [ ] This test MUST use a MinBal property to take in the double 150 and return the same.

### Details
- [ ] The program MUST include the items listed below. You can choose where to implement each method type.
	- [ ] 1 abstract method (at least)
	- [ ] 1 virtual method (at least)
	- [ ] 1 override method (at least)

- [ ] The Account, Saving and Checking class' MUST contain the following:
	- [ ] An account number
	- [ ] Balance
	- [ ] An account type (savings or checking)
	- [ ] A way to view the current balance
	- [ ] User must be able to deposit money into either account
	- [ ] User must be able to withdraw money from either account

- [ ] Along with the previous requirements, the Checking class must contain the following:
	- [ ] One constructor 

- [ ] Along with the previous requirements, the Saving Class must contain the following:
    - [ ] 1 property
    - [ ] 1 constructor

- [ ] Program Class
    - [ ] Must instantiate one client object
    - [ ] Must instantiate one checking account object
    - [ ] Must instantiate one savings account object
    - [ ] All menu options listed above must have functionality behind them
    - [ ] Program should run until user selects 'Exit'

- [ ] Client Class
	- [ ] 3 properties
	- [ ] 1 constructor
	- [ ] 1 method
	- [ ] Client information should be filled in here

### Menu Details
- [ ] You must include a functional menu that includes the following choices for the user.
```
- [ ] View Client Information
- [ ] View Account Balance
  - [ ] Checking Account Balance
  - [ ] Savings Account Balance
- [ ] Deposit Funds
  - [ ] To Checking Account
  - [ ] To Savings Account
- [ ] Withdraw Funds
  - [ ] From Checking Account
  - [ ] From Savings Account
- [ ] Exit
```
- [ ] The menu should display the options as shown in the Details section below.
- [ ] In the menu, after a user selects either View Balance, Deposit, or Withdraw, the program should then give the option of selecting which account.

- [ ] When a user launches the program the following menu should be displayed to the screen.
```
1. View Client Information
2. View Account Balance
3. Deposit Funds
4. Withdraw Funds
5. Exit
```

- [ ] If the user wants to view account balance, deposit funds, or withdraw money, the user should be prompted to select which account.
```
	1. View Client Information
	2. View Account Balance
	3. Deposit Funds
	4. Withdraw Funds
	5. Exit

	2

	a. Checking Account
	b. Savings Account
```

- [ ] Be sure the user can continue making selections from the menu until all desired transactions have been completed.
### Hints

- [ ] Persistence is not required. Meaning each time you run the program all of the values can reset.

- [ ] You can choose any starting balance to begin the program.

- [ ] Think about what data type should be used for dealing with money.
### Copyright &copy; 2017, We Can Code IT, LLC. All rights reserved.
