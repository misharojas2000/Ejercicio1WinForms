namespace Ejercicio1WinForms
{
    partial class Ejercicio3
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
            Value1 = new Label();
            Value2 = new Label();
            Value1Txt = new TextBox();
            Value2Txt = new TextBox();
            label1 = new Label();
            OperationResultLbl = new Label();
            OperationSimbolLbl = new Label();
            SumaButton = new Button();
            RestarButton = new Button();
            multiplicarButton = new Button();
            DividirButton = new Button();
            SuspendLayout();
            // 
            // Value1
            // 
            Value1.AutoSize = true;
            Value1.Location = new Point(93, 78);
            Value1.Name = "Value1";
            Value1.Size = new Size(152, 20);
            Value1.TabIndex = 0;
            Value1.Text = "Primer valor a operar:";
            Value1.Click += label1_Click;
            // 
            // Value2
            // 
            Value2.AutoSize = true;
            Value2.Location = new Point(93, 125);
            Value2.Name = "Value2";
            Value2.Size = new Size(168, 20);
            Value2.TabIndex = 1;
            Value2.Text = "Segundo valor a operar:";
            // 
            // Value1Txt
            // 
            Value1Txt.Location = new Point(298, 78);
            Value1Txt.Name = "Value1Txt";
            Value1Txt.Size = new Size(125, 27);
            Value1Txt.TabIndex = 2;
            // 
            // Value2Txt
            // 
            Value2Txt.Location = new Point(298, 125);
            Value2Txt.Name = "Value2Txt";
            Value2Txt.Size = new Size(125, 27);
            Value2Txt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 155);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 4;
            label1.Text = "----------------------------";
            label1.Click += label1_Click_1;
            // 
            // OperationResultLbl
            // 
            OperationResultLbl.AutoSize = true;
            OperationResultLbl.Location = new Point(335, 175);
            OperationResultLbl.Name = "OperationResultLbl";
            OperationResultLbl.Size = new Size(49, 20);
            OperationResultLbl.TabIndex = 5;
            OperationResultLbl.Text = "          ";
            OperationResultLbl.Click += OperationResultLbl_Click;
            // 
            // OperationSimbolLbl
            // 
            OperationSimbolLbl.AutoSize = true;
            OperationSimbolLbl.Location = new Point(436, 136);
            OperationSimbolLbl.Name = "OperationSimbolLbl";
            OperationSimbolLbl.Size = new Size(41, 20);
            OperationSimbolLbl.TabIndex = 6;
            OperationSimbolLbl.Text = "        ";
            // 
            // SumaButton
            // 
            SumaButton.Location = new Point(584, 41);
            SumaButton.Name = "SumaButton";
            SumaButton.Size = new Size(94, 29);
            SumaButton.TabIndex = 7;
            SumaButton.Text = "Sumar";
            SumaButton.UseVisualStyleBackColor = true;
            SumaButton.Click += SumaButton_Click;
            // 
            // RestarButton
            // 
            RestarButton.Location = new Point(584, 96);
            RestarButton.Name = "RestarButton";
            RestarButton.Size = new Size(94, 29);
            RestarButton.TabIndex = 8;
            RestarButton.Text = "Restar";
            RestarButton.UseVisualStyleBackColor = true;
            RestarButton.Click += RestarButton_Click;
            // 
            // multiplicarButton
            // 
            multiplicarButton.Location = new Point(584, 151);
            multiplicarButton.Name = "multiplicarButton";
            multiplicarButton.Size = new Size(94, 29);
            multiplicarButton.TabIndex = 9;
            multiplicarButton.Text = "Multiplicar";
            multiplicarButton.UseVisualStyleBackColor = true;
            multiplicarButton.Click += multiplicarButton_Click;
            // 
            // DividirButton
            // 
            DividirButton.Location = new Point(584, 199);
            DividirButton.Name = "DividirButton";
            DividirButton.Size = new Size(94, 29);
            DividirButton.TabIndex = 10;
            DividirButton.Text = "Dividir";
            DividirButton.UseVisualStyleBackColor = true;
            DividirButton.Click += DividirButton_Click;
            // 
            // Ejercicio3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 278);
            Controls.Add(DividirButton);
            Controls.Add(multiplicarButton);
            Controls.Add(RestarButton);
            Controls.Add(SumaButton);
            Controls.Add(OperationSimbolLbl);
            Controls.Add(OperationResultLbl);
            Controls.Add(label1);
            Controls.Add(Value2Txt);
            Controls.Add(Value1Txt);
            Controls.Add(Value2);
            Controls.Add(Value1);
            Name = "Ejercicio3";
            Text = "Ejercicio3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Value1;
        private Label Value2;
        private TextBox Value1Txt;
        private TextBox Value2Txt;
        private Label label1;
        private Label OperationResultLbl;
        private Label OperationSimbolLbl;
        private Button SumaButton;
        private Button RestarButton;
        private Button multiplicarButton;
        private Button DividirButton;
    }
}