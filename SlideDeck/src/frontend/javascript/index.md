title: JavaScript
subtitle: Like C# but better!
theme: league

## What is JavaScript?

- JavaScript is a **dynamic**, **weakly typed**, **prototype-based** programming language.

- Many of you notice there will be parts of JavaScript that remind you of C#.

- JavaScript is mostly used on the front-end or client-side of web applications.

- But now, JavaScript is able to be used as a full-stack tool for developing robust web applications thanks to **Node.js**

- We will only be going through using JavaScript on the front-end to add interactivity with our end user.

## HTML DOM or Document Object Model

- Before we get started, let's discuss a very important concept you will need to understand.

- When a web page is loaded, the browser creates a <mark>Document Object Model</mark> of the page.

- The HTML DOM model is constructed as a tree of Objects:

<div style="text-align:center" class="img"><img src="./resources/DomModel.gif" /></div>

## Dynamic HTML

- With the object model, JavaScript gets all the power it needs to create dynamic HTML.

- Here are some example of what you can accomplish using JavaScript:

	- JavaScript can change all the HTML elements in the page
	- JavaScript can change all the HTML attributes in the page
	- JavaScript can change all the CSS styles in the page
	- JavaScript can remove existing HTML elements and attributes
	- JavaScript can add new HTML elements and attributes
	- JavaScript can react to all existing HTML events in the page
	- JavaScript can create new HTML events in the page



## Let's do this

- We could create a blank website and practice, but I feel working with an existing website would be beneficial.

