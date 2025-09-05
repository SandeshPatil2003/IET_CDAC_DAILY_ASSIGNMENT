class Solution {
public:
    bool isPalindrome(int x) {

        long int num = x,rem=0,sum=0;

        while(num > 0)
        {
            rem=num%10;
            sum = sum*10+rem;
            num/=10;
        }
        if(sum == x)
        {
            return true;
        }
        
        return false;
    }

    
};