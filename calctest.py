import unittest
import calc

class TestCalc(unittest.TestCase):
    def test_add(self):
        print("\nTesting sum method")
        result = calc.add(8, 3)
        print(f"Testing addition: 8 + 3 = {result}")
        self.assertEqual(result, 11)

       
        result = calc.add(-12, 7)
        print(f"Testing addition: -12 + 7 = {result}")
        self.assertEqual(result, -5)

       
        result = calc.add(15, -6)
        print(f"Testing addition: 15 + (-6) = {result}")
        self.assertEqual(result, 9)


    def test_minus(self):
        print("\nTesting minus method")
        result = calc.minus(20, 4)
        print(f"Testing subtraction: 20 - 4 = {result}")
        self.assertEqual(result, 16)

       
        result = calc.minus(-9, 5)
        print(f"Testing subtraction: -9 - 5 = {result}")
        self.assertEqual(result, -14)

      
        result = calc.minus(18, -3)
        print(f"Testing subtraction: 18 - (-3) = {result}")
        self.assertEqual(result, 21)

    def test_times(self):
        print("\nTesting times method")
        result = calc.times(7, 2)
        print(f"Testing multiplication: 7 * 2 = {result}")
        self.assertEqual(result, 14)

    
        result = calc.times(-6, 3)
        print(f"Testing multiplication: -6 * 3 = {result}")
        self.assertEqual(result, -18)

        
        result = calc.times(9, -4)
        print(f"Testing multiplication: 9 * (-4) = {result}")
        self.assertEqual(result, -36)

    def test_divide(self):
        print("\nTesting divide method")
        result = calc.divide(16, 4)
        print(f"Testing division: 16 / 4 = {result}")
        self.assertEqual(result, 4)

       
        result = calc.divide(-15, 5)
        print(f"Testing division: -15 / 5 = {result}")
        self.assertEqual(result, -3)

        
        result = calc.divide(24, -8)
        print(f"Testing division: 24 / (-8) = {result}")
        self.assertEqual(result, -3)

if __name__ == '__main__':
    unittest.main()
