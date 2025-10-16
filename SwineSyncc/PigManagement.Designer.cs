namespace SwineSyncc
{
    partial class PigManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pigTable = new System.Windows.Forms.DataGridView();
            this.PigID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Breed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegisterPig = new System.Windows.Forms.Button();
            this.btnEditPig = new System.Windows.Forms.Button();
            this.btnDeletePig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pigTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pig Management";
            // 
            // pigTable
            // 
            this.pigTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pigTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PigID,
            this.TagNumber,
            this.Breed,
            this.Sex,
            this.BirthDate,
            this.Weight,
            this.Status});
            this.pigTable.Location = new System.Drawing.Point(238, 118);
            this.pigTable.Name = "pigTable";
            this.pigTable.RowHeadersWidth = 51;
            this.pigTable.RowTemplate.Height = 24;
            this.pigTable.Size = new System.Drawing.Size(929, 488);
            this.pigTable.TabIndex = 1;
            // 
            // PigID
            // 
            this.PigID.HeaderText = "Pig ID";
            this.PigID.MinimumWidth = 6;
            this.PigID.Name = "PigID";
            this.PigID.Width = 125;
            // 
            // TagNumber
            // 
            this.TagNumber.HeaderText = "Tag Number";
            this.TagNumber.MinimumWidth = 6;
            this.TagNumber.Name = "TagNumber";
            this.TagNumber.Width = 125;
            // 
            // Breed
            // 
            this.Breed.HeaderText = "Breed";
            this.Breed.MinimumWidth = 6;
            this.Breed.Name = "Breed";
            this.Breed.Width = 125;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Sex";
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            this.Sex.Width = 125;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "BirthDate";
            this.BirthDate.MinimumWidth = 6;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Width = 125;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.MinimumWidth = 6;
            this.Weight.Name = "Weight";
            this.Weight.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // btnRegisterPig
            // 
            this.btnRegisterPig.Location = new System.Drawing.Point(238, 656);
            this.btnRegisterPig.Name = "btnRegisterPig";
            this.btnRegisterPig.Size = new System.Drawing.Size(214, 79);
            this.btnRegisterPig.TabIndex = 2;
            this.btnRegisterPig.Text = "Register pig";
            this.btnRegisterPig.UseVisualStyleBackColor = true;
            this.btnRegisterPig.Click += new System.EventHandler(this.btnRegisterPig_Click);
            // 
            // btnEditPig
            // 
            this.btnEditPig.Location = new System.Drawing.Point(600, 656);
            this.btnEditPig.Name = "btnEditPig";
            this.btnEditPig.Size = new System.Drawing.Size(214, 79);
            this.btnEditPig.TabIndex = 3;
            this.btnEditPig.Text = "Edit pig info";
            this.btnEditPig.UseVisualStyleBackColor = true;
            // 
            // btnDeletePig
            // 
            this.btnDeletePig.Location = new System.Drawing.Point(953, 656);
            this.btnDeletePig.Name = "btnDeletePig";
            this.btnDeletePig.Size = new System.Drawing.Size(214, 79);
            this.btnDeletePig.TabIndex = 4;
            this.btnDeletePig.Text = "Delete pig";
            this.btnDeletePig.UseVisualStyleBackColor = true;
            // 
            // PigManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeletePig);
            this.Controls.Add(this.btnEditPig);
            this.Controls.Add(this.btnRegisterPig);
            this.Controls.Add(this.pigTable);
            this.Controls.Add(this.label1);
            this.Name = "PigManagement";
            this.Size = new System.Drawing.Size(1346, 797);
            ((System.ComponentModel.ISupportInitialize)(this.pigTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView pigTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn PigID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Breed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnRegisterPig;
        private System.Windows.Forms.Button btnEditPig;
        private System.Windows.Forms.Button btnDeletePig;
    }
}
