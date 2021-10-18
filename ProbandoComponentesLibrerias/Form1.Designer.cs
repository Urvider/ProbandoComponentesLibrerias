namespace ProbandoComponentesLibrerias
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
            this.agregar1 = new WindowsFormsControlLibrary1.Agregar();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.lbR = new System.Windows.Forms.Label();
            this.btCalcularPer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btCalcularArea = new System.Windows.Forms.Button();
            this.rbCuadrado = new System.Windows.Forms.RadioButton();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // agregar1
            // 
            this.agregar1.Location = new System.Drawing.Point(33, 12);
            this.agregar1.Name = "agregar1";
            this.agregar1.Size = new System.Drawing.Size(277, 186);
            this.agregar1.TabIndex = 0;
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(93, 226);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(100, 20);
            this.txtL.TabIndex = 1;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(93, 275);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 20);
            this.txtH.TabIndex = 2;
            // 
            // lbR
            // 
            this.lbR.AutoSize = true;
            this.lbR.Location = new System.Drawing.Point(141, 328);
            this.lbR.Name = "lbR";
            this.lbR.Size = new System.Drawing.Size(10, 13);
            this.lbR.TabIndex = 3;
            this.lbR.Text = "-";
            // 
            // btCalcularPer
            // 
            this.btCalcularPer.Location = new System.Drawing.Point(227, 224);
            this.btCalcularPer.Name = "btCalcularPer";
            this.btCalcularPer.Size = new System.Drawing.Size(167, 23);
            this.btCalcularPer.TabIndex = 4;
            this.btCalcularPer.Text = "Calcular Perimetro";
            this.btCalcularPer.UseVisualStyleBackColor = true;
            this.btCalcularPer.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado";
            // 
            // btCalcularArea
            // 
            this.btCalcularArea.Location = new System.Drawing.Point(227, 272);
            this.btCalcularArea.Name = "btCalcularArea";
            this.btCalcularArea.Size = new System.Drawing.Size(167, 23);
            this.btCalcularArea.TabIndex = 8;
            this.btCalcularArea.Text = "Calcular Area";
            this.btCalcularArea.UseVisualStyleBackColor = true;
            this.btCalcularArea.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbCuadrado
            // 
            this.rbCuadrado.AutoSize = true;
            this.rbCuadrado.Location = new System.Drawing.Point(264, 376);
            this.rbCuadrado.Name = "rbCuadrado";
            this.rbCuadrado.Size = new System.Drawing.Size(71, 17);
            this.rbCuadrado.TabIndex = 9;
            this.rbCuadrado.TabStop = true;
            this.rbCuadrado.Text = "Cuadrado";
            this.rbCuadrado.UseVisualStyleBackColor = true;
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Location = new System.Drawing.Point(93, 376);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(69, 17);
            this.rbTriangulo.TabIndex = 10;
            this.rbTriangulo.TabStop = true;
            this.rbTriangulo.Text = "Triangulo";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 415);
            this.Controls.Add(this.rbTriangulo);
            this.Controls.Add(this.rbCuadrado);
            this.Controls.Add(this.btCalcularArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCalcularPer);
            this.Controls.Add(this.lbR);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtL);
            this.Controls.Add(this.agregar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.Agregar agregar1;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label lbR;
        private System.Windows.Forms.Button btCalcularPer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCalcularArea;
        private System.Windows.Forms.RadioButton rbCuadrado;
        private System.Windows.Forms.RadioButton rbTriangulo;
    }
}

