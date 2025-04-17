# Task 1: Tree Traversals
Problem Statement:

You are given a binary tree as an adjacency list. Perform in-order, pre-order, and post-order traversal of the tree.

Input:

n  

val left right  

... (n lines)  

Each line contains:

val – the node's value


left – index of the left child (-1 if null)


right – index of the right child (-1 if null)

 Assume index 0 is always the root.

Output:
 Print three lines:

In-order traversal


Pre-order traversal


Post-order traversal


Example Input:

5  

4 1 2  

2 -1 -1  

5 3 4  

1 -1 -1  

3 -1 -1  






This represents the tree:

        4

       / \

      2   5

         / \

        1   3

Example Output:

2 4 1 5 3

4 2 5 1 3

2 1 3 5 4

# Task 2: Height of a Tree
Problem Statement:
 Given a tree in the form of a parent array where -1 represents the root, compute the height of the tree.

Input:

n  

p₀ p₁ p₂ ... pₙ₋₁  

Each pᵢ is the parent of node i. The height of a tree is the number of nodes in the longest path from root to leaf.

Output
 Print the height of the tree.

Example Input:

5  

5 -1 5 2 2 

Example Output:

3