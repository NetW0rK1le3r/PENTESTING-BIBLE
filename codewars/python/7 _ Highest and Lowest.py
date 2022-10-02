#In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
#high_and_low("1 2 -3 4 5") # return "5 -3"
high_and_low = lambda numbers : str(max((int(i) for i in numbers.split())))+" "+str(min((int(i) for i in numbers.split())))
