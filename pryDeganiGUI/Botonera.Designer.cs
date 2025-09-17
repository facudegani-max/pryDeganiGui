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
            btnUltimo = new Button();
            btnPrimero = new Button();
            lblBienvenido = new Label();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.SpringGreen;
            btnAtras.FlatStyle = FlatStyle.Popup;
            btnAtras.Location = new Point(152, 150);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "< Anterior";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnAdelante
            // 
            btnAdelante.BackColor = Color.SpringGreen;
            btnAdelante.FlatStyle = FlatStyle.Popup;
            btnAdelante.Location = new Point(233, 150);
            btnAdelante.Name = "btnAdelante";
            btnAdelante.Size = new Size(75, 23);
            btnAdelante.TabIndex = 2;
            btnAdelante.Text = "Siguiente >";
            btnAdelante.UseVisualStyleBackColor = false;
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
            // btnUltimo
            // 
            btnUltimo.BackColor = Color.SpringGreen;
            btnUltimo.FlatStyle = FlatStyle.Popup;
            btnUltimo.Location = new Point(314, 150);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(75, 23);
            btnUltimo.TabIndex = 4;
            btnUltimo.Text = "Ultimo";
            btnUltimo.UseVisualStyleBackColor = false;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.BackColor = Color.SpringGreen;
            btnPrimero.FlatStyle = FlatStyle.Popup;
            btnPrimero.Location = new Point(71, 150);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(75, 23);
            btnPrimero.TabIndex = 5;
            btnPrimero.Text = "Primero";
            btnPrimero.UseVisualStyleBackColor = false;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.BackColor = Color.Yellow;
            lblBienvenido.BorderStyle = BorderStyle.Fixed3D;
            lblBienvenido.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenido.Location = new Point(173, 54);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(114, 27);
            lblBienvenido.TabIndex = 6;
            lblBienvenido.Text = "Bienvenido";
            lblBienvenido.Click += lblBienvenido_Click;
            // 
            // Botonera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(484, 461);
            Controls.Add(lblBienvenido);
            Controls.Add(btnPrimero);
            Controls.Add(btnUltimo);
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
        private Button btnUltimo;
        private Button btnPrimero;
        private Label lblBienvenido;
    }
}