How to write a function solution that, given a String S consisting of N letters 'a' or/and 'b' 
returns true when occurences of 'a' are before 'b' and return false otherwise?

The example results would be:

Given S 'aaab', the function should return true.
Given S 'ba', the function should return false.
Given S 'aaa', the function should return true. 'b' does not need to occur in S
Given S 'b', the function should return true. 'a' does not need to occur in S
Given S 'abba', the function should return false.
Given S 'baa', the function should return false.

Write an efficient algorithm for the following assumptions:
N is an integer within the range [1..300,000];
string S consists only of the characters 'a' and/or 'b'