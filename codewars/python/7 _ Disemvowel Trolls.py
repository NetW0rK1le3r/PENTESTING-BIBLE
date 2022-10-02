#Your task is to write a function that takes a string and return a new string with all vowels removed.
#For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".
disemvowel = lambda s : ''.join(i for i in s if i.lower() not in "aeiou")
