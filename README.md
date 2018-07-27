# Week 1 - Computational Thinking

Students begin to learn their way around Visual Studio and learn some of the fundamentals of the language.

Objectives:
* Begin to understand working with Visual Studio.
* Using `Console.WriteLine()` to output

Key Terminology:
* Input: what goes IN to the computer (whether it be commands entered on a keyboard or data from another computer
* Output: what is produced, or the product, can be a web page, an app, our text sent to the Console
* Solution: A group of one or more Projects that work together.
* Project: A group of related code that work together.
* Class: created in Eclipse to house code that becomes the blueprint for an object read more
* Object: an instance of a class
* Object Oriented Programming (OOP): a shift from just writing logic towards writing about the objects we want to manipulate
* camelCase: naming convention used in C# to combine multiple words together. Ex: playerScore
* PascalCase: naming convention used in C# to combine multiple words together. Ex: PlayerScore
* Concatenation: using + to join strings
* Syntax: A set of rules that define how code needs to be written
* Condition: evaluates to true or false (found in decision structures)

Reading:
* TODO:

## Introduction

Setting expectations for everyone about course content and high level flow.

[Slides](http://htmlpreview.github.io/?https://github.com/WeCanCodeIT/CleMasterSyllabus/blob/master/SlideDeck/docs/introduction/intro/index.html#/)

[Slides Source Code](https://github.com/WeCanCodeIT/CleMasterSyllabus/blob/master/SlideDeck/src/introduction/intro/index.md)


## School Policies

More expectation setting.  Grading, attendance, pass/fail, homework, late & incomplete assignments, academic probation, who to talk to.

[Slides](http://htmlpreview.github.io/?https://github.com/WeCanCodeIT/CleMasterSyllabus/blob/master/SlideDeck/docs/introduction/policy/index.html#/)

[Slides Source Code](https://github.com/WeCanCodeIT/CleMasterSyllabus/blob/master/SlideDeck/src/introduction/policy/index.md)


## Student Welcome Trello Boards

TODO: I've seen this, but I'm not sure when/where this takes place.  Here seems like a good spot?


## Hello World

Follow along with the slides to create your first C# Application!

[Slides](http://htmlpreview.github.io/?https://github.com/WeCanCodeIT/CleMasterSyllabus/blob/master/SlideDeck/docs/fundamentals/hello-world/index.html#/)

[Slides Source Code](https://github.com/WeCanCodeIT/CleMasterSyllabus/blob/master/SlideDeck/src/fundamentals/hello-world/index.md)


## Syntax - Statements & Blocks of Code

Walk through the following example code, highlighting:
* Statements
* Expressions
* Blocks of Code
* Naming Conventions
* etc.


```code csharp
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I can code it!");

            Console.WriteLine(42);
            Console.WriteLine(1.23);
            Console.WriteLine(2 + 3);
        }
    }
}
```

## Basic Types

TODO: Rework slides to be similar to Java slides -
https://wecancodeit.github.io/java-slides/fundamentals/basic-types-and-variables/#/1

## Operators & Expressions

TODO: Rework slides to be similar to Java slides -
https://wecancodeit.github.io/java-slides/fundamentals/operators-and-expressions/#/

## Conditionals

TODO: Rework slides to be similar to Java slides -
https://wecancodeit.github.io/java-slides/fundamentals/conditionals/#/13

## Console Input

TODO: Create something similar to Java slides - 
https://wecancodeit.github.io/java-slides/fundamentals/reading-console-input/#/

## Strings

TODO: Remove dependencies on prior code - structure this as a new console app specific to strings.

Java slides for reference:  https://wecancodeit.github.io/java-slides/fundamentals/strings/#/11

[Practice Problems](https://wecancodeit.github.io/java-exercises/fundamentals-practice-problems/strings/)


## Introduction to GIT

Git is one of the most popular Version Control Systems out there.  We'll use Git, along with Github to keep track of our code and the changes that we make to it.

[Slides](http://htmlpreview.github.io/?https://github.com/WeCanCodeIT/CleMasterSyllabus/blob/master/SlideDeck/docs/Git/GitHubIntro/index.html#/)

## Graded Project:  Fortune Teller



# Week 2 Flow of Control and Class Design

Learn how to control the flow of execution in your application. Begin developing capabilities to store larger amounts of data and be able to iterate through that data. Begin the process of Object Oriented Programming. Test-Drive an application's design from start to finish.

Objectives:
* Understanding when to use loops
* Understand why loops are needed
* Write code blocks that use `while` and `do/while` loops
* Write code blocks that use `for` loops
* Write code blocks that use `foreach` loops
* Begin to understand infinite loops
* Basic usage of the debugger
* Be able to work with Branching statements like `break`, `continue`, and `return`

Key Terminology:
* Conditional Statement: Evaluates to either true or false…allows for executing decision structures or loops
* Iteration: A pass through a loop (lap)
* Code Block: Code contained within { }. Code Blocks are useful in loops `while(condition){ do this and this and this }`
* Initialization: Assigning a variable a beginning value
* Array: A data structure that contains a group of elements all sharing the same data type
* Index(plural Indices): Location of an item in an Array (begins at 0)
* Traversal: A loop that visits every element in the Array
* Class: Used to house code that becomes the blueprint for an object
* Object: an instance of a class
* Object Oriented Programming (OOP): a shift from just writing logic towards writing about the objects we want to manipulate
* Constructor: shares the same name as the class, has no data type, constructs the object

Reading:
* TODO:

## Flow of Control

This [Google Doodle](https://www.google.com/doodles/celebrating-50-years-of-kids-coding) from December 4, 2017, celebrates 50 years of kids coding. It offers a great visualization of how loops work. Can you use loops to find the shortest solution to each challenge?

## While Loops

TODO: Remove dependencies on prior code.

Instructor notes: Use debugger to allow students to visualize.

Java slides for reference:
https://wecancodeit.github.io/java-slides/fundamentals/while-loops/#/

[Slides](http://htmlpreview.github.io/?https://github.com/WeCanCodeIT/CleMasterSyllabus/blob/master/SlideDeck/docs/fundamentals/loops-01/index.html#/)

[Practice Problems](https://wecancodeit.github.io/java-exercises/fundamentals-practice-problems/while-loops/)

## For Loops

TODO: Remove dependencies on prior code. Use a new console app instead.

[Slides](http://htmlpreview.github.io/?https://github.com/WeCanCodeIT/CleMasterSyllabus/blob/master/SlideDeck/docs/fundamentals/for-loops/index.html#/)

## Branching Statements

TODO: Remove dependencies on prior code.  Use a new console app instead.

Java slides for reference:  https://wecancodeit.github.io/java-slides/fundamentals/branching-statements/#/

[Slides](http://htmlpreview.github.io/?https://github.com/WeCanCodeIT/CleMasterSyllabus/blob/master/SlideDeck/docs/fundamentals/conditionals/index.html#/)

## Arrays

TODO: Where did this lesson go?  Bring back based on java?

Java slides:  https://wecancodeit.github.io/java-slides/fundamentals/arrays/#/1


## ForEach Loops

Iterating over Enumerables.

[Slides](http://htmlpreview.github.io/?https://github.com/WeCanCodeIT/CleMasterSyllabus/blob/master/SlideDeck/docs/fundamentals/for-each-loops/index.html#/) 

## Designing Classes

Classes are one of the fundamental building blocks that are used to create software.

Objectives:
* Students should be able to use TDD to drive the creation of a class.
* Students should be able to create instance of a class (objects) using the `new` operator.
* Students should be able to create and manipulate instance variables.
* Students should be able to create and use methods.

TODO: Lesson plan based on flexcode lesson found here:  https://flexcode.wecancodeit.org/mod/hvp/view.php?id=111

JAVA constructor slides for reference: https://wecancodeit.github.io/java-slides/objects/constructors/#/1
TODO: C# version of constructor slides?

TODO: Are there slides for class design?  I don't see them in FlexCode.

## Bridge Project: ATM

## Graded Project: Virtual Pet


# Week 3 - Collections and Other Data Types

Design more powerful collections to handle your data. Learn how to test drive and build out maintenance on your data collections. 

## Lists

## Dictionaries


# Week 4 - Inheritance

Explore the core concepts of Java as an Object Oriented Programming language. You will learn how relationships are structured and begin to place more thought into the architecture and design of your software.  Your software is starting to look more organized. 

## Inheritance

## IComparable

## Equality

## Enumerables

## Encapsulation

## Polymorphism


# Week 5 - Model View Controller

Begin to develop an understanding of the tools available in the ASP.NET MVC Framework to wire up a web application. Take your C# code from the back end and wire it up using ASP.NET MVC, Razor and HTML to create a web based application.

## Introduction to HTML

[Slides](https://wecancodeit.github.io/java-slides/frontend/html/#/)

## ASP.NET MVC Intro

TODO: Develop MVC equivalent of java slides:  https://wecancodeit.github.io/java-slides/spring/spring-boot/#/
TODO: May also need something similar to this:  https://spring.io/guides/gs/serving-web-content/

## Razor Basics

TODO: New curriculum?

## Razor Enumeration

TODO: New curriculum?

## Dependency Injection & Mocking

TODO: Develop similar to: https://wecancodeit.github.io/java-slides/objects/dependency-injection/#/

## MVC Courses Project

TODO: Develop TDD curriculum similar to https://flexcode.wecancodeit.org/course/view.php?id=17#section-3

## Graded Project: Reviews Site (TDD Version)      

TODO: Develop curriculm
Java version:  https://wecancodeit.github.io/java-exercises/reviews-site/

# Week 6 - Front End Development

Students will be introduced to CSS Grid and Flexbox and learn how to use these tools to create a beautiful front end to their web applications.

## Introduction to CSS

[Slides](https://wecancodeit.github.io/java-slides/frontend/css-styling/#/)

## CSS Grid

[Slides](https://wecancodeit.github.io/java-slides/frontend/css-grid/#/)

[Activity: Grid Garden](https://cssgridgarden.com/)

## Flexbox

[Slides](https://wecancodeit.github.io/java-slides/frontend/css-flexbox/#/)

[Activity: Flexbox Zombies](https://flexboxzombies.com/p/flexbox-zombies)

## Project: Code Business Site

TODO: What's needed here?  Similar to: https://flexcode.wecancodeit.org/course/view.php?id=18#section-4

## Graded Project: Professional Portfolio

Java: https://wecancodeit.github.io/java-exercises/professional-portfolio/


# Week 7 - Entity Framework

Learn how to implement and manage the data access layer of your application.  Develop an understanding of Relational Databases and Object Relational Mapping, and how a powerful tool like Entity Framework can get you up and running quickly and efficiently. Quickly configure an application, explore relationships and query your data. 

## Intro to Entity Framework 

TODO: Create this curriculum
Java version: https://wecancodeit.github.io/java-slides/data/jpa/#/

## Accessing Data (Code First)

TODO: Create this curriculum?
Java Version: https://flexcode.wecancodeit.org/course/view.php?id=19#section-2

## Migrations (Code First)

TODO: Create this curriculum?

## Graded Project: Review Site Full Stack

Java version: https://wecancodeit.github.io/java-exercises/reviews-site-fullstack/


# Week 8 - JavaScript

Now that you are beginning to understand the logic of C#, let's fully immerse you in the language of JavaScript, a dynamically typed functional language. Learn the basics, DOM manipulation and Ajax requests to allow your JavaScript to talk to your Java database. 

## C# Vs JavaScript

TODO: Create?
Java Version: https://wecancodeit.github.io/java-slides/web/java-vs-javascript/#/11

## Intro to JavaScript

## Intro to ES6

## CSS Media Queries and JavaScript DOM Manipulation

## AJAX Requests

Replaces java's jquery curriculum here: https://wecancodeit.github.io/java-slides/frontend/jquery/#/
and also from java: https://wecancodeit.github.io/java-slides/flexcode/ajax/#/
with something that uses fetch...or we let jQuery & xhr live on?


# Week 9 - Forms and API Development

Take full control of your software. Create your own API so that you know what data you want to hit on and when. Add dynamically changing content to your repertoire and take your development skills to the next level. 


# Week 10 - Single Page Applications (React) || More SQL || Database First?

TODO: Develop curriculum || Link to Sql in 7 slides || Review slides


# Weeks 11-14

Flex week & Final projects.