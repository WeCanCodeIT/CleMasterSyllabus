# Lucky Numbers
## Due: Monday, January 29, 2018 By 9:30 AM
### - [GitHub Submission Link](https://docs.google.com/forms/d/e/1FAIpQLScUEvl_ZgH_OgBu0zbg_WIvB6zBSkkXh7wfxqjv4LwLdBDxLg/viewform)
  - Correct GitHub link must be submitted on time, or the project will be considered late/not submitted.
  - GitHub repository must be created from correct folder and contain solution file, or the project will be considered late/not submitted.

## Overview
- As a junior developer, you are being tasked to develop a console application that will be a lucky numbers guessing game similar to the lottery.
- The user will choose a range of numbers and then try to guess all 6 of the numbers that will be randomly generated within the range.
- The user will win a portion of the jackpot based on the number of numbers guessed correctly.

## Skills Required
In order to deliver this application solution, you will need the following skills and knowledge.
-  Variables and Basic Types
-  Operators and Expressions
-  Conditionals
-  Loops
-  Arrays
-  Math Random (not to be graded)

## Tasks

### Project Prerequisites

After you have completed all coding and testing of your application, you will ensure the product owner has access to the application by ensuring the following:
- [ ] Correct GitHub link is properly submitted.
- [ ] GitHub repository created from correct folder and contains solution file.

###  User Interface Requirements, Part 1

During application development process, the following user interface (UI) requirements were identified. 
- [ ] The application MUST ask the user for a starting number.
	- [ ] The application MUST set this number as the lowest number in the number range.
- [ ] The application must ask the user for an ending number.
	- [ ] The application MUST set this number as the highest number in the number range.
- [ ] The application MUST ask the user to input 6 numbers the user thinks will match the lucky numbers generated within the number range.
    - [ ] The application MUST save the 6 user inputted numbers utilizing an array data structure.
    - [ ] The Application MUST use a loop to populate the required array.
- [ ] The application MUST validate that each of the 6 numbers entered by the user are within the set range.
	- [ ] The application MUST prompt the user to input a valid number until the number(s) entered are valid.

### Application Logic Requirements

During application development process, the following application logic requirements were identified. 
- [ ] The application MUST randomly generate 6 numbers using a loop.
- [ ] The application MUST save randomly generated numbers utilizing an array data structure.
	- [ ] The application MUST use a loop to populate the required array.
- [ ] The application MUST display the random numbers to the console using a loop.
- [ ] The application MUST be displayed in the following format: (Numbers below are for example only.)
  ```
  Lucky Number: 12
  Lucky Number: 47
  Lucky Number: 28
  Lucky Number: 3
  Lucky Number: 19
  Lucky Number: 35
  ```
  
### Application Logic Requirements

During application development process, the following application logic requirements were identified. 
- [ ] The application MUST provide a hard-coded value for the jackpot amount.
	- [ ] The applilcation MUST present the jackpot amount to the user.
	- [ ] As the junior developer, the product owner has given you flexibility to decide when and how to meet this requirement.
- [ ] The application MUST count the number of correctly guessed numbers.
	- [ ] The application MUST output to the console to notify the user.
	- [ ] As the junior developer, the product owner has given you flexibility to decide when and how to meet this requirement.
	- [ ] The statement below is an example of the desired output:
 
```
  You guessed 3 numbers correctly!
```

- [ ] The application MUST calculate the user's winnings based on the number of numbers guessed correctly.
	- [ ] You cannot hard code the user winnings. Example would be winnings = jackpot/correctGuessed 
- [ ] The application MUST display the user's winnings to the console.
	- [ ] As the junior developer, the product owner has given you flexibility to decide when and how to meet this requirement.
	- [ ] The statement below is an example of the desired output:
 
 ``` 
  You won $256,877.23!
 ``` 
  
###  User Interface Requirements, Part 2

During application development process, the following user interface (UI) requirements were identified. 
- [ ] The application MUST provide the user the opportunity to play the game again.
	- [ ] If the user says yes, the application MUST execute the program from the beginning.
	- [ ] All of the values must reset as if the application was being executed for the first time. 
	- [ ] If the user says no, the application MUST display the following statement exactly as written below before exiting:

```	
Thanks for playing! 
```

## Stretch Tasks:

During application development process, the following application logic requirements were identified. These requirements are not mandatory and are in no way a requirement for delivering the application.
- [ ] The application COULD ensure none of the generated numbers are repeated. 
- [ ] The following is an example of valid output: 
  
  ```
  Lucky Number: 12
  Lucky Number: 47
  Lucky Number: 28
  Lucky Number: 3
  Lucky Number: 19
  Lucky Number: 35
  ```

- [ ] The following is an example of invalid output:
  
  ```
  Lucky Number: 12
  Lucky Number: 47
  Lucky Number: 28
  Lucky Number: 3
  Lucky Number: 19
  Lucky Number: 12
  ```

- [ ] The application COULD replace a duplicate number with a new number.
- [ ] The appplication COULD repeat this process until there are no duplicate numbers.