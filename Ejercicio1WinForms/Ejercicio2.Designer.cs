namespace Ejercicio1WinForms
{
    partial class Ejercicio2
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
            DatoIngresadoTxt = new TextBox();
            ConversionType = new ComboBox();
            ResultLbl = new Label();
            Title1 = new Label();
            GradesLbl = new Label();
            SuspendLayout();
            // 
            // DatoIngresadoTxt
            // 
            DatoIngresadoTxt.ForeColor = Color.MidnightBlue;
            DatoIngresadoTxt.Location = new Point(195, 46);
            DatoIngresadoTxt.Name = "DatoIngresadoTxt";
            DatoIngresadoTxt.Size = new Size(92, 27);
            DatoIngresadoTxt.TabIndex = 0;
            DatoIngresadoTxt.TextChanged += DatoIngresadoTxt_TextChanged;
            // 
            // ConversionType
            // 
            ConversionType.FormattingEnabled = true;
            ConversionType.Items.AddRange(new object[] { "Celsius a Fahrenheit", "Fahrenheit a Celsius" });
            ConversionType.Location = new Point(326, 46);
            ConversionType.Name = "ConversionType";
            ConversionType.Size = new Size(170, 28);
            ConversionType.TabIndex = 1;
            ConversionType.Text = "Tipo de conversión";
            ConversionType.SelectedIndexChanged += ConversionType_SelectedIndexChanged;
            // 
            // ResultLbl
            // 
            ResultLbl.AutoSize = true;
            ResultLbl.ForeColor = SystemColors.ActiveCaptionText;
            ResultLbl.Location = new Point(263, 124);
            ResultLbl.Name = "ResultLbl";
            ResultLbl.Size = new Size(33, 20);
            ResultLbl.TabIndex = 2;
            ResultLbl.Text = "      ";
            ResultLbl.Click += label1_Click;
            // 
            // Title1
            // 
            Title1.AutoSize = true;
            Title1.Location = new Point(151, 124);
            Title1.Name = "Title1";
            Title1.Size = new Size(78, 20);
            Title1.TabIndex = 3;
            Title1.Text = "Resultado:";
            // 
            // GradesLbl
            // 
            GradesLbl.AutoSize = true;
            GradesLbl.Location = new Point(36, 46);
            GradesLbl.Name = "GradesLbl";
            GradesLbl.Size = new Size(133, 20);
            GradesLbl.TabIndex = 4;
            GradesLbl.Text = "Ingresa los grados:";
            // 
            // Ejercicio2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 250);
            Controls.Add(GradesLbl);
            Controls.Add(Title1);
            Controls.Add(ResultLbl);
            Controls.Add(ConversionType);
            Controls.Add(DatoIngresadoTxt);
            Name = "Ejercicio2";
            Text = "Ejercicio2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DatoIngresadoTxt;
        private ComboBox ConversionType;
        private Label ResultLbl;
        private Label Title1;
        private Label GradesLbl;
    }
}