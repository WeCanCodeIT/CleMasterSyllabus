# Virtual Pet Shelter
## Due: Monday 2/12/18 at 9:30AM
### [Submission Link](https://docs.google.com/forms/d/e/1FAIpQLScUEvl_ZgH_OgBu0zbg_WIvB6zBSkkXh7wfxqjv4LwLdBDxLg/viewform)

So, you have some experience under your belt in the care and feeding of a virtual pet. It's time to share that with the community! 

## Skills Required
-  Loops
-  Lists
-  Methods
-  Intro to OOP
-  Defining Classes
-  Creating Classes and Access Modifiers
-  Inheritance and Polymorphism

## Requirements

- [ ] Create a C# project in Visual Studio named `VPShelter`.
- [ ] Create a GitHub repository also named `VPShelter` and set it up so that you can push your code there from your Visual Studio project. Do this *now*. It's the least fun part, so just get it out of the way.
- Create the following classes:
	- [ ] `VirtualPet`: You can start with your class from last week's assignment or create another.
	- [ ] A class that is derived and has `VirtualPet` as its base class.
		- [ ] Fields/Properties for the type of pet and the pet's diet
	- [ ] `VirtualPetShelter`: Homeless virtual pets need a place to stay.
		- [ ] Fields/Properties to store all of the pets and all of the employees
	- [ ] `Employee` base class.
		- [ ] One property (perhaps EmployeeID)
		- [ ] Two abstract methods
	- [ ] `Volunteer` class derived from `Employee`
		- [ ] An override method
		- [ ] An additional property
		- [ ] A method for feeding all of the pets
		- [ ] A method for giving water to all of the pets
	- [ ] `Manager` class derived from `Employee`
		- [ ] An override method
		- [ ] An additional property
		- [ ] A method for adopting a pet
- Your Program class will house your `Main` method, and be responsible for reading user input and writing output to the console.

## Details

We're going to create an application that simulates employees taking care of the pets in a shelter.

Include a game loop in this project, too. It should prompt the user, then call the appropriate method(s) on any of the required classes.

### NOTE:

The following examples are _GUIDELINES ONLY_, you can customize your user interface as you see fit as long as you meet all of the above requirements.

### Example Employee Set Up

```bash
Welcome to Big Al's Virtual Pet Shelter. What employee type are you?
1. Manager
2. Volunteer
```
### Example Interactions

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

Ok, you play with Tommy.
```

## Required Tasks

### Program class

- In the `Main` method have a program that…
	- [ ] asks for user input.
	- [ ] writes output to the console.

- Available user interface actions should include (at minimum)…
	- [ ] `Volunteer` feeding all the pets 
	- [ ] `Volunteer` watering all the pets 
	- [ ] `Volunteer` or `Manager` playing with an individual pet
	- [ ] `Manager` to coordinate adoption of a pet, which should display a list of pet names and descriptions, allowing a user to select one


### VirtualPetShelter class

- [ ] include appropriate instance variable(s) (fields/Properties) to store the pets who reside at the shelter
- [ ] include appropriate instance variable(s) (fields/Properties) to store all of the employees who volunteer or work at the shelter.
- *HINT:* Don't overthink this class. You might not instantiate an object from this class in your program. This class allows us to see your ability to appropriately use Lists.

### VirtualPet class
	
For this week's VirtualPet, you can keep the class from last week's project and add the following, or create a new class with the following: 
- include instance variables (fields/Properties) representing:
	- [ ] name
	- [ ] description
- include a constructor that accepts a name and description only
- include a constructor that, in addition to name and description, accepts starting values for the pet's attributes (hunger, boredom, etc)

Remember that it is OK to have more than one constructor. This will be called an **overloaded** constructor

### Class derived from VirtualPet

- Include instance variables (fields/Properties) representing:
	- [ ] type of pet
	- [ ] pet's specific diet

### Employee Classes
- [ ] `Employee` base class.
		- [ ] One property (perhaps EmployeeID)
		- [ ] Two abstract methods (for example, ClockIn() or ShowID())
	- [ ] `Volunteer` class derived from `Employee`
		- [ ] An override method (How does a Volunteer do one of the Employee methods differently?)
		- [ ] An additional property (for example HoursAvailable, VolunteerType, or VolunteerSpecialty)
		- [ ] A method for feeding all of the pets (*HINT:* Don't overthink this. It can return a status of "All pets have been fed.")
		- [ ] A method for giving water to all of the pets (see above hint)
	- [ ] `Manager` class derived from `Employee`
		- [ ] An override method (How does a Manager do one of the Employee methods differently?)
		- [ ] An additional property (for example, Salary, YearsEmployed, or Department)
		- [ ] A method for adopting a pet

## Stretch Tasks

- [ ] Consider any stretch tasks from last week's project that you did not attempt.
- [ ] Keep track of the cleanliness of individual pets' cages and offer an option in the user interface to clean pet cages

## Hints
- Break this project down into smaller parts. Start with your VirtualPet class and then create your derived "type of pet" class before starting the new stuff.
- There is a lot of creativity allowed in this project. Focus on meeting the requirements first, then add some personality. *KEEP IN MIND you will not be graded on your stylistic choices, you will be graded on whether or not you met the requirements.*
- Review the _BankAccount_ project, the _Lists_ slides, and the _Inheritance and Polymorphism_ slides as preparation for this project.
- Have fun!!
