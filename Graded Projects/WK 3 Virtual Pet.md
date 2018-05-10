# Virtual Pet
## Due:
### [Submission Link](https://docs.google.com/forms/d/e/1FAIpQLScUEvl_ZgH_OgBu0zbg_WIvB6zBSkkXh7wfxqjv4LwLdBDxLg/viewform)

## Overview
As a junior developer, you are being tasked with developing a console application for an interactive, game-like virtual pet program (i.e. your version of a Tamagotchi or DigiPet). The user must be able to select different tasks or activities from a menu.

## Skills Required
In order to deliver this application solution, you will need the following skills and knowledge.
-  Loops
-  Arrays
-  Methods
-  Principles of OOP
-  Defining Classes
-  Creating Classes and Access Modifiers

## Tasks

### Project Prerequisites

After you have completed all coding and testing of your application, you will ensure the product owner has access to the application by ensuring the following:
- [ ] Correct GitHub link is properly submitted.
- [ ] GitHub repository created from correct folder and contains solution file.

### Application Logic Requirements, Part 1

During application development process, the following application logic requirements were identified.
- [ ] The application MUST have a VirtualPet class.
  - [ ] The VirtualPet class MUST have at least 3 fields.
  - [ ] The VirtualPet class MUST have at least 3 properties.
  - [ ] The VirtualPet class MUST have at least 3 methods.
  - [ ] The VirtualPet class MUST have a `Tick` method.
  - [ ] The VirtualPet class MUST have at least 1 constructor.
- [ ] The application MUST have a Program class.
  - [ ] The Program class MUST have the `Main` method.
    - [ ] The Program class MUST implement a method called `Tick`. The `Tick()` method will update any properties or call time-based methods. The idea behind this method is that every time the menu is shown or some user interaction occurs, you could call the `Tick()` method to cause properties to update. You may want to have some of the properties update randomly to make the virtual pet less predictable.

### User Interface Requirements, Part 1

During application development process, the following user interface (UI) requirements were identified.

- [ ] The Program class MUST contain an interactive user interface (see example at bottom of page).
  - [ ] The Program class MUST display the current status of pet.
  - [ ] The Program class MUST display options for interacting with pet.
  - [ ] The Program class MUST ask user what action to take.
  - [ ] The user's selection MUST trigger an action.

### Application Logic Requirements, Part 2

During application development process, the following application logic requirements were identified.
- [ ] The below are ideas for things that a virtual pet COULD have (along with some ideas for activities that might address them):
  - [ ] Hunger (Feed it)
  - [ ] Thirst (Water it)
  - [ ] Waste (Let it out to the bathroom)
  - [ ] Boredom (Play with it)
  - [ ] Sickness (Take it to the doctor)

- [ ] Your methods MUST cause the appropriate properties to update - for instance, if you have a `Feed()` method, it might make `Hunger` go down, but make `Thirst` go up.

- [ ] Other properties that COULD update when `Tick` is called:
  - [ ] Boredom increasing
  - [ ] Hunger increasing
  - [ ] Sleepiness increasing (e.g. playing with pet COULD increase sleepiness)

### User Interface Requirements, Part 2

During application development process, the following user interface (UI) requirements were identified.
We're using a Console interface for now, so it will likely involve some sort of loop and a menu showing possible actions, as well as indicating the state of the pet. You'll have to decide when to call the `Tick` method - if you want it to `Tick` every time the menu is shown, or for a stretch task you could explore using a separate thread to have `Tick`s occur automatically every second.

- [ ] Your UI MUST live in the `Main` method of the `Program` class. You MUST also have a `VirtualPet` class in a separate file.

An example user interface is below (yours need not match):

```
Horace the Hippo
Hunger: 27
Thirst: 5
Boredom: 5
Tiredness: 50

What do you want to do?
1. Feed Horace
2. Water Horace
3. Play with Horace
4. Put Horace to sleep
5. Do nothing

> 1

You fed Horace.
```

## Stretch Tasks

During application development process, the following application logic requirements were identified. These requirements are not mandatory and are in no way a requirement for delivering the application.
- [ ] The application COULD give the pet the ability to take care of some of its own needs.
  - [ ] When `Tick` is called, you COULD have your pet take a look at its needs and possibly address one. You COULD use a random number generator to have it do things randomly, or prioritize things based upon what need is highest. You COULD also make your pet uncooperative - when the user tries to feed the pet, for example, you might make the pet refuse to eat.

- [ ] The application COULD create a visual representation of the pet.
- [ ] Rather than using numbers to convey your pet's status, you COULD have some sort of visual representation of the pet, e.g. instead of printing `hunger: 50`, you could use smileys or [ASCII art](https://en.wikipedia.org/wiki/ASCII_art) to show hunger when `hunger >= 50`.

```
     >=<        
,.--'  ''-.
(  )  ',_.'
Xx'xX      

Horace looks like this: :0

1. Feed Horace
2. Water Horace
3. Play with Horace
4. Put Horace to sleep
5. Do nothing
```

- [ ] The application COULD call `Tick` in a separate thread.
  - [ ] Consider exploring threads - you COULD have `Tick` occur every second, rather than waiting for user input.

- [ ] The application COULD function in alternative interfaces.
  - [ ] Your `VirtualPet` class COULD be usable with a completely different interface, such as a web page or a phone app. You might want to explore how you could use it elsewhere.

## Hints
Don't try to tackle everything at once! Break this project up into smaller chunks, and you will find that they are all manageable.

First, decide what "features" you want to incorporate. You might be tempted to make this a long list - start small! Think MVP!

Next, design a class for the pet. Think of what properties/methods you will need to have for your MVP. Methods might involve things that happen when a person interacts with the pet.

More features `!=` better - pick a focus/theme for your pet.
### Copyright &copy; 2017, We Can Code IT, LLC. All rights reserved.