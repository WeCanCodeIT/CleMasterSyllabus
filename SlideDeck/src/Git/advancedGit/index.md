title: Branching and Merging
subtitle: Git and GitHub
theme: league

## Git and GitHub Process

## Git Commits

- Each time there's a code change, we make a **commit**.
- We can think of a straight line with many dots, each dot representing a commit.
- Each commit keeps track of the author.

## Benefits of Git

- Allows us to collaborate/work with others.
- `master` is the default branch for any Git repository when it is created.
- We have the ability to create other branches.

## Creating Branches

- `testBranch1` or `featureBranch` as demonstrated in class.
- Called branches because they look like branches on a tree. Difference is that they merge back in to master.
- Branches create a copy and allow us to have a separate place to work on something.
- Separate stream of development, separate commits, exist on their own.

## You might want to create a branch...

- To test something that you're not sure you want to have as a part of your program.
- To work on a specific feature separate from the rest of the project before integrating it back in.

## Merging

- Takes changes and deviations of new branch and merges it back into another branch (usually `master`)
- Git merge takes what you have been working on separate from the project (i.e. the changes) and merges them into the branch.
- Where does the merge take place?
  - One of the advantages of branching is that the rest of your team doesn't have to stop the work they're doing.
  - We don't have to coordinate with anyone, we can make our separate branch, do our separate commits, they can do what they're doing, and then when we're ready, we can merge our changes back in.

!SLIDE

- What do you do when two people on a team are working with the same section of code? How do the changes line up?
  - Git is really smart when it comes to merging sets of code. It can track when changes were made. Git does its best to merge things together.
  - Eventually, Git will run into some problems. It holds the separate parts of the code in separate places, and asks the developer to choose which changes she or he wants to include and which ones to not include. This is called resolving a *merge conflict*.
  
## Best Practice

- Nobody should be doing all of their work in `master`. `master` should be reserved for working, clean, and tested code while all of the members of the team are doing their work in their separate branches.

## Where Can Branches Be Created?

- Branches can be created directly off the master branch. They can also be created from existing branches.

## Interesting Fact

- Some teams change the name of their `master` branch to something like `stable`. However, `master` is the convention, so changing it from the standard might not be the best idea.

## Best Practice

- A `.gitignore` file goes a long way towards preventing merge conflicts!! *ALWAYS* include a `.gitignore`!

## Remember

- Include your `.gitignore` file in your project before initializing your Git repository.

## To Find Your Graph

- In your Git repository on GitHub, click the Insights tab, then choose Network, and you can see the graph as it's getting built.

## Ways to Create a Branch

- Easiest command is `git checkout -b branchName` where "branchName" is replaced by whatever you are naming your branch. (You decide on the name) 
  - This command creates the branch and then switches you over to the new branch you've created.
  - Whenever you create a branch, it's taking the most recent code and making a copy for that branch.
  - The branch starts from wherever you currently are when you create your branch.
  
## Branch Naming

- If it's used for testing, call it `testBranch`.
- If it's used for building a feature, name the branch after that feature.
- Give some intention to your branch names.
- NO SPACES in your branch name. 
  - When you have spaces in your branch name, some programs will not function correctly with the branch.

## Knowing what branch you're in

- Git Bash will include the name of your branch in blue and in parentheses.

## Pushing your branch to GitHub

- We've only ever previously done `git push origin master`
- With branches, we'll do `git push origin branchName` where "branchName" is replaced by whatever your branch's name is.

## To Switch Branches

- `git checkout` is the code we use to switch from one branch to another. Example: `git checkout master` from `testBranch`
- When you switch a branch, Visual Studio will try to revert back your code to wherever the code was when the branch was intitiated.

## Command to use sparingly

- `git push origin --all` will push all of your branches to Github. Use sparingly because you don't want to be pushing non-functional branches and you don't want all of the members of your team to have to delete the bad branches.

## Merge

