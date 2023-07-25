namespace SistemaClientes
{
    partial class FrmCartel
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
            btnNo = new Button();
            label1 = new Label();
            btnSi = new Button();
            SuspendLayout();
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.Gainsboro;
            btnNo.FlatAppearance.BorderColor = Color.Gainsboro;
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.ForeColor = Color.Black;
            btnNo.Location = new Point(228, 81);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(75, 23);
            btnNo.TabIndex = 1;
            btnNo.Text = "NO";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(80, 33);
            label1.Name = "label1";
            label1.Size = new Size(251, 26);
            label1.TabIndex = 2;
            label1.Text = "Seguro desea eliminar?";
            // 
            // btnSi
            // 
            btnSi.BackColor = Color.Gainsboro;
            btnSi.FlatAppearance.BorderColor = Color.Gainsboro;
            btnSi.FlatAppearance.MouseDownBackColor = Color.Red;
            btnSi.FlatAppearance.MouseOverBackColor = Color.Red;
            btnSi.FlatStyle = FlatStyle.Flat;
            btnSi.Location = new Point(111, 81);
            btnSi.Name = "btnSi";
            btnSi.Size = new Size(75, 23);
            btnSi.TabIndex = 0;
            btnSi.Text = "SI";
            btnSi.UseVisualStyleBackColor = false;
            btnSi.Click += btnSi_Click;
            // 
            // FrmCartel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 151);
            Controls.Add(label1);
            Controls.Add(btnNo);
            Controls.Add(btnSi);
            Name = "FrmCartel";
            Text = "FrmCartel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnNo;
        private Label label1;
        private Button btnSi;
    }
}