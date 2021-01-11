
namespace BS2020proj
{
    partial class ClientForm
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
            this.clientLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgLibraryCollection = new System.Windows.Forms.DataGridView();
            this.dvgReservedBooks = new System.Windows.Forms.DataGridView();
            this.dvgRentedBooks = new System.Windows.Forms.DataGridView();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLibraryCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgReservedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRentedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.Location = new System.Drawing.Point(88, 22);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(120, 20);
            this.clientLabel.TabIndex = 0;
            this.clientLabel.Text = "Client Logged";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello:";
            // 
            // dvgLibraryCollection
            // 
            this.dvgLibraryCollection.AllowUserToAddRows = false;
            this.dvgLibraryCollection.AllowUserToDeleteRows = false;
            this.dvgLibraryCollection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvgLibraryCollection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLibraryCollection.Location = new System.Drawing.Point(473, 22);
            this.dvgLibraryCollection.Name = "dvgLibraryCollection";
            this.dvgLibraryCollection.ReadOnly = true;
            this.dvgLibraryCollection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgLibraryCollection.Size = new System.Drawing.Size(292, 395);
            this.dvgLibraryCollection.TabIndex = 2;
            // 
            // dvgReservedBooks
            // 
            this.dvgReservedBooks.AllowUserToAddRows = false;
            this.dvgReservedBooks.AllowUserToDeleteRows = false;
            this.dvgReservedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvgReservedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgReservedBooks.Location = new System.Drawing.Point(30, 81);
            this.dvgReservedBooks.Name = "dvgReservedBooks";
            this.dvgReservedBooks.ReadOnly = true;
            this.dvgReservedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgReservedBooks.Size = new System.Drawing.Size(344, 154);
            this.dvgReservedBooks.TabIndex = 3;
            // 
            // dvgRentedBooks
            // 
            this.dvgRentedBooks.AllowUserToAddRows = false;
            this.dvgRentedBooks.AllowUserToDeleteRows = false;
            this.dvgRentedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvgRentedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRentedBooks.Location = new System.Drawing.Point(30, 270);
            this.dvgRentedBooks.Name = "dvgRentedBooks";
            this.dvgRentedBooks.ReadOnly = true;
            this.dvgRentedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgRentedBooks.Size = new System.Drawing.Size(344, 146);
            this.dvgRentedBooks.TabIndex = 4;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(380, 125);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(75, 23);
            this.btnReserve.TabIndex = 5;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(167, 241);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 6;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Library Collection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Reserved Books:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rented Books:";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.dvgRentedBooks);
            this.Controls.Add(this.dvgReservedBooks);
            this.Controls.Add(this.dvgLibraryCollection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientLabel);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.dvgLibraryCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgReservedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRentedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgLibraryCollection;
        private System.Windows.Forms.DataGridView dvgReservedBooks;
        private System.Windows.Forms.DataGridView dvgRentedBooks;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}