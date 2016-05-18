namespace RFCWEBSAP
{
    partial class Form1
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
            this.btnconsultarInventario = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtJerarquiaWeb = new System.Windows.Forms.TextBox();
            this.btnconsultarJerarquiaWeb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCentro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnconsultarInventario
            // 
            this.btnconsultarInventario.Location = new System.Drawing.Point(12, 41);
            this.btnconsultarInventario.Name = "btnconsultarInventario";
            this.btnconsultarInventario.Size = new System.Drawing.Size(128, 23);
            this.btnconsultarInventario.TabIndex = 0;
            this.btnconsultarInventario.Text = "Consultar Inventario";
            this.btnconsultarInventario.UseVisualStyleBackColor = true;
            this.btnconsultarInventario.Click += new System.EventHandler(this.btnconsultarInventario_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(864, 393);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtJerarquiaWeb
            // 
            this.txtJerarquiaWeb.Location = new System.Drawing.Point(388, 45);
            this.txtJerarquiaWeb.Name = "txtJerarquiaWeb";
            this.txtJerarquiaWeb.Size = new System.Drawing.Size(100, 20);
            this.txtJerarquiaWeb.TabIndex = 3;
            // 
            // btnconsultarJerarquiaWeb
            // 
            this.btnconsultarJerarquiaWeb.Location = new System.Drawing.Point(12, 12);
            this.btnconsultarJerarquiaWeb.Name = "btnconsultarJerarquiaWeb";
            this.btnconsultarJerarquiaWeb.Size = new System.Drawing.Size(128, 23);
            this.btnconsultarJerarquiaWeb.TabIndex = 4;
            this.btnconsultarJerarquiaWeb.Text = "Consultar JerarquiaWeb";
            this.btnconsultarJerarquiaWeb.UseVisualStyleBackColor = true;
            this.btnconsultarJerarquiaWeb.Click += new System.EventHandler(this.btnconsultarJerarquiaWeb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "JerarquiaWeb:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Centro:";
            // 
            // txtCentro
            // 
            this.txtCentro.Location = new System.Drawing.Point(200, 44);
            this.txtCentro.Name = "txtCentro";
            this.txtCentro.Size = new System.Drawing.Size(100, 20);
            this.txtCentro.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "probar rfc idoc_inbound_single";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCentro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconsultarJerarquiaWeb);
            this.Controls.Add(this.txtJerarquiaWeb);
            this.Controls.Add(this.btnconsultarInventario);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconsultarInventario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtJerarquiaWeb;
        private System.Windows.Forms.Button btnconsultarJerarquiaWeb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCentro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

