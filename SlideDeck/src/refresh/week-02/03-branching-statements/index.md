title: Branching
subtitle: Control the flow!
theme: league

# Branching statements

In addition to the decision making and looping statements, we have *branching* statements. These interrupt the normal top-to-bottom execution of our code. There are three: `break`, `continue`, and `return`.

## Neither Pass Go, Nor Collect $200

A `break` statement exits a loop (jumps to the code after its code block) immediately. What it says is **"Stop doing that! Now!"**

Here is an example of (bad) code that I saw in production. How could we write this using an equivalent `if` statement?

```csharp
bool shouldPrint = true;
while(shouldPrint) {
  Console.WriteLine("I should print!");
  break;
}
```

We cried, then laughed a bit, and dubbed it the "while/break" statement. (No, that shouldn't be a thing.)

## Ummm… `break` it down?

`break` statements are not that common. In fact, they're often a symptom of poorly designed code. An example of where you might use them is if you have a progam interacting with the user, and would like to abruptly exit, perhaps because of an error conditiion.

Remember Fortune Teller? We might have done something like this (assuming we were asking the user questions inside a loop):

```csharp
while (true)
{
    Console.WriteLine("What is your favorite color?");
    string favoriteColor = Console.ReadLine();

    if (favoriteColor == "Blue. No yel-- Auugh!")
    {
        Console.WriteLine("You're just making Monty Python references.");
        Console.WriteLine("Get out!");
        break;
    }

    Console.WriteLine("Your favorite color is " + favoriteColor);
}
```

Try it!

## Continuing with… `continue`

The second branching statement is `continue`. The `continue` statement is more common than the `break` statement.

Continue skips the current iteration, jumping to the end of the loop.

Let's say we wanted to count from one to ten, skipping multiples of three:

```csharp
for(int count = 1; count <= 10; count++) {
  if(count % 3 == 0) { // it's a multiple of three
    continue;
  }
  Console.WriteLine("Count is " + count);
}
```

We *could* have done this with an `if/else` statement, but using `continue` skips our `println` just fine. Which one should you use? This depends on the situation. A `continue` may make the code clearer.

How could we have changed our condition to make this code simpler and avoided using `continue`?

## Baby, Come Back!

The third branching statement, `return`, isn't specific to loops. When we write our own methods, we'll use this to exit a method and *return* execution to the point where another method called it.

Try this:
```csharp
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Message for 42: " + ChooseMessage(42));
        Console.WriteLine("Message for 23: " + ChooseMessage(23));
    }

    private static string ChooseMessage(int input)
    {
        if (input % 2 == 0)
        {
            return "Even Steven!";
        }
        return "You're odd!";
    }
}
```

Notice how using a return allows us to avoid using `else`—the method immediately *returns* (responds) and exits. More on this when we get to methods.

## Nested Loops

It is not uncommon to place one loop inside another. Imagine the second, minute, and hour hands of a clock. Once the second hand completes its circuit of the clock face, the minute hand advances. When the minute hand completes its circuit, the hour hand advances.

Let's do the hour and minute hand in code. We'll increment the minute hand by five minutes each time so that we don't fill up our console so quickly. Also, we'll only do three hours, starting with 1:00 and ending with 2:55:

```csharp
for (int hours = 1; hours < 3; hours++) {
  for (int minutes = 0; minutes < 60; minutes += 5) {
    Console.WriteLine("The time is " + hours + ":" + minutes);
  }
}
```

Now *that* is wizardy!

## Making It Pretty

Notice how "1:00" comes out "1:0" in the previous example? This is because we're simply appending the value of `minutes` (`0` in this case) to the hours value. We can use string interpolation's built in formatting to make our output prettier by specifying a format pattern. This is similar to how number formats in spreadsheets work:

```csharp
for (int hours = 1; hours < 3; hours++)
{
    for (int minutes = 0; minutes < 60; minutes += 5)
    {
        Console.WriteLine($"The time is {hours:00}:{minutes:00}");
    }
}
```

The `$` before the string indicates that the string is the be interpolated.  Values that are within `{}`'s are converted to strings using the objects `ToString` method.  Optionally, you can specify the formatting by putting a `:` and the desired format string after the value that's being interpolated.