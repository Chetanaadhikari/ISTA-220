# Course: ISTA-220
## Lesson Plan: 04
### Name: Chetana Adhikari


1. What are all possible values of a Boolean expression? 

The possible values of a Bool expression are true and false.

2. List eight Boolean operators. 
	
==, !=, &&, ||, <, <=, > and >=.

3. What are the difference in how short circuiting works for && and ||? 

In the case of &&, if the statement on the left is false, the statement on the right is not evaluated. All statements need to be true for it to be true.
For ||, if the left operand is true, the right operand isn’t evaluated. Both statements have to be false for it to be false.
For both, it is best practice to put the most likely case as the left operand to boost performance.

4. Look at the list of operators. What operator has the highest precedence? Which has the lowest? 

(parenthesis) has the highest precedence and assignment (=) has the lowest.

5. In an if or else construction using multiple lines of code, what effect does the use of curly braces have? 

A block is simply a sequence of statements grouped between an opening brace and a closing brace. 

6. In a switch statement, what happens if you omit break? 

If any code exists without a break statement, it will fail to compile. 