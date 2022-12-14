namespace ZH3_BSCSRJ
{
    partial class UserControlFogasok
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
            this.components = new System.ComponentModel.Container();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fogasIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fogasNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leirasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fogasokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fogasokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(27, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 78);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Hozzáad";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(149, 3);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(116, 78);
            this.buttonDel.TabIndex = 1;
            this.buttonDel.Text = "Töröl";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(271, 3);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(116, 78);
            this.buttonExcel.TabIndex = 2;
            this.buttonExcel.Text = "Mentés Excelbe";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fogasIdDataGridViewTextBoxColumn,
            this.fogasNevDataGridViewTextBoxColumn,
            this.leirasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fogasokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(421, 370);
            this.dataGridView1.TabIndex = 3;
            // 
            // fogasIdDataGridViewTextBoxColumn
            // 
            this.fogasIdDataGridViewTextBoxColumn.DataPropertyName = "FogasId";
            this.fogasIdDataGridViewTextBoxColumn.HeaderText = "FogasId";
            this.fogasIdDataGridViewTextBoxColumn.Name = "fogasIdDataGridViewTextBoxColumn";
            // 
            // fogasNevDataGridViewTextBoxColumn
            // 
            this.fogasNevDataGridViewTextBoxColumn.DataPropertyName = "FogasNev";
            this.fogasNevDataGridViewTextBoxColumn.HeaderText = "FogasNev";
            this.fogasNevDataGridViewTextBoxColumn.Name = "fogasNevDataGridViewTextBoxColumn";
            // 
            // leirasDataGridViewTextBoxColumn
            // 
            this.leirasDataGridViewTextBoxColumn.DataPropertyName = "Leiras";
            this.leirasDataGridViewTextBoxColumn.HeaderText = "Leiras";
            this.leirasDataGridViewTextBoxColumn.Name = "leirasDataGridViewTextBoxColumn";
            // 
            // fogasokBindingSource
            // 
            this.fogasokBindingSource.DataSource = typeof(ZH3_BSCSRJ.Models.Fogasok);
            // 
            // UserControlFogasok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Name = "UserControlFogasok";
            this.Size = new System.Drawing.Size(429, 460);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fogasokBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonAdd;
        private Button buttonDel;
        private Button buttonExcel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn fogasIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fogasNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn leirasDataGridViewTextBoxColumn;
        private BindingSource fogasokBindingSource;
    }
}
