def length_of_longest_substring(string):
    if not string:
        return 0

    char_index = {}
    start = 0
    longest = 0

    for end in range(len(string)):
        if string[end] in char_index and char_index[string[end]] >= start:
            start = char_index[string[end]] + 1

        char_index[string[end]] = end
        longest = max(longest, end - start + 1)

    return longest
