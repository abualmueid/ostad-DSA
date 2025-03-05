# Task 1: Convert an integer into LL, LL into an integer


Given an integer n, construct 2 function.

Your first function returns the digit representation of the number as a doubly linked list(sign <->).

Your second function returns the integer extracted from the linked list representation.

Constraints:

-2^31 <= n <= 2^31 - 1

Example 1:

Input: n = 25

Output: first function: 2 <-> 5

	  second function: 25

Example 2:

Input: n = -4

Output: first function: - <-> 4

	  second function: -4

# Task 2: Delete from Linked List



You are given the elements(integer) of an array and the elements(integer) of a linked list. Construct the linked list and array, then Return the head of the modified linked list after removing all nodes from the linked list that have a value that exists in the array and print it.




Example 1:

input: array= [1,2,3], linked list= [1,2,3,4,5]  

Output: [4,5]

Example 2:

	input: array= [5], linked list= [1,2,3,4]  

Output: [1,2,3,4]