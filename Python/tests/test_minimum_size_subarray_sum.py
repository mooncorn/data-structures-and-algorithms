from algorithms.arrays.sliding_window.minimum_size_subarray_sum import (
    minimum_size_subarray_sum,
)
import unittest


class TestMinSubArrayLen(unittest.TestCase):
    def test_example_1(self):
        self.assertEqual(minimum_size_subarray_sum(7, [2, 3, 1, 2, 4, 3]), 2)

    def test_example_2(self):
        self.assertEqual(minimum_size_subarray_sum(4, [1, 4, 4]), 1)

    def test_example_3(self):
        self.assertEqual(minimum_size_subarray_sum(11, [1, 1, 1, 1, 1, 1, 1, 1]), 0)

    def test_empty_array(self):
        self.assertEqual(minimum_size_subarray_sum(5, []), 0)

    def test_target_greater_than_max_element(self):
        self.assertEqual(minimum_size_subarray_sum(100, [1, 2, 3, 4]), 0)

    def test_minimum_length_subarray(self):
        self.assertEqual(minimum_size_subarray_sum(7, [2, 3, 1, 2, 4, 3]), 2)

    def test_target_equals_element(self):
        self.assertEqual(minimum_size_subarray_sum(1, [1, 2, 3, 4]), 1)
