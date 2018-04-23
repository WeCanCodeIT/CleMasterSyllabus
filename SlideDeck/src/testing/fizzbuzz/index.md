title: FizzBuzz Review
subtitle: 1… 2… Fizz! 4… Buzz!
theme: league

# Rules of Testing
- **First Rule**: You can write no production code except to pass a failing test case
- **Second Rule**: You can only write enough of a test case to demonstrate a failure
- **Third Rule**: You can only write enough production code to pass the currently failing test case

# FizzBuzz Kata

## FizzBuzz Game
- "Fizz" if a number is divisible by 3
- "Buzz" if a number is divisible by 5
- "FizzBuzz" if a number is divisible by 3 and 5
- Otherwise, show the number (let's show the number as a String)

## Project Setup
- Open `Git Bash`
- `cd` into your eclipse workspace
- `mkdir fizzbuzz`
- `cd` into the fizzbuzz directory
- copy and paste the following: `curl https://raw.githubusercontent.com/WeCanCodeIT/gradle-scripts/master/basic-junit/build.gradle --output build.gradle`
- `gradle eclipse`
- Open `Eclipse` and import existing project into workspace
- Create a package named `FizzBuzz`
- Create a class named `FizzBuzz` and a class named `FizzBuzzTest`

## Writing the first test scenario
```java
public class FizzBuzzTest {
	
	
	@Test
	public void shouldReturnOneAsNumber() {
		
		FizzBuzz.getAnswerFor(1);
		
	}

}
```

```java
public class FizzBuzz {
	
	public static void getAnswerFor(int num) {
		
	}
	

}
```
ctrl + r to run the test...it will pass 

## Make some changes
```java
public class FizzBuzzTest {
	
	
	@Test
	public void shouldReturnOneAsNumber() {
		
		String answer = FizzBuzz.getAnswerFor(1);
		
	}

}
```

```java
public class FizzBuzz {
	
	public static String getAnswerFor(int num) {
		
		return "";
		
	}
	

}
```
remember...we want to return `String`

## Make more changes
```java
public class FizzBuzzTest {
	
	
	@Test
	public void shouldReturnOneAsNumber() {
		
		String answer = FizzBuzz.getAnswerFor(1);
		assertEquals(answer,"1");
	}

	

}
```
ctrl + r and test should now fail...make the test pass!

# Attempt to write the second test scenario
- Write enough to make it fail
- Then make it pass

## Test scenario 2
In `FizzBuzzTest` add the following

```java
@Test
	public void shouldReturnTwoAsNumber() {
		
		String answer = FizzBuzz.getAnswerFor(2);
		assertEquals(answer,"2");
	}
```

```java
public class FizzBuzz {
	
	public static String getAnswerFor(int num) {
		
		return "" + num;
		
	}
	

}
```
Do you see anything that could be refactored?

## Test scenario 2 refactored
```java
public class FizzBuzzTest {
	
	// arrange
	private FizzBuzz underTest = new FizzBuzz();
	
	@Test
	public void shouldReturnOneAsNumber() {
		
		//act
		String answer = underTest.getAnswerFor(1);
		//assert
		assertEquals(answer, "1");
	}
	
	
	@Test
	public void shouldReturnTwoAsNumber() {
		
		String answer = underTest.getAnswerFor(2);
		assertEquals(answer,"2");
	}

	

}
```
# Complete test scenario 3
- Test should fail
- Edit production code to pass test

## Test scenario 3
In `FizzBuzzTest`
```java
@Test
	public void shouldReturnThreeAsFizz() {
		String answer = underTest.getAnswerFor(3);
		assertEquals(answer, "Fizz");
	}
```

```java
public class FizzBuzz {
	
	public String getAnswerFor(int num) {
		
		if(num == 3) {
			return "Fizz";
		}
		
		return "" + num;
		
	}
	

}
```
# What should be your next logical test scenario?
- Now program it
- Remember write enough code to cause a failing test
- Write enough code to pass a failing test

## Test scenario 4
In `FizzBuzzTest`
```java
@Test
	public void shouldSayBuzzForFive() {

		String response = underTest.getAnswerFor(5);

		assertEquals("Buzz", response);
	}
```

```java
public class FizzBuzz {
	
	public String getAnswerFor(int num) {
		
		if(num == 3) {
			return "Fizz";
		}
		if(num == 5) {
			return "Buzz";
		}
		
		return "" + num;
		
	}
	

}
```
# Conplete remaining test cases
- for num = 6,10,15,30 ?
- What happens at num = 15?
- Refactor `FizzBuzz` class





