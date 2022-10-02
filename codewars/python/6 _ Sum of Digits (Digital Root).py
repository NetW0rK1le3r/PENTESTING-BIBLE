"""
In this kata, you must create a digital root function.
A digital root is the recursive sum of all the digits in a number. Given n, take the sum of the digits of n. If that value has two digits, continue reducing in this way until a single-digit number is produced. This is only applicable to the natural numbers.
digital_root(16)
  => 1 + 6
  => 7
digital_root(942)
  => 9 + 4 + 2
  => 15 ...
  => 1 + 5
  => 6
digital_root(493193)
  => 4 + 9 + 3 + 1 + 9 + 3
  => 29 ...
  => 2 + 9
  => 11 ...
  => 1 + 1
  => 2
"""
def digital_root(n):
    c = str(n)
    while len(c) != 1:
        nc = 0
        for i in c:
            print(i)
            nc += int(i)
        c = str(nc)
    return int(c)
