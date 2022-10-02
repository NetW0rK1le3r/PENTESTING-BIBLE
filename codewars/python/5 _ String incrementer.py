#Your job is to write a function which increments a string, to create a new string. If the string already ends with a number, the number should be incremented by 1. If the string does not end with a number the number 1 should be appended to the new string.
#foo -> foo1
#foo0042 -> foo0043
#foo099 -> foo100
def increment_string(strng):
    return (lambda strng, s = (strng[-(int(((len(''.join(list(map(lambda n: n if n not in "1234567890" else "!~!", list(strng))))))-(len(''.join(list(map(lambda n: n if n not in "1234567890" else "!~!", list(strng)))).rstrip("!~!"))))/3)):]) : (((s if s.isdigit() else "0").join(strng.split(s if s.isdigit() else "0")[:-1]) if (s if s.isdigit() else "0") in strng else strng)+(str(int(s if s.isdigit() else "0")+1)).zfill(len(s if s.isdigit() else "0"))))(strng)

