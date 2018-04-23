title: Files and File Systems
subtitle: Where do I find it?
theme: league

# File It Away

The computers we use have file systems. A disk drive is much like a file cabinet, with the exception that we put file folders inside other file folders. This helps us find things. The sequence of folders that represents a file's location is called its *path*.

# Different Strokes

The Windows OS uses backslashes ('\') as path delimiters. Other OSes and shells like Git Bash use slashes ('/') as path delimiters.

Windows also uses drive letters(`C:`) unlike other OSes, so Git Bash interprets them differently as well.

The Windows path `C:\foo\bar`

is represented in Git Bash as `/c/foo/bar`.

In Windows, you will see this path as your location in an Explorer window.

# Can One Ever Go Home?

By default, you are logged in to your WCCI laptop as a user named "WeCanCodeIT".

Each user on a computer has a folder where the user's personal files are stored. In Git Bash and Linux(-like) OSes, We call this the 'home' folder. The same concept exists in Windows but it's a bit hidden from the casual user.

Home folder in Git Bash: `/c/Users/WeCanCodeIT`

The Windows path `C:\Users\WeCanCodeIT`

is represented in Git Bash as `/c/Users/WeCanCodeIT`.

# What the Tilde?

Your home folder in Git Bash can be (and often is) represented by a tilde (`~`) character.


# What's in Here?

In git bash, you can list the contents of your current directory with `ls`:

```bash
```

To see them in long form, use the `-l` switch:

```bash
```

To see them all (including hidden files that start with a '.'), use `-a`:

```bash
```

Or both:

```bash
```

# Finding your current directory

When you are at a GitBash prompt, your prompt will show your current directory, which may include `~` to represent the current path:

```bash
```

In order to **P**rint the **Working** **Directory** (the current directory), use the `pwd` command:

```bash
```