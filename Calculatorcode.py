from typing import Union


class CalculatorEquation:
    def __init__(self):

        pass

    def ADD(self, num1: Union[int, float], num2: Union[int, float]):
        self.num1 = num1
        self.num2 = num2
        try:
            self.result =self.num1 + self.num2
        except TypeError:
            raise TypeError
        return self.result
    def Minus(self, num1: Union[int, float], num2: Union[int, float]):
        self.num1 = num1
        self.num2 = num2
        try:
            self.result =self.num1 - self.num2
        except TypeError:
            raise TypeError
        return self.result
    def Times(self, num1: Union[int, float], num2: Union[int, float]):
        self.num1 = num1
        self.num2 = num2
        try:
            self.result =self.num1 * self.num2
        except TypeError:
            raise TypeError
        return self.result
    def Divide(self, num1: Union[int, float], num2: Union[int, float]):
        self.num1 = num1
        self.num2 = num2
        try:
            self.result =self.num1 / self.num2
        except TypeError:
            raise TypeError
        except ZeroDivisionError:
            raise ZeroDivisionError
        return self.result
    
    
    