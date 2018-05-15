title: Lists
subtitle: Like Arrays, but Mutable!
theme: league

# Data Collections

We have already seen one data collection type, an `array`. An `array` is a collection of values that have the same type, like `int` or `string`.

There are several types of data collections in C#, many of which you will see during the upcoming weeks and even more during final projects.

Today, we will be talking about `Lists`.

## Arrays are fixed size

We can't change the size of an array once we've created it. It will never grow or shrink. This array will always have a `length` of three:

<code class="language-C#" data-noescape>
int[] myArray = {1, 2, 3};
</code>

If I wanted to add an element to this array, I'd generally do something like this (but hopefully I'd use a loop):

```C#
int[] oldArray = myArray;

myArray = new int[4];
for(int index = 0; index < oldArray.Length; index++) 
{
  myArray[index] = oldArray[index];
}
myArray[3] = 42;
```

We are forced to create a new array and assigned it to our `myArray` variable. Imagine if we needed to insert a new element in the middle? *Yuck!*

## Let's Start a New Project

Create a new Console Application with the title "ToyStore"

<div float="right"><img src="./resources/createproject.jpg" /></div>

## Array Review

This is how we'd set up an array of toys at our toy store. Remember, arrays have a fixed size.

<div float="right"><img src="./resources/toyarray.JPG" /></div>

## How To Initialize a List

A list is created with the <mark>new</mark> keyword, which we will see a lot more of soon!

Create the following list.

<div float="right"><img src="./resources/toylist.JPG" /></div>

Notice the similarities and differences between creating a new List versus creating an array.

## Initializing an Empty List

Unlike arrays, with lists we don't have to set a size when we create an empty list.

<div float="right"><img src="./resources/newEmptyList.JPG" /></div>

## Mutable

Unlike an array, a List is **mutable**, meaning that it does not have a fixed size and can increase or decrease in size.

We can use the <mark>.Add()</mark> method to add elements to our list.

<div float="right"><img src="./resources/addToToyList.JPG" /></div>

<div class="fragment">
What did our <code>foreach</code> loop do?
</div>

## Printing Elements in a List

We saw what the `foreach` loop did in our previous slide. There is another way to print elements in a list using their indices.

<div float="right"><img src="./resources/PrintAtIndex.JPG" /></div>

## Objects and Methods

We will be talking a lot more about objects this week, but it is good for you to know that Lists are a type of object.

Lists have several built-in properties and methods, which we will go over now. Some of those are:
 - `.Count`
 - `.Insert()`
 - `.Add()`
 - `.Remove()`

## Count and Remove

The `.Count` property is the List version of the `.Length` property that is built in to arrays. `.Count` tells us the size of the list.

Write out the following code and share what you discover about `.Remove()`.

<div float="right"><img src="./resources/CountAndRemove.JPG" /></div>

## Insert

The `.Insert()` method allows us to put a new element in our list AND specify which index we want that element to go to. Take a look at the following code.

<div float="right"><img src="./resources/InsertMethod.JPG" /></div>

<div class="fragment">
What index is each element at?
</div>
<div class="fragment">
Where did the elements originally at the indices of 0, 2, and 1 go?
</div>

