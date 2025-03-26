# Task 1: Fast Search
Problem Statement:
 You are given an array a of n integers a₁, a₂, ..., aₙ.
 Your task is to respond to multiple queries of the form:
 "How many numbers in the array are between l and r (inclusive)?"

Input:

The first line contains an integer n (1 ≤ n ≤ 10⁵) – the length of the array.

The second line contains n integers a₁, a₂, ..., aₙ (-10⁹ ≤ aᵢ ≤ 10⁹).

The third line contains an integer k (1 ≤ k ≤ 10⁵) – the number of queries.

The next k lines each contain two integers l and r (-10⁹ ≤ l ≤ r ≤ 10⁹).

Output:

Print k integers – the results of each query.

Example:
 📌 Input:

5  

10 1 10 3 4  

4  

1 10  

2 9  

3 4  

2 2  



📌 Output:

5  

2  

2  

0  


# Task 2: Closest to the Left
Problem Statement:
 Given an array of n numbers, sorted in non-decreasing order, and k queries,
 for each query, find the maximum index of an element not greater than the given value.

Input:

The first line contains n and k (0 < n, k ≤ 10⁵).

The second line contains n integers in sorted order.

The third line contains k queries.

All values are integers with absolute values ≤ 2 × 10⁹.

Output:

For each query, print the maximum index (1-based) of the element ≤ the given number.

If no such element exists, print 0.

Example:
 📌 Input:

5 5  

3 3 5 8 9  

2 4 8 1 10  



📌 Output:

0  

2  

4  

0  

5  