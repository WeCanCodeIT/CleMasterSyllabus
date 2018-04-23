title: Maps
subtitle: Pairing Keys with Values
theme: league

# What is it?

A map is a construct that allows us to pair keys and values. Maps are sometimes referred to as tables or dictionaries.

Let's say that I have the following student information:

Student ID  |Name
----------  |------------
23A52   |Harvey Dent
68Z29   |Jessica Jones
57W85   |J Jonah Jameson

Each student will have a unique ID, but multiple students could have the same name.

## How Do I…?

Each student ID (*key*) corresponds to a student name (*value*). Each of these key/value pairs is known as a map *entry*. In Java, we can create a `Map` to hold these entries.

***key*<br>↓↓↓**<br>Student ID|***value*<br>↓↓↓↓↓**<br>Name
----------    |------------
23A52     |Harvey Dent
68Z29     |Jessica Jones
57W85     |J Jonah Jameson

`Map` is a *parameterized type*, so we declare it thus, specifying the types for key and value:

```java
Map<String, String> students;
```

<div class="fragment">
<p>The first <em>type parameter</em> indicates the type of the key. Student IDs are <code>String</code>s.</p>
<pre><code class="language-java hljs" data-noescape>Map<<mark>String</mark>, String> students;</code></pre>
</div>

<div class="fragment">
<p>The second indicates the type of the value. Student names are also <code>String</code>s.</p>
<pre><code class="language-java hljs" data-noescape>Map<String, <mark>String</mark>> students;</code></pre>
</div>

## …build it?

`Map` is an *interface*, an *abstract* type rather than a *concrete* type, so in order to *instantiate* (create) a map, we must call the constructor for a concrete type. The most common concrete `Map` is `HashMap`:

```java
Map<String, String> students = new HashMap<String, String>();
```

To add students, we use `put(key, value)`:
```java
students.put("23A52", "Harvey Dent");
students.put("68Z29", "Jessica Jones");
students.put("57W85", "J Jonah Jameson");
```

Let's look at what we've got:
```java
System.out.println("The students are " + students);
```

# What is it Good For?

We know that we could use an array or an `ArrayList` to hold collections of things, so why `Map`?

Imagine we wanted to look up students by name from our example student information. First, we'd ened to create a class to hold student ID and name:

```java
public class Student {
  String id;
  String name;
}
```

Assuming we have populated a collection of `Student` objects, to find a student by ID, we'd do something like this:

```java
for(Student current: students) {
  if("23A52".equalsIgnoreCase(current.id)) {
    System.out.println("Found the student!");
    System.out.println("The student's name name is " + current.name);
    break;
  }
}
```

Maps make this easier. Also, what if there were 20,000 students and the one we were looking for was 19,998th in our list? Maps also perform better for doing lookups like this.

## Finding our Student

`Map` defines a method called `get`. Given a key, the `get` method will return its value.

Assuming we have populated a `Map` named `students` whose keys are IDs (`String`s) and whose values are student names (`String`s), finding a student by ID with a `Map` is simple:

```java
String studentName = students.get("23A52");
System.out.println("Found the student!");
System.out.println("The student's name name is " + studentName);
```

# A Collection Ally

Maps are part of the JCF (**J**ava **C**ollections **F**ramework), but a `Map` is not a `Collection`.

Remember the two types of `Collection` we have talked about?

- `List`: characterized by being *ordered*. May contain duplicate elements.
- `Set`: elements are *unordered*. Elements must be unique.

`Map` keys can not be duplicated and we don't care about their order, so we use a `Set` to represent them.

`Map` values can be duplicated, but their order isn't significant. They don't fit our concepts of a `List` or a `Set`. For these, we use the parent of `List` and `Set`, `Collection`. A `Collection` promises to be no more than a collection of elements over which you can iterate.

## Looking at Keys

To look at a `Map`'s keys, we call its `keySet` method:

```java
Set<String> studentIds = students.keySet();
System.out.println("The student IDs are " + studentIds);
```

## Looking at Values

To look at a `Map`'s values, we call its `values` (Surprise!) method:

```java
Collection<String> studentNames = students.values();
System.out.println("The student names are " + studentNames);
```

## Looking at Entries

If we want to iterate over all (or many) of the entries in a map, looking at both key and value, it is intuitive to do something like this:

```java
for(String id: students.keySet()) {
  System.out.println("This student's name is " + students.get(id));
}
```

The problem with this approach is that it will result in poor performance. (**This is a common interview question.**) This is because looking up the value for a key requires effort, and this code would look up the value for every key.

If we want to iterate over all keys and values, we do something like this instead:

```java
for(Entry<String, String> entry: students.entrySet()) {
  System.out.println("The student's id is " + entry.getKey());
  System.out.println("The student's name is " + entry.getValue());
}
```

## Other Useful `Map` Methods

method                  |what does it do?
------------            |----------------
remove(*key*)           |removes the entry associated with *key*
containsKey(*key*)      |returns true if this map contains the *key*
containsValue(*value*)  |returns true if this map contains the *value*
size()                  |returns the number of entries in the map
isEmpty()               |returns true if the map does not have any entries
clear()                 |removes all entries from the map
