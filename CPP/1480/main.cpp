//https://leetcode.com/problems/running-sum-of-1d-array

#include <iostream>
#include <vector>

using namespace std;

class Soluction{
    public:

    void displayArray(vector<int>& array){
    cout << "Display Array: ";

    for (int n : array)
        cout << n << " ";
    
    cout << endl;

    return;

    }


    vector<int> sumArray(vector<int>& nums){

        for(int index = 1; index < nums.size(); index++){
            nums[index]+=nums[index-1];
        }
        
        return nums;
    
    }



};

int main(){
    vector<int> nums = {3,1,2,10,1};

    Soluction S = Soluction();
    
    nums = S.sumArray(nums);

    S.displayArray(nums);

    return 0;
}