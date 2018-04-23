# Fortune Teller
## Due: Monday Week Two By 9:30 AM
### - [GitHub Submission Link](https://docs.google.com/forms/d/e/1FAIpQLScUEvl_ZgH_OgBu0zbg_WIvB6zBSkkXh7wfxqjv4LwLdBDxLg/viewform)

## Overview
As a Junior Developer, you are being tasked with developing a console application. When complete, the application will provide the customer with their fortune based on data they provide.

## Skills Required

In order to deliver this application solution, you will need the following skills and knowledge:
-  Variables and Basic Types
-  Operators and Expressions
-  Conditionals
-  Strings

## Tasks

### Project Prerequisites

After you have completed all coding and testing of your application, you will ensure the product owner has access to the application by ensuring the following:
- [ ] Correct GitHub link is properly submitted
- [ ] GitHub repository created from correct folder and contains solution file

### User Interface Requirements, Part 1

During application development process, the following user interface (UI) requirements were identified. 
- [ ] The application MUST ask for the user’s first name.
- [ ] The application MUST ask for the user’s last name.
- [ ] The application MUST ask for the user’s age.
- [ ] The application MUST ask for user’s birth month. 
	- [ ] The application MUST store the birth month as an 'integer'.
- [ ] The application MUST ask the user to select a favorite color from the following: Red, Orange, Yellow, Green, Blue, Indigo, Violet.
	- [ ] The application MUST represent the colors using the ROYGBIV acronym.
	- [ ] The application MUST contain a “Help” menu.
	- [ ] The 'Help' menu Must provide a list of the ROYGBIV colors.
	- [ ] The 'Help' menu MUST be accessible by the user after entering 'Help'.
- [ ] The application MUST ask for the user's number of siblings.
	- [ ] The application MUST store the number of siblings as an 'integer'.

### Application Logic Requirements

During application development process, the following application logic requirements were identified. 
- [ ] The application MUST contain logic to calculate years until retirement based on the user's age.
	- [ ] The application MUST calculate the years until retirement based on the following: even or odd years.
- [ ] The application MUST choose a vacation home based on the number of siblings.
	- [ ] The application MUST choose a vacation home based on the following criteria:
		- [ ] The application MUST choose a different vacation home for each of the following numbers of siblings: '0', '1', '2', '3'.
		- [ ] The application MUST choose one vacation home for all numbers of siblings over '3'.
		- [ ] The application MUST choose one vacation home for all numbers of siblings under '0'.
			- [ ] The application SHOULD choose a less 'desirable' vacation home for all numbers of siblings under '0'.
- [ ] The application MUST choose a different mode of transportation based on the choice of ROYGBIV color.
- [ ] The application MUST contain logic to calculate the amount of money in the bank based on the birth month.
	- [ ] The application MUST calculate the amount of money based on the following criteria:
		- [ ] The application MUST calculate a different amount of money for birth months '1 - 4'.
		- [ ] The application MUST calculate a different amount of money for birth months '5 - 8'.
		- [ ] The application MUST calculate a different amount of money for birth months '9 - 12'.
		- [ ] The application MUST choose a value of '$0.00' for birth months less than '1' or greater than '12'.
		
### User Interface Requirements, Part 2

During application development process, the following user interface (UI) requirements were identified.
- [ ] The application MUST display the user’s fortune in the following format:
  - [ ] [First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location], and a [Mode of Transportation].
- [ ] The application MUST be able to process user inputs regardless of case.
- [ ] The application MUST use string concatenation to format the user's fortune.

## Stretch Tasks:

During application development process, the following user interface (UI) requirements were identified. These requirements are not mandatory and are in no way a requirement for delivering the application.
- [ ] The application COULD give the user the ablity to exit the application when the user input is required.
- [ ] The application MUST present the following comment when the user exits: “Nobody likes a quitter...”