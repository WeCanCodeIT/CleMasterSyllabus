title: Intro to TDD
subtitle: Fail fast, fail often
theme: league

# Meet Uncle Bob!

![](./resources/uncle-bob.jpg)

- Co-author of the [Manifesto for Agile Software Development](http://agilemanifesto.org/)
- Creator of the [Three Rules of TDD](http://butunclebob.com/ArticleS.UncleBob.TheThreeRulesOfTdd)
- And other stuff…

# Three simple (but not easy) rules

<blockquote style="width: 100%;">
<p>Over the years I have come to describe Test Driven Development in terms of three simple rules. They are:</p>
<ol>
<li>You are not allowed to write any production code unless it is to make a failing unit test pass.</li>
<li>You are not allowed to write any more of a unit test than is sufficient to fail; and compilation failures are failures.</li>
<li>You are not allowed to write any more production code than is sufficient to pass the one failing unit test.</li>
</ol>
</blockquote>

What do these mean? What are their ramifications?

# First, we fail

<div class="sidebar rgr"><img src="./resources/red.png"></div>

<div class="rgr-text">
	<blockquote>You are not allowed to write any production code unless it is to make a failing unit test pass.</blockquote>

	<p>This means that we need to write a failing test.</p>

	<p>Also: <blockquote>You are not allowed to write any more of a unit test than is sufficient to fail; and compilation failures are failures.</blockquote></p>
</div>

## What constitutes failure?

<div class="sidebar rgr"><img src="./resources/red.png"></div>

<div class="rgr-text">
	<ul>
		<li class="fragment">Not compiling (<em>You have red on you!</em>)
			<ul>
				<li>A class, method, … does not exist yet</li>
				<li>A method does not accept the necessary parameters (needs to be changed or overloaded)</li>
			</ul>
		</li>
		<li class="fragment">Your tests' assertions fail</li>
	</ul>
</div>

<p class="fragment"><em>Always run your tests to verify they will fail before moving on. Assuming a test will fail is the road to <strong>pain</strong>.</em></p>


# Go green

<div class="sidebar rgr"><img src="./resources/green.png"></div>

<div class="rgr-text">
	<blockquote>You are not allowed to write any more production code than is sufficient to pass the one failing unit test.</blockquote>

	<p>If the simplest thing is to return a hard-coded value, then return a hard-coded value. If it is to add a simple conditional, add the conditional. <strong>Even if you know it must change later.</strong></p>
	<p>Sometimes this feels like you're not doing enough. What you must realize is that you are <em>designing</em> how you will interact with your code.</p>
	<p>Also, this cycle keeps us from complicating our code. If we don't need the code to make a test pass, we don't need the code.</p>
</div>

# Improve the design

<div class="sidebar rgr"><img src="./resources/refactor.png"></div>

<div class="rgr-text">
	<p>Refactoring, as originally defined by Martin Fowler and Kent Beck, is:</p>

	<blockquote>A change made to the internal structure of software to make it easier to understand and cheaper to modify without changing its observable behavior… It is a disciplined way to clean up code that minimizes the chances of introducing bugs.</blockquote>

	<p>Simply put, it is improving the design of your code without changing what it does.</p>

	<p>Improve your design. Your tests were passing before refactoring, so they should be green once you've finished.</p>
</div>

## What refactoring is *not*

The term *refactoring* is often misused. The following are *not* refactoring activities, since they change what your code is doing:

<ul>
	<li class="fragment">fixing bugs</li>
	<li class="fragment">optimization</li>
	<li class="fragment">adding error handling</li>
</ul>

<p class="fragment">These are all good things to do in the appropriate context. Each should be started with a failing test, just like any other new functionality.</p>

!SLIDE

<img src="./resources/tdd_flow.gif" style="width: 60%; padding: 2rem; background-color: #FAFAFA; " />

<style type="text/css">
.reveal section div.rgr {
	width: 40rem;
	height: 40rem;
	background-color: #FAFAFA;
	display: flex;
	align-items: center;
	justify-content: center;
}
.reveal section div.rgr img {
	width: 100%;
	border: 0;
	box-shadow: unset;
}
.reveal section .rgr-text {
	max-width: 50rem;
}
.reveal section .rgr-text blockquote {
	margin-right: 0;
	width: 90%;
}

</style>