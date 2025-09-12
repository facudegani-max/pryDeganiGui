namespace pryDeganiGui
{
    partial class Botonera
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
            btnAtras = new Button();
            btnAdelante = new Button();
            lblNombres = new Label();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(152, 150);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "<";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnAdelante
            // 
            btnAdelante.Location = new Point(233, 150);
            btnAdelante.Name = "btnAdelante";
            btnAdelante.Size = new Size(75, 23);
            btnAdelante.TabIndex = 2;
            btnAdelante.Text = ">";
            btnAdelante.UseVisualStyleBackColor = true;
            btnAdelante.Click += btnAdelante_Click;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.BorderStyle = BorderStyle.FixedSingle;
            lblNombres.Location = new Point(173, 107);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(2, 17);
            lblNombres.TabIndex = 3;
            lblNombres.Click += lbl1_Click;
            // 
            // Botonera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(lblNombres);
            Controls.Add(btnAdelante);
            Controls.Add(btnAtras);
            Name = "Botonera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Botonera";
            Load += Botonera_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAtras;
        private Button btnAdelante;
        private Label lblNombres;
    }
}