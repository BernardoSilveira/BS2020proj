
namespace BS2020proj
{
    partial class StaffForm
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
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgReservedBooks = new System.Windows.Forms.DataGridView();
            this.dvgRentedBooks = new System.Windows.Forms.DataGridView();
            this.btnRent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dvgLibraryCollection = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgReservedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRentedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLibraryCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(54, 12);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(228, 21);
            this.cmbClient.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client:";
            // 
            // dvgReservedBooks
            // 
            this.dvgReservedBooks.AllowUserToAddRows = false;
            this.dvgReservedBooks.AllowUserToDeleteRows = false;
            this.dvgReservedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgReservedBooks.Location = new System.Drawing.Point(10, 77);
            this.dvgReservedBooks.Name = "dvgReservedBooks";
            this.dvgReservedBooks.ReadOnly = true;
            this.dvgReservedBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvgReservedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgReservedBooks.Size = new System.Drawing.Size(344, 204);
            this.dvgReservedBooks.TabIndex = 2;
            // 
            // dvgRentedBooks
            // 
            this.dvgRentedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRentedBooks.Location = new System.Drawing.Point(10, 326);
            this.dvgRentedBooks.Name = "dvgRentedBooks";
            this.dvgRentedBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvgRentedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgRentedBooks.Size = new System.Drawing.Size(344, 197);
            this.dvgRentedBooks.TabIndex = 3;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(128, 287);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(86, 23);
            this.btnRent.TabIndex = 4;
            this.btnRent.Text = "Process Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reserved Books:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rented Books:";
            // 
            // dvgLibraryCollection
            // 
            this.dvgLibraryCollection.AllowUserToAddRows = false;
            this.dvgLibraryCollection.AllowUserToDeleteRows = false;
            this.dvgLibraryCollection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLibraryCollection.Location = new System.Drawing.Point(428, 38);
            this.dvgLibraryCollection.Name = "dvgLibraryCollection";
            this.dvgLibraryCollection.ReadOnly = true;
            this.dvgLibraryCollection.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvgLibraryCollection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgLibraryCollection.Size = new System.Drawing.Size(230, 486);
            this.dvgLibraryCollection.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Library Collection:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(288, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(360, 388);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(62, 23);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 544);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dvgLibraryCollection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.dvgRentedBooks);
            this.Controls.Add(this.dvgReservedBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClient);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgReservedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRentedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLibraryCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgReservedBooks;
        private System.Windows.Forms.DataGridView dvgRentedBooks;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dvgLibraryCollection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnReturn;
    }
}