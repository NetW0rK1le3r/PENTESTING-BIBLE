#In this simple Kata your task is to create a function that turns a string into a Mexican Wave. You will be passed a string and you must return that string in an array where an uppercase letter is a person standing up.
#1.  The input string will always be lower case but maybe empty.
#2.  If the character in the string is whitespace then pass over it as if it was an empty seat.
#wave("hello") => ["Hello", "hEllo", "heLlo", "helLo", "hellO"]
wave = lambda str : [str[:n]+str[n].upper()+str[n+1:] for n in range(0, len(str)) if str[n] != " "]
