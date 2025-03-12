# Task 1: Next Smaller Element (NSE) Detection

Given an array of n integers, find the next smaller element for each element in the array. The next smaller element for an element x is the first smaller element on the right side of x. If there is no smaller element, return -1.

Input:
An integer n (1 ≤ n ≤ 10^⁵) represents the size of the array.
An array of n integers (-10^⁹ ≤ arr[i] ≤ 10^⁹).

Output:
Print n space-separated integers where the ith integer represents the next smaller element of arr[i]. If no smaller element exists, print -1.

Example 1:

Input:  
5  
4 5 2 10 8  


Output:  

2 2 -1 8 -1  


Example 2:

Input:  
6  
1 3 4 2 5 1  

Output:  

-1 2 2 1 1 -1  


# Task 2: Implement a Queue using Two Stacks


Implement a queue using two stacks such that the following operations work efficiently:

Enqueue(x) – Inserts an element x at the end of the queue.

Dequeue() – Removes and returns the front element of the queue. If the queue is empty, return -1.

Input Format:
The first line contains an integer q (1 ≤ q ≤ 10^⁵), the number of operations.

The next q lines contain one of the following commands:

"1 x" → Enqueue x into the queue (1 ≤ x ≤ 10^⁹).

"2" → Dequeue and print the front element. If the queue is empty, print -1.

"3" → Print the front element without removing it. If the queue is empty, print -1.

Output Format:
For each dequeue (2) or front query (3) operation, print the required value.



Example 1:

input: 

6  

1 10  

1 20  

3  

2  

3  

2  

output:

10

10

20

20

Explanation:
Enqueue(10) → [10]

Enqueue(20) → [10, 20]

Front() → 10

Dequeue() → Removes 10, queue = [20]

Front() → 20

Dequeue() → Removes 20, queue = []