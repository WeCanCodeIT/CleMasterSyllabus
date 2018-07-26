# Wardrobe MVC
## Due: Monday 9:30am
### - [Submission Link](https://docs.google.com/forms/d/e/1FAIpQLScUEvl_ZgH_OgBu0zbg_WIvB6zBSkkXh7wfxqjv4LwLdBDxLg/viewform)

## Overview
As a junior developer, you are being tasked with developing a web application for managing the contents of your wardrobe. The app will allow you to add, edit, view, and delete items in your closet.

## Skills Required

In order to deliver this application solution, you will need the following skills and knowledge.
- Database First MVC

## Tasks

### Application Logic Requirements

During application development process, the following application logic requirements were identified.
- [ ] Clothing MUST be organized by type
- [ ] The following categories MUST be included:
  - [ ] Tops
  - [ ] Bottoms
  - [ ] Shoes
  - [ ] Accessories
- [ ] Model(s) MUST include the following properties:
  - [ ] ***category name***ID
  - [ ] Name
  - [ ] Photo
  - [ ] Type
  - [ ] Color
  - [ ] Season
  - [ ] Occasion
- [ ] Controllers
  - [ ] Each model MUST have a controller
- [ ] You MUST determine the appropriate columns/constraints to use for all fields.
- [ ] A SQL script for the database (schema and data) MUST be generated.

![Generate SQL scripts](generatesql.gif) - *Remember to go to "Advanced", "Types of Data to Script", and choose Schema and Data!!*

### User Interface Requirements

During application development process, the following user interface (UI) requirements were identified.
- [ ] Views
  - [ ] The layout for the index and details pages MUST be customized to properly show the properties for the following:
    - [ ] Tops
    - [ ] Bottoms
    - [ ] Shoes
    - [ ] Accessories
  - [ ] Photo MUST be properly included where appropriate (index/detail)
  - [ ] Homepage MUST be updated for your app
- [ ] Bootstrap/CSS
  - [ ] Navbar MUST be updated
  - [ ] Thumbnails MUST be included where appropriate
  - [ ] At least 1 other Bootstrap component of your choice MUST be utilized
  - [ ] The website MUST have a responsive layout (using Bootstrap grid)
  - [ ] Styling MUST be customized for all index and details pages
- [ ] You MUST customize all of your views to develop the best user experience you can manage. Show photos when appropriate, but don't have them get in the way. Use Bootstrap effectively to make the app responsive for both desktops and mobile devices. Add your own styles to make it a little less "bootstrappy".


## Stretch Tasks

During application development process, the following application logic requirements were identified. These requirements are not mandatory and are in no way a requirement for delivering the application.
- [ ] A natural progression of this app COULD be to support the creation of outfits - a collection of coordinating tops/bottoms/shoes/accessories. This COULD be built into your model to create views for working with outfits.

- [ ] Ultimately, your views COULD be integrated, so you can see all the pictures of each item per outfit.

## Hints
As usual, start with the model, and spend some time considering how many tables to create and how they will be related.

Use the scaffolded controller views to get going and put some data in your app, and then start to work on the index view(s) and making them look nice.

Whether or not you store these as separate tables or a single table is up to you. You will need to have views that allow the user to focus on clothing by type, so keep that in mind when making your decision.

Always target MVP - and once you get there, figure out what the next MVP is!

Don't forget to add your `.gitignore`
