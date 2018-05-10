# Virtual Pet Shelter
## Due: Monday 2/12/18 at 9:30AM
### [Submission Link](https://docs.google.com/forms/d/e/1FAIpQLScUEvl_ZgH_OgBu0zbg_WIvB6zBSkkXh7wfxqjv4LwLdBDxLg/viewform)

## Overview
As a junior developer, you are being tasked with developing an application to share your experience in the care and feeding of a virtual pet with the community. The application will simulate employees taking care of the pets in a shelter.

## Skills Required
In order to deliver this application solution, you will need the following skills and knowledge.
-  Loops
-  Lists
-  Methods
-  Principles of OOP
-  Defining Classes
-  Creating Classes and Access Modifiers
-  Inheritance and Polymorphism

## Tasks

### Project Prerequisites

After you have completed all coding and testing of your application, you will ensure the product owner has access to the application by ensuring the following:
- [ ] Correct GitHub link is properly submitted.
- [ ] GitHub repository created from correct folder and contains solution file.

### Application Logic Requirements, Part 1

During application development process, the following application logic requirements were identified.
- [ ] Create a C# project in Visual Studio named `VPShelter`.

- Create the following classes:
	- [ ] The application MUST contain a `VirtualPet` class (you can start with your class from last week's assignment or create another).
	- [ ] The application MUST contain a class that is derived and has `VirtualPet` as its base class.
		- [ ] The derived class MUST contain Fields/Properties for the type of pet and the pet's diet.
	- [ ] The application MUST contain a `VirtualPetShelter` class: Homeless virtual pets need a place to stay.
		- [ ] The `VirtualPetShelter` class MUST contain Fields/Properties to store all of the pets and all of the employees.
	- [ ] The application MUST contain an `Employee` base class.
		- [ ] The `Employee` class MUST contain one property (e.g. EmployeeID).
		- [ ] The `Employee` class MUST contain two abstract methods.
	- [ ] The application MUST contain a `Volunteer` class derived from `Employee`.
		- [ ] The `Volunteer` class MUST contain an override method.
		- [ ] The `Volunteer` class MUST contain an additional property.
		- [ ] The `Volunteer` class MUST contain a method for feeding all of the pets.
		- [ ] The `Volunteer` class MUST contain a method for giving water to all of the pets.
	- [ ] The application MUST contain a `Manager` class derived from `Employee`.
		- [ ] The `Manager` class MUST contain an override method.
		- [ ] The `Manager` class MUST contain an additional property.
		- [ ] The `Manager` class MUST contain a method for adopting a pet.
- [ ] The `Program` class MUST house your `Main` method, and be responsible for reading user input and writing output to the console.

- [ ] The application MUST also include a game loop in this project. It should prompt the user, then call the appropriate method(s) on any of the required classes.

### User Interface Requirements, Part 1

During application development process, the following user interface (UI) requirements were identified.

#### Program class

- The `Main` method MUST have a program that…
	- [ ] asks for user input.
	- [ ] writes output to the console.

- Available user interface actions MUST include (at minimum)…
	- [ ] `Volunteer` feeding all the pets 
	- [ ] `Volunteer` watering all the pets 
	- [ ] `Volunteer` or `Manager` playing with an individual pet
	- [ ] `Manager` to coordinate adoption of a pet, which should display a list of pet names and descriptions, allowing a user to select one

#### NOTE:

The following examples are _GUIDELINES ONLY_, you can customize your user interface as you see fit as long as you meet all of the above requirements.

#### Example Employee Set Up

```bash
Welcome to Big Al's Virtual Pet Shelter. What employee type are you?
1. Manager
2. Volunteer
```
#### Example Interactions

For volunteer:

```bash
Thank you for volunteering at Big Al's Virtual Pet Shelter!

This is the status of your pets:

Name	|Hunger	|Thirst	|Boredom
--------|-------|-------|-------
Joey	|83     |34     |23
Johnny	|69     |49     |2
Dee Dee	|39     |18     |88
Tommy	|59     |19     |37

What would you like to do next?

1. Feed the pets
2. Water the pets
3. Play with a pet
4. Quit
```
For manager:

```bash
Thank you for working at Big Al's Virtual Pet Shelter!

What would you like to do?
1. Adopt a pet
2. Feed the pets
3. Play with a pet
4. Pay the bills
5. Quit
```

#### Example Pet Selection Interaction

```bash
Ok, so you'd like to play with a pet. Please choose one:

For [Joey] type 1
For [Johnny] type 2
For [Dee Dee] type 3
For [Tommy] type 4

Which pet would you like to play with?

4

Ok, you played with Tommy.
```

### Application Logic Requirements, Part 2

During application development process, the following application logic requirements were identified.

#### VirtualPetShelter class

- [ ] The `VirtualPetShelter` class MUST include the appropriate instance variable(s) (fields/properties) to store the pets who reside at the shelter.
- [ ] The `VirtualPetShelter` class MUST include the appropriate instance variable(s) (fields/properties) to store all of the employees who volunteer or work at the shelter.
- *HINT:* Don't overthink this class. You might not instantiate an object from this class in your program. This class allows us to see your ability to appropriately use Lists.

#### VirtualPet class
	
For this week's VirtualPet, you can keep the class from last week's project and add the following, or create a new class with the following: 
- [ ] The `VirtualPet` class MUST include instance variables (fields/Properties) representing:
	- [ ] name
	- [ ] description
- [ ] The `VirtualPet` class MUST include a constructor that accepts a name and description only
- [ ] The `VirtualPet` class MUST include a constructor that, in addition to name and description, accepts starting values for the pet's attributes (hunger, boredom, etc).

Remember that it is OK to have more than one constructor. This will be called an **overloaded** constructor

#### Class derived from VirtualPet

- The dervied class MUST include instance variables (fields/properties) representing:
	- [ ] type of pet
	- [ ] pet's specific diet

#### Employee Classes
- [ ] The `Employee` base class MUST include:
		- [ ] One property (perhaps EmployeeID).
		- [ ] Two abstract methods (for example, `ClockIn()` or `ShowID()`).
	- [ ] The `Volunteer` class derived from `Employee` MUST include:
		- [ ] An override method (How does a Volunteer do one of the Employee methods differently?).
		- [ ] An additional property (for example HoursAvailable, VolunteerType, or VolunteerSpecialty).
		- [ ] A method for feeding all of the pets. (*HINT:* Don't overthink this. It can return a status of "All pets have been fed.")
		- [ ] A method for giving water to all of the pets (see above hint).
	- [ ] The `Manager` class derived from `Employee` MUST include:
		- [ ] An override method (How does a Manager do one of the Employee methods differently?).
		- [ ] An additional property (for example, Salary, YearsEmployed, or Department).
		- [ ] A method for adopting a pet.

## Stretch Tasks

During application development process, the following application logic requirements were identified. These requirements are not mandatory and are in no way a requirement for delivering the application.
- [ ] Consider any stretch tasks from last week's project that you did not attempt.
- [ ] The application COULD keep track of the cleanliness of individual pets' cages and offer an option in the user interface to clean pet cages.

## Hints
- Break this project down into smaller parts. Start with your VirtualPet class and then create your derived "type of pet" class before starting the new stuff.
- There is a lot of creativity allowed in this project. Focus on meeting the requirements first, then add some personality. Keep in mind you will not be graded on your stylistic choices: *you will be graded on whether or not you met the requirements.*
- Review the _BankAccount_ project, the _Lists_ slides, and the _Inheritance and Polymorphism_ slides as preparation for this project.