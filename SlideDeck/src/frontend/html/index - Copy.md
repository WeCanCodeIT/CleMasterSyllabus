title: HTML
subtitle: The Structure of the Internet
theme: league

# What is HTML?

HTML (Hyper Text Markup Language) is the first of three languages we use to create the front-end (also known as the client-side) of the web. Each of the three languages that we use (HTML, CSS, and JavaScript) have a specific job to do and it is important to keep these concerns separate. HTML's job is to structure and organize your content.

## Standard HTML Document

HTML is marked up with tags. There are common tags that you will see in each HTML document. A basic HTML document looks like this:

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <title>Document</title>
</head>
<body>

</body>
</html>
```

Tags to note are:
- `<!DOCTYPE html>`
- `<html>`
- `<head>`
- `<body>`

You'll notice these each have a closing tag (i.e. `</body>`). Let's look at these in more detail.

## DOCTYPE

<pre><code class="language-html" data-noescape>
<mark>&lt;!DOCTYPE html&gt;</mark>
&lt;html lang="en"&gt;
&lt;head&gt;
    &lt;meta charset="UTF-8"&gt;
    &lt;meta
        name="viewport"
        content="width=device-width, initial-scale=1.0"&gt;

    &lt;title&gt;Document&lt;/title&gt;
&lt;/head&gt;
&lt;body&gt;

&lt;/body&gt;
&lt;/html&gt;
</code></pre>

The DOCTYPE tag tells your browser that this document is HTML. With that declaration, your browser knows to interpret this as HTML and display it as such.

## HTML Tag

<pre><code class="language-html" data-noescape>
&lt;!DOCTYPE html&gt;
<mark>&lt;html lang="en"&gt;</mark>
&lt;head&gt;
    &lt;meta charset="UTF-8"&gt;
    &lt;meta
        name="viewport"
        content="width=device-width, initial-scale=1.0"&gt;

    &lt;title&gt;Document&lt;/title&gt;
&lt;/head&gt;
&lt;body&gt;

&lt;/body&gt;
<mark>&lt;/html&gt;</mark>
</code></pre>

The `<html>` tag houses all of your other tags. All of your content needs to be inside of them.

## Head Tag

<pre><code class="language-html" data-noescape>
&lt;!DOCTYPE html&gt;
&lt;html lang="en"&gt;
<mark>&lt;head&gt;</mark>
    &lt;meta charset="UTF-8"&gt;
    &lt;meta
        name="viewport"
        content="width=device-width, initial-scale=1.0"&gt;

    &lt;title&gt;Document&lt;/title&gt;
<mark>&lt;/head&gt;</mark>
&lt;body&gt;

&lt;/body&gt;
&lt;/html&gt;
</code></pre>

The `<head>` tag houses meta data for each of your pages. This content gives information to your browser about the page and content on the page. This is also where CSS and JS files can be attached to your page.

## Body Tag

<pre><code class="language-html" data-noescape>
&lt;!DOCTYPE html&gt;
&lt;html lang="en"&gt;
&lt;head&gt;
    &lt;meta charset="UTF-8"&gt;
    &lt;meta
        name="viewport"
        content="width=device-width, initial-scale=1.0"&gt;

    &lt;title&gt;Document&lt;/title&gt;
&lt;/head&gt;
<mark>&lt;body&gt;</mark>

<mark>&lt;/body&gt;</mark>
&lt;/html&gt;
</code></pre>

The `<body>` tag houses all of the content that your user will see/interact with.

# Box Model

## The Box Model in HTML

HTML tags and the content they house are called elements.

`<p>This is an element</p>`

These elements can be thought of as boxes. We will often house elements inside of each other. This can be for organization or just as a method of containing elements.

## More boxes

Each HTML element in the body has a structure that looks like this:

![box model image](./resources/boxmodel-image.png)

- At the center is the content inside of your element. (i.e. `<p>This is the content</p>`).
- Just outside of that we have the padding. Padding adds space between your content and the inside of your element.
- The next layer is the border. The border outlines your element. Borders don't have a value by default.
- The final layer is the margin. The margin is similar to padding but this creates space outside of your element.

# Display Values

## Inline vs. Block

There are two basic display values, inline and block. All HTML elements have one of these values by default.

Block level elements can be thought of like building blocks. These elements will have the width of your viewport and will stack one on top of the other based on where they are in the code.

Inline elements will only take up as much space as their content requires. Think paragraphs, anchors, or spans.

## Common Tags

Common tags you'll use in HTML5:

| Tag                     | Use                                                          |
| ----------------------- | ------------------------------------------------------------ |
| `<h1>, <h2>, <h3> ...`  | For headings                                                 |
| `<p>`                   | For blocks of text                                           |
| `<ul>, <ol>`            | Used to make lists                                           |
| `<section>`             | Used to organize related elements                            |
| `<article>`             | Similar to section. Usually specifically for actual articles |
| `<a>`                   | Used to make links                                           |
| `<img>`                 | Used to include images in your code                          |
| `<title>`               | Used to declare the title of your page                       |

## Deprecated Tags

Tags you may encounter but shouldn't use anymore due to separation of concerns:

| Tag         | Use                                            |
| ----------- | ---------------------------------------------- |
| `<b>`       | Used to make things bold                       |
| `<i>`       | Used to make things italic                     |
| `<center>`  | Used to center elements                        |
| `<font>`    | Used to change the font of a group of elements |

## Element Attributes

There are attributes that you can include on your elements that will affect the way they behave. Some attributes are required to make an element function. These include:

- href (hypertext reference) - Used to give anchor tags a location to link to
- type - Used usually on input elements to describe what type of input they should accept
- src (source) - Used in script tags and img tags. These house the location of the resource

## Custom Attributes

In HTML5, we have the ability to create custom attributes. These can be very useful for identifying items and selecting them.

Custom attributes need to be prefixed with 'data' in order to be recognized properly.

i.e. To add a key attribute to an element:
```html
    <ul>
        <li data-key="item1">Item 1</li>
        <li data-key="item2">Item 2</li>
        <li data-key="item3">Item 3</li>
    </ul>
