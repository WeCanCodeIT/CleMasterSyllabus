title: Intro To MVC
subtitle: Model-View-Controller
theme: league



## Description

- What does MVC stand for?
- Why use MVC?
- When should MVC be used?
- What are the steps to creating an MVC project?
- What role does the Model play?
- What role does the View play?
- What role does the Controller play?
- What is Razor?

## What is MVC?

- MVC is a way we can design our web applications. Web applications are most websites you visit that have interactivity. 

- Things such as a login, the ability to save information, or a page that changes depending on your settings are all good signs of a web application. (We'll dig more into the definition later.)

!SLIDE

- There are many different ways to design web applications. But, as we build larger and larger applications, we need a better way to manage them. Without MVC we might be left hundreds of unique files to edit and manage to get the functionality we like.

!SLIDE

- MVC takes a large application and splits it into three distinct parts: the **M**odel, the **V**iew, and the **C**ontroller.

- This is where we get our acronym MVC from. Each of the three parts has a specific purpose.

- There isn't much overlap, so it allows our applications to be segmented by purpose.

!SLIDE

- Separating our application into distinct parts does a few things:

- First, it allows us to simplify our code. Thus, we can look only in the part that matches the functionality of interest rather than searching everywhere.

- Next, it allows us to reuse our code. Instead of writing unique code for each part, we can write more generally and reuse the code where appropriate.

- Often at large organizations a separate team may be responsible for the model, the view, and the controller.

- Now let's look at what each one of these parts does in detail.


## Model

- The *Model* handles all of the data and contains the business logic.
  - For example, the classes you create for your application (with attributes and methods) belong in the model.
- The model represents what is being displayed. If you check your email via Gmail (or a similar web client), the {content} of your emails represents the model.

## View

- The *View* is how the model is shown to the user.
  - The interface you're looking at when you're checking Facebook, including its styling (fonts, borders, etc) represents the view.
    - Different people checking their Facebook will see the same interface, but different content. Their feeds are unique. Different people will see the *same* view but *different* models.
- This is the front-end of the application where HTML, CSS, JavaScript languages belong.

## Controller

- The *Controller* is responsible for controlling the flow of the program.
  - The controller controls the interactions between the models and views. It's the "intermediary" in between the model and view.
- The controller is the glue that holds the two together. When you want to create or delete an email in your email client, you're sending a message to the controller. It is responsible for updating the model (creating or deleting the email), then refreshing the view (showing you what you see on the screen).


## See It

- Let's walk through [creating an ASP.NET MVC Web Application](https://docs.google.com/presentation/d/1yqn9NZOcxetfKugCa_jkCg2vbTnDQMY14IVDMBR9mqA/edit?usp=sharing)
- App_Start Folder
  - Here you will find config files. Let's look specifically at the `RouteConfig.cs` file. Double click on it to open it.
  - You will define the routes and those routes will map URLs to a specific controller action.
  - An **action** is just a method on the controller. 
  - It can also pick parameters out of that URL and pass them as parameters into the method.
  - This route that is defined in the application is the default route. 

!SLIDE

  - When you see a URL arrive in the form of (something)/(something)/(something), then the first piece is the **controller name**, second piece is the **action name**, and the third piece is an **ID parameter**.
  - Let's see what happens when you change `defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }` from Index to About, like so: `defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }`
    - The new default route is the About page instead of the Index page. Save and run the app to see for yourself.
    - Now change the homepage/default route back to the Index page.

!SLIDE

- Content Folder
  - The content folder holds the Bootstrap files as well as the Site.css file.

!SLIDE

- Controllers Folder
  - The controllers folder holds all of the MVC controllers. Let's look at the `HomeController.cs`.
  - Notice it has methods that return the view for each of the pages of our application.

!SLIDE

- Models Folder
  - The models folder has all of the classes for the data or business logic of the application.
  - Where did the Account and Identity classes come from?

!SLIDE

- Views Folder
  - Inside the Views folder, you will find a subfolder for each of the Controllers (Home, Account, Manage) plus a Shared folder.
  - Let's first look at `Index.cshtml` in the Home subfolder and then run the page. See what is rendered in the browser. There is body content, but also a navbar.
  - Delete everything in the `Index.cshtml` except for the first few lines that include:

  ```csharp
  @{
    ViewBag.Title = "Home Page";
  }
  ```

!SLIDE

  - Now save and run the app. Notice what's left. Explore and try to figure out where the navbar is coming from.
  - Now, open the Shared Folder inside Views. Double-click on `_Layout.cshtml` 
  - The Layout page is like a template. It holds all of the other information, such as the Head section, Navbar, and Footer that we want to be applied to all views. 
  - Look for `@RenderBody()` on the Layout page.
  - `RenderBody()` is where the content of each of the Views, such as Index or About, is placed with respect to the Layout page.   

!SLIDE

- Scripts Folder
  - This folder holds all of the JavaScript and jQuery files.
  

## Razor

- Razor isn't an entirely new language, it simply means "we're executing this C# in the view to create some additional HTML". If we think about a social media site, this is how each user has a separate feed based on the users or topics they follow.

- A section of Razor code is started with an `@` symbol. You can think of this as a _switch_ that causes the rest of the line. For example:

```csharp
@Html.DisplayFor(modelItem => item.Details)
```

- If an `@` symbol is placed in front of curly brace, the section between the opening and closing closing curly brace will all be Razor. This allows us to have multiple lines of Razor. For example: 
```csharp
@{
    ViewBag.Title = "Index";
}
```

!SLIDE

- We can also use Razor to call methods. Most commonly you'll see Razor used to call **HTML helper methods** - we'll cover these in more detail later. These are methods that can make web programming a lot more convenient.

- You can place an `@` in front of a method call and everything up until the end of the method will be Razor. This allows us to insert Razor in our HTML.

- For example, the following Razor method will produce HTML that will populate the `href` attribute of a link: 
```csharp
   <a href="@Url.Action("ToggleDone", new {id = item.ItemID})">
``` 

<style type="text/css">
.reveal section img.logo {
	border: none;
	background-color: rgba(255, 255, 255, 0.25);
	padding: 1rem;
}
.reveal ol, .reveal dl, .reveal ul {
	margin: 0 0 1rem 2rem;
}
</style>
