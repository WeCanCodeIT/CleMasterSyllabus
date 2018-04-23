title: Spring Data JPA
subtitle: Accessing data through JPA
theme: league

% TODO update screenshots for Windows UI




## There are standard behaviors in a typical REST API 

- Get all resources
- Get an individual resource 
- Create or add new resource
- Update/change a resource
- Delete a resource

## What is JPA

- Java Persistence API
  - Allows for **Object-Relational Mapping (ORM)**
- Most databases that you are accessing are SQL
- **SQL** is a Relational Database
- A **Relational Database** contains tables and keys 
- ORM lets you map entity classes to SQL tables

## The Entity Class

- The class that needs mapped to the database
- Think of the member variables (instance data) as the columns
- Think of the objects (class instances) as the rows 

Example:

 ```
  @Entity
  public class CourseTopic {
  
  @Id
  @GeneratedValue
  private String id;
  private String name;
  private String description;

```
- with the **@Entity** annotation JPA knows to create a table called CourseTopic with 3 columns: id, name and description
- **@Id** tells the database where the primary key is
- The annotations affect what is directly underneath, therefore attaching @Id to the String id member

## The Process

- Step 1: Entity Mapping
- Step 2: Find the class to connect to the database and run commands to access, save and retrieve data
  - No matter what your entity is, the structure will remain very similar (Standard operations)
- Step 3: Determine the key (link) for your database using the @Id annotation

## The CrudRepository

- Contains the logic for an entity class
- Each Entity class can create its own repository to extend the CrudRepository
- CrudRepository Generic Type
- CrudRepository<Entity Class, Type for Key>
  - **public interface TopicRepository extends CrudRepository<CourseTopic,Long>**
- You will now have access to all methods that come out of the box with CrudRepository
  - These methods will update
    - Get all resources
    - Get an individual resource 
    - Create or add new resource
    - Update/change a resource
    - Delete a resource 

## One to Many

- **@OneToMany** (mapped by "instructor")
- one Instructor can be tied into multiple CourseTopics
- A course is then tied to a particular topic 
- **mapped by** is the owning side of a bi-directional relationship

## Many to One

- **@ManyToOne**
- There can be many courses tied to one instructor


% TODO should move this after I've nailed it down

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