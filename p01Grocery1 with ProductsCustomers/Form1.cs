using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace p01Grocery1
{
    public partial class frmHome : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;

        public frmHome()
        {
            InitializeComponent();
        }

        private void SetConnection()
        {
            con = new SqlConnection(
                @"Data Source = localhost\SQLEXPRESS; 
                Initial Catalog = POLGO_GROCERY196; 
                user ID = ken; 
                password = mireille34?!;");
        }

        private void LoadProducts()
        {
            dataProducts.Rows.Clear();
            dataSalesProduct.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"SELECT prodID, prodName, prodType,
                manufacturer, price FROM PRODUCTS;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataProducts.Rows.Add(rdr[0].ToString(),
                    rdr[1].ToString(), rdr[2].ToString(),
                    rdr[3].ToString(), rdr[4].ToString());

                dataSalesProduct.Rows.Add(rdr[0].ToString(),
                    rdr[1].ToString(), rdr[2].ToString(),
                    rdr[3].ToString(), rdr[4].ToString());
            }
            con.Close();
        }

        private void LoadProducts(string searchText)
        {
            dataProducts.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"SELECT prodID, prodName, prodType, manufacturer,
                price FROM PRODUCTS WHERE prodName LIKE '%"+searchText
                +"%' OR prodID LIKE '%"+searchText
                +"%' OR prodType LIKE '%"+searchText
                +"%' OR manufacturer LIKE '%"+searchText
                +"%' OR price LIKE '%"+searchText+"%';", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataProducts.Rows.Add(rdr[0].ToString(),
                    rdr[1].ToString(), rdr[2].ToString(),
                    rdr[3].ToString(), rdr[4].ToString());
            }
            con.Close();
        }

        private void LoadCustomers()
        {
            dataCustomers.Rows.Clear();
            dataSalesCustomers.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"SELECT custID, custLname, custFname,
                custMname, custAddress, sex FROM CUSTOMERS;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataCustomers.Rows.Add(rdr[0].ToString(), rdr[1].ToString(),
                     rdr[2].ToString(), rdr[3].ToString(),
                     rdr[4].ToString(), rdr[5].ToString());

                dataSalesCustomers.Rows.Add(rdr[0].ToString(), rdr[1].ToString(),
                     rdr[2].ToString(), rdr[3].ToString(),
                     rdr[4].ToString(), rdr[5].ToString());
            }
            con.Close();
        }

        private void LoadCustomers(string searchText1)
        {
            dataCustomers.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"SELECT custID, custLname, custFname, custMname, custAddress, sex 
                FROM CUSTOMERS WHERE custID LIKE '%"+searchText1
                +"%' OR custLname LIKE '"+searchText1
                +"' OR custFname LIKE '%"+searchText1
                +"%' OR custMname LIKE '%"+searchText1
                +"%' OR custAddress LIKE '%"+searchText1
                +"%' OR sex LIKE '%"+searchText1+"%';", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataCustomers.Rows.Add(rdr[0].ToString(), rdr[1].ToString(),
                     rdr[2].ToString(), rdr[3].ToString(),
                     rdr[4].ToString(), rdr[5].ToString());

            }
            con.Close();
        }

        private void LoadSales()
        {
            dataSales.Rows.Clear();
            con.Open();
            cmd = new SqlCommand(@"SELECT saleID, custLname, prodName,
                price, quantity, price * quantity AS 'Total Sales', datePurchase 
                FROM CUSTOMERS INNER JOIN SALES 
                ON CUSTOMERS.custID = SALES.custID 
                INNER JOIN PRODUCTS 
                ON SALES.prodID = PRODUCTS.prodID;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataSales.Rows.Add(rdr[0].ToString(), rdr[1].ToString(),
                    rdr[2].ToString(), rdr[3].ToString(),
                    rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString());
            }
            con.Close();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            SetConnection();
            LoadProducts();
            LoadCustomers();
            LoadSales();
            btnProdSave.Enabled = false;
            btnCustSave.Enabled = false;
        }

        private void btnProdAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand(@"INSERT INTO 
                PRODUCTS(prodName, prodType, manufacturer, price) 
                VALUES ('"+txtProdName.Text+"','"+txtProdType.Text
                +"','"+txtManufacturer.Text+"','"+txtPrice.Text+"');", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Product Added Successfully", "Success");
            LoadProducts();
            ClearAll();
        }

        private void ClearAll()
        {
            txtProdID.Clear();
            txtProdName.Clear();
            txtProdType.Clear();
            txtManufacturer.Clear();   
            txtPrice.Clear();
            btnProdAdd.Enabled = true;
            btnProdSave.Enabled = false;

            txtCustID.Clear();
            txtCustLname.Clear();
            txtCustFname.Clear();
            txtCustMname.Clear();
            txtAddress.Clear();
            txtSex.Clear();
            btnCustAdd.Enabled = true;
            btnCustSave.Enabled = false;

            txtSalesCustID.Clear();
            txtSalesProdID.Clear();
            txtQuantity.Clear();

            txtSearchProduct.Clear();
            LoadProducts();

            txtCustomerSearch.Clear();
            LoadCustomers();
        }

        private void dataProducts_SelectionChanged(object sender, EventArgs e)
        {
            if(dataProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dataProducts.SelectedRows[0];
                txtProdID.Text = selected.Cells[0].Value.ToString();
                txtProdName.Text = selected.Cells[1].Value.ToString();
                txtProdType.Text = selected.Cells[2].Value.ToString();
                txtManufacturer.Text = selected.Cells[3].Value.ToString();
                txtPrice.Text = selected.Cells[4].Value.ToString();
                btnProdSave.Enabled = true;
                btnProdAdd.Enabled = false;
            }
        }

        private void btnProdSave_Click(object sender, EventArgs e)
        {
            if(dataProducts.SelectedRows.Count > 0)
            {
                con.Open();
                cmd = new SqlCommand("UPDATE PRODUCTS SET prodName = '"
                    +txtProdName.Text
                    +"', prodType = '"+txtProdType.Text
                    +"', manufacturer = '"+txtManufacturer.Text
                    +"', price = '"+txtPrice.Text
                    +"' WHERE prodID = '"+txtProdID.Text+"';", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Product Updated!", "Success");
                LoadProducts();
                ClearAll();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void dataCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataCustomers.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dataCustomers.SelectedRows[0];
                txtCustID.Text = selected.Cells[0].Value.ToString();
                txtCustLname.Text = selected.Cells[1].Value.ToString();
                txtCustFname.Text = selected.Cells[2].Value.ToString();
                txtCustMname.Text = selected.Cells[3].Value.ToString();
                txtAddress.Text = selected.Cells[4].Value.ToString();
                txtSex.Text = selected.Cells[4].Value.ToString();
                btnProdSave.Enabled = true;
                btnProdAdd.Enabled = false;
                btnCustSave.Enabled = true;
                btnCustAdd.Enabled = false;
            }
        }

        private void btnCustAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand(@"INSERT INTO 
                CUSTOMERS(custLname, custFname, custMname, custAddress, sex)
                VALUES ('"+txtCustLname.Text+"','"+txtCustFname.Text
                +"','"+txtCustMname.Text+"','"+txtAddress.Text
                +"','"+txtSex.Text+"');", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Customer Added Successfully", "Success");
            LoadCustomers();
            ClearAll();
        }

        private void btnCustSave_Click(object sender, EventArgs e)
        {
            if (dataCustomers.SelectedRows.Count > 0)
            {
                con.Open();
                cmd = new SqlCommand("UPDATE CUSTOMERS SET custLname = '"
                    +txtCustLname.Text+"', custFname = '"+txtCustFname.Text
                    +"', custMname = '"+txtCustMname.Text+"', custAddress = '"+
                    txtAddress.Text+"', sex = '"+txtSex.Text
                    +"' WHERE custID = '"+txtCustID.Text+"';", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Customer Updated!", "Success");
                LoadCustomers();
                ClearAll();
            }
        }

        private void btnCustClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void dataSalesCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if(dataSalesCustomers.SelectedRows.Count > 0)
            {
                txtSalesCustID.Text =
                    dataSalesCustomers.SelectedRows[0].Cells[0].Value.ToString();
                txtSalesCustomer.Text =
                    dataSalesCustomers.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void dataSalesProduct_SelectionChanged(object sender, EventArgs e)
        {
            if(dataSalesProduct.SelectedRows.Count > 0)
            {
                txtSalesProdID.Text =
                    dataSalesProduct.SelectedRows[0].Cells[0].Value.ToString();
                txtSalesProdcut.Text =
                    dataSalesProduct.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            if (dataSalesCustomers.SelectedRows.Count > 0 &&
                dataSalesProduct.SelectedRows.Count > 0)
            {
                con.Open();
                cmd = new SqlCommand(@"INSERT INTO SALES(custID, prodID, 
                quantity, datePurchase) 
                VALUES ('" + txtSalesCustID.Text + "','" + txtSalesProdID.Text
                    + "','" + txtQuantity.Text + "','"+
                    DateTime.Now.ToString("yyyy'-'MM'-'dd' ' HH':'mm':'ss")+"');", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sale Added!", "Success");
                LoadSales();
                ClearAll();
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            LoadProducts(txtSearchProduct.Text);
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            LoadCustomers(txtCustomerSearch.Text);
        }
    }
}

