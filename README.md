# [Which are in?](https://www.codewars.com/kata/550554fd08b86f84fe000a58)

---

Given two arrays of strings `a1` and `a2` return a sorted array `r` in lexicographical order of the strings of `a1` which are substrings of strings of `a2`.

#Example 1: `a1 = ["arp", "live", "strong"]`

`a2 = ["lively", "alive", "harp", "sharp", "armstrong"]`

returns `["arp", "live", "strong"]`

#Example 2: `a1 = ["tarp", "mice", "bull"]`

a2 = `["lively", "alive", "harp", "sharp", "armstrong"]`

returns `[]`

#Notes: Arrays are written in "general" notation. See "Your Test Cases" for examples in your language.

Beware: `r` must be without duplicates.

---

### 中文大意

找出第一個 array 裡面的字是否為第二個 array 的字的一部份，返回的結果必需排序而且不能重覆
