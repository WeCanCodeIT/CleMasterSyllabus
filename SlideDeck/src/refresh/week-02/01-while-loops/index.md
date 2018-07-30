title: While Loops
subtitle: A New Hope
theme: league

## What is Looping?

Looping means to repeat something. This another means of controlling flow within a program. `if/else` and `switch/case` statements focus on *decision making*. Looping statements focus on doing something repeatedly. We call doing something repeatedly *iterating*.

## Why Would I Want To Do That?

There are many practical examples of loops:

- Sunrise and sunset
- Your daily routine: drink coffee, walk the dog, ask the neighbors if they've seen the dog, catch the dog, take a shower, go to work, come home, eat dinner, repeat

## While Loops

A `while` loop continues to do what you've told it to do *while* some condition continues to be true.

Usually, we won't use them for counting, but it's simple to illustrate them this way. This loop will count from one to ten:

```csharp
int count = 1;
while (count < 11) {
	System.out.println("The count is " + count);
	count++; // remember, this increases the value of count by 1
}
```
Try it!

## Let's Break That Down

We start with the `while` keyword:

<pre><code class="language-csharp" data-noescape>int count = 1;
<mark>while</mark> (count < 11) {
	Console.WriteLine("The count is " + count);
	count++; // remember, this increases the value of count by 1
}</code></pre>

<div class="fragment">
<p>Followed by a set of parentheses:</p>
<pre><code class="language-csharp" data-noescape>int count = 1;
while <mark>(</mark>count < 11<mark>)</mark> {
	Console.WriteLine("The count is " + count);
	count++; // remember, this increases the value of count by 1
}</code></pre>
</div>

## Let's Keep Breaking It Down

Within these parentheses, we find a *condition*. This evaluates to true or false (`boolean`), just like our condition for an `if` statement:

<pre><code class="language-csharp" data-noescape>int count = 1;
while (<mark>count < 11</mark>) {
	Console.WriteLine("The count is " + count);
	count++; // remember, this increases the value of count by 1
}</code></pre>

In this case, we will continue to *iterate* as long as the value of `count` is less than eleven.

## But What Happens?

Each time our `while` statement finds its condition to be true, it will execute the code inside the (*wait for it…*) **code block** that follows it, denoted by our friends the curly brackets:

<pre><code class="language-csharp" data-noescape>int count = 1;
while (count < 11) <mark>{</mark>
	Console.WriteLine("The count is " + count);
	count++; // remember, this increases the value of count by 1
<mark>}</mark></code></pre>

The way we read this would be: *"While count is less than eleven, we will print its value, then increase its value by one."*

## Doing it at least once

A `while` statement checks its condition before it runs. A `do/while` is similar, but it runs the code at least once before checking the condition. We don't see these as often, since it's always possible to use a `while` loop instead, and they're generally easier to understand.

If I wanted to allow a user to ask for help regarding question options (this may remind you of a recent exercise), I may do something like this:

```csharp
string porridgeTemperature;
do {
  Console.WriteLine("Please specify porridge temperature.");
  Console.WriteLine("Type \"help\" to list options.");
  porridgeTemperature = Console.ReadLine();
  if(porridgeTemperature.Equals("help")) {
    Console.WriteLine("Options: too hot, too cold, just right");
  }
} while(porridgeTemperature.Equals("help"));
```

Note that since `porridgeTemperature` is accessed *outside* of the curly brackets, we must define it *before* the curly brackets for the `do/while` block.

## Let's Do It Together

- If I wanted to ask the user for a message, then display it five times, how would I do this?
- If I wanted to pick a number, then ask the user to guess it, how might I do this?
  - What if I wanted my program to pick a random number?

## It Never Stops

Infinite loops aren't fun. You're sure to encounter one at some point. That's when you'll become more familiar with the *Debug perspective* in Eclipse, so that you can kill an errant loop.

These happen when the circumstances never arise to make the condition for your loop become false:

```csharp
while(true) {
  Console.WriteLine("I will run forever!");
  Console.WriteLine("(Or until you figure out how to stop me!)");
}
```

Usually it's not that straightforward, but the concept is the same. If your condition is never false when it is checked by the loop, then the loop never ends.

Bad loops just need to be put down. Let's try it out!

## You Can Do It!

For the following exercises, you'll need to figure out whether a `while` or a `do/while` loop is most appropriate:

- ATM: Prompt the user for a PIN. Display an error message if the user gets it wrong, and prompt again. If the user gets it right, print a congratulatory message.
  - Stretch goal: quit after three failed attempts with an apologetic message.

- Sum: Ask the user for an integer. Calculate the sum of the numbers from one to the integer the user entered. Example: If the user enters 6, your program should print 21 (1 + 2 + 3 + 4 + 5 + 6).
  - Stretch goal: Allow the user to enter a lower integer and a higher integer. Calculate the sum of the numbers from the lower to the higher, inclusive. Example: If the user entered 4, then 6, your program should print 15 (4 + 5 + 6).
  - Stretchier goal: If user enters a lower number for the second number, display an error message instead of calculating the sum.