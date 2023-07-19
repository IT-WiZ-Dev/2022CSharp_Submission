namespace FlowersLanguage
{
    partial class FormEdit
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
            this.dataGridViewContents = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FlowerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerColor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContents
            // 
            this.dataGridViewContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeleteButton,
            this.FlowerName,
            this.FlowerColor,
            this.Language});
            this.dataGridViewContents.Location = new System.Drawing.Point(14, 12);
            this.dataGridViewContents.Name = "dataGridViewContents";
            this.dataGridViewContents.RowTemplate.Height = 21;
            this.dataGridViewContents.Size = new System.Drawing.Size(618, 201);
            this.dataGridViewContents.TabIndex = 0;
            this.dataGridViewContents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewContents_CellContentClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.HeaderText = "削除";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Width = 50;
            // 
            // FlowerName
            // 
            this.FlowerName.HeaderText = "花の名前（カタカナ）";
            this.FlowerName.Name = "FlowerName";
            this.FlowerName.Width = 150;
            // 
            // FlowerColor
            // 
            this.FlowerColor.HeaderText = "色";
            this.FlowerColor.Items.AddRange(new object[] {
            "赤",
            "白",
            "ピンク",
            "黄",
            "紫",
            "青",
            "黒"});
            this.FlowerColor.Name = "FlowerColor";
            this.FlowerColor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FlowerColor.Width = 75;
            // 
            // Language
            // 
            this.Language.HeaderText = "花ことば";
            this.Language.Name = "Language";
            this.Language.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Language.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Language.Width = 300;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(326, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdd.Location = new System.Drawing.Point(245, 226);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "OK";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 261);
            this.Controls.Add(this.dataGridViewContents);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormEdit";
            this.Text = "花ことばの追加・編集・削除";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContents;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerName;
        private System.Windows.Forms.DataGridViewComboBoxColumn FlowerColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
    }
}