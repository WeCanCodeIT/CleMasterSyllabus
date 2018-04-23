title: Constructors
subtitle: Methods for instance creation (instantiation)
theme: league

# Let's review methods

Methods are messages that we send to objects. Let's start our review with looking at a familiar method of the `String` class. When we want to compare a `String` with another, regardless of case, one of our approaches is to use the `toLowerCase` method.

Let's say that we have a `String` variable named `color`:

```java
if(color.toLowerCase().equals("the colour out of space")) {
  System.out.println("That is truly a strange color.");
}
```

Calling `color.toLowerCase()` is like saying, "Hey, `color`, can you give me a lowercase version of yourself?" Whether `color` holds the value `"Purple"`, `"purple"`, or `"PuRpLe"`, it will respond `"purple"`.

We refer to a method's response as it *returning* a value.

## Break It Down

Let's look at the method declaration for `toLowerCase` (you can find this in the `String` class). (*This is followed by a code block containing the method body, but we're leaving that out.*)

```java
public String toLowerCase()
```
<div class="fragment">
<p>The first part consists of one or more optional modifiers, something we'll go into later. <code>public</code> here indicates that the message can be seen everywhere:</p>
<pre><code class="language-java hljs" data-noescape><mark>public</mark> String toLowerCase()</code></pre>
</div>

<div class="fragment">
<p>The next part is the <em>return type</em>, indicating how the method will respond. This is like declaring a type for a variable. It can be one of the types that you would use to declare a variable or <code>void</code>, indicating that the method will not return a response.</p>
<pre><code class="language-java hljs" data-noescape>public <mark>String</mark> toLowerCase()</code></pre>
</div>

<div class="fragment">
<p>Last but not least is the method's name, followed by any <em>method parameters</em> it accepts. This method does not accept parameters, so the parentheses are empty.</p>
<pre><code class="language-java hljs" data-noescape>public String <mark>toLowerCase()</mark></code></pre>
</div>

## Information, Please

When a method needs additional information, we add *method parameters* to its definition.

Remember the `split` method of `String`? We passed it a `String`, indicating what we wanted to use as a *delimiter* to split it:

```java
String str = "this, that, the other";
String[] pieces = str.split(", ");
System.out.println(pieces[1]); // prints "that"
```

This is the declaration of the `split` method. We say that it accepts a method parameter of type `String`, named `regex`:

<pre><code class="language-java hljs" data-noescape>public String[] split(<mark>String regex</mark>)</code></pre>

If we didn't pass it the `regex` parameter, how would it know where to split?

## John Hancock

The combination of the method name and parameter types is called its *method signature*. This is how Java identifies which method we are calling. Also, the method signature allows Java to determine whether a method is redefining another method (called *overriding*):

<pre><code class="language-java hljs" data-noescape>public String[] <mark>split(String regex)</mark></code></pre>

## Talking Back

A method whose return type is anything other than `void` must `return` a response. We do this with the `return` statement.

A `String` is an *abstraction* representing a sequence of characters, so it contains an *instance variable* containing those characters. Lets look at how its `isEmpty` method works. If we strip away from `String` everything not relevant to this slide, we're left with something like this:

```java
public class String {
  char[] value; // characters in the string

  public boolean isEmpty() {
    return value.length == 0;
  }
}
```

To determine whether it is empty, a `String` looks at `value` to determine whether its `length` is zero. `value.length == 0` returns a boolean value (true or false) based on this comparison. Note that `isEmpty`'s *return type* is `boolean`.

This allows us to do:

```java
if(myString.isEmpty()) {
  System.out.println("This string is empty!");
}
``` 

# Creating An Object

Object Oriented Programming is all about creating objects (instances of a class) and communicating with those objects (calling methods). Objects contain *instance variables* that contain the *state* of an object, describing the object's attributes.

Let's say that we have a simple `Parrot` class that looks like this:

```java
public class Parrot {
  String name;
}
```

So, far when we have created an object and defined its state, we've done it something like this:

```java
Parrot myParrot = new Parrot();
myParrot.name = "Dewd";
```

Here, we've created an *instance* of the `Parrot` class named `myParrot`. `myParrot` has an *instance variable* named `name` with the value `"Dewd"`.

## A Flock of Parrots
<div class="sidebar"><img src="./resources/parrots_of_telegraph_hill.jpg" style="height: 45rem" /></div>

San Francisco is just the right climate for parrots from Central/South America. Flocks of parrots that have escaped from owners or been let loose flock together on Telegraph Hill. Birds of a feather do truly flock together.

I recommend tracking down a flock sometime. They're wild (*err… feral*).

## Creating lots of objects

Let's say we need to create a lot of parrots. There's a flock. That wouldn't be too difficult, given that our parrots only have a name right now, but if we started adding other attributes, this would become more and more difficult. We're developers, not typists. Also, it would be easy to forget to assign one or more attributes. So we can make it easier and less error prone by creating a method to create `Parrot` instances.

Here's what we were doing before:

```java
Parrot myParrot = new Parrot();
myParrot.name = "Dewd";
```

Here's how we could create a method to do the same thing:

```java
public static Parrot createParrot(String parrotName) {
  Parrot p = new Parrot();
  p.name = parrotName;
  return p;
}
```

And here's how we would call it:

```java
Parrot myParrot = createParrot("Dewd");
```

## But that still seems like a lot of work?

Luckily, there's a cleaner way. Remember that constructor we've been calling?

<pre><code class="language-java hljs" data-noescape>Parrot p = new <mark>Parrot()</mark>;</code></pre>

We call this a *constructor* because it *constructs* an instance of the class.

### But there's no constructor in my class!

This constructor is what is known as a *default constructor*. If we haven't explicitly defined a constructor for our class, the compiler creates a constructor for us that doesn't accept any arguments and does basic instance construction. That's why we don't see the constructor in our class.

The constructor that the compiler nicely creates for us if we have not explicitly declared one looks like this:

```java
public Parrot() {
}
```

Note that it has neither a return type nor a `return` statement. Also, its name is the same as the name of its class.

## We have the technology

When we want to initialize attributes of an object, we create our own constructor that accepts parameters, just like methods that accept parameters.

Remember our `createParrot` method?

```java
public static Parrot createParrot(String parrotName) {
  Parrot p = new Parrot();
  p.name = parrotName;
  return p;
}
```

We can (and should) move this work into the constructor for the class. Here is our `Parrot` class with an equivalent constructor:

```java
public class Parrot {

  String name;

  public Parrot(String parrotName) {
    name = parrotName; // name refers to our instance variable
  }
}
```

## We can construct it

Once we've created our constructor, instead of this:

```java
Parrot myParrot = createParrot("Dewd");
```

we can do this:

```java
Parrot myParrot = new Parrot("Dewd");
```

This is cleaner, more expressive, and moves the *responsibility* of construction to the `Parrot` class, where it belongs.

## Now write this method

![party parrot](./resources/party-parrot.gif)