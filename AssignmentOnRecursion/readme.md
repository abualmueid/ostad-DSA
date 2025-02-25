# Task 1: Power of 5

Given an integer n, return true if it is a power of 5. Otherwise, return false.

An integer n is a power of 5, if there exists an integer x such that n == 5^x

Constraints:

-2^31 <= n <= 2^31 - 1

Example 1:

Input: n = 25

Output: true

Example 2:

Input: n = 4

Output: false

Example 3:

Input: n = 1

Output: true

# Task 2: Find the K-th Character

Sadman and Salman are playing a game. Initially, Sadman has a string word = "a".

You are given a positive integer k.

Now Salman will ask Sadman to perform the following operation forever:

Generate a new string by changing each character in word to its next character in the English alphabet, and append it to the original word.

For example, performing the operation on "c" generates "cd" and performing the operation on "zb" generates "zbac".

Return the value of the kth character in word, after enough operations have been done for word to have at least k characters.

Note that the character 'z' can be changed to 'a' in the operation.

 Constraints:

1 <= k <= 500

Example 1:

Input: k = 5

Output: "b"

Explanation:

Initially, word = "a". We need to do the operation three times:

Generated string is "b", word becomes "ab".

Generated string is "bc", word becomes "abbc".

Generated string is "bccd", word becomes "abbcbccd".

Example 2:

Input: k = 10

Output: "c"