- Go to the following GitHub link, and clone [Tuscany Villa](https://github.com/pfittante1001/Villa).

- Open Tuscany Villa.

- Add a new JavaScript page named <mark>villaScript</mark>

- Place a source reference to `villaScript.js` in your head section above `style.css`

## We should all be here

<div style="text-align:center" class="img1"><img src="./resources/js1.png" /></div>


## How to include JS

- We can include JavaScript in our page very similarly to how we include CSS.

- Like CSS, there are 3 options (and two of them are not advised).

- Question Time: What are the three methods you can use to implement CSS?

## Inline

- We can include JavaScript right inside of our HTML elements. (Your separation-of-concerns sense should be tingling right now):

- Go to lines <mark>53-54</mark> of your index page and enter/update the following code:

```html
<h2 onclick=" this.style.color = 'red';">LOCATIONS</h2>
<p onclick=" this.style.color = 'yellow';">Some places for you to go</p>
```
- Save and open your browser by selecting Google Chrome.

- Browse to the <mark>Locations</mark> subheader and click on both lines of text.

- You should get the following:

<div style="text-align:center" class="img1"><img src="./resources/js2.png" /></div>

## Inside Script Tags

- You can also write JavaScript directly inside your HTML by enclosing it in `<script>` tags.

- Go to line 240 of your index pages and enter the following code:

```HTML
<script>
        function myFunction() {
        var x = document.getElementById("jumbomain");
        x.getElementsByTagName("h1")[0].style.fontSize = "50px";
        x.getElementsByTagName("p")[0].style.fontSize = "50px";
        x.getElementsByTagName("h1")[0].style.color = "red";
        x.getElementsByTagName("p")[0].style.color = "red";
    };
</script>
```
- Update lines <mark>43-44</mark> as follows:

```HTML
<h1 onclick="myFunction()">Tuscany Villa</h1>
<p onclick="myFunction()">We specialize in relaxation</p>
```
- Question Time: What section of code will this script affect, and what will be the result?

!SLIDE

Before

<div style="text-align:center" class="img1"><img src="./resources/js3.png" /></div>


<div class="fragment">
After

<div style="text-align:center" class="img1"><img src="./resources/js4.png" /></div>
</div>

## Linking an External JS File (Do this one!)

- Finally, similar to CSS, you can link JS code from an external file.

- This is ideal because it keeps your code organized and concerns separated.

- You connect the file to your HTML with the `<script>` tag like your `style.css`


## External is where it is at

- Just like external CSS, we can keep our JavaScript separate from our HTML.

- Copy the following code and paste it into villaScript.js

```Javascript
function overBtn(x) {
	x.style.backgroundColor = "white";
	x.style.color = "black";
    }

function outBtn(x) {
	x.style.backgroundColor = "#474e5d";
	x.style.color = "white";
    }
```
- Make the following changes to the Reserve Now! button located on line 61 of your HTML.

```HTML
<button type="button" class="btn" onmouseover="overBtn(this)" 
   onmouseout="outBtn(this)">Reserve Now!</button>
```
- Question Time: What section of code will this script affect, and what will be the result?

!SLIDE
- Before mouseover
<div class="fragment">
<div style="text-align:center" class="img1"><img src="./resources/js5.png" /></div>

</div>
<div class="fragment">
- During mouseover
<div style="text-align:center" class="img1"><img src="./resources/js6.png" /></div>

</div>
<div class="fragment">
- After mouseover
<div style="text-align:center" class="img1"><img src="./resources/js5.png" /></div>
</div>

## So how does this whole thing work you ask
 
 - Let's make another change to our site which I think you will find extremely useful

 - After we make this change we will dicuss each part of the code

 - Copy and paste the following code into villaScript.js

 ```Javascript
function SwapDivsWithClick(div1,div2)
{
    d1 = document.getElementById(div1);
    d2 = document.getElementById(div2);
   if( d2.style.display == "none" )
   {
        d1.style.display = "none";
        d2.style.display = "flex";
   }
   else
   {
        d1.style.display = "flex";
        d2.style.display = "none";
   }
}
```
!SLIDE

- Paste the following code on line 67 of index.html by inserting a blank line:

```HTML
<div class="row locationsrowodd" style="display:none" id="swap">
   <div class="col-7 locationscolodd">
      <h2>Please login or join to reserve a site</h2>
      <form action="/action_page.php">
         First name:<br>
         <input type="text" name="firstname" value="Mickey">
         <br>
         Last name:<br>
         <input type="text" name="lastname" value="Mouse">
         <br><br>
         <button type="button" class="btn" onmouseover="overBtn(this)" onmouseout="outBtn(this)" onclick="SwapDivsWithClick('orig','swap')">Submit</button>
      </form>

      </div>
      <div class="col-5 locationscolodd">

      </div>
   </div>
```
- Replace the button on line 61 of index.html with the following code:

```HTML
<button type="button" class="btn" onmouseover="overBtn(this)" onmouseout="outBtn(this)" 
  onclick="SwapDivsWithClick('orig','swap')">Reserve Now!</button>
```
- Update line 57 with the following:

```HTML
<div class="row locationsrowodd" style="display:flex" id="orig">
```
## We should all be here

<div style="text-align:center" class="img1"><img src="./resources/js7.png" /></div>

- Now click on the button and you should have the following

<div style="text-align:center" class="img1"><img src="./resources/js8.png" /></div>


## Let's discuss the code

<div style="text-align:center" class="img1"><img src="./resources/js9.png" /></div>

<div style="text-align:center" class="img"><img src="./resources/js10.png" /></div>

## Some things look familiar

- In the code we have seen the use of the following:
	
- Functions:
```Javascript
onmouseover="overBtn(this)" onmouseout="outBtn(this)" onclick="SwapDivsWithClick(
   'orig','swap')" function SwapDivsWithClick(div1,div2)
```
- Variables:
```Javascript
d1 = document.getElementById(div1);
d2 = document.getElementById(div2);
```
- Parameters:
```Javascript
onmouseover="overBtn(this)" onmouseout="outBtn(this)" onclick="SwapDivsWithClick('orig','swap')"
```
- CSS Styling:
```Javascript
d1.style.display = "none";
d2.style.display = "flex";
```
- The concept behind the use of the tools we have used throughout the course is the same with JavaScript.

- Because JavaScript takes advantage of the DOM and is rooted in the concept of OOP, our options are almost limitless.

## To be sucessful in using JavaScript, you must understand...

- With JavaScript, you want to manipulate HTML elements.

- To do so, you have to find the elements first. There are a couple of ways to do this:

- Finding HTML elements by **id**: `document.getElementById();`
- Finding HTML elements by **tag name**: `document.getElementsByTagName();`
- Finding HTML elements by **class name**: `document.getElementsByClassName();`
- Finding HTML elements by **CSS selectors**: `document.querySelectorAll();`
- Finding HTML elements by **HTML object collections**:
```Javascript
var x = document.forms["frm1"];
var text = "";
var i;
for (i = 0; i < x.length; i++) {
	text += x.elements[i].value + " ";
}
document.getElementById("demo").innerHTML = text;
```

## Let's look at some more tools

- JavaScript allows you to send and receive messages from your user in a number of ways.

- The first ones we're going to talk about are boxes.

- There are three types of boxes:

	- alert
	- confirm
	- prompt

- Let's explore them in more detail.

## Alert

- Alert boxes allow you to send a message that your user can read when an action is performed.

- Replace the submit button located on line 77 of your index.html with the following code:

```html
<button type="button" class="btn" onmouseover="overBtn(this)" onmouseout="outBtn(this)" onclick="SwapDivsWithClick('orig', 'swap'); Redirect();">Submit</button>
```
- Paste the following code into villaScript.js

```JavaScript
function Redirect() {
	alert('You are being redirected');      
	}
```
- Select <mark>Reserve Now!</mark> then select <mark>Submit</mark>

## We should all be here

<div style="text-align:center" class="img1"><img src="./resources/js11.png" /></div>


## Confirm

- Confirm boxes actually perform a action based on a boolean.

- This way, you can interact with your user and get some kind of feedback from them.

- When your user clicks ok in the confirm box, you get a **true** value, and an action is performed.

- When they click cancel, you get a **false** value, and an action is not performed:


- Paste the following code into villaScript.js:

```JavaScript
function Redirect(x) {
    var confirmButton = document.getElementById(x);
    var userResponse = confirm('You are about to leave this site. If you want to stay, please select cancel.');
    var displayContainer = document.getElementById('confirmResponse');
    var displayMessage = '';
    if (userResponse) {
        var win = window.open("https://www.tuscanyaccommodation.com/tuscany-villas/?gclid=EAIaIQobChMIlcqH3bzi2QIVDEwNCh1Xbg9DEAAYAyAAEgLW1vD_BwE", '_blank');
        win.focus();
    } }
```
- Paste the following code to line 78 of index.html by inserting a blank line:

```HTML
 <output name="result" id="confirmResponse"></output>
 ```

## Prompt

- Prompt works very similar to to confirm.

- It accepts input from your user as well.

- This time, the value is a `string` so you can get specific information from your user and use it however you want.

- Replace the `<body>` tag located on line 14 of index.html with the following code:

```html
<body onload="Greeting()">
```

- Add the following code to villaScript.js.

```JavaScript
function Greeting() {
        var x = document.getElementById("jumbomain");
        var userResponse = prompt('Welcome to Tuscany Villa. What is your name?');
        x.getElementsByTagName('h1')[0].innerText = 'Welcome to Tuscany Villa ' + userResponse;
      }
```
!SLIDE

- When we load our site, we can take input from the user and use it however we want.

- We prompt the user upon load of our site:

<div style="text-align:center" class="img1"><img src="./resources/js12.png" /></div>

- We take the user input and use it in another element:

<div style="text-align:center" class="img1"><img src="./resources/js13.png" /></div>


## Variables

- As we have seen, JS uses variables just like we have in C#.

- Since JS isn't statically typed, we don't have to expressly tell JS what type of variable we have.

- This is a cool feature but it can also get you into trouble.

- For example, if you're trying to do some sort of math operation and accidentally pass a boolean value instead of a number, you'll get unexpected functionality.

- Variables are declared in JS using the `var` keyword, like so:

```JavaScript
var myNumber = 42;
var myString = 'Hello world'
var myFunction = function() {
    // I do stuff
}
```
- With these variables declared, you can now use them inside your code.

- These are more useful than literals because you can reference them as many times as you want without having to explicitly define them again.

## Other useful comparisons

- Some of the concepts we used in C# are the same when using JavaScript. Here some examples:

- Tools like **concatenation**, **comparison operators**, **logical** and **mathematical operators** all work the same.

- There are 2 additional comparison operators I would like to highlight: <mark><code>===</code></mark> and <mark><code>!==</code></mark>

- These have more specificity than `==` and `!=`

- With the less specific operators, if two objects have the same value, they are considered equal.

- The more specific versions, however, will compare the types *and* values, e.g.

```javascript
5 == '5' // true
5 === '5' // false
```


## Arrays

- Arrays in JS are way more useful than the arrays we're used to. 

- They're **mutable**, which means you can alter them.

- There are two ways to declare an array:

```javascript
var myFavoriteFruits = ['bananas', 'oranges', 'papaya', 'mango', 'pineapple'];
var myEmptyArray = new Array(5);
```
Similar to what we're used to, these arrays are also zero-indexed and have a built-in **length** property.

- Let's use an array as well as some of the other tools we have in our Tuscany Villa website.

!SLIDE

- Replace the code at line 160 of your index.html with the following code:

```HTML
<div class="col-4 square bg text" id="villachoice">
```

- Insert the following code at line 167 of your index.html by inserting a blank line:

```HTML
<div class="col-4 square bg text" id="villaswap" style="display:none">
    <div class="content">
        <p class="lochead">Available Villas</p>
        <p class="locp" id="villout"></p>
        <input id="buttonloc" type="submit" value="Return" onmouseover="overBtn(this)" onmouseout="outBtn(this)" onclick="SwapDivsWithClick('villachoice', 'villaswap');">
    </div>
</div>
```

!SLIDE

- Paste the following code into your villaScript.js
```JavaScript
function GetVilla() {
    var villaArray = new Array(0);
     var userResponse = confirm('Would you like to check the availability of a Villa?');
     while(userResponse) {
        var villa = prompt('Please enter the name of a villa');
        userResponse = confirm('Would you like to add another Villa?');
        villaArray.push(villa);     
     } 
     var d = new Date();
     var m = d.getMonth();   
     var x = document.getElementById("villaswap");
     if (m > 0 && m < 4) {
         x.getElementsByTagName('p')[1].innerText = villaArray[0];
     } else if (m > 3 && m < 7) {
         x.getElementsByTagName('p')[1].innerText = villaArray[1];
     } else if (m > 6 && m < 10) {
         x.getElementsByTagName('p')[1].innerText = villaArray[2];
     } else if (m > 9 && m < 13) {
         x.getElementsByTagName('p')[1].innerText = villaArray[3];
     } else {
         x.getElementsByTagName('p')[1].innerText = 'Sorry we have no villas available';
     }
}
```
## Push and Pop

- As we have seen in our recent JS code, we can add and remove items to the end of our arrays using the `.push()` and `.pop()` methods.

```JavaScript
//This adds the value of the user input 'villa' to the end of our villaArray.
villaArray.push(villa);     

//This removes the last element from our villaArray
villaArray.pop(villa);     
```

## Lets take a breather

- We have covered a lot of material I feel you will find very useful.

- Likewise, the material we have covered should give you a good understanding of how to implement JS.

- In the coming slides, I will present some other JS tools that you could use to enhance your skills.

- Keep in mind there are many tools in JS, so what we have covered is not the end all, be all.

## Splice

- The **splice** method allows you to remove any number of items from your array at any given location.

- Splice accepts two parameters: `.splice(index, number of items to remove)`

- So, for example:

```javascript
// Current value of myFavoriteFruits
// ['bananas', 'oranges', 'papaya', 'mango', 'watermelon']

var myMostFavorite = myFavoriteFruits.splice(2, 2);
// This will store the array ['papaya', 'mango']

// It also makes our array have the value of
// ['bananas', 'oranges', 'watermelon']
```

## Shift and Unshift

- Now you're wondering, if I can add and remove to the end of my array, what if I want to add to the beginning?

- We use the methods `.shift()` and `.unshift()`.

```javascript
// Makes our array have the value of
// ['blueberries', 'bananas', 'oranges', 'watermelon']
myFavoriteFruits.unshift('blueberries');

// This variable gets passed the value 'blueberries'
var kingOfBerries = myFavoriteFruits.shift();
```

## Assigning Values

- There are a few different ways to add values to our array.

- We can declare our array with values already inside:

```JavaScript
// This array has five values. Notice how
// we can mix value types in JS arrays
var numbers = [1.0, 2, 'three', 4, 'five'];
```

- We can also give values to specific indices in arrays:

```JavaScript
var names = new Array(3);

// This changes the value of the second
// item from null to 'Alan'
names[1] = 'Alan';

// This creates a key of 'Brian'
// and gives it the value 'Brian'
names['Brian'] = 'Brian';
```

## Objects

- We have objects in JS the same as C#. They behave in a similar fashion.

- **Methods and Properties vs. Functions and Variables:**

	- Functions and variables are the anonymous versions of methods and properties.

	- Once a variable is place inside of an object, it is a property of that object.

	- The same goes for functions and methods.

	- Let's look at how to declare an object in JS and give it some properties and methods.

```javascript
var Car = {
    color: 'green',
    hornSound: 'BEEEEP!',
    numOfWheels: 4,

    honk: function() {
        console.log(this.hornSound)
    }
};

// We can also add values like this
Car.engine = 'V8';
```

## Dates and times

- We can access current times and dates on the user's machine with JavaScript.

- Make sure to note that times are based on the settings on the user's machine, so we can't be sure that our intended time or date will display.

- We used two Date methods in our last JS entry: `new Date();` and `getMonth();`

- We reference a new date object like so:

```javascript
var date = new Date();

// This method shows the number of milliseconds
// that have passed since 1 January 1970 00:00:00 UTC.
date.getTime();

// This value gets the current year
date.getFullYear();
```

- There are many useful methods on the date object. 

- Read about them [here](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date). You can read about why we're getting milliseconds since 1 January 1970 [here](https://en.wikipedia.org/wiki/Unix_time).

## Intervals

- JavaScript has plenty of useful built-in methods for you to use.

- Two of the most frequently used are `setInterval(time in milliseconds, function to execute)` and `setTimeout(time in milliseconds, function to execute)`.

- These are used to delay operations from happening until a specified time.

- In the case of `setInterval()`, we are setting up intervals for operations to be executed multiple times in increments set by the developer.

!SLIDE

Let's see how they work:

```javascript
var i = 0;

// This will call setInterval() and execute the anonymous function 
// that we're passing into it.
var interval = setInterval(function() {
    i++;
    console.log(i);

    if (i === 10) {
        clearInterval(interval);
    }
}, 1000);

// This will log to the console after 11 seconds.
setTimeout(function() {
    console.log('This took 11 seconds');
}, 11000);
```

- But, what is that function doing?

## Callbacks

- That anonymous function that we pass to `setInterval` is called a callback.

- Callbacks are used to execute specific behavior with a value that has been passed to it. Let's explore:

```javascript
var colors = ['red', 'green', 'blue', 'yellow'];
var listAllColors = function(array, callbackFunction) {
    list = '';
    for(var i = 0; i < array.length; i++) {
        if (!(i === array.length - 1)) {
			list += array[i] + ', ';
		} else {
			list += array[i];
		}
        list += array[i] + ', ';
    }
    callbackFunction(list);
};
listAllColors(colors, function(listOfColors) {
    console.log(listOfColors);
});
```

!SLIDE

This prints the concatenated array to the console:

<img src="./resources/callbacks.png" alt="callbacks" style="width: 100%;">

## DOM Manipulation

- Probably the biggest tool we have in JS is DOM manipulation.

- This is what allows you to dynamically populate your page with elements based on data being updated.

- Let's look at some code to see how this works.

- Let's look at referencing DOM elements first:

```html
<!-- index.html -->
<body>
    <h1 id="title">Here's my title</h1>
</body>
```
```javascript
// app.js
// This tells our browser that we are
// referencing this specific element
// and sets it to a variable.
var title = document.getElementById('title');
```

!SLIDE

- We can also work with attributes on the element (e.g. things like `href` or `type`).

```javascript
// This gives us a variable with the value
// of the ID attribute.
var titleId = title.getAttribute('id');
```

!SLIDE

- We can also see if an element has an attribute and, if so, examine what its value is.
```javascript
// This returns us a boolean value
// of false because our 'h1' element
// doesn't have an 'href' value
title.hasAttribute('href');
```

## Remove Elements

- The same way we can manipulate elements, we can remove them:

```javascript
// The remove method is built in to
// JavaScript and deletes an element for us.
title.remove();
```

## Query Selector

- So, we find ourselves selecting elements in a very clumsy way.

- There seems to be a different way to find each element in JS.

- Why not one way? BECAUSE THERE ARE TWO! `.querySelector('thing')` and `.querySelectorAll('things')`

```javascript
// This selects the first element of
// its kind in the document.
document.querySelector('h1');

// This selects a group of things
// that have the parameter in common.
document.querySelectorAll('.content');
```

- This way, we can select elements more dynamically.

## Event Handlers

- Event handlers are the way we deal with interactivity.

- So, for example, you want to change the way your heading is sized when your user clicks on it, you can!

```javascript
var title = document.querySelector('#title');

// This is going to make your 'h1' tag(s)
// be '50px' when you click it
title.addEventListener('click', function() {
    title.style.fontSize = '50px';
});
```

Now for some...

## PRACTICE!

Clone the example project from [here](https://github.com/WeCanCodeIT/javascript-example-project). ENJOY!
<style type="text/css">
.img:hover  {
        transform: scale(3);
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.5);
    }
.img1:hover  {
    transform: scale(1.5);
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.5);
}
</style>