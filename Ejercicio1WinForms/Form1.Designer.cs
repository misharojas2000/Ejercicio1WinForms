namespace Ejercicio1WinForms
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
            HelloWorlLbl = new Label();
            GreetButton = new Button();
            SuspendLayout();
            // 
            // HelloWorlLbl
            // 
            HelloWorlLbl.AutoSize = true;
            HelloWorlLbl.Font = new Font("Segoe UI", 30F);
            HelloWorlLbl.Location = new Point(200, 72);
            HelloWorlLbl.Name = "HelloWorlLbl";
            HelloWorlLbl.Size = new Size(304, 67);
            HelloWorlLbl.TabIndex = 0;
            HelloWorlLbl.Text = "Hola Mundo";
            HelloWorlLbl.Click += label1_Click;
            // 
            // GreetButton
            // 
            GreetButton.Location = new Point(229, 191);
            GreetButton.Name = "GreetButton";
            GreetButton.Size = new Size(203, 29);
            GreetButton.TabIndex = 2;
            GreetButton.Text = "Mejorar Saludo";
            GreetButton.UseVisualStyleBackColor = true;
            GreetButton.Click += GreetButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 344);
            Controls.Add(GreetButton);
            Controls.Add(HelloWorlLbl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HelloWorlLbl;
        private Button GreetButton;
    }
}
