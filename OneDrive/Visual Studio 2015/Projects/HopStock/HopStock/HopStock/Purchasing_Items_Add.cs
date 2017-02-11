using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopStock
{
    public partial class Purchasing_Items_Add : Form
    {
        public Purchasing_Items_Add()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Purchasing_Items form = new Purchasing_Items();
            FormHandling.OpenNewForm(this, form, this.MdiParent);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //VerifyData returns a bool value.
            //Will be used later to determine whether data gets processed or not.
            //False indicates error, true indicates data has been verified
            //Return is to prevent a stream of error boxes
            if (DataVerification.VerifyData(tb_ItemName.Text, "string", lbl_ItemName.Text) == false)
            {
                return;
            }
            if (DataVerification.VerifyData(tb_ItemSize.Text, "int", lbl_ItemSize.Text) == false)
            {
                return;
            }
            if (DataVerification.VerifyData(tb_BarcodeNumber.Text, "int", lbl_BarcodeNumber.Text) == false)
            {
                return;
            }
            if (DataVerification.VerifyData(tb_WholesalePrice.Text, "double", lbl_WholesalePrice.Text) == false)
            {
                return;
            }
            if (DataVerification.VerifyData(tb_RetailPrice.Text, "double", lbl_RetailPrice.Text) == false)
            {
                return;
            }

            //Confirmed good data entered
            //Assign data to a temporary item object
            Item item = new Item();
            item.BarcodeNumber = int.Parse(tb_BarcodeNumber.Text);
            item.Department = cb_Department.Text;
            item.ItemName = tb_ItemName.Text;
            item.ItemSize = int.Parse(tb_ItemSize.Text);
            item.MeasurementType = cb_MeasurementType.Text;
            item.RetailPrice = double.Parse(tb_RetailPrice.Text);
            item.WholesalePrice = double.Parse(tb_WholesalePrice.Text);

            //Pass in item with all its properties to be added to database
            //DatabaseHandling method will add item to database
            DatabaseHandling.AddItemToDatabase(item);
            clearAllFields();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void clearAllFields()
        {
            tb_ItemName.Text = "";
            tb_ItemSize.Text = "";
            tb_BarcodeNumber.Text = "";
            tb_WholesalePrice.Text = "";
            tb_RetailPrice.Text = "";
            cb_Department.SelectedIndex = 0;
            cb_MeasurementType.SelectedIndex = 0;
        }


        private void updateAllData()
        {
            // TODO: This line of code loads data into the 'itemsDataSet.Department_List' table. You can move, or remove it, as needed.
            this.department_ListTableAdapter.Fill(this.itemsDataSet.Department_List);
            // TODO: This line of code loads data into the 'itemsDataSet.Measurement_Types' table. You can move, or remove it, as needed.
            this.measurement_TypesTableAdapter.Fill(this.itemsDataSet.Measurement_Types);
        }

        private void Purchasing_Items_Add_Load(object sender, EventArgs e)
        {
            updateAllData();
        }
    }
}
