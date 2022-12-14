namespace ZH3_BSCSRJ
{
    partial class UserControlReceptek
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
            this.textBoxFogas = new System.Windows.Forms.TextBox();
            this.listBoxFogasok = new System.Windows.Forms.ListBox();
            this.listBoxNyersek = new System.Windows.Forms.ListBox();
            this.textBoxNyers = new System.Windows.Forms.TextBox();
            this.textBoxMenny = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.receptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fogasIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyersanyagNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyiseg4foDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egysegNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hozzavaloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFogas
            // 
            this.textBoxFogas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFogas.Location = new System.Drawing.Point(3, 3);
            this.textBoxFogas.Name = "textBoxFogas";
            this.textBoxFogas.Size = new System.Drawing.Size(178, 23);
            this.textBoxFogas.TabIndex = 0;
            this.textBoxFogas.TextChanged += new System.EventHandler(this.textBoxFogas_TextChanged);
            // 
            // listBoxFogasok
            // 
            this.listBoxFogasok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFogasok.FormattingEnabled = true;
            this.listBoxFogasok.ItemHeight = 15;
            this.listBoxFogasok.Location = new System.Drawing.Point(3, 32);
            this.listBoxFogasok.Name = "listBoxFogasok";
            this.listBoxFogasok.Size = new System.Drawing.Size(178, 544);
            this.listBoxFogasok.TabIndex = 1;
            this.listBoxFogasok.SelectedIndexChanged += new System.EventHandler(this.listBoxFogasok_SelectedIndexChanged);
            // 
            // listBoxNyersek
            // 
            this.listBoxNyersek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxNyersek.FormattingEnabled = true;
            this.listBoxNyersek.ItemHeight = 15;
            this.listBoxNyersek.Location = new System.Drawing.Point(877, 32);
            this.listBoxNyersek.Name = "listBoxNyersek";
            this.listBoxNyersek.Size = new System.Drawing.Size(178, 514);
            this.listBoxNyersek.TabIndex = 3;
            // 
            // textBoxNyers
            // 
            this.textBoxNyers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNyers.Location = new System.Drawing.Point(877, 3);
            this.textBoxNyers.Name = "textBoxNyers";
            this.textBoxNyers.Size = new System.Drawing.Size(178, 23);
            this.textBoxNyers.TabIndex = 2;
            this.textBoxNyers.TextChanged += new System.EventHandler(this.textBoxNyers_TextChanged);
            // 
            // textBoxMenny
            // 
            this.textBoxMenny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMenny.Location = new System.Drawing.Point(877, 553);
            this.textBoxMenny.Name = "textBoxMenny";
            this.textBoxMenny.Size = new System.Drawing.Size(84, 23);
            this.textBoxMenny.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(980, 552);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Hozzáad";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receptIDDataGridViewTextBoxColumn,
            this.fogasIDDataGridViewTextBoxColumn,
            this.nyersanyagNevDataGridViewTextBoxColumn,
            this.mennyiseg4foDataGridViewTextBoxColumn,
            this.egysegNevDataGridViewTextBoxColumn,
            this.arDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hozzavaloBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(187, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(684, 543);
            this.dataGridView1.TabIndex = 6;
            // 
            // receptIDDataGridViewTextBoxColumn
            // 
            this.receptIDDataGridViewTextBoxColumn.DataPropertyName = "ReceptID";
            this.receptIDDataGridViewTextBoxColumn.HeaderText = "ReceptID";
            this.receptIDDataGridViewTextBoxColumn.Name = "receptIDDataGridViewTextBoxColumn";
            // 
            // fogasIDDataGridViewTextBoxColumn
            // 
            this.fogasIDDataGridViewTextBoxColumn.DataPropertyName = "FogasID";
            this.fogasIDDataGridViewTextBoxColumn.HeaderText = "FogasID";
            this.fogasIDDataGridViewTextBoxColumn.Name = "fogasIDDataGridViewTextBoxColumn";
            // 
            // nyersanyagNevDataGridViewTextBoxColumn
            // 
            this.nyersanyagNevDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.HeaderText = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.Name = "nyersanyagNevDataGridViewTextBoxColumn";
            // 
            // mennyiseg4foDataGridViewTextBoxColumn
            // 
            this.mennyiseg4foDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg_4fo";
            this.mennyiseg4foDataGridViewTextBoxColumn.HeaderText = "Mennyiseg_4fo";
            this.mennyiseg4foDataGridViewTextBoxColumn.Name = "mennyiseg4foDataGridViewTextBoxColumn";
            // 
            // egysegNevDataGridViewTextBoxColumn
            // 
            this.egysegNevDataGridViewTextBoxColumn.DataPropertyName = "EgysegNev";
            this.egysegNevDataGridViewTextBoxColumn.HeaderText = "EgysegNev";
            this.egysegNevDataGridViewTextBoxColumn.Name = "egysegNevDataGridViewTextBoxColumn";
            // 
            // arDataGridViewTextBoxColumn
            // 
            this.arDataGridViewTextBoxColumn.DataPropertyName = "Ar";
            this.arDataGridViewTextBoxColumn.HeaderText = "Ar";
            this.arDataGridViewTextBoxColumn.Name = "arDataGridViewTextBoxColumn";
            // 
            // hozzavaloBindingSource
            // 
            this.hozzavaloBindingSource.DataSource = typeof(ZH3_BSCSRJ.Hozzavalo);
            // 
            // UserControlReceptek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxMenny);
            this.Controls.Add(this.listBoxNyersek);
            this.Controls.Add(this.textBoxNyers);
            this.Controls.Add(this.listBoxFogasok);
            this.Controls.Add(this.textBoxFogas);
            this.Name = "UserControlReceptek";
            this.Size = new System.Drawing.Size(1060, 584);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxFogas;
        private ListBox listBoxFogasok;
        private ListBox listBoxNyersek;
        private TextBox textBoxNyers;
        private TextBox textBoxMenny;
        private Button buttonAdd;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn receptIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fogasIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nyersanyagNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiseg4foDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egysegNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn arDataGridViewTextBoxColumn;
        private BindingSource hozzavaloBindingSource;
    }
}
