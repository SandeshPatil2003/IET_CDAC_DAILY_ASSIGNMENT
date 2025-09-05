class Solution {
public:
    int findClosest(int x, int y, int z) {

        if(abs(x-z)<abs(y-z))
        {   return 1;
        }
        if (abs(y-z)<abs(x-z))
        {   return 2;}

        if(abs(x-z)==abs(y-z))
        {
            return 0;
        }
        return{};
    } 
};