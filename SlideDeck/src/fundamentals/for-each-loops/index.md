title: Foreach Loops
subtitle: •••
theme: league

## The wonderful world of Loops

- In prior lessons we covered <mark>while</mark>, <mark>do while</mark>, and <mark>for</mark> loops.

- We also discussed some of the situations in which we would use them.

- Now we will discuss the <mark>foreach</mark> loop.

- The <mark>foreach</mark> loop will be one of the most important tools C# has to offer.

- We predominantly use a <mark>foreach</mark> loop when we are iterating through an array, list, dictionary, or other data structure.

## Understanding the foreach loop structure

- The <mark>foreach</mark> loop is one of the least error-prone loops we will use in programming.

- The structure of a <mark>foreach</mark> loop is different from that of a <mark>for</mark> loop.

- As with the <mark>for</mark> loop, the <mark>foreach</mark> keyword tells the compiler to execute a foreach loop.

- Unlike a <mark>for</mark> loop, we do not use an index variable, .Length property, or an increment/decrement statement.

- One of the most common errors, <mark>Array out of bounds exception</mark>, does not apply to <mark>foreach</mark> loops.

## Foreach loop array example

- Here is an example of a <mark>foreach</mark> loop. Let's walk through its parts.

- You will notice a <mark>foreach</mark> loop is written in plain English.

```C#
int[] fibArray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
foreach (int element in fibArray)
{
    Console.WriteLine(element);
}
```
- The <mark>foreach</mark> loop operates just as it is written.

- The loop will execute for each int element in the fibArray.

- We do not have to keep track of the length, nor do we have to increment with each iteration.


## Foreach loop list example

- Here is another example of a <mark>foreach</mark> loop. 

```C#
List<int> fibArray = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
foreach (int element in fibArray)
{
    Console.WriteLine(element);
}
```
- The <mark>foreach</mark> loop operates just as it is written.

- The loop will execute for each int element in the fibArray.

- We do not have to keep track of the length, nor do we have to increment with each iteration.

## The body

- With the exception of list operations such as .Add(), .Remove(), .Insert(), etc., the body is the same as a <mark>for</mark> loop.

## Summary

- The for loop and the foreach loop perform the same functions.

- Although their inital set-up statements are different, the work done in the body is the same.

<style type="text/css">
.img:hover  {
        transform: scale(1.5);
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.5);
    }
</style>