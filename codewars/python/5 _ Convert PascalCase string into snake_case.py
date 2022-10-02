#Complete the function/method so that it takes CamelCase string and returns the string in snake_case notation. Lowercase characters can be numbers. If method gets number, it should return string.
#to_underscore('TestController') --> test_controller
#to_underscore('MoviesAndBooks') --> movies_and_books
#to_underscore('App7Test') --> app7_test
def to_underscore(string):
    import re
    try: return '_'.join(re.findall('[A-Z][^A-Z]*', string)).lower()
    except: return str(string)

