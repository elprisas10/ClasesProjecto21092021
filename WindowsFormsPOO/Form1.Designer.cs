
namespace WindowsFormsPOO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.txtstartP = new System.Windows.Forms.TextBox();
            this.txtfinishP = new System.Windows.Forms.TextBox();
            this.txtdescriptionP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstProjectInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codigo del proyecto";
            // 
            // txtIDP
            // 
            this.txtIDP.Location = new System.Drawing.Point(58, 47);
            this.txtIDP.Name = "txtIDP";
            this.txtIDP.Size = new System.Drawing.Size(100, 20);
            this.txtIDP.TabIndex = 1;
            // 
            // txtstartP
            // 
            this.txtstartP.Location = new System.Drawing.Point(183, 47);
            this.txtstartP.Name = "txtstartP";
            this.txtstartP.Size = new System.Drawing.Size(100, 20);
            this.txtstartP.TabIndex = 2;
            // 
            // txtfinishP
            // 
            this.txtfinishP.Location = new System.Drawing.Point(316, 47);
            this.txtfinishP.Name = "txtfinishP";
            this.txtfinishP.Size = new System.Drawing.Size(100, 20);
            this.txtfinishP.TabIndex = 3;
            // 
            // txtdescriptionP
            // 
            this.txtdescriptionP.Location = new System.Drawing.Point(463, 47);
            this.txtdescriptionP.Name = "txtdescriptionP";
            this.txtdescriptionP.Size = new System.Drawing.Size(100, 20);
            this.txtdescriptionP.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Inicio del proyecto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Final del proyecto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Descripcion del proyecto";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(633, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstProjectInfo
            // 
            this.lstProjectInfo.FormattingEnabled = true;
            this.lstProjectInfo.Location = new System.Drawing.Point(58, 109);
            this.lstProjectInfo.Name = "lstProjectInfo";
            this.lstProjectInfo.Size = new System.Drawing.Size(650, 238);
            this.lstProjectInfo.TabIndex = 9;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(761, 400);
            this.Controls.Add(this.lstProjectInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdescriptionP);
            this.Controls.Add(this.txtfinishP);
            this.Controls.Add(this.txtstartP);
            this.Controls.Add(this.txtIDP);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtstart;
        private System.Windows.Forms.TextBox txtfinish;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDP;
        private System.Windows.Forms.TextBox txtstartP;
        private System.Windows.Forms.TextBox txtfinishP;
        private System.Windows.Forms.TextBox txtdescriptionP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstProjectInfo;
    }
}

