title: Introduction to SQL Queries
subtitle: The Basics
theme: league

% TODO update screenshots for Windows UI


## Taking off the seat belt. Writing SQL Queries instead of using the editor.

You've used SSMS previously to create databases for your MVC database first project. Let's review how we created tables there, added keys, and even selected from the table. What's going on? Behind the scenes of SSMS, which is a GUI for SQL Server (the db), SQL Queries are hard at work for you. It's time to learn how to write them yourselves. 

## SQL is a language

SQL stands for Structured Query Language. It's a language specific to getting information from databases like SQL Server. It's pretty standard across relational DBs, so it is also used with MySQL, Oracle, and many more. 

## What are queries?

- A **query** is a question that is asked of a database.  This can include one table or many tables to find the answer.

- We can create queries using SQL Server Management Studio (SSMS) and the **Query Editor Window**.

- SSMS executes queries for each action it does, so when you're clicking buttons and updating tables, you're actually executing SQL queries in the background.  We are going to explain some of the queries that you will use most often when asking questions of databases.

## Show It

- Let's practice creating a database by hand. First, open up SSMS and create a new database called QueryPractice.
- To start a new query right click your new database and select "New Query". 

    <div float="right"><img src="./resources/ChangeDatabaseScreenShot.jpg" /></div>
- This opens a new Query Editor Window for us. 

!SLIDE

- We can change the database we are working with using the drop down in the top left. 
<div float="right"><img src="./resources/ChangeDatabaseScreenShot.jpg" /></div>

Be sure your query editor window says QueryPractice.

!SLIDE
    
- We are able to enter our queries into this window. There are two way we can run our queries in this window.
    - Each time we hit the green "Execute" button, or we hit the F5 key it will run all SQL commands in our query window.
    - Another common way to execute queries is to select a line or lines that contain SQL commands and hit the green "Execute" button, or the F5 key. This will only run the selected lines. This can be useful if you have a number of different SQL commands, you don't need to create a new query window for each new set of commands. 
        - BUT, you need to be very careful to make sure you _ALWAYS_ have something selected or else it will run every command in your query window.
- Formatting SQL: SQL is non case-sensitive, but it's convention to write all the the SQL specific keywords in all UPPERCASE. We can end our statements with a **semicolon** (;). They aren't always required and our query will probably work without them, but it is the standard to include them. We can break our SQL into as many lines as we like - people like to format their SQL queries in different ways. 

## Queries

- We'll be creating a database to help track the menu items in a restaurant. 
- Let's start with a query to create a new table:

## Creating a table

```SQL
CREATE TABLE MenuItem(
    MenuItemID int IDENTITY(1,1) NOT NULL,
    ItemName varchar(50) NOT NULL,
    ItemDescription varchar(50) NULL,
    Price float NULL,
    CONSTRAINT PK_MenuID PRIMARY KEY CLUSTERED (MenuItemID)
)
```
- You may notice the keywords `CONSTRAINT` and `CLUSTERED`, which may be new to you. A `CONSTRAINT` in SQL specifies certain properties that the database data must comply with, like a set of rules. The `CLUSTERED` keyword means the records in the table are physically stored in a sorted manner.

- Before you run the preceding query, take some time to discuss the command with your neighbor. What looks the same? What looks different? Do you notice anything familiar?

- Now, add the query into your query window and run. If everything ran successfully you should get the following message: `Command(s) completed successfully.`

## INSERT 

- Now that we have a table, let's insert some data into it. We can use the `INSERT` command to do that.

- Before running the `INSERT` command take some time to review these commands. Take note at how we list each column we want to _insert_ into, separated by commas. Then in the next section we list each of the values to be inserted into the columns.

