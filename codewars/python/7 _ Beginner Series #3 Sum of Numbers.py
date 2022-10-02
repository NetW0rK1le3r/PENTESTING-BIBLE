#Given two integers a and b, which can be positive or negative, find the sum of all the numbers between including them too and return it. If the two numbers are equal return a or b.
#Note: a and b are not ordered!
get_sum = lambda a,b : sum([i for i in range(min(a,b), max(a,b)+1)])