```

This is very common in new JavaScript frameworks.

# DIV and SPAN tags

## Divs

Div tags are a useful tool in HTML. A `<div></div>` tag is a generic block level element. They are used mostly for organizational purposes in HTML code. If you have a block of information that exists as a group, you may choose to group it in a div to keep it organized and identify it as one unit:

```html
<div class="my-info"><!-- more on classes shortly -->
    <h2>My Name</h2>
    <h3>My Title</h3>
    <p>10/13/2017</p>
</div>
```

## Spans

Similar to divs, spans are a generic element in html as well. The difference being that they are generic inline level elements. These can be used for highlighting individual text in a paragraph or list item:

```html
<p>""You miss <span>100 percent</span> of the shots you never take."
— Wayne Gretzky" - Michael Scott</p>
```

Span tags are used mostly to add emphasis or apply specific CSS styles.

# IDs and Classes

## IDs

IDs in HTML are used as unique identifiers for your elements. You can apply them to specific elements but, no two elements should have the same identifier. You can think of them as similar to the key value in a map.

```html
<h1 id="page-title">My Title</h1>
```

This is helpful when selecting specific elements in CSS and JS. You can also use them for their specific location in a page. For example, if you give an anchor tag an existing ID as a value, when you click the link, it will take you to the location of the element with that ID on the page.

```html
<a href="#page-title">Go back to where 'My Title' is located on the page.</a>
```

This can be useful for saving scrolling on mobile devices.

## Classes

Classes in HTML are similar to IDs. They identify an element in your code. The difference between IDs and classes is that classes are not unique. You may give multiple elements the same class and you can give one element multiple classes. For example:

```html
<p class="blue-text yellow-background medium-font-size red-border">My super long paragraph</p>
```

or:

```html
<li class="item item-1">Apple</li>
<li class="item item-2">Orange</li>
<li class="item item-3">Banana</li>
<li class="item item-4">Spaghetti</li>
```

## Now you do it

Navigate to [the exercise](https://github.com/donhamiltoniii/semantic-markup) on Github and follow the instructions in the repository to complete the project.
