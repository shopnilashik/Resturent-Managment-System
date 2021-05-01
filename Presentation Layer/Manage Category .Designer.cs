
namespace Resturent_Managment_System.Presentation_Layer
{
    partial class Manage_Category
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteCategoryIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updateCategoryIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.categoryListDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.deleteButton);
            this.groupBox4.Controls.Add(this.deleteCategoryIdTextBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(45, 338);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 109);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete Category";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(117, 65);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(146, 31);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteCategoryIdTextBox
            // 
            this.deleteCategoryIdTextBox.Location = new System.Drawing.Point(117, 25);
            this.deleteCategoryIdTextBox.Name = "deleteCategoryIdTextBox";
            this.deleteCategoryIdTextBox.Size = new System.Drawing.Size(146, 22);
            this.deleteCategoryIdTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category Id";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.updateCategoryIdTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.updateButton);
            this.groupBox3.Controls.Add(this.updateCategoryNameTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(45, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 164);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Category";
            // 
            // updateCategoryIdTextBox
            // 
            this.updateCategoryIdTextBox.Enabled = false;
            this.updateCategoryIdTextBox.Location = new System.Drawing.Point(117, 33);
            this.updateCategoryIdTextBox.Name = "updateCategoryIdTextBox";
            this.updateCategoryIdTextBox.Size = new System.Drawing.Size(146, 22);
            this.updateCategoryIdTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category Id";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(117, 111);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(146, 31);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateCategoryNameTextBox
            // 
            this.updateCategoryNameTextBox.Location = new System.Drawing.Point(117, 71);
            this.updateCategoryNameTextBox.Name = "updateCategoryNameTextBox";
            this.updateCategoryNameTextBox.Size = new System.Drawing.Size(146, 22);
            this.updateCategoryNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.addCategoryNameTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 109);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Category";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(117, 65);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(146, 31);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addCategoryNameTextBox
            // 
            this.addCategoryNameTextBox.Location = new System.Drawing.Point(117, 25);
            this.addCategoryNameTextBox.Name = "addCategoryNameTextBox";
            this.addCategoryNameTextBox.Size = new System.Drawing.Size(146, 22);
            this.addCategoryNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.categoryListDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(462, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 197);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category List";
            // 
            // categoryListDataGridView
            // 
            this.categoryListDataGridView.AllowUserToAddRows = false;
            this.categoryListDataGridView.AllowUserToDeleteRows = false;
            this.categoryListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryListDataGridView.Location = new System.Drawing.Point(17, 28);
            this.categoryListDataGridView.Name = "categoryListDataGridView";
            this.categoryListDataGridView.ReadOnly = true;
            this.categoryListDataGridView.Size = new System.Drawing.Size(262, 150);
            this.categoryListDataGridView.TabIndex = 0;
            // 
            // Manage_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Manage_Category";
            this.Text = "Manage_Category";
            this.Load += new System.EventHandler(this.Manage_Category_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox deleteCategoryIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox updateCategoryIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox updateCategoryNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addCategoryNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView categoryListDataGridView;
    }
}