title: For Loops
subtitle: •••
theme: league

## The wonderful world of Loops

- In a prior lesson we covered <mark>while</mark> and <mark>do while</mark> loops.

- We also discussed some of the situations in which we would use them.

- Now we will discuss the <mark>for</mark> loop.

- The <mark>for</mark> loop will be one of the most important tools C# has to offer.

- We predominantly use a <mark>for</mark> loop when we are iterating through an array, list, dictionary, or other data structure.

- The importance of the <mark>.Length</mark> property we learned about will become clear in this lesson.

## Understanding the for loop structures

- The <mark>for</mark> loop has four parts: **Setup**, **Test Expression**, **Body** and **Increment**.

<pre><code class="language-C#" data-noescape>
<mark>for</mark> <mark>(setup; test expression; increment)</mark> 
{
  <mark>body</mark>;	
}</code></pre>

- As with the <mark>while</mark> loop, the <mark>for</mark> keyword tells the compiler to execute a for loop.

- The setup involves *declaring* and *initializing* an **increment variable**. The letter <mark>i</mark> is most commonly used as the increment variable. 

<pre><code class="language-C#" data-noescape>
for (<mark>int i = 0</mark>; test expression; increment) 
{
  body;	
}</code></pre>

- In the parentheses we declare and intialize the increment variable.

<div class="fragment">
Question time: Why is the increment variable initialized with a value of 0?
</div>


## Test expression

- The second part to our <mark>for</mark> structure is the <mark>test expression</mark>.

<pre><code class="language-C#" data-noescape>for (int i = 0; <mark>test expression</mark>; increment) 
{
 body;	
}</code></pre>

- Unlike a `while` or `do while` loop, which have an exit determined by a `bool` value, we employ a <mark>for</mark> loop **when the amount of iterations is known**.

- The <mark>test expression</mark> is the conditional by which we test the iteration variable's value. 

- For our purposes, we will use the length of the `foodList` array.

<pre><code class="language-C#" data-noescape>for (int i = 0; <mark>i < foodList.Length</mark>; increment) 
{
 body;	
}</code></pre>

<div class="fragment">
Question time: How many times will our for loop iterate?
</div>

## Increment

- The third part of our <mark>for</mark> loop structure is the <mark>postfix increment</mark>.

<pre><code class="language-C#" data-noescape>for (int i = 0; i < foodList.Length;<mark>increment</mark>) 
{
 body;	
}</code></pre>

- After each iteration of our <mark>for</mark> loop, the iteration variable is incremented.

- We use the <mark>postfix increment</mark> operator to increment the iteration variable.

- Please note you have flexibility when it comes to how you increment or decrement the iteration variable.

<pre><code class="language-C#" data-noescape>for (int i = 0; i < foodList.Length;<mark>i++</mark>) 
{
 body;	
}</code></pre>


## The body

- As with the `do while` and `while` loops, the code within the <mark>body</mark> of the for loop will execute as long as the test expression returns true.

<pre><code class="language-C#" data-noescape>for (int i = 0; i < foodList.Length; i++) 
{
 <mark>Console.WriteLine(i);</mark>	
}</code></pre>

- In this example, we have inserted a <mark><code>Console.WriteLine()</code></mark> with the increment variable.

<div class="fragment">
Question time: If we execute this code, what will the <code>Console.WriteLine(i)</code> return?
</div>

## Let's experiment

- Volunteer time

- Open your Hello World project.

- Comment out the code contained in part thirteen.

- Uncomment the line in your code which declares and intializes the `foodAmount` array.

<p>Add the following code to your Hello World project</P>
<pre><code class="language-C#" data-noescape>//Part fourteen for-loop examples
for (int i = 0; i < foodAmount.Length; i++) 
{
 Console.WriteLine(i);	
}</code></pre> 

## We should all be here

<div class="img" float="right"><img src="./resources/for1.png" /></div>


## Loop execution in depth

- Before we execute our code, let me explain the process part by part.

- When the compiler reaches the `for` keyword, the following will take place:

	<div class="fragment">
	1. The iteration variable is declared and assigned a value of 0.
	</div>

	<div class="fragment">
	2. The test expression is validated for true or false.
	</div>

	<div class="fragment">
	3. If the expression is true, the code in the loop body will execute.
	</div>

	<div class="fragment">
	4. Once the code in the body executes, the postfix increment will increment the iteration variable by 1.
	</div>

	<div class="fragment">
	5. The test expression is validated for true or false.
	</div>

	<div class="fragment">
	6. If the expression is true, the code in the loop body will execute.
	</div>

	<div class="fragment">
	7. Once the code in the body executes, the postfix increment will increment the iteration variable by 1.
	</div>
 
<div class="fragment">
Question time: What value must be returned for the loop iteration to complete?
</div>
<div class="fragment">
Execute your code!!
</div>

## For loops and data structures

