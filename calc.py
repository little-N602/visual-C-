def add(x , y):
    return x + y
def minus(x , y):
    return x - y
def times(x , y):
    return x * y
def divide(x , y):
    if y == 0:
     raise ValueError('can not divide by zero')
    return x / y