```SQL
INSERT INTO MenuItem ([ItemName],[ItemDescription],[Price]) VALUES 
	('Hamburger', 'Angus beef', 12.00);
INSERT INTO MenuItem ([ItemName],[Price]) VALUES ('Salad', 7.00);
INSERT INTO MenuItem ([ItemName],[ItemDescription],[Price]) VALUES 
	('Cheese', 'Swiss', 5.00);
INSERT INTO MenuItem ([ItemName],[ItemDescription],[Price]) VALUES 
	('Hamburger', 'Black Bean Burger', 8.00);
```

- After performing the operation you should see the following message: `(1 row(s) affected)`, once per insert statement.

## SELECT

- Now that we have some info in the database how do we view it? Let's start with the following `SELECT` statement

```SQL
SELECT * FROM MenuItem;
```

- It starts out with the `SELECT` keyword. The next part is the asterisk (*), this means we will pull back _all_ columns for the table. Which table exactly? The `FROM` keyword is what we use to designate which table we're selecting from. And `FROM` is followed with the table we're selecting from. In this case its our `MenuItem` table.

!SLIDE

- How else can we select things? If we don't need all columns, we can specify exactly which columns we want to pull information from. Here is how we select just the `ItemName` and the `Price` columns in the `MenuItem` table.

```SQL
SELECT ItemName, Price FROM MenuItem;
```

## Do It

- There's a lot more we can do with select statements. Work together through the following queries:


```SQL
--If we want to make sure we don't get any duplicates, we can use DISTINCT.
SELECT DISTINCT ItemName FROM MenuItem;
```

!SLIDE

```SQL
--We can use COUNT to count the total number of records in a table.
SELECT COUNT(ItemName) FROM MenuItem;
```

!SLIDE

```SQL
--We can use COUNT with DISTINCT to count unique values in a column.
SELECT COUNT(DISTINCT ItemName) FROM MenuItem;
```

!SLIDE

```SQL
--We can use AVG to calculate the average value of a column.
SELECT AVG(Price) FROM MenuItem;
```

!SLIDE

```SQL
--WHERE lets us further define what we're selecting.
--We can use conditionals similar to an "if" statement in C#.
SELECT * FROM MenuItem WHERE ItemName = 'Hamburger';
SELECT * FROM MenuItem WHERE MenuItemID = 1;
```

!SLIDE

```SQL
--It's also fairly common to see a SQL statement split up
--where each part is on a new line for readability.
SELECT * 
FROM MenuItem 
WHERE ItemName = 'Hamburger';
```

!SLIDE

```SQL
--We can use WHERE to determine when things are not equal as well.
--Both statements are equivalent, the second uses a SQL specific form.
SELECT * FROM MenuItem WHERE ItemName != 'Hamburger';
SELECT * FROM MenuItem WHERE ItemName <> 'Hamburger';
```

!SLIDE

```SQL
--We can compare using SELECT, just like in C#.
SELECT * FROM MenuItem WHERE Price > 7;
```

!SLIDE

```SQL
--We can use the keyword AND to indicate a range with which to compare.
SELECT * FROM MenuItem WHERE Price BETWEEN 7 AND 9;
```

!SLIDE

```SQL
--We can use ORDER BY and ASC to order our results in ascending order.
SELECT * FROM MenuItem ORDER BY Price ASC;
```

!SLIDE

```SQL
--We can also use ORDER BY and DESC to order our results in descending order.
SELECT * FROM MenuItem ORDER BY Price DESC;
```

## LIKE

- In SQL we might have a situation where we might want to search for something, but we don't know exactly what we are looking for. We can use the keyword `LIKE` to include a **wildcard character** in our `WHERE` clauses. This allows us to match a partial string.


- The wildcard character in SQL is the percentage sign (%). We can use it like in the following example.

```SQL
--Here we are using the LIKE and the wildcard character(%)
--to match the remainder of a string.-
SELECT * from MenuItem WHERE ItemName LIKE 'Ham%';


--Finally, we can combine everything we've learned in a query like
--the following. Have fun experimenting!
SELECT AVG(Price) 
FROM MenuItem
WHERE ItemName LIKE 'Ham%';
 ```

