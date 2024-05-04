namespace WinFormsApp2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.txtPlazoMeses = new System.Windows.Forms.TextBox();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCuotaMensual = new System.Windows.Forms.Label();
            this.lblTotalPagado = new System.Windows.Forms.Label();
            this.lblTotalIntereses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(409, 252);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(133, 39);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CALCULADORA CAPITAL FINAL";
            // 
            // txtMontoPrestamo
            // 
            this.txtMontoPrestamo.Location = new System.Drawing.Point(362, 96);
            this.txtMontoPrestamo.Name = "txtMontoPrestamo";
            this.txtMontoPrestamo.Size = new System.Drawing.Size(218, 25);
            this.txtMontoPrestamo.TabIndex = 2;
            // 
            // txtPlazoMeses
            // 
            this.txtPlazoMeses.Location = new System.Drawing.Point(362, 201);
            this.txtPlazoMeses.Name = "txtPlazoMeses";
            this.txtPlazoMeses.Size = new System.Drawing.Size(218, 25);
            this.txtPlazoMeses.TabIndex = 3;
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.AcceptsReturn = true;
            this.txtTasaInteres.Location = new System.Drawing.Point(362, 148);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(218, 25);
            this.txtTasaInteres.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Monto inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tasa de Interes ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(216, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Plazo a Meses ";
            // 
            // lblCuotaMensual
            // 
            this.lblCuotaMensual.AutoSize = true;
            this.lblCuotaMensual.Location = new System.Drawing.Point(176, 311);
            this.lblCuotaMensual.Name = "lblCuotaMensual";
            this.lblCuotaMensual.Size = new System.Drawing.Size(108, 17);
            this.lblCuotaMensual.TabIndex = 8;
            this.lblCuotaMensual.Text = "Cuota Mensual";
            // 
            // lblTotalPagado
            // 
            this.lblTotalPagado.AutoSize = true;
            this.lblTotalPagado.Location = new System.Drawing.Point(392, 311);
            this.lblTotalPagado.Name = "lblTotalPagado";
            this.lblTotalPagado.Size = new System.Drawing.Size(98, 17);
            this.lblTotalPagado.TabIndex = 9;
            this.lblTotalPagado.Text = "Total Pagado";
            // 
            // lblTotalIntereses
            // 
            this.lblTotalIntereses.AutoSize = true;
            this.lblTotalIntereses.Location = new System.Drawing.Point(604, 311);
            this.lblTotalIntereses.Name = "lblTotalIntereses";
            this.lblTotalIntereses.Size = new System.Drawing.Size(93, 17);
            this.lblTotalIntereses.TabIndex = 10;
            this.lblTotalIntereses.Text = "Total Interes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(792, 510);
            this.Controls.Add(this.lblTotalIntereses);
            this.Controls.Add(this.lblTotalPagado);
            this.Controls.Add(this.lblCuotaMensual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTasaInteres);
            this.Controls.Add(this.txtPlazoMeses);
            this.Controls.Add(this.txtMontoPrestamo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcular;
        private Label label1;
        private TextBox txtMontoPrestamo;
        private TextBox txtPlazoMeses;
        private TextBox txtTasaInteres;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblCuotaMensual;
        private Label lblTotalPagado;
        private Label lblTotalIntereses;
    }
}