# Mean of slices

## Problem

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

## Solution

```
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
```