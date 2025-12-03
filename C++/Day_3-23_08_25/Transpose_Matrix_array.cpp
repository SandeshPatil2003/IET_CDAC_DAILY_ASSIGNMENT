#include<iostream>

using namespace std;

int main()
{
    // int a[3][3] = {1,2,3,4,5,6,7,8,9};
    int i,j,a[3][3];
    cout<<"Enter a 3x3 matrix :"<<endl;
    for(i=0;i<3;i++)
    {
        for(j=0;j<3;j++)
        {
            cin>>*(*(a+i)+j);
        }

    }

    int at[3][3], i,j;
    
    cout<<"Original Array :"<<endl;
      for(i=0;i<3;i++)
        {
         for ( j = 0; j < 3; j++)
         {
           
             cout<<*(*(a+i)+j)<<"\t";        //a[i][j]<<"\t";

//             *(*(c+i)+j) = *(*(a+i)+j)+*(*(b+i)+j); 
         }
         cout<<endl;
    }

        for(i=0;i<3;i++)
        {
            for(j=0;j<3;j++)
            {
                //at[i][j]=a[j][i];
                *(*(at+i)+j)=*(*(a+j)+i);

            }
        }
        cout<<"Transpose Array :"<<endl;
         for ( i = 0; i < 3; i++)
    {

         for ( j = 0; j < 3; j++)
         {
           
            // cout<<at[i][j]<<"\t";

              cout<<*(*(at+i)+j)<<"\t";
           
         }
         cout<<endl;
    }

}