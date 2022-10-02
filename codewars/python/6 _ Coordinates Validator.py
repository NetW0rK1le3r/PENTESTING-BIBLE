#You need to create a function that will validate if given parameters are valid geographical coordinates.
#Valid coordinates look like the following: "23.32353342, -32.543534534". The return value should be either true or false.
#Latitude (which is first float) can be between 0 and 90, positive or negative. Longitude (which is second float) can be between 0 and 180, positive or negative.
#Coordinates can only contain digits, or one of the following symbols (including space after comma) -, .
#There should be no space between the minus "-" sign and the digit after it.
def is_valid_coordinates(coordinates):
    return (lambda coordinates, two=coordinates.split(', ') : False if ((len(two) != 2) or (len([i for i in ''.join(two) if i not in "0123456789. -"]) > 0) or (len([n for n in two if (n.count(".") > 1 or n.count(" ") > 0)]) > 0) or (float(two[0].replace("-",""))>90) or (float(two[1].strip().replace("-",""))>180)) else True)(coordinates)
