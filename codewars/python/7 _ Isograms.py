#An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.
is_isogram = lambda s : True if sum([s.lower().count(i) for i in s.lower()]) == len(s) else False
