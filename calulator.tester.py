import unittest
from Calculatorex import Calculator

class TestCalculator(unittest.TestCase):

    def setUp(self):
        self.calculator = Calculator()

    def test_divide(self):
        print("\nTesting divide method")
        print(f"10 / 5 = {self.calculator.divide(10, 5)}")
        self.assertEqual(self.calculator.divide(10, 5), 2)
        print(f"-10 / 5 = {self.calculator.divide(-10, 5)}")
        self.assertEqual(self.calculator.divide(-10, 5), -2)
        print(f"10 / -5 = {self.calculator.divide(10, -5)}")
        self.assertEqual(self.calculator.divide(10, -5), -2)
        self.assertRaises(ZeroDivisionError, self.calculator.divide, 10, 0)
        self.assertRaises(TypeError, self.calculator.divide, 10, "5")
        self.assertRaises(TypeError, self.calculator.divide, "10", 5)

    def test_multiply(self):
        print("\nTesting multiply method")
        print(f"10 * 5 = {self.calculator.multiply(10, 5)}")
        self.assertEqual(self.calculator.multiply(10, 5), 50)
        print(f"-10 * 5 = {self.calculator.multiply(-10, 5)}")
        self.assertEqual(self.calculator.multiply(-10, 5), -50)
        print(f"10 * -5 = {self.calculator.multiply(10, -5)}")
        self.assertEqual(self.calculator.multiply(10, -5), -50)
        self.assertRaises(TypeError, self.calculator.multiply, 10, "5")
        self.assertRaises(TypeError, self.calculator.multiply, "10", 5)

    def test_sum(self):
        print("\nTesting sum method")
        print(f"10 + 5 = {self.calculator.sum(10, 5)}")
        self.assertEqual(self.calculator.sum(10, 5), 15)
        print(f"-10 + 5 = {self.calculator.sum(-10, 5)}")
        self.assertEqual(self.calculator.sum(-10, 5), -5)
        print(f"10 + -5 = {self.calculator.sum(10, -5)}")
        self.assertEqual(self.calculator.sum(10, -5), 5)
        self.assertRaises(TypeError, self.calculator.sum, 10, "5")
        self.assertRaises(TypeError, self.calculator.sum, "10", 5)

    def test_subtract(self):
        print("\nTesting subtract method")
        print(f"10 - 5 = {self.calculator.subtract(10, 5)}")
        self.assertEqual(self.calculator.subtract(10, 5), 5)
        print(f"-10 - 5 = {self.calculator.subtract(-10, 5)}")
        self.assertEqual(self.calculator.subtract(-10, 5), -15)
        print(f"10 - -5 = {self.calculator.subtract(10, -5)}")
        self.assertEqual(self.calculator.subtract(10, -5), 15)
        self.assertRaises(TypeError, self.calculator.subtract, 10, "5")
        self.assertRaises(TypeError, self.calculator.subtract, "10", 5)

if __name__ == "__main__":
    unittest.main()
