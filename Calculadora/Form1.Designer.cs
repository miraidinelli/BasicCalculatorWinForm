namespace Calculadora
{
    partial class frmcalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbnumero1 = new System.Windows.Forms.TextBox();
            this.txbnumero2 = new System.Windows.Forms.TextBox();
            this.txbresultado = new System.Windows.Forms.TextBox();
            this.btnsoma = new System.Windows.Forms.Button();
            this.btnsubtracao = new System.Windows.Forms.Button();
            this.btnmultiplicacao = new System.Windows.Forms.Button();
            this.btndivisao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado:";
            // 
            // txbnumero1
            // 
            this.txbnumero1.Location = new System.Drawing.Point(80, 78);
            this.txbnumero1.Name = "txbnumero1";
            this.txbnumero1.Size = new System.Drawing.Size(100, 23);
            this.txbnumero1.TabIndex = 3;
            // 
            // txbnumero2
            // 
            this.txbnumero2.Location = new System.Drawing.Point(80, 116);
            this.txbnumero2.Name = "txbnumero2";
            this.txbnumero2.Size = new System.Drawing.Size(100, 23);
            this.txbnumero2.TabIndex = 4;
            // 
            // txbresultado
            // 
            this.txbresultado.Location = new System.Drawing.Point(80, 149);
            this.txbresultado.Name = "txbresultado";
            this.txbresultado.ReadOnly = true;
            this.txbresultado.Size = new System.Drawing.Size(100, 23);
            this.txbresultado.TabIndex = 5;
            // 
            // btnsoma
            // 
            this.btnsoma.Location = new System.Drawing.Point(244, 82);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(23, 23);
            this.btnsoma.TabIndex = 6;
            this.btnsoma.Text = "+";
            this.btnsoma.UseVisualStyleBackColor = true;
            this.btnsoma.Click += new System.EventHandler(this.btnsoma_Click);
            // 
            // btnsubtracao
            // 
            this.btnsubtracao.Location = new System.Drawing.Point(244, 115);
            this.btnsubtracao.Name = "btnsubtracao";
            this.btnsubtracao.Size = new System.Drawing.Size(23, 23);
            this.btnsubtracao.TabIndex = 7;
            this.btnsubtracao.Text = "-";
            this.btnsubtracao.UseVisualStyleBackColor = true;
            this.btnsubtracao.Click += new System.EventHandler(this.btnsubtracao_Click);
            // 
            // btnmultiplicacao
            // 
            this.btnmultiplicacao.Location = new System.Drawing.Point(273, 99);
            this.btnmultiplicacao.Name = "btnmultiplicacao";
            this.btnmultiplicacao.Size = new System.Drawing.Size(24, 23);
            this.btnmultiplicacao.TabIndex = 8;
            this.btnmultiplicacao.Text = "*";
            this.btnmultiplicacao.UseVisualStyleBackColor = true;
            this.btnmultiplicacao.Click += new System.EventHandler(this.btnmultiplicacao_Click);
            // 
            // btndivisao
            // 
            this.btndivisao.Location = new System.Drawing.Point(211, 99);
            this.btndivisao.Name = "btndivisao";
            this.btndivisao.Size = new System.Drawing.Size(27, 23);
            this.btndivisao.TabIndex = 9;
            this.btndivisao.Text = "/";
            this.btndivisao.UseVisualStyleBackColor = true;
            this.btndivisao.Click += new System.EventHandler(this.btndivisao_Click);
            // 
            // frmcalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 249);
            this.Controls.Add(this.btndivisao);
            this.Controls.Add(this.btnmultiplicacao);
            this.Controls.Add(this.btnsubtracao);
            this.Controls.Add(this.btnsoma);
            this.Controls.Add(this.txbresultado);
            this.Controls.Add(this.txbnumero2);
            this.Controls.Add(this.txbnumero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmcalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbnumero1;
        private TextBox txbnumero2;
        private TextBox txbresultado;
        private Button btnsoma;
        private Button btnsubtracao;
        private Button btnmultiplicacao;
        private Button btndivisao;
    }
}