- One of the many tasks we can perform with a for loop is iterating through a data structure.

- We will focus primarily on the array, but almost any data structure could be used.

- Let's take our code from Hello World, and integrate a for loop as we did with the do and do while loops.

- Volunteer time

- Before we get started, comment out our last for loop example in part fourteen.

!SLIDE

- We are going to enter the values for the foodAmount array, then print them using a for loop.

- Because we declared and initialized the foodAmount array with values, we will be replacing these values. 

- Knowing what we are entering values for would be helpful as well. Uncomment the code which declares and enters values for the <mark>foodList</mark> array.

<p>Add the following code to your Hello World project</P>
<pre><code class="language-C#" data-noescape>
for (int i = 0; i < foodAmount.Length; i++)
{
    Console.WriteLine("Enter a value for " + foodList[i]);
    foodAmount[i] = int.Parse(Console.ReadLine());
}</code></pre> 

## Time to dive deeper

- When we use a <mark>for</mark> loop to iterate through an array, the iteration variable's value is also the value of the array's **index**.

- When we reference the iteration variable, in our case <mark>i</mark>, we are referencing the array index.

- Let's carefully step through the array and understand the process. 

<pre><code class="language-C#" data-noescape>
for (int i = 0; i < foodAmount.Length; i++)
{
    Console.WriteLine("Enter a value for " + foodList[i]);
    foodAmount[i] = int.Parse(Console.ReadLine());
}</code></pre>

<div class="fragment">
- In the first iteration of our loop, the variable values are: <mark><code>i = 0</code></mark> and <mark><code>foodList[0] = Milk</code></mark>
</div>

<div class="fragment">
- In the second iteration of our loop, the variable values are: <mark><code>i = 1</code></mark> and <mark><code>foodList[1] = Fruit</code></mark>
</div>

<div class="fragment">
- In the third iteration of our loop, the variable values are: <mark><code>i = 2</code></mark> and <mark><code>foodList[2] = Meat</code></mark>
</div>

<div class="fragment">
Question time: What is the value of <code>foodList[i]</code> when <code>i = 3</code> and when <code>i = 4</code>?
</div>

<div class="fragment">
Question time: When <code>i = 3</code> and you enter a value via the console to the <code>foodAmount</code> array, what value are you overwriting?
</div>

## Let's experiment

- Enter the following code into your Hello World program, then execute your program.

<pre><code class="language-C#" data-noescape>
for (int i = 0; i < foodAmount.Length; i++)
{
    Console.WriteLine("Enter a value for " + foodList[i]);
    foodAmount[i] = int.Parse(Console.ReadLine());
}</code></pre>

<div class="fragment">
We should all be here.
</div>

<div class="fragment">
<div class="img" float="right"><img src="./resources/for2.png" /></div>
</div>

## Nested for loop

- One of the most powerful applications of the <mark>for loop</mark> is the implementation of <mark>nesting</mark>.

- <mark>Nested for loops</mark> are used in a wide range of applications, e.g. searching, sorting, and comparing data.

- Although the nested for loop can be essential in many applications, its use decreases the efficiency of your program.

- Let's walk through an example of a nested for loop.


## Step by step

- In the following example of a nested for loop, we are going to construct a half pyramid.

- Lets define the first two lines of our code:

	- <mark><code>int size = 5;</code></mark> defines the maximum height and width of our pyramid.

	<div class="fragment">
	- Question time: What is the purpose of declaring the <mark>int i, j;</mark> variables?
	</div>
	
<pre><code class="language-C#" data-noescape>int size = 5;    //Equals the max number of columns and rows
int i, j;
for (i = 0; i <= size; i++)
{
    for (j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}
Console.ReadLine();
</code></pre>

[Nested for loop demonstration](https://youtu.be/k7aBHls-ZzU)




## Some useful ideas

- Another useful application of a for loop is performing math calculations.

- Let's look at how we can easily perform many math functions.

<pre><code class="language-C#" data-noescape>int sum = 1;
for (int i = 0; i <= 10; i++)
{
    sum = sum + 1;   
}
Console.WriteLine(sum);
</code></pre> 

<pre><code class="language-C#" data-noescape>
int sum = 1;
for (int i = 0; i <= 10; i++)
{
    sum = sum * 3;   
}
Console.WriteLine(sum);
</code></pre>

!SLIDE

- Take note of the <mark>+=</mark> and <mark>*=</mark> operators. 

- These are a shortcut for <mark>sum = sum + 3</mark> and <mark>sum = sum * 3</mark>
<pre><code class="language-C#" data-noescape>for (int i = 0; i <= 10; i++)
{
    sum *= 3;
}
Console.WriteLine(sum);

for (int i = 0; i <= 10; i++)
{
    sum += 3;
}
Console.WriteLine(sum);
</code></pre>
<style type="text/css">
.img:hover  {
        transform: scale(1.5);
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.5);
    }
</style>