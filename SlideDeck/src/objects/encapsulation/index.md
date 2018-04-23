title: Enapsulation
subtitle: Out of Sight!
theme: league

# Feeding Your Monkey

Your `feed` method in `VirtualPet` was an example of encapsulation. It probably resembled this:

```java
public void feed() {
  hunger -= 5;
}
```

So we fed our pets like this:

```java
myMonkey.feed();
```

Here, the `VirtualPet` class is responsible for updating hunger when a pet feeds. A benefit of this is that the `VirtualPet` class *encapsulates* the effect of a feeding. In this case, it decreases hunger by five.

If we were to do this in a procedural fashion without encapsulation, we might do this from our `main` method in our app:

```java
myMonkey.hunger -= 5; // feed myMonkey
```

# Hide Your Hunger

An example of violating encapsulation is the way we've handled accessing our `VirtualPet`'s hunger so far. You may have been doing something like this:

```java
System.out.println("My pet's hunger is " + myMonkey.hunger);
```

That's all well and good while only our app class is using `VirtualPet`, but what if other developers start using our code, and someone (let's assume innocently) does something like the following?

```java
thatPet.hunger = -5;
```

That would wreck your assumptions about hunger a bit, wouldn't it? We avoid this situation by giving our `hunger` instance variable a `private` *visibility modifier*.

<pre><code class="language-java hljs" data-noescape><mark>private</mark> int hunger;</code></pre>

## How do I get at it?

Once our hunger is private, we can't access it via `myMonkey.hunger`. If we need to know how hungry our pet is, the best way is just to ask if it's hungry. Perhaps with an `isHungry` method:

```java
public boolean isHungry() {
  return hunger > 50;
}
```

We should usually allow our pet to deal with hunger, but if we need to know its specific hunger value, we could create a method to tell us:

```java
public int hunger() {
  return hunger;
}
```

For reasons that will (hopefully) become clear later, it's more common in Java to call this method `getHunger`:

```java
public int getHunger() {
  return hunger;
}
```

# Keep Your Hands to Yourself

*Encapsulation* is the practice of hiding information about an object from other objects. We do this so that the *responsibility* for manipulating state is limited to one object.

A classic example of encapsulation is the cashier<sup>1</sup> collecting the price of a purchase. The cashier asks you for money to cover your purchase. You withdraw the money from your wallet/purse/pocket, then he returns your change. The cashier does not reach into your pocket, withdraw your wallet, remove money, then put change into your wallet.

*Shotgun surgery*, a design smell from Fowler's *Refactoring*, can be an indicator of poor encapsulation. This analogy references the small pellets resulting from a shotgun blast, the removal of which requires surgery at several places. Poor encapsulation means that a small change can require us to change several classes.

<p style="padding-left: 1rem;"><sup>1</sup> In the days of yore, this example was of a paperboy (not "person"—this was the days of yore) coming to your door to collect the weekly fee for a newspaper, a daily periodical printing the news of the day on cheap pulp.</p>

## I spy, with my little eye…

*Visibility modifiers* allow us to specify the *visibility* of an element (who can see it). From most visible to least visible, these are:

modifier  |visibility
--------  |----------
`public`    |everyone can see it
`protected` |this class and subclasses can see it
*none* (default)  |things in the same package can see it
`private`   |only visible inside this class, not even subclasses can see it

The instance variables that define the state of your objects should have less than `public` visibility.

In practice, most things will be `public` or `private`. Sometimes, you will see `protected`. You will almost never see default visibility in practice. (There's nothing wrong with default visibility. This is more a statement about practices in the industry and the level of craftsmanship.)

## In Practice

In reading your book, it may feel like "setter" methods violate enapsulation. For example, imagine I created a `setHunger` method for my pet that I would call like this:

```java
myMonkey.setHunger(35);
```
How is this any different or better than directly manipulating the value?

```java
myMonkey.hunger = 35; // direct manipulation
```

The answer is **not much**. We could do some validation of the value passed in, but this isn't much different. **_Setter methods violate encapsulation by definition_**. We introduce them because you will see them in the wild, where sometimes they are used to do great damage.

The *JavaBeans specification* introduced the concept of "getter" and "setter" methods for entirely different reasons than how they are used today. Human beings, apes in shoes that we are, embraced them in order to maintain the status quo, to continue to write procedural code. There were some practical reasons for doing so as well, but those have been overcome as the Java language matured.

Luckily, we can usually avoid using setter methods. Avoid them. Prefer constructor parameters to initialize state. Use techniques that allow you to eliminate them.