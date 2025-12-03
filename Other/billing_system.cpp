#include<iostream>
#include<fstream>
#include<vector>
#include<string>
#include<stdexcept>
using namespace std;

class Item{
    int itemId;
    int stockQuantity;
    int purchaseQuantity;
    string itemName;
    float price;
    public :
    //Item();
    void acceptItemData() ;
    void acceptPurchaseQuantity();
    int getItemId() const;
    int getStockQuantity() const;
     int getPurchaseQuantity() const;
    string getItemName() const;
    float getItemPrice() const;
};

void Item::acceptItemData() 
{
    cout<<"Enter itemId :";
    cin>>itemId;

    cout<<endl;

    cout<<"Enter stock quantity :";
    cin>>stockQuantity;
    cin.ignore();
        if (stockQuantity <= 0) 
        throw runtime_error("Negative and zero stock quantity not allowed");


    cout<<endl;

    cout<<"Enter itemName :";
    //cin>>itemName;
    getline(cin, itemName);

    cout<<endl;

    cout<<"Enter price of item :";
    cin>>price;
       if (price <= 0) throw runtime_error("Negative and zero price not allowed");

    cout<<endl;

    
}
int Item::getPurchaseQuantity() const {
    return purchaseQuantity;
}

void Item::acceptPurchaseQuantity() {
    cout << "Enter purchase quantity: ";
    cin >> purchaseQuantity;
    cin.ignore();
    if (purchaseQuantity <= 0)
        throw runtime_error("Purchase quantity must be positive");
    if (purchaseQuantity > stockQuantity)
        throw runtime_error("Purchase quantity exceeds available stock");
    // Decrement stock by purchased quantity
    stockQuantity -= purchaseQuantity;
}

int Item::getItemId() const
{
    return itemId;
}
int Item::getStockQuantity() const
{
    return stockQuantity;
}
string Item::getItemName() const
{
    return itemName;
}
float Item::getItemPrice() const
{ return price; }

class Bill
{
    int billId;
    string customerName;
    //string items[100];
    vector<Item> items;
    public :
    void acceptCustomerData();

    Bill& operator+(const Item&);
    
    friend ostream& operator<<(ostream&, const Bill&);

   // friend ostream& operator<<(ostream&, Bill&);

    int getBillId() const;
    string getCustomerName() const;
    void getItemList() const;

        void saveToFile() const;   // file handling

    void displayItem();
};

int Bill::getBillId() const
     { 
        return billId;
     }
string Bill::getCustomerName() const{
    return customerName;
  }
void Bill::acceptCustomerData()
{

    cout<<"Enter bill Id :";
    cin>>billId;

   cin.ignore(); // consume newline

    cout<<"Enter name of customer :";
    getline(cin, customerName);
   // cin>>customerName;

    cout<<endl;
    
}

Bill& Bill::operator+(const Item& addItem)
{
     if (addItem.getPurchaseQuantity() <= 0)
        throw runtime_error("Invalid purchase quantity for item: " + addItem.getItemName());
    items.push_back(addItem);
    return *this;
    // if (addItem.getStockQuantity() <= 0) 
    // throw runtime_error("Invalid quantity for item: " + addItem.getItemName());
    // items.push_back(addItem);
    // return *this;
   

}

// void Bill::displayItem()
// {
//     cout<<"Bill :"<<endl;
//     cout<<"Bill id :"<<billId<<"\nCustomer :"<<customerName<<"\n";
//     cout << "Items Purchased:\n";
//         cout << "ID\tName\tQuantity\tPrice\n";
//      for (const auto& item : items) {
//             cout << item.getItemId() << "\t"<< item.getItemName() << "\t"<< item.getStockQuantity() << "\t"<<"\t"<< item.getItemPrice() << "\t";
//             cout<<endl;
//         }
// }
ostream& operator<<(ostream& output, const Bill& bill) {
     if (bill.items.empty())
        throw runtime_error("Empty bill cannot be displayed");


    output << "Bill ID: " << bill.getBillId() << "\nCustomer: " << bill.getCustomerName() << "\n";
    output << "Items Purchased:\n";
    output << "ID\tName\tPurchaseQty\tPrice\n";
     float total = 0;
    for (const auto& item : bill.items) {
        float totalItemPrice = item.getItemPrice() * item.getPurchaseQuantity();
        output << item.getItemId() << "\t"
               << item.getItemName() << "\t"
               << item.getPurchaseQuantity() << "\t\t"
               // << item.getStockQuantity() << "\t\t"
               << item.getItemPrice() << "\n";
            total += totalItemPrice;      //item.getItemPrice() * item.getStockQuantity();
    }
    output << "-------------------------------\n";
    output << "Total Amount: " << total << "\n";
    return output;
}
// ostream& operator<<(ostream& output, const Bill& bill) {
  
//     output << "Bill ID: " << bill.getBillId() << "\n"<<"Customer :"<<bill.getCustomerName()<<"\n";
//     // ...
//     return output;
// }
void Bill::saveToFile() const {
    ofstream bill_file("bills.txt", ios::app);
    if(!bill_file)
    throw runtime_error("Error opening file");

    bill_file << "Bill Id: "<<billId<<", Customer: "<<customerName<<"\n";
    
    float total = 0;

    for(const auto& item : items)
    {
        float totalItemPrice = item.getItemPrice() * item.getPurchaseQuantity();

        bill_file <<"Item Id:"<<item.getItemId()<<" "
       << "Item Name"<< item.getItemName() << " "
           <<"Stock"  << item.getStockQuantity() << " "
             <<"Item Price :"<< item.getItemPrice() << "\n";
        total += totalItemPrice;  //item.getItemPrice() * item.getStockQuantity();
    }
    bill_file<<"Total = "<<total<<"\n-------\n";
    bill_file.close();
    
}

int main()
{
    try{
    string line;

    ifstream prev_bill("bills.txt");

    if(!prev_bill.is_open()){
         cout << "No previous bills found, starting fresh.\n";
    }
    else{
        cout << "Previous Bills:\n";
        while (!prev_bill.eof())
        {
            getline(prev_bill,line);
            cout<<line<<endl;
        }
        prev_bill.close();
    } 
    
   string itemName;
   char ch;
   
    Bill b;
    b.acceptCustomerData();


    do{
         Item i;
    i.acceptItemData();
      i.acceptPurchaseQuantity();

            b= b+i; //b =  b.operator+(i);

        cout<<"Add another item? (y/n) :";
        cin>>ch;
        
         cin.ignore();
    }while (ch == 'y' || ch == 'Y');
    
   cout << b; 
    b.saveToFile();

}
catch(const exception& e)
{
    cout<<"Error :"<<e.what()<<endl;
}
    
}



