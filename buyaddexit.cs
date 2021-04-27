1.Add products-- User should able to add products increse in inventory
2.Buy product-- user can buy product and invoice should be there Decrease in Inventory
3.exit
public Form1()
{
    InitializeComponent();
    Product products = new Product();
    AddProducts(); 
}

List<string> productList = new List<string>();

public void AddProducts()
{
    productNames.Add("Product X");
    productNames.Add("Product Z");

    foreach (var product in productList) 
    {
        ProductListBox.Items.Add(product);
    }
}