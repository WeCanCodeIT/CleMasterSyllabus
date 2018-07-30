title: For Loops
subtitle: •••
theme: league

# Counting

Remember when we used a `while` loop to count?

```csharp
int count = 1;
while(count <= 10) {
  System.out.println("Count is " + count);
  count++;
}
```
The `for` loop allows us to do this in a more concise fashion.

```csharp
for(int count = 1; count <= 10; count++) {
  System.out.println("Count is " + count);
}
```

## Initialize…

The bit before the first semicolon inside a `for` statement runs *before* looping begins:

<pre><code class="language-csharp hljs" data-noescape>for(<mark>int count = 1;</mark> count <= 10; count++) {
  Console.WriteLine("Count is " + count);
}</code></pre>

You may hear this called many things. We will call it the *initialization expression*.

This is analogous to how we initialized `count` before our while loop:

<pre><code class="language-csharp hljs" data-noescape><mark>int count = 1;</mark>
while(count <= 10) {
  Console.WriteLine("Count is " + count);
  count++;
}</code></pre>

## Loop While…

Our loop condition is the same and even in pretty much the same spot:

<pre><code class="language-csharp hljs" data-noescape>for(int count = 1; <mark>count <= 10;</mark> count++) {
  Console.WriteLine("Count is " + count);
}</code></pre>

<pre><code class="language-csharp hljs" data-noescape>int count = 1;
while(<mark>count <= 10</mark>) {
  Console.WriteLine("Count is " + count);
  count++;
}</code></pre>

## Afterwards…

A `for` loop that follows the standard pattern makes it easy for us to find what happens *after* the loop.

<pre><code class="language-csharp hljs" data-noescape>for(int count = 1; count <= 10; <mark>count++</mark>) {
  Console.WriteLine("Count is " + count);
}</code></pre>

<pre><code class="language-csharp hljs" data-noescape>int count = 1;
while(count <= 10) {
  Console.WriteLine("Count is " + count);
  <mark>count++;</mark>
}</code></pre>

## I am NOT a Number!

Our *initialization expression* is usually a number, but initialize pretty much anything we like. Also, our *increment expression* is often used to decrement, but you can also get weird:

```csharp
for(string r = "foo"; !r.equals("quit"); r = input.nextLine()) {
  Console.WriteLine("What should I do?");
}

System.out.println("Ok, I quit!");
```
Yeah, probably don't do that. It's not *good*-weird.

*Note: we're using `r` as the variable name to get this to fit on the slide. The name should be more descriptive.*

## Leaving Out Bits

Each of these three parts is optional. This:

```java
for (; myCondition; ) {
  // do something
}
```

is the same as:

```java
while(myCondition) {
  // do something
}
```

Which of these is easier to read? As developers, we want to write code that minimizes the *cognitive load* required to understand it. Ideally, we also avoid disturbing fellow developers. Don't be cute. Just use a `while` statement.

# Summary
When it's appropriate to use, a `for` loop is generally easier to read.

Including initialization and incrementing in a consistent spot also makes it less prone to error than a comparable `while` loop.