- This is when we bring the changes back in.
- **Important:** You want to be in the branch where you want the changes and bring the changes in.
  - Example - Be in `master` and merge `testBranch` in.
  - Note - it is possible to do it backwards, so be mindful when doing merges.
- To merge, you are in the branch where you want the changes to end up, and type `git merge -m "Merge Message" branchName` into `master` where "Merge Message" is replaced by the message you want to include.

## When It Goes Wrong

- Multiple members of a team working on the same section of code.
- Visual Studio includes mark-up and options in your program, and the developer then chooses which section(s) of code is correct.

## Cloning

- Copy the HTTPS url from the green "Clone or download" button.
- In Git Bash, type `git clone url` where URL is where you have pasted what you copied in the last step.
- Make sure you have changed directories in Git Bash to where you want to clone the project. (Example: `~/source/repos`)

**Git Cloning Exercise**

   For this exercise you will need at least two people, Person A and Person B. Changes should not be made in master directly, but rather, each person should make changes in a branch and merge them into master.

1. Have Person A create a new project, create a Git repository, and add a .gitignore file. Next, they should perform an initial commit and push the code to a new GitHub repository.

2. Person A should go into the Git repository's "Settings" and add Person B as a collaborator under "Collaborators & teams". If there are more than two people, also add them at this point.

3. Person B (and Person C, etc.) should accept the invite via email (or via the sharable link from Person A).

!SLIDE
<ol start="4">
<li>Person B should copy the link under the green "Clone or download" button on the repository's main page. Person B should now run <code>git clone [url copied from the repository]</code></li>
<br>
Be sure to run the <code>git clone</code> command wherever you would like the folder to be created on your computer. For example, if you run the <code>git clone</code> command in the <code>~/source/repos/Projects</code> directory, the project folder would be created at <code>~/source/repos/Projects/[ProjectName]</code><br>
<br>
Ensure Person B navigates into the project directory by running the <code>cd</code> command. For example, if you ran your <code>git clone</code> command in the <code>~/source/repos/Projects</code> and your project was called <code>GitBranchTest</code>, you would then need to run <code>cd GitBranchTest</code> to navigate to the project directory.<br>
<br>
You can verify you are in the project directory if you see the branch name at the end of the directory name in the console like the following: <code>~/source/repos/Projects/GitBranchTest (master)</code>
</ol>

!SLIDE
<ol start="5">    
<li>Person B now needs to create a branch by running <code>git checkout -b [newBranchName]</code> Person B should make a few small changes, and commit those changes locally.</li>
<br>
    5a. (Optional) If Person B wants to add their changes to GitHub, they can run <code>git push origin [newBranchName]</code><br>
<br>
<li>Once Person B is done with their changes, they need to merge them back into <code>master</code>. First, they should checkout master with <code>git checkout master</code>. Then, to merge their changes into master, they should run <code>git merge -m "[merge message]" [newBranchName]</code></li>
<br>
    Remember, when we perform a merge, we are <i>merging</i> the changes into the branch we currently have checked out. You can kinda think about us <i>bringing</i> those changes into our currently checked out branch.
</ol>

!SLIDE
<ol start="7">
<li>With their changes merged in, Person B now needs to update origin. Before running a push, you should run a <code>git pull</code> to make sure you have the most recent code. Then you can update origin by running <code>git push origin master</code></li><br>

<li>Person A now needs the most recent changes in master. First, they need to have the master branch checked out by running <code>git checkout master</code>. To get the most recent changes, they can run <code>git pull</code>. If there are more than 2 people working on the project, everyone can run this step now to ensure all are up-to-date.</li><br>

<li>Person A can now repeat steps 5-6. If there are more than 2 people, have Person C repeat these steps afterwards as well.</li>
</ol>

## Additional:

You can repeat these steps, alternating who is creating a branch and adding changes until you feel comforatable with the process.

You can also _reuse_ any of the already created branches. You should first checkout the branch, make your changes, commit, and follow the same steps from there.

You can use the "Network" graph under the "Insights" tab on the GitHub repository to help verify the state and relationship of the different branches.