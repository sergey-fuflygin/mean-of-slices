# Mean of slices

We have a large array of integers and we need to compute the mean
of a slice. We'll do many computations on varying slices in the
same array.

The array will be of size `N`. The allowed slices indicated by a
`start` and `end` integer should fall within the range `0 .. N-1`.

You can choose any language you want and design an API suitable in
that language. Here's an example in Python:

```python
m = Mean([1, 1, 2, 3, 1, 4])
print(m.mean(2, 3)) # prints 2.5
```

```
Solution

Input : arr[] = [ 1, 2, 3, 4 ]

Subarrays are

[ 1 ]
[ 1, 2 ]
[ 1, 2, 3 ]
[ 1, 2, 3, 4 ]
[ 2 ]
[ 2, 3 ]
[ 2, 3, 4 ]
[ 3 ]
[ 3, 4 ]
[ 4 ]

In general, for an array of size n, there are n*(n+1)/2 non-empty subarrays.

n = 4
4*(4+1)/2 = 10

We can run two nested loops, the outer loop picks starting element and inner loop considers all elements on right of the picked elements as ending element of subarray. 

Complexity- O(n^3)

[ (0, 1) ]
[ (0, 2) ]
[ (0, 3) ]
[ (0, 4) ]
[ (1, 1) ]
[ (0, 2) ]





Subsets with their average are,

[ 1 ]           average = 1/1 = 1
[ 2 ]           average = 2/1 = 2
[ 3 ]           average = 3/1 = 3
[ 3 ]           average = 4/1 = 4
[ 1, 2 ]        average = (1+2)/2 = 1.5
[ 2, 3 ]        average = (2+3)/2 = 2.5
[ 3, 4 ]        average = (3+4)/2 = 3.5
[ 1, 2, 3 ]     average = (1+2+3)/3 = 2
[ 2, 3, 4 ]     average = (1+2+3)/3 = 3
[ 1, 2, 3, 4 ]  average = (1+2+3+4)/4 = 2.5

Brute force solution

[ 1, 2, 3, 4 ]

[ 1, 2 ] and [ 3, 4 ]

[ 1 ] and [ 2 ] and [ 3 ] and [ 4 ]

```