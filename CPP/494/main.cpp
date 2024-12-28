//https://leetcode.com/problems/target-sum
#include <iostream>
#include <vector>
#include <cmath>
#include <numeric>

using namespace std;

class Solution{

    private:


    public:

    int findTargetSumWays2(vector<int>& nums, int target) {
        int r=0;
          // Calculate the sum of all numbers in the vector
        int sum = accumulate(nums.begin(), nums.end(), 0);
      
        // If the sum is less than the target or the adjusted sum is odd, return 0
        if (sum < target || (sum - target) % 2 != 0) return 0;
        
        vector<int> result = vector<int>((int)pow(2,nums.size()),0);
        for (int i=0;i < nums.size(); i++){
            bool swapSignal = true;
            
            for(int j=0; j<result.size();j++){

                if(j%(int)(pow(2,(i)))==0){
                    swapSignal = !swapSignal;
                }
                

                if(swapSignal){
                    result[j]+=(nums[i]*(-1));
                }
                else{
                    result[j]+=nums[i];
                }

            }
        }
        for (int n: result){
            if(n == target){
                r++;
            }

        }
        return r;
    }
        
    int findTargetSumWays(vector<int>& nums, int target) {
        int sum = 0;
        int newTarget=0;

        for (int n : nums){
            sum += n;
        }
      
        if (sum < target) return 0;

        if( (sum - target) % 2 != 0) return 0;

        newTarget = (sum - target)/2;

        vector<int> r(newTarget+1,0);
        r[0]=1;
        for(int n : nums){
            for(int i = newTarget; i >= n; --i){
                r[i] += r[i-n];
            }
        }
        
        return r[newTarget];
    }
};

int main(){
    Solution S = Solution();
    vector<int> nums = {35,25,24,23,2,47,39,22,3,7,11,26,6,30,5,34,10,43,41,28};
    int target = 3;

    cout << S.findTargetSumWays(nums,target) << endl;

    return 0;
}