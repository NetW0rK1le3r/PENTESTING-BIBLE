#The validation checks for this were broken, so this was a bodge.
#A string is considered to be in title case if each word in the string is either (a) capitalised (that is, only the first letter of the word is in upper case) or (b) considered to be an exception and put entirely into lower case unless it is the first word, which is always capitalised.
#A string is considered to be in title case if each word in the string is either (a) capitalised (that is, only the first letter of the word is in upper case) or (b) considered to be an exception and put entirely into lower case unless it is the first word, which is always capitalised.
#title_case('a clash of KINGS', 'a an the of') # should return: 'A Clash of Kings'
#title_case('THE WIND IN THE WILLOWS', 'The In') # should return: 'The Wind in the Willows'
title_case = lambda title, minor_words='' : ' '.join(map(lambda word : ([lambda: word.capitalize() if word.lower() not in [i.lower() for i in minor_words.split()] else word.lower(), lambda: word.capitalize()][word==title.split()[0]]()), title.split()))
