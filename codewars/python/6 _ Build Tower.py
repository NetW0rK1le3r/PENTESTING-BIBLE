"""
Build Tower by the following given argument:
number of floors (integer and always greater than 0).
Tower block is represented as *
for example, a tower of 3 floors looks like below
[
  '  *  ', 
  ' *** ', 
  '*****'
]
"""
def tower_builder(n_floors):
    mainlist = []
    for i in range(n_floors): stars = (((n_floors + (n_floors-1)-((i+1)+((i+1)-1)))/2)*" ") + ('*'*((i+1)+((i+1)-1))) + (((n_floors + (n_floors-1)-((i+1)+((i+1)-1)))/2)*" ");mainlist.append(stars)
    return mainlist