## UPDATE

- We've learned how to insert data. What if we want to update the values? We have a lot of different ways of performing updates. The following update will find all the Hamburgers and change their price to 14.0.  

One key to remember about updates is that you _almost always_ want to have a `WHERE` to specify criteria in your `UPDATE` statement, otherwise you will update the *entire table*!

```SQL
UPDATE MenuItem  
    SET Price = 14.0  
    WHERE ItemName = 'Hamburger';
```

## DELETE

- We also have a `DELETE` keyword that removes data. We need to give it a condition - this is how it finds the data (rows) it should delete. 

- NOTE: Be very careful with the `DELETE` command. There is no _undo_, so once the data is gone, it's gone! So just remember to double check before you delete, and don't leave any extra `DELETE` commands in your query window.

```SQL
DELETE FROM MenuItem
WHERE ItemName = 'Hamburger';
```

## Other commands

- There are many other SQL commands to learn, but these are the most common. There are resources at the end of this page that point towards places to learn more about SQL commands.

## Relationships

- We know that Microsoft SQL Server is a _relational_ database. How can we define a foreign key relationship using SQL queries?

- Before we begin we need to delete the table we've been using so far. Don't worry, using SQL queries we can quickly, delete, recreate, and populate our databases and tables with information. To delete our table we can run the following command:

```SQL
DROP TABLE MenuItem;
```
!SLIDE

- Now let's create two new tables with a foreign key relationship. Take some time to study the following example before proceeding.

```SQL
CREATE TABLE Category(
	CategoryID int IDENTITY(1,1) NOT NULL,
	Name varchar(50) NOT NULL,
	CONSTRAINT PK_CategoryID PRIMARY KEY CLUSTERED (CategoryID)
);
```

!SLIDE

```SQL
CREATE TABLE MenuItem(
    MenuItemID int IDENTITY(1,1) NOT NULL,
    ItemName varchar(50) NOT NULL,
    ItemDescription varchar(50) NULL,
    Price float NULL,
    CategoryID int NOT NULL,
    CONSTRAINT PK_MenuID PRIMARY KEY CLUSTERED (MenuItemID),
    CONSTRAINT FK_PRODUCT foreign key (CategoryID) references 
	   Category(CategoryID)
);
```
- Can you see the relationship between the two tables? 

!SLIDE

- We're almost ready to start using our new tables. Before we can use our `MenuItem` table, we need to add data into our `Category` table.

```SQL
INSERT INTO Category([Name]) VALUES ('Lunch');
INSERT INTO Category ([Name]) VALUES ('Dinner');
```

- Now that we have at least one category, we can add new menu items. Can you tell what's different with these `INSERT` statements?

```SQL
INSERT INTO MenuItem ([ItemName],[ItemDescription],[Price],[CategoryID]) 
 VALUES ('Hamburger','Angus beef', 12.00,2);
INSERT INTO MenuItem ([ItemName],[Price],[CategoryID]) VALUES ('Salad',7.00,1);
INSERT INTO MenuItem ([ItemName],[Price],[CategoryID]) VALUES ('Salad',8.00,2);
INSERT INTO MenuItem ([ItemName],[ItemDescription],[Price],[CategoryID]) 
 VALUES ('Ham & Cheese Sandwich','Black Forest Ham with Swiss Cheese',5.00,1);
INSERT INTO MenuItem ([ItemName],[ItemDescription],[Price],[CategoryID]) 
 VALUES ('Hamburger','Black Bean Burger', 8.00,2);
INSERT INTO MenuItem ([ItemName],[ItemDescription],[Price],[CategoryID]) 
 VALUES ('Turkey & Cheese Sandwich','Smoked Turkey & American Cheese',5.00,1);
```

## Do It

- Practice using different SQL commands to insert, update, delete, and select rows from your table. Try calculating different values based on the information stored in your tables.




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