title: Thymeleaf
subtitle: Elegant dining for your development workflow
theme: league

% TODO update screenshots for Windows UI


## What is Thymeleaf?


<div float="right"><img src="./resources/logo.png" class="logo" /></div>

• Thymeleaf is a modern server-side Java Template engine for both web and standalone environments, capable of processing HTML, XML, JavaScript, CSS and even plain text

• Assists in your front-end HTML designs

## Natural Templates

<div class="sidebar">
	<img alt="code" src="./resources/code.png" />
</div>

• HTML Templates written in Thymeleaf still look and work
 like HTML Templates

• HTML can be correctly displayed in browser

• Can also work as a static prototype (useful in team dev) 




## Iterating in Thymeleaf

-th: each 
  - for each item in a collection of items
  - similar to a for each loop traversing a List
  - will iterate over a list of products, array, map or other collection
  
  ## Examples
```
  <tbody>
    <tr th:each="student: ${students}">
        <td th:text="${student.id}" />
        <td th:text="${student.name}" />
    </tr>
	</tbody
```

Concatenation
```
	th:text="'The name of the student is ' + ${student.name}"
```
  
If/Unless
```
  <td>
    <span th:if="${student.age} &ge; 16" th:text="You can drive" /> 
    <span th:unless="${student.age} &lt; 16" th:text="You cannot drive" />
  </td>
```

## Referencing 

- You should match your attributes from your Controller class


In the Controller class...ie StudentController, imagine the following method
```
@RequestMapping("/students")
public String getStudents(Model model) {
	model.addAttribute("students", repository.findAll());
	return "students";
}
```
In students.html notice the collection is referred to as students 
```
 <tr th:each="student: ${students}">

```


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
