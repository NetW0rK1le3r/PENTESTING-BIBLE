#Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.
#pig_it('Pig latin is cool') # igPay atinlay siay oolcay
#pig_it('Hello world !')     # elloHay orldway !
def pig_it(text):
    sentence = ""
    for word in text.split(' '):
        if word not in "!?.,": sentence += (word[1:]+word[0]) + "ay "
        else: sentence += word + " "
    return sentence[:-1]
