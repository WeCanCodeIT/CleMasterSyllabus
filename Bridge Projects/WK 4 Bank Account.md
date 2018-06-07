
# Bank Account OOP 

## Overview

In this assignment, you will be tasked with building a Bank Account. 

## Prerequisites
- OOP
- Inheritance
- Methods
- Basic C# principles

### Required Tasks

- [ ] Set Up VS project. The project MUST contain the following classes
	- Account (Abstract Base Class)
	- Checking (Derived from Account)
	- Saving (Derived from Account)
	- Client 
	- Program 

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
	- [ ] The application must add interest to the checking and savings account balances efter every user interation.
		- [ ] The interest rates applied to each account must be differant.

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

- [ ] All user interaction must be performed in the Program class. Only data must be shared between classes and the program class.
### Copyright &copy; 2017, We Can Code IT, LLC. All rights reserved.
