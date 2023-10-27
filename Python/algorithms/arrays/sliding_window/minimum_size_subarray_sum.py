from typing import List


def minimum_size_subarray_sum(target: int, nums: List[int]):
    start = 0
    minimum = float("inf")
    sum = 0

    for end in range(len(nums)):
        sum += nums[end]

        while sum >= target:
            minimum = min(minimum, end - start + 1)
            sum -= nums[start]
            start += 1

    return minimum if minimum != float("inf") else 0
