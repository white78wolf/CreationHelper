namespace CreationHelper
{
    partial class MainForm
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
            lblPerson = new Label();
            lblContext = new Label();
            txtPerson = new TextBox();
            SuspendLayout();
            // 
            // lblPerson
            // 
            lblPerson.AutoSize = true;
            lblPerson.Location = new Point(98, 51);
            lblPerson.Name = "lblPerson";
            lblPerson.Size = new Size(64, 15);
            lblPerson.TabIndex = 0;
            lblPerson.Text = "Персонаж";
            // 
            // lblContext
            // 
            lblContext.AutoSize = true;
            lblContext.Location = new Point(273, 57);
            lblContext.Name = "lblContext";
            lblContext.Size = new Size(56, 15);
            lblContext.TabIndex = 1;
            lblContext.Text = "Контекст";
            // 
            // txtPerson
            // 
            txtPerson.Location = new Point(81, 86);
            txtPerson.Multiline = true;
            txtPerson.Name = "txtPerson";
            txtPerson.Size = new Size(100, 147);
            txtPerson.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPerson);
            Controls.Add(lblContext);
            Controls.Add(lblPerson);
            Name = "MainForm";
            Text = "Генератор сюжетов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPerson;
        private Label lblContext;
        private TextBox txtPerson;
    }
}
