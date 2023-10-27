from algorithms.arrays.sliding_window.longest_substring_without_repeating_characters import (
    length_of_longest_substring,
)
import unittest


class TestLongestSubstring(unittest.TestCase):
    def test_example_1(self):
        self.assertEqual(length_of_longest_substring("abcabcbb"), 3)

    def test_example_2(self):
        self.assertEqual(length_of_longest_substring("bbbbb"), 1)

    def test_example_3(self):
        self.assertEqual(length_of_longest_substring("pwwkew"), 3)

    def test_empty_string(self):
        self.assertEqual(length_of_longest_substring(""), 0)

    def test_string_with_spaces(self):
        self.assertEqual(length_of_longest_substring("a b c a b c b b"), 3)
