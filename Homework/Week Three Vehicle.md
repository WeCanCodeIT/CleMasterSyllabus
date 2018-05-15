
# Vehicle OOP

## Overview

In this assignment, you will be tasked with building a base vehicle class. You MUST use TDD to accomplish this assignment. 
There MUST be a test for every item in your Vehicle class.

## Submission

You must submit a screen shot showing your sucessful tests. When you take your screen shot you will put your name and date as shown in the following example

![Submission Screen Shot](Submissionexample.png)

## Prerequisites
- OOP
- TDD
- Unit Testing
- Methods
- Basic C# principles

### Required Tasks

- [ ] Set Up VS project. The project MUST contain the following classes
	- Vehicle
	- VehicleTests

        
- [ ] The VehicleTests class must have the following tests
	- public void Create_Veh_CTR_1_Input()
		- This will test the instantiation of the Vehicles class with one value parameter.
		- This test MUST use a constructor to take in the string "Ford" and return the same.
	- public void Create_Veh_CTR_2_Input()
		- This will test the instantiation of the Vehicles class with two value parameters.
		- This test MUST use a constructor to take in the string "Ford" and "Bronco" and return "Bronco".
	- public void Create_Veh_CTR_3_Input()
		- This will test the instantiation of the Vehicles class with three value parameters.
		- This test MUST use a constructor to take in the string "Ford", "Bronco" and "1965" and return "1965".
	- public void Set_Engine_Size()
		- This will test the function of the EngineSize property.
		- This test MUST set the EngineSize property with the value 5.0 and return the same.
	- public void Set_Rim_Size()
		- This will test the function of the RimSize property.
		- This test MUST set the RimSize property with the value 16 and return the same.
	- public void Set_Veh_Color()
		- This will test the function of the VehColor property.
		- This test MUST set the VehColor property with the value "Red" and return the same.
	- public void Get_MPH()
		- This will test the function of the GetMPH method.
		- This test MUST take in the following values as paramenter: time = 7 min and distance = 1 mile.
		- This test MUST return the following: 9 MPH.
	- public void Get_MPG()
		- This will test the function of the GetMPG method.
		- This test MUST take in the following values as paramenter: startODO = 3579, endOdo = 3117, TankSize = 9251.
		- This test MUST return the following: 49.94 MPG.

- [ ] The Vehicle class MUST contain the following properties, constructors, and methods
	- string Model
    - string Make
    - string Year 
    - double EngSize
    - int RimSize
    - string Color

- [ ] The Vehicle class MUST contain the following constructors:
	- public Vehicles()
    - public Vehicles(string make)
    - public Vehicles(string make, string model)
    - public Vehicles(string make, string model, string year)

- [ ] The Vehicle class MUST contain the following methods:
    - public int GetMph(double distance, double time)
    - public int GetMpg(double endOdo, double startOdo, double tankSize)

### Hints

- You will need to look up the conversions for MPG and MPH.

- You will need to use C# functions like math.round.

### Copyright &copy; 2017, We Can Code IT, LLC. All rights reserved.
