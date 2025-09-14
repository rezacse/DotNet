#include <iostream>
#include <vector>
using namespace std;

int searchInsert(vector<int>& nums, int target) {
    int l = 0, h = nums.size() - 1, m = 0;
    while (l <= h) {
        m = l + (h - l) / 2;
        if (target < nums[m]) h = m - 1;
        else if (target > nums[m]) l = m + 1;
        else if (target = nums[m]) return m;
    }
    return target < nums[m] ? m : m + 1;
}