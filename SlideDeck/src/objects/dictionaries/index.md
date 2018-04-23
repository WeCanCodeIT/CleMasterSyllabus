title: Dictionaries
subtitle: Pairing Keys with Values
theme: league

## Topics

- What is a dictionary?
- Structure & Syntax
- Key & Value Pairs
- Printing elements in a dictionary

## Common Properties & Methods

- `Add`
- `ContainsKey`
- `ContainsValue`
- `TryGetValue`
- `Remove`
- `Clear`
- `Key`
- `Value`
- `Count`

## Goals

- To understand and be able to use dictionaries in your code.
  - Students should know when to use a dictionary.
  - Students should be able to complete the code exercises and project.
  - Students should be able to identify a dictionary when they see one.
  - Students should be able to explain dictionaries in their own words.
  - Students should know how to print the elements of a dictionary.
  - Students should understand how and when to use the different common properties and methods for dictionaries.

## The Basics

- Think of a dictionary data structure in C# just as the dictionary you use to look up words. 
- When you need to find the definition of a term, you look up the term and the definition is paired with it.
- In C#, dictionary entries are composed of a key-value pair. In our dictionary example, if we are looking up the term "tasty", the key would be the term "tasty" and the value would be the definition, "having a marked and appetizing flavor".
- With dictionaries in C#, all keys within one dictionary must be unique, but values can be repeated.

!SLIDE

 For example, let's say we have we students, and each student has a student ID. Paired with the student's ID number is the student's full name. Which would be the key and which would be the value?

<div class="fragment">
- The key would be the student ID numbers because they cannot be repeated
</div>
<div class="fragment">
- The value would be the student's full name. Can you have students with the same full name? 
</div>
<div class="fragment">
Yes, so that's a hint that the student's full name could not be the key.
</div>

!SLIDE

<div float="right" class="img"><img src="./resources/Dictionary.jpg" /></div>

!SLIDE

- Let's try creating a dictionary for a vending machine. 
- Each vending machine has an associated code such as A4 (for the 4th item on the first row) and an item it holds, such as "Twix".
<div class="fragment">
- Which will be the key and which will be the value? How do you know?
<div>

!SLIDE

- Let's add items to our vending machine dictionary.

<pre><code class="language-C#" data-noescape>
     Dictionary<string,string>snackMachine = new Dictionary<string,string>()
     {
        {"A1", "Twix"},
        {"A2", "Twizzlers"},
        {"A3", "Hershey's"}
     };
</code></pre> 

!SLIDE

  - We can print the items in our dictionary using a <code>foreach</code> loop:

<pre><code class="language-C#" data-noescape>
     foreach(KeyValuePair<string,string> item in snackMachine)
     {
        Console.WriteLine(item);
     }
</code></pre> 

!SLIDE

  - You may also see the <code>foreach</code> loop using the general keyword <code>var</code> for the data types of the KeyValuePair. 
  <p>- Recognize what it is, but do not do this. Use the implicit version in the previous slide.</p>

<pre><code class="language-C#" data-noescape>
     foreach(var item in snackMachine)
     {
        Console.WriteLine(item);
     }
</code></pre> 

!SLIDE

- Now, let's try creating a dictionary for the drink vending machine. This time, we do not know what items we want to add to our dictionary initially.

<pre><code class="language-C#" data-noescape>
     Dictionary<int,string>drinkMachine = new Dictionary<int,string>();
     
     //Using the Add method, let's add drinks to our drinks vending machine. 
     //This vending machine uses a number to access the items versus a 
     //combination of numbers and letters (e.g. A4 in the snackMachine).
     
     drinkMachine.Add(10, "Ginger Ale");
     drinkMachine.Add(11, "Bottled Water");
     drinkMachine.Add(12, "Orange Juice");
     drinkMachine.Add(13, "Fruit Punch");
     drinkMachine.Add(14, "Sparkling Water");
     drinkMachine.Add(15, "Sports Drink");
</code></pre> 

!SLIDE

  - Use the <code>Count</code> property to ensure all 6 drinks have been added to your drinks vending machine.

<pre><code class="language-C#" data-noescape>
     Console.WriteLine(drinkMachine.Count);
</code></pre> 
<div class="fragment">
- Like lists and arrays, dictionaries also come with built-in properties and methods you can use (see Common Properties & Methods above).
</div>

!SLIDE

- Let's say you only want to print the keys in the dictionary, you can use <code>.Key</code>:

<pre><code class="language-C#" data-noescape>
   foreach(KeyValuePair<int,string> drink in drinkMachine)
   {
      Console.WriteLine(drink.Key);
   }
</code></pre> 

!SLIDE

- This time, let's use <code>.Value</code> to print the drinks in our vending machine:

<pre><code class="language-C#" data-noescape>
   foreach(KeyValuePair<int,string> drink in drinkMachine)
   {
      Console.WriteLine(drink.Value);
   }
</code></pre> 

!SLIDE
<div>
 - Come up with an example for each property and method listed in the Common Properties & Methods section.
</div>
<div class="fragment">
 - Create a dictionary for a theater coat check with 10 elements. The key will be a number and the value will be the coat style. Print all elements to the console.
 </div>
 <div class="fragment">
 - Create a dictionary for a car valet service with 10 cars. The key will be the customer’s last name and the value will be the car make. Print all elements to the console.
 </div>
 <div class="fragment">
 - Create a dictionary of 10 zoo animals. The key will be the animal type and the value will be the number of animals at the zoo. Print the animal with the highest quantity to the console.
 </div>

!SLIDE

<div>
 - Remove the zoo animal with the lowest quantity from the dictionary using the <code>Remove</code> method. 
 </div>
<div class="fragment"> 
 - Use the Count property to count the number of remaining entries in the dictionary. Print to the console.
 </div>
<div class="fragment"> 
 - Create a program that allows a user to input an animal name to check to see if the dictionary contains that animal name.
 </div>
<div class="fragment"> 
 - If the animal does not exist in the dictionary, ask the user if he/she would like to add it. If so, add the animal to the dictionary.
 </div>


<style type="text/css">
/* should we move this into the template, or will it break existing slides. Maybe those slides are wrong. */
.reveal h3 {
	font-size: 4.4rem;	
}
.img:hover  {
        transform: scale(1.5);
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.5);
    }
</style>