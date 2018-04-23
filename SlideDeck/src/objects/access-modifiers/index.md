title: Access Modifiers
subtitle: Now you see me, now you don't
theme: league

## Goals
- What are access modifiers?
- How do they work? What do we use them for?

## Description

- Access modifiers are the way we control where our member can be viewed. We can use them in front of classes, fields, methods and properties.

- In C# we have 4 access modifiers
    - `public` - can be accessed from every class
    - `private` - can not be accessed from any other class (default for elements of a class)
    - `protected` - can be accessed from its class and all descendent classes
    - `internal` - can only be accessed from the same assembly (default for classes)

!SLIDE
    
- `public` means any part of our program can access and change a variable. This means _the door is wide open_. It should only be used where appropriate. 
- Classes, properties, and methods are often `public`. 
- Fields are not usually set to `public`, when they are it means any line in our program can change the value, leading to unintended consequences.

!SLIDE

- `private` means the only code in that class can access that member. 
- From outside the the class it anything set to `private` will appear not to exist at all. 
- This allows us to hide the internal details. 

!SLIDE

- `protected` means only the class itself, and any derived(child) classes can reference a member. 
- This is useful in situations where a variable should not be set to public, but child classes may need to reference the member.

## Examples

Boat class, up to the Default constructor 
```csharp
class Boat
{
    public int numberOfPassengers;

    private string name;
    private double engineSize;

    public string Name
    {
        get {return name;}
        set { name = value;}
    }


    public Boat()
    {

    }
```
!SLIDE 

Boat class continued, methods section.

```csharp
    public void Move()
    {
        //code to make the boat move
    }

    private double CalculateMPG()
    {
        //code to calculate the MPG
        return MPG;
    }
}

```

!SLIDE 

- Classes, constructors, and properties are always set as `public`, with very few exceptions. 
- Fields are nearly always set to `private` or `protected`. 
- Methods will be set to public or private depending on their functionality
- Take some time and discuss which access modifiers are appropriate in different situations.

## Practice
Work in pairs. On paper or in a word processor:
 - Create a class cell phone and determine the 
    - 3 fields
    - 2 properties
    - 4 methods

- For each of the members you created determine whether it should be public or private.

<style type="text/css">
/* should we move this into the template, or will it break existing slides. Maybe those slides are wrong. */
.reveal h3 {
	font-size: 4.4rem;	
}
</style>

