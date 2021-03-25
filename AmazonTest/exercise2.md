# Explaining Exercise 1 Code

## Big O

- O(log jeans * log shoes * log skirts * log tops)
- We have four different arrays that might have different lengths, and for that they we need four variables at big O.
- "Log" here means that it won't be linear. The optimization is that it compares only elements within the budget to the next array.

## How it Works

- Using Linq to improve readability and maintainability. Code is very short and easy to understand.
- It iterates through the 4 arrays getting any element that is within the budget (already after subtracting what was spent on previous products which were bought together) and considering that it can be part of a combination. Checks with next product.
