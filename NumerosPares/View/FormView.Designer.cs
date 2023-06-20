namespace NumerosPares.View
{
    partial class FormView
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
            this.label2 = new System.Windows.Forms.Label();
            this.tx_resultado = new System.Windows.Forms.Label();
            this.valores = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(97, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite um número";
            // 
            // tx_resultado
            // 
            this.tx_resultado.BackColor = System.Drawing.SystemColors.Info;
            this.tx_resultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tx_resultado.Location = new System.Drawing.Point(12, 106);
            this.tx_resultado.Name = "tx_resultado";
            this.tx_resultado.Size = new System.Drawing.Size(361, 193);
            this.tx_resultado.TabIndex = 2;
            this.tx_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tx_resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // valores
            // 
            this.valores.Location = new System.Drawing.Point(37, 69);
            this.valores.Name = "valores";
            this.valores.Size = new System.Drawing.Size(168, 23);
            this.valores.TabIndex = 3;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(240, 68);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(94, 23);
            this.calcular.TabIndex = 4;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 308);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.valores);
            this.Controls.Add(this.tx_resultado);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "FormView";
            this.ShowIcon = false;
            this.Text = "FormView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label tx_resultado;
        private TextBox valores;
        private Button calcular;
    }
}