namespace ZH3_BSCSRJ
{
    partial class FormData
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
            this.buttonReceptek = new System.Windows.Forms.Button();
            this.buttonFogasok = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonReceptek
            // 
            this.buttonReceptek.Location = new System.Drawing.Point(12, 12);
            this.buttonReceptek.Name = "buttonReceptek";
            this.buttonReceptek.Size = new System.Drawing.Size(91, 71);
            this.buttonReceptek.TabIndex = 0;
            this.buttonReceptek.Text = "Receptek";
            this.buttonReceptek.UseVisualStyleBackColor = true;
            this.buttonReceptek.Click += new System.EventHandler(this.buttonReceptek_Click);
            // 
            // buttonFogasok
            // 
            this.buttonFogasok.Location = new System.Drawing.Point(12, 89);
            this.buttonFogasok.Name = "buttonFogasok";
            this.buttonFogasok.Size = new System.Drawing.Size(91, 71);
            this.buttonFogasok.TabIndex = 1;
            this.buttonFogasok.Text = "Fogások";
            this.buttonFogasok.UseVisualStyleBackColor = true;
            this.buttonFogasok.Click += new System.EventHandler(this.buttonFogasok_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(109, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 583);
            this.panel1.TabIndex = 2;
            // 
            // FormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 607);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonFogasok);
            this.Controls.Add(this.buttonReceptek);
            this.Name = "FormData";
            this.Text = "FormData";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonReceptek;
        private Button buttonFogasok;
        private Panel panel1;
    }
}