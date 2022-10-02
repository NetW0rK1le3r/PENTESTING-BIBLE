#Your task is to write a function maskify, which changes all but the last four characters into '#'.
#Kata.Maskify('4556364607935616'); // should return "############5616"
#Kata.Maskify('1');                // should return "1"
#Kata.Maskify('');                 // should return ""
maskify = lambda cc : ("#"*(len(cc)-4))+cc[-4:]
