title: Branching
subtitle: Control the flow!
theme: league

# Branching statements

In addition to the decision making and looping statements, we have *branching* statements. These interrupt the normal top-to-bottom execution of our code. There are three: `break`, `continue`, and `return`.

## Neither Pass Go, Nor Collect $200

A `break` statement exits a loop (jumps to the code after its code block) immediately. What it says is **"Stop doing that! Now!"**

Here is an example of (bad) code that I saw in production. How could we write this using an equivalent `if` statement?

```C#
boolean shouldPrint = true;
while(shouldPrint) {
  Console.WriteLine("I should print!");
  break;
}
```

We cried, then laughed a bit, and dubbed it the "while/break" statement. (No, that shouldn't be a thing.)

## Ummm… `break` it down?

`break` statements are not that common. In fact, they're often a symptom of poorly designed code. An example of where you might use them is if you have a progam interacting with the user, and would like to abruptly exit, perhaps because of an error conditiion.

Remember Fortune Teller? We might have done something like this (assuming we were asking the user questions inside a loop):

```C#
while(true) {
  Console.WriteLine("What is your favorite color?"); 
  String favoriteColor = Console.ReadLine();

  if(favoriteColor == ("Blue. No yel-- Auuuuuuuugh!")) {
    Console.WriteLine("You're just making Monty Python references.");
    Console.WriteLine("Get out!");
    break;
  }

  Console.WriteLine("Your favorite color is " + favoriteColor);
}
```
Try it!
Question time: Can you think of one type of flow control logic you may use which requires a break statement? Here is a hint. Its not the following: if, if/else, if/else if.

## Continuing with… `continue`

The second branching statement is `continue`. The `continue` statement is more common than the `break` statement.

Continue skips the current iteration, jumping to the end of the loop.

Let's say we wanted to count from one to ten, skipping multiples of three:

```C#
for(int i = 1; i <= 10; i++) {
  if(i % 3 == 0) { // it's a multiple of three
    continue;
  }
  Console.WriteLine("i is " + i);
}
```

We *could* have done this with an `if/else` statement, but using `continue` skips our `println` just fine. Which one should you use? This depends on the situation. A `continue` may make the code clearer.

How could we have changed our condition to make this code simpler and avoided using `continue`?

## Baby, Come Back!

The third branching statement, `return`, isn't specific to loops. When we write our own methods, we'll use this to exit a method and *return* execution to the point where another method called it.

Try this:
```C#
class EvenOrOdd {

  static void main(String[] args) {
    Console.WriteLine("Message for 42: " + chooseMessage(42));
    Console.WriteLine("Message for 23: " + chooseMessage(23));
  }

  public static String chooseMessage(int input) {
    if(input % 2 == 0) {
      return "Even Steven!";
    }
    return "You're odd!";
  }
}
```

Notice how using a return allows us to avoid using `else`—the method immediately *returns* (responds) and exits. More on this when we get to methods.
<div class="fragment">
Question time: What will chooseMessage(81) return?
</div>

## Nested Loops

It is not uncommon to place one loop inside another. Lets imagine a calendar if you will. Of course we know there are twelve months in a year. Each month has a specific number of days.
If we needed to count every day in months 1 thru 12, we could use nested for-loops. 

Now lets code it!! We are going to assume every month has 30 days. We will create an outer loop and an inner loop. 

<div class="fragment">
Question time: Can someone tell me what the outer loop will represent? Months or Days?
</div>
<div class="fragment">
Question time: What else must our logic inlude if we want to count the number of days?
</div>
<div class="fragment">
Question time: Great we should use a variables. Now what type of variables should we use?
</div>

## Lets see how this works!!

```C#
class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;//This variable will keep track of the days 
            int total = 0;//This variable will sum the days of each month and save that value
            for(int months = 1; months <= 12; months++)
            {
				}	
                for(int days = 1; days <= 30; days++)
                {
                    sum = days;
                }
                total = total + sum;
            }
            Console.WriteLine(total);
        }
    }
```
Now *that* is wizardy!
<div class="fragment">
Question time: How many total times will the inner loop run? How many times will the outer loop run? Why?
</div>

## Making It Pretty

Now lets do something cool. Lets use nested for loops to draw a half pyramid.
We are going to use the Debugging tool in Visual Studio and walk through each step in the loop.

```C#
static void Main(string[] args)
        {
            int val = 5;//Equals the max number of columns and rows
            int i, j, k;
            for (i = 1; i <= val; i++)//OuterLoop is the number of rows
            {
                for (k = 1; k <= i; k++)//InnerLoop is the number of columns
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
```
Visual Studio Debugger is a great tool. 

It can be used to understand the code you are writing, as well as troubleshoot the code you have written. 

Learning how to use Debugger would be time well spent.
