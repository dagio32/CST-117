namespace HopStock
{
    partial class Purchasing_Items_Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchasing_Items_Add));
            this.lbl_ItemName = new System.Windows.Forms.Label();
            this.tb_ItemName = new System.Windows.Forms.TextBox();
            this.tb_ItemSize = new System.Windows.Forms.TextBox();
            this.lbl_ItemSize = new System.Windows.Forms.Label();
            this.tb_BarcodeNumber = new System.Windows.Forms.TextBox();
            this.lbl_BarcodeNumber = new System.Windows.Forms.Label();
            this.tb_WholesalePrice = new System.Windows.Forms.TextBox();
            this.lbl_WholesalePrice = new System.Windows.Forms.Label();
            this.tb_RetailPrice = new System.Windows.Forms.TextBox();
            this.lbl_RetailPrice = new System.Windows.Forms.Label();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.itemsDataSet = new HopStock.ItemsDataSet();
            this.cb_Department = new System.Windows.Forms.ComboBox();
            this.departmentListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_DollarSign2 = new System.Windows.Forms.Label();
            this.lbl_DollarSign1 = new System.Windows.Forms.Label();
            this.lbl_MeasurementType = new System.Windows.Forms.Label();
            this.cb_MeasurementType = new System.Windows.Forms.ComboBox();
            this.measurementTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.measurement_TypesTableAdapter = new HopStock.ItemsDataSetTableAdapters.Measurement_TypesTableAdapter();
            this.department_ListTableAdapter = new HopStock.ItemsDataSetTableAdapters.Department_ListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ItemName
            // 
            this.lbl_ItemName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemName.Location = new System.Drawing.Point(13, 10);
            this.lbl_ItemName.Name = "lbl_ItemName";
            this.lbl_ItemName.Size = new System.Drawing.Size(172, 23);
            this.lbl_ItemName.TabIndex = 11;
            this.lbl_ItemName.Text = "Item Name";
            this.lbl_ItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_ItemName
            // 
            this.tb_ItemName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ItemName.Location = new System.Drawing.Point(191, 10);
            this.tb_ItemName.MaxLength = 50;
            this.tb_ItemName.Name = "tb_ItemName";
            this.tb_ItemName.Size = new System.Drawing.Size(177, 23);
            this.tb_ItemName.TabIndex = 0;
            // 
            // tb_ItemSize
            // 
            this.tb_ItemSize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ItemSize.Location = new System.Drawing.Point(191, 39);
            this.tb_ItemSize.MaxLength = 50;
            this.tb_ItemSize.Name = "tb_ItemSize";
            this.tb_ItemSize.Size = new System.Drawing.Size(177, 23);
            this.tb_ItemSize.TabIndex = 1;
            // 
            // lbl_ItemSize
            // 
            this.lbl_ItemSize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemSize.Location = new System.Drawing.Point(13, 39);
            this.lbl_ItemSize.Name = "lbl_ItemSize";
            this.lbl_ItemSize.Size = new System.Drawing.Size(172, 23);
            this.lbl_ItemSize.TabIndex = 12;
            this.lbl_ItemSize.Text = "Item Size";
            this.lbl_ItemSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_BarcodeNumber
            // 
            this.tb_BarcodeNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BarcodeNumber.Location = new System.Drawing.Point(191, 98);
            this.tb_BarcodeNumber.MaxLength = 50;
            this.tb_BarcodeNumber.Name = "tb_BarcodeNumber";
            this.tb_BarcodeNumber.Size = new System.Drawing.Size(177, 23);
            this.tb_BarcodeNumber.TabIndex = 3;
            // 
            // lbl_BarcodeNumber
            // 
            this.lbl_BarcodeNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BarcodeNumber.Location = new System.Drawing.Point(13, 98);
            this.lbl_BarcodeNumber.Name = "lbl_BarcodeNumber";
            this.lbl_BarcodeNumber.Size = new System.Drawing.Size(172, 23);
            this.lbl_BarcodeNumber.TabIndex = 14;
            this.lbl_BarcodeNumber.Text = "Barcode Number";
            this.lbl_BarcodeNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_WholesalePrice
            // 
            this.tb_WholesalePrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_WholesalePrice.Location = new System.Drawing.Point(191, 127);
            this.tb_WholesalePrice.MaxLength = 50;
            this.tb_WholesalePrice.Name = "tb_WholesalePrice";
            this.tb_WholesalePrice.Size = new System.Drawing.Size(177, 23);
            this.tb_WholesalePrice.TabIndex = 4;
            // 
            // lbl_WholesalePrice
            // 
            this.lbl_WholesalePrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WholesalePrice.Location = new System.Drawing.Point(13, 127);
            this.lbl_WholesalePrice.Name = "lbl_WholesalePrice";
            this.lbl_WholesalePrice.Size = new System.Drawing.Size(172, 23);
            this.lbl_WholesalePrice.TabIndex = 15;
            this.lbl_WholesalePrice.Text = "Wholesale Price";
            this.lbl_WholesalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_RetailPrice
            // 
            this.tb_RetailPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RetailPrice.Location = new System.Drawing.Point(191, 156);
            this.tb_RetailPrice.MaxLength = 50;
            this.tb_RetailPrice.Name = "tb_RetailPrice";
            this.tb_RetailPrice.Size = new System.Drawing.Size(177, 23);
            this.tb_RetailPrice.TabIndex = 5;
            // 
            // lbl_RetailPrice
            // 
            this.lbl_RetailPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RetailPrice.Location = new System.Drawing.Point(13, 156);
            this.lbl_RetailPrice.Name = "lbl_RetailPrice";
            this.lbl_RetailPrice.Size = new System.Drawing.Size(172, 23);
            this.lbl_RetailPrice.TabIndex = 17;
            this.lbl_RetailPrice.Text = "Retail Price";
            this.lbl_RetailPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Department
            // 
            this.lbl_Department.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.Location = new System.Drawing.Point(13, 185);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(172, 23);
            this.lbl_Department.TabIndex = 19;
            this.lbl_Department.Text = "Department";
            this.lbl_Department.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemsDataSet
            // 
            this.itemsDataSet.DataSetName = "ItemsDataSet";
            this.itemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_Department
            // 
            this.cb_Department.DataSource = this.departmentListBindingSource;
            this.cb_Department.DisplayMember = "Department";
            this.cb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Department.FormattingEnabled = true;
            this.cb_Department.Location = new System.Drawing.Point(191, 185);
            this.cb_Department.Name = "cb_Department";
            this.cb_Department.Size = new System.Drawing.Size(177, 21);
            this.cb_Department.TabIndex = 6;
            this.cb_Department.ValueMember = "Department";
            // 
            // departmentListBindingSource
            // 
            this.departmentListBindingSource.DataMember = "Department List";
            this.departmentListBindingSource.DataSource = this.itemsDataSet;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Image = global::HopStock.Properties.Resources.plus_sign_small;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Add.Location = new System.Drawing.Point(129, 212);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(58, 58);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Image = global::HopStock.Properties.Resources.reset;
            this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Clear.Location = new System.Drawing.Point(193, 212);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(58, 58);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Back.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Image = global::HopStock.Properties.Resources.back_arrow;
            this.btn_Back.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Back.Location = new System.Drawing.Point(310, 260);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(58, 58);
            this.btn_Back.TabIndex = 10;
            this.btn_Back.Text = "Back";
            this.btn_Back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_DollarSign2
            // 
            this.lbl_DollarSign2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DollarSign2.Location = new System.Drawing.Point(161, 156);
            this.lbl_DollarSign2.Name = "lbl_DollarSign2";
            this.lbl_DollarSign2.Size = new System.Drawing.Size(30, 23);
            this.lbl_DollarSign2.TabIndex = 18;
            this.lbl_DollarSign2.Text = "$";
            this.lbl_DollarSign2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_DollarSign1
            // 
            this.lbl_DollarSign1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DollarSign1.Location = new System.Drawing.Point(161, 127);
            this.lbl_DollarSign1.Name = "lbl_DollarSign1";
            this.lbl_DollarSign1.Size = new System.Drawing.Size(30, 23);
            this.lbl_DollarSign1.TabIndex = 16;
            this.lbl_DollarSign1.Text = "$";
            this.lbl_DollarSign1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_MeasurementType
            // 
            this.lbl_MeasurementType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MeasurementType.Location = new System.Drawing.Point(13, 69);
            this.lbl_MeasurementType.Name = "lbl_MeasurementType";
            this.lbl_MeasurementType.Size = new System.Drawing.Size(172, 23);
            this.lbl_MeasurementType.TabIndex = 13;
            this.lbl_MeasurementType.Text = "Measurement Type";
            this.lbl_MeasurementType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_MeasurementType
            // 
            this.cb_MeasurementType.DataSource = this.measurementTypesBindingSource;
            this.cb_MeasurementType.DisplayMember = "Measurement Type";
            this.cb_MeasurementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MeasurementType.FormattingEnabled = true;
            this.cb_MeasurementType.Location = new System.Drawing.Point(191, 69);
            this.cb_MeasurementType.Name = "cb_MeasurementType";
            this.cb_MeasurementType.Size = new System.Drawing.Size(177, 21);
            this.cb_MeasurementType.TabIndex = 2;
            this.cb_MeasurementType.ValueMember = "Measurement Type";
            // 
            // measurementTypesBindingSource
            // 
            this.measurementTypesBindingSource.DataMember = "Measurement Types";
            this.measurementTypesBindingSource.DataSource = this.itemsDataSet;
            // 
            // measurement_TypesTableAdapter
            // 
            this.measurement_TypesTableAdapter.ClearBeforeFill = true;
            // 
            // department_ListTableAdapter
            // 
            this.department_ListTableAdapter.ClearBeforeFill = true;
            // 
            // Purchasing_Items_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(380, 330);
            this.Controls.Add(this.cb_MeasurementType);
            this.Controls.Add(this.lbl_MeasurementType);
            this.Controls.Add(this.lbl_DollarSign2);
            this.Controls.Add(this.lbl_DollarSign1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.cb_Department);
            this.Controls.Add(this.lbl_Department);
            this.Controls.Add(this.tb_RetailPrice);
            this.Controls.Add(this.lbl_RetailPrice);
            this.Controls.Add(this.tb_WholesalePrice);
            this.Controls.Add(this.lbl_WholesalePrice);
            this.Controls.Add(this.tb_BarcodeNumber);
            this.Controls.Add(this.lbl_BarcodeNumber);
            this.Controls.Add(this.tb_ItemSize);
            this.Controls.Add(this.lbl_ItemSize);
            this.Controls.Add(this.tb_ItemName);
            this.Controls.Add(this.lbl_ItemName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Purchasing_Items_Add";
            this.Text = "Purchasing_Items_Add";
            this.Load += new System.EventHandler(this.Purchasing_Items_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ItemName;
        private System.Windows.Forms.TextBox tb_ItemName;
        private System.Windows.Forms.TextBox tb_ItemSize;
        private System.Windows.Forms.Label lbl_ItemSize;
        private System.Windows.Forms.TextBox tb_BarcodeNumber;
        private System.Windows.Forms.Label lbl_BarcodeNumber;
        private System.Windows.Forms.TextBox tb_WholesalePrice;
        private System.Windows.Forms.Label lbl_WholesalePrice;
        private System.Windows.Forms.TextBox tb_RetailPrice;
        private System.Windows.Forms.Label lbl_RetailPrice;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.ComboBox cb_Department;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_DollarSign2;
        private System.Windows.Forms.Label lbl_DollarSign1;
        private System.Windows.Forms.Label lbl_MeasurementType;
        private System.Windows.Forms.ComboBox cb_MeasurementType;
        private ItemsDataSet itemsDataSet;
        private System.Windows.Forms.BindingSource measurementTypesBindingSource;
        private ItemsDataSetTableAdapters.Measurement_TypesTableAdapter measurement_TypesTableAdapter;
        private System.Windows.Forms.BindingSource departmentListBindingSource;
        private ItemsDataSetTableAdapters.Department_ListTableAdapter department_ListTableAdapter;
    }
}