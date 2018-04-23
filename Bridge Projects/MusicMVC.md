# Music Database-First MVC App

Create a database-first MVC application that keeps track of musical artists and their albums. 

### Requirements
- Two Tables
  - Artists
    - You won't need many columns/fields/properties for this table
  - Albums
    - You might want to include a track listing, whether or not it won a Grammy, the biggest hit off the album, the year it was released, or any other information you deem important.
  - There should be a one-to-many relationship between the two tables
    - How many albums can an artist have? Usually (when it's not a mixed tape), how many artists does an album have?
  - You should have an IMAGE for each artist and each album
    - Remember to use an `nvarchar(200)` as your data type for the image. *NOTE*: You might pick a different size for your `nvarchar`, but make sure it's big enough to hold an image URL.
- Customized Views
  - Artist Views
    - Index view should be customized (NOT default table layout - use other HTML elements)
    - Index view should be styled
  - Album Views
    - Index view should be customized (NOT default table layout - use other HTML elements)
    - Index view should be styled
    - Details view should be customized and styled
 - Photos should be visible in the Index views for both Artists and Albums *AND* in the Details view for Album.
 
 - Must have at least 2 artists.
 - Must have at least 1 album per artist (preferably 2).
