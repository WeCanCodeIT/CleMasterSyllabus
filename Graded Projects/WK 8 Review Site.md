# MVC Review Site Project
## Due: Monday March 12 2018 at 9:30am
### - [Submission Link](https://docs.google.com/forms/d/e/1FAIpQLScUEvl_ZgH_OgBu0zbg_WIvB6zBSkkXh7wfxqjv4LwLdBDxLg/viewform)

## Overview
As a junior developer, you are being tasked with developing an MVC web application of either a Technology Review site or a Travel Review site. The application must use multiple models and foreign key relationships.

## Skills Required

In order to deliver this application solution, you will need the following skills and knowledge.
- MVC
- Code First Model Design

## Tasks

### Project Prerequisites

After you have completed all coding and testing of your application, you will ensure the product owner has access to the application by ensuring the following:
- [ ] Correct GitHub link is properly submitted.
- [ ] GitHub repository created from correct folder and contains solution file.

### Application Logic Requirements

During application development process, the following application logic requirements were identified.
- [ ] The following models MUST be created:
  - [ ] Review
  - [ ] Category
  - [ ] You MUST have at least two models and a foreign key relationship. Review the [Bookshelf](https://docs.google.com/a/wecancodeit.org/presentation/d/1C9v9Upx7NWePFbh5kO06GSQnuxdyeJwFVAWsTKHzgdw/edit?usp=sharing) for an example of a foreign key relationship.
  - [ ] You MUST be able to view the styled home page, navigate to the reviews index, click a review and view a styled detail page.
- [ ] The Review model MUST have properties to properly represent all the fields you feel need to be represented in a review. This may include:
    - [ ] ID
    - [ ] Title
    - [ ] Content
    - [ ] Publish Date
    - [ ] Etc.

### User Interface Requirements

During application development process, the following user interface (UI) requirements were identified.
- [ ] Content Requirements
  - [ ] There MUST be a **homepage** (i.e. Index.html inside your Home folder in Views)
    - [ ] The **homepage** MUST include a title for your website and a brief description. You can use lorem ipsum.
  - [ ] There MUST be a **Reviews Index**
    - [ ] All reviews MUST be displayed. Experiment with different ways of presenting the reviews. Follow the examples provided in class to customize your view. Do not use the default table layout.
  - [ ] **Reviews Details**
    - [ ] The details view MUST have customized styling so it does not look like default detail-list (dl, dt, dd) layout. Attempt to make the details view look like an Article or Card on a review site like Yelp.
- [ ] The below MUST be styled (for the Review views ONLY - do not style the Category views):
  - [ ] Homepage
  - [ ] Reviews Index
  - [ ] Reviews Details
    - Note: Use what we’ve learned regarding CSS and Bootstrap to style the pages to your liking. Pages should no longer look like basic Bootstrap. Do not worry about styling the Create, Edit and Delete views initially. 
- [ ] Bootstrap Requirements
  - [ ] Navbar - user MUST be able to navigate to the Reviews Index and Categories Index from the homepage
  - [ ] Row(s) & Columns MUST be used
- [ ] Recommended: Populate Categories table and Reviews table
  - Recommended: Three categories
  - Recommended: Five reviews
  - *NOTE*: Your categories and reviews will not be committed to GitHub because we have not yet introduced you to how to transfer database data to GitHub. Create these categories and reviews to practice, but be aware that the Education Team will be creating their own categories and reviews in your project in order to grade it.
- [ ] Documentation
  - [ ] Program MUST be commented throughout explaining the code


## Stretch Tasks

During application development process, the following application logic requirements were identified. These requirements are not mandatory and are in no way a requirement for delivering the application.
  - [ ] Unique images COULD be added for each review
  - [ ] The Edit, Create, and Delete pages COULD be styled
  
## Hints
 - After your app is created, populate the Categories table with at least 3 categories, and your Reviews table with at least 5 mock reviews. Feel free to fill them out with lorem ipsum.
 - If you want to clean up your Reviews Index page, use CSS and Bootstrap to hide some of the fields, but show them in Details.   
   - For example, maybe you have a Title and an Author field that displays on the Index, but on the Details view you display a Title, Author, Review, and Score. Be creative!
 - Do not do *ANY* styling until you have a working application, including a working foreign key relationship. Best practice is to include styling after you are sure that everything works.
 - This project may seem significantly more difficult than what we've done in class this week, but it is not. It does have more "moving parts", but it is actually not anything more than what you have seen thus far. Don't overthink it!