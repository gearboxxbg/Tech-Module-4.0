# 9. *Kamino Factory
The clone factory in Kamino got another order to clone troops. But this time you are tasked to find the best DNA
sequence to use in the production.
You will receive the DNA length and until you receive the command &quot;Clone them!&quot; you will be receiving a DNA
sequences of ones and zeroes, split by &quot;!&quot; (one or several).
You should select the sequence with the longest subsequence of ones. If there are several sequences with same
length of subsequence of ones, print the one with the leftmost starting index, if there are several sequences with
same length and starting index, select the sequence with the greater sum of its elements.
After you receive the last command &quot;Clone them!&quot; you should print the collected information in the following
format:
&quot;Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.&quot;
&quot;{DNA sequence, joined by space}&quot;