title: Equality and Sets
subtitle: •••
theme: league

# Comparing primitives

Primitives are stored *by value*, so checking them for equality is simple. We use the `==` operator.

```java
int firstInt = 42;
int secondInt = 86;
if(firstInt == secondInt) {
	System.out.println("These are equal.");
} else {
	System.out.println("These are not equal.");
}
```

# Comparing objects

Variables that hold objects are called `reference types`, because they hold a reference to an object. Think of this as a pointer to the object stored as a memory address.

If we compare two object reference using the equals (`==`) operator, we are actually comparing the references, not the values to which they refer.

Try this. You may be suprised:

```java
Integer firstInt = new Integer(42);
Integer secondInt = new Integer(42);
if(firstInt == secondInt) {
	System.out.println("These are equal.");
} else {
	System.out.println("These are not equal.");
}
```

What just happened?

## I am me

Try changing `secondInt` to `firstInt` in the comparison. What happens?

```java
Integer firstInt = new Integer(42);
Integer secondInt = new Integer(42);
if(firstInt == firstInt) {
	System.out.println("These are equal.");
} else {
	System.out.println("These are not equal.");
}
```


## Doing it right

To compare objects, we use the `equals` method.

```java
Integer firstInt = new Integer(42);
Integer secondInt = new Integer(42);
if(firstInt.equals(secondInt)) {
	System.out.println("These are equal.");
} else {
	System.out.println("These are not equal.");
}
```

# Full circle

Fire up your IDE, and create this `Circle` class:

```java
public class Circle {

	private int radius;

	public Circle(int radius) {
		this.radius = radius;
	}

	public double circumference() {
		return 2 * Math.PI * radius;
	}
}
```

Note: `Math.PI` above is a *constant*. What does that mean?

## Circles of a size

As per our `Integer` example, this code won't work as you may expect (drop it into a `main` method):

```java
Circle firstCircle = new Circle(42);
Circle secondCircle = new Circle(42);

if(firstCircle.equals(secondCircle)) {
	System.out.println("These are the same size");
} else {
	System.out.println("These aren't the same size.");
}
```

## Establishing equality

What is the method we are using to compare objects?

It is the `equals` method, not an operator. The `equals` method is a method like any other.

`Object` is the parent class for all objects, so when we call the `equals` method on `Circle`, we are calling the `equals` method on its parent class, `Object`:

```java
public boolean equals(Object obj) {
    return (this == obj);
}
```

What did we just discover about objects and the `==` operator?

## Creating our own equals method

In order to compare two circles, we *override* the `equals` method in our `Circle` class.

```java
@Override
public boolean equals(Object obj) {
	
	boolean isACircle = obj instanceof Circle;
	
	if(obj == null || !isACircle) {
		return false;
	}
	
	Circle theOther = (Circle) obj;
	
	return radius == theOther.radius;
}
```

We're comparing the radii of our `Circle`s!

# Lets break that down!

# Sets

From Wikipedia:

> In mathematics, a set is a well-defined collection of distinct objects, considered as an object in its own right. For example, the numbers 2, 4, and 6 are distinct objects when considered separately, but when they are considered collectively they form a single set of size three, written {2,4,6}. Sets are one of the most fundamental concepts in mathematics. 