namespace pryDeganiGui
{
    partial class GUI
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
            btnBotonera = new Button();
            lstbox1 = new ListBox();
            SuspendLayout();
            // 
            // btnBotonera
            // 
            btnBotonera.BackColor = Color.SpringGreen;
            btnBotonera.FlatStyle = FlatStyle.Popup;
            btnBotonera.Location = new Point(12, 12);
            btnBotonera.Name = "btnBotonera";
            btnBotonera.Size = new Size(460, 63);
            btnBotonera.TabIndex = 0;
            btnBotonera.Text = "Botonera";
            btnBotonera.UseVisualStyleBackColor = false;
            btnBotonera.Click += btnBotonera_Click;
            // 
            // lstbox1
            // 
            lstbox1.FormattingEnabled = true;
            lstbox1.ItemHeight = 15;
            lstbox1.Location = new Point(12, 81);
            lstbox1.Name = "lstbox1";
            lstbox1.Size = new Size(460, 94);
            lstbox1.TabIndex = 1;
            lstbox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // GUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(484, 461);
            Controls.Add(lstbox1);
            Controls.Add(btnBotonera);
            Name = "GUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de interfaz grafica";
            Load += GUI_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBotonera;
        private ListBox lstbox1;
    }
}
