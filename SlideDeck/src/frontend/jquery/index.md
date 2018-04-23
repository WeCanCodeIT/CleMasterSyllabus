title: JQuery
subtitle: The Most Ubiquitous JS Library
theme: league

## What is jQuery?

jQuery is a JS library that allows you to, "write less and do more" with JS. It is built using the JS programming language. So, everything that you can do in jQuery can be done with Vanilla JS. But jQuery simplifies otherwise complex and code heavy endeavors like AJAX and DOM manipulation.

## Including jQuery in your project

There are two ways to include jQuery in your project. The first is to go to the [jQuery site](https://jquery.com) and download it and include it inside of your project.

```html
<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8">
        <title></title>
    </head>
    <body>

    <script src="./js/jquery-3.2.1.min.js"></script>
    </body>
</html>
```

!SLIDE

The other way to include jQuery is to use what's called a CDN (Content Delivery Network).

```html
<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8">
        <title></title>
    </head>
    <body>

    <script
        src="https://code.jquery.com/jquery-3.2.1.min.js"
        integrity="sha256-hwg4gsxgFZhOsEEamdOYGBf13FyQuiTwlAQgxVSNgt4="
        crossorigin="anonymous"></script>
    </body>
</html>
```

## Variables

Since jQuery is just JS, variables work the same, but, when using jQuery, there is a common convention to use a `$` character before any variable that represents jQuery objects.

```javascript
var $myVar = $('#root');
$myVar.click(function() {
    $('.item')[0].hide();
});
```

## Syntax

Let's talk a little bit about the convention that we used in the previous slide to select an item and do something with it.

```javascript
$('selector').action();
```

So jQuery is a list of predefined methods that execute some JS functionality but more simply than Vanilla JS. The selector behaves similarly to our `querySelector()` and `querySelectorAll()` methods. You can put any valid CSS selector in there and it will get that element for you. We can then call the methods, or as they're know in jQuery, actions, to do something to the selector we're referencing.

## $(document).ready();

next we're going to talk about jQuerys `$(document).ready(function() {})` method. This method is going to wait until your page loads to execute any jQuery code within it. You should house all of your jQuery code inside the anonymous function being passed to `$(document).ready(function() {})`.

## Methods

Methods in jQuery allow you to interact with your DOM elements. Let's look at some of the most used jQuery methods:

```javascript
// Just like JS, this gives our
// first 'p' element a new value
$('p')[0].text('Some new value');

// This does the same but it includes HTML elements
$('#title').html('This is going to give <span>HTML</span> code to our title');

// The '.val' method actually gets the
// value from an input element and let's
// you use it in your jQuery code
$('input').val();
```

## Callbacks

We have methods that accept callbacks in JS as well. Let's play around with some of the more useful ones below:

```javascript
// This is going to set the value of 'display'
// on '#myLogo' to 'hidden'
$('#myLogo').hide();

// This is going to toggle the value of 'display'
// between 'block' and 'hidden' based on its
// current value
$('.container').toggle();
```

## Event Methods

Event methods in jQuery are used the same way we use event listeners in JS. They call some action when a selector is interacted with. Let's see an example.

```javascript
// When any 'h1' elements on your page are clicked
// they will be hidden from view.
$('h1')[0].click(function() {
    $('h1')[0].hide();
});
```

I encourage you to look at the jQuery [documentation](https://api.jquery.com/) to see what other methods there are. Notable event methods include:

- `.click`
- `.dblclick`
- `.mouseenter`
- `.mouseout`
- `.focus`

## Effects

There are effects that you can use inside of jQuery to add stylish effects to your code. Let's look at some below.

- `.show(speed, callback)`
- `.hide(speed, callback)`
- `.toggle(speed, callback)`
- `.fadeToggle(speed, callback)`
- `.fadeIn(speed, callback)`
- `.fadeOut(speed, callback)`
- `.slideUp(speed, callback)`
- `.slideDown(speed, callback)`
- `.slideToggle(speed, callback)`

These effects are useful for adding interesting effects to your elements when your user interacts with them.

## jQuery CSS

So we can interact with our CSS inside of jQuery. This is really useful for dynamic styling. For example, if you want to change the background color of an element based on whether or not a user has clicked a button, you could use the css property for that. Or if you want to get the value of the color of one element to apply the same value to another element, the jQuery `.css()` method will do that for you.

```javascript
// This will return the current background-color
// on your 'h1' element since it's only receiving one value.
$('h1')[0].css('backgroundColor');

// This will set the value of the 'font-size'
// on the paragraph element when they are clicked
$('p').click(function() {
    $('p').css('fontSize', '30px');
});

// What do you think this will do?
$('div').css({
    'backgroundColor': 'blue',
    'color': 'white',
    'fontFamily': 'sans-serif'
    'fontSize': '20px'
});
```

## Practice

Clone the example exercise from [here](https://github.com/WeCanCodeIT/jquery-example-project) and solve the challenges in the JS file.
