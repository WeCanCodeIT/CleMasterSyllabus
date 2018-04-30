# Fortune Teller TDD

## Due Date:
### Submission Link:

## Overview

We're going to recreate the core logic of the FortuneTeller application using Test Driven Development.

We're not going to bother with all of the user input, we'll just create a Method that calculates the user's
fortune.

## Get Started

Let's create our projects, add NUnit, and get the 

1.  Create a new solution and select `Class Library (.NET Framework)` for the project type, and set the name of the project to "FortuneTellerTDD".
2.  Add another Project to the solution, select `Class Library (.NET Framework)` for the project type, and set the name of the project to "FortuneTellerTDD.Tests".
3. In the *Tests* project, add the `NUnit3` Nuget Package.
4. In the *Tests* project, add a reference to the *FortuneTellerTDD* project.  Do this by right clicking "References" in the *Tests* project, and checking the box next to the *FortuneTellerTDD* project.  This allows the *Tests* project to use code that's in the other project.

## What are we building?

We're going to create a class that can, given some input, calculate a user's fortune.  Let's call that class a `FortuneCalculator`.

Our `FortuneCalculator` will have a single method, called `Calculate`, that returns an instance of a `Fortune`.

The `Fortune` class will include properties like `YearsUntilRetirement`, and `VacationHomeType`.

## Business Logic

If the user's Age is an odd number, they will retire in 10 years.
If the user's Age is an even number, they will retire in 20 years.


### Example Unit Test

```csharp
[TestFixture]
public class FortuneCalculatorTests 
{
    [Test]
    public void Odd_Current_Age_Causes_RetireIn_10_years()
    {
        FortuneCalculator calculator = new FortuneCalculator();
        FortuneInput input = new FortuneInput()
        {
            Age = 13
        };

        Fortune fortune = calculator.Calculate(input);

        Assert.That(fortune.RetireIn, Is.EqualTo(10));
    }
}
```

### Stretch Tasks

1.  Override the `ToString` method on your `Fortune` class so that it builds your fortune text.  You should Test Drive this functionality.
2.  Add a `Console Application` project to your solution, and wire up your `FortuneCalculator` class to make
a functioning Fortune Teller application, similar to what you've built previously. Test driving user input and output on
the command line is pretty tricky, so you can skip it for now.