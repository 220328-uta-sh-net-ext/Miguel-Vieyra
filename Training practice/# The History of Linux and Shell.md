# The History of Linux and Shell
## ***Linux***

Linux is a free open-source operating system based on Unix. Linus Torvalds originally created Linux with the assistance of developers from around the world. In 1991, Linus Torvalds was studying UNIX at university, where he was using a special educational, experimental purpose operating system called Minix (a small version of UNIX to be utilized in the academic environment). However, Minix had its limitations, and Linus felt he could create something better. Therefore he developed his version of Minix, known as Linux. Linux was Open Source right from the start.

## ***Shell***

Shells or command-line interpreters have a long history, but this discussion begins with the first UNIX shell. Ken Thompson (of Bell Labs) developed the first shell for UNIX called the V6 shell in 1971. Similar to its predecessor in Multics, this shell (/bin/sh) was an independent user program that executed outside of the kernel. Concepts like globbing (pattern matching for parameter expansion, such as *.txt) were implemented in a separate utility called glob, as was the if command to evaluate conditional expressions.

<p>&nbsp;</p>  
<p>&nbsp;</p>
<p>&nbsp;</p>

# Getting started with Shell Programming


Introduction to the Bash Shell
A command line is a text user interface. One can use such an interface to provide instructions to a Linux powered computer. Under Linux, a programmed called shell used to provide a Linux command line user interface. The default shell for users in Linux is the GNU bash

-The bash shell comes with two types of commands

Internal commands (builtins) - part of the shell itself, i.e. built into the shell.


External commands - separate binaries stored in /sbin, /usr/sbin, /usr/bin, /bin, or /usr/local/bin directories.

<img src="shell2.png">

<p>&nbsp;</p>  
<p>&nbsp;</p>  
<p>&nbsp;</p>  


# The Shell Variables and Environment


You can use variables to store data and configuration options. There are two types of variable as follows

Use echo command to display variable value. To display the program search path, type

Creating and setting variables within a script is fairly simple. Use the following syntax:

***varName=someValue***


someValue is assigned to given varName and someValue must be on right side of = (equal) sign. If someValue is not given, the variable is assigned the null string.

Variable name must begin with alphanumeric character or underscore character (_), followed by one or more alphanumeric or underscore characters. Valid shell variable 

* *Examples:* 

    (HOME),

    (SYSTEM_VERSION),

    (vech),

    (no)