
namespace SimpleDataApp
{
    partial class FillOrCancel
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnFindByOrderID = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFillDate = new System.Windows.Forms.DateTimePicker();
            this.salesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDataSet = new SimpleDataApp.SalesDataSet();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnFillOrder = new System.Windows.Forms.Button();
            this.btnFinishUpdates = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Location = new System.Drawing.Point(185, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Идентификатор заказа:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(340, 51);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(76, 20);
            this.txtOrderID.TabIndex = 1;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // btnFindByOrderID
            // 
            this.btnFindByOrderID.AutoSize = true;
            this.btnFindByOrderID.BackColor = System.Drawing.Color.Pink;
            this.btnFindByOrderID.Location = new System.Drawing.Point(293, 87);
            this.btnFindByOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindByOrderID.Name = "btnFindByOrderID";
            this.btnFindByOrderID.Size = new System.Drawing.Size(81, 23);
            this.btnFindByOrderID.TabIndex = 2;
            this.btnFindByOrderID.Text = "Найти заказ";
            this.btnFindByOrderID.UseVisualStyleBackColor = false;
            this.btnFindByOrderID.Click += new System.EventHandler(this.btnFindByOrderID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Location = new System.Drawing.Point(72, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "При заполнении заказа укажите дату заполнения";
            // 
            // dtpFillDate
            // 
            this.dtpFillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFillDate.Location = new System.Drawing.Point(345, 150);
            this.dtpFillDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFillDate.Name = "dtpFillDate";
            this.dtpFillDate.Size = new System.Drawing.Size(151, 20);
            this.dtpFillDate.TabIndex = 4;
            this.dtpFillDate.ValueChanged += new System.EventHandler(this.dtpFillDate_ValueChanged);
            // 
            // salesDataSetBindingSource
            // 
            this.salesDataSetBindingSource.DataSource = this.salesDataSet;
            this.salesDataSetBindingSource.Position = 0;
            // 
            // salesDataSet
            // 
            this.salesDataSet.DataSetName = "SalesDataSet";
            this.salesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.AutoSize = true;
            this.btnCancelOrder.BackColor = System.Drawing.Color.Pink;
            this.btnCancelOrder.Location = new System.Drawing.Point(26, 330);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(100, 23);
            this.btnCancelOrder.TabIndex = 6;
            this.btnCancelOrder.Text = "Отменить заказ";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnFillOrder
            // 
            this.btnFillOrder.AutoSize = true;
            this.btnFillOrder.BackColor = System.Drawing.Color.Pink;
            this.btnFillOrder.Location = new System.Drawing.Point(271, 330);
            this.btnFillOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnFillOrder.Name = "btnFillOrder";
            this.btnFillOrder.Size = new System.Drawing.Size(104, 23);
            this.btnFillOrder.TabIndex = 7;
            this.btnFillOrder.Text = "Заполнить заказ";
            this.btnFillOrder.UseVisualStyleBackColor = false;
            this.btnFillOrder.Click += new System.EventHandler(this.btnFillOrder_Click);
            // 
            // btnFinishUpdates
            // 
            this.btnFinishUpdates.AutoSize = true;
            this.btnFinishUpdates.BackColor = System.Drawing.Color.Pink;
            this.btnFinishUpdates.Location = new System.Drawing.Point(516, 330);
            this.btnFinishUpdates.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinishUpdates.Name = "btnFinishUpdates";
            this.btnFinishUpdates.Size = new System.Drawing.Size(56, 23);
            this.btnFinishUpdates.TabIndex = 8;
            this.btnFinishUpdates.Text = "Готово";
            this.btnFinishUpdates.UseVisualStyleBackColor = false;
            this.btnFinishUpdates.Click += new System.EventHandler(this.btnFinishUpdates_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimpleDataApp.Properties.Resources._12;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FillOrCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnFinishUpdates);
            this.Controls.Add(this.btnFillOrder);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.dtpFillDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFindByOrderID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FillOrCancel";
            this.Text = "Заполнить или отменить заказ";
            this.Load += new System.EventHandler(this.FillOrCancel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnFindByOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFillDate;
        private System.Windows.Forms.BindingSource salesDataSetBindingSource;
        private SalesDataSet salesDataSet;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnFillOrder;
        private System.Windows.Forms.Button btnFinishUpdates;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}