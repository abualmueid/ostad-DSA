# Task 1: Sorting Hospital Patient Records

A hospital maintains a record of patients with details such as Patient ID, Name, Age, Severity Score (higher severity means more critical). The hospital wants to efficiently manage patient treatment, ensuring that patients with higher severity are attended to first.
 Write a program that:

Reads an integer n (number of patients).

Reads n lines containing Patient ID (integer), Name (string), Age (integer), and Severity Score (integer).

Sorts the records primarily by Severity Score (descending). If two patients have the same severity, sort them by Age (ascending).

Outputs the sorted patient list.

Input Example:

5  

101 Alice 30 5  

102 Bob 25 8  

103 Charlie 40 8  

104 David 35 6  

105 Eve 28 5 

Output Example:

102 Bob 25 8  

103 Charlie 40 8  

104 David 35 6  

105 Eve 28 5  

101 Alice 30 5



# Task 2: Facebook Post-Like Tracking System

Facebook keeps track of the number of likes on each post. You are given n posts, each having an initial number of likes. Over time, users can like posts, and your task is to efficiently process these updates and determine which post has the highest number of likes after each update.

Task
Read two integers:

n: Number of Facebook posts.

m: Number of queries.

Read an array of n integers, where a[i] represents the initial number of likes on the i-th post.

Process m queries of the form:

post_no like_increase

This means the post_no-th post receives like_increase more likes.

After each query, print the post number (1-based index) with the highest likes and its like count. If multiple posts have the same highest likes, return the smallest index.

Input
	5 3

	10 20 30 40 50

	3 25

2 35

5 10

Output 
3 55

2 55

5 60

