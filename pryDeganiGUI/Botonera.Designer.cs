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
            btnAgregar = new Button();
            button2 = new Button();
            button3 = new Button();
            lbl1 = new Label();
            txtNombres = new TextBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(192, 138);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(139, 198);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(242, 198);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = ">";
            button3.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(171, 63);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(113, 15);
            lbl1.TabIndex = 3;
            lbl1.Text = "Ingrese los nombres";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(171, 92);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(113, 23);
            txtNombres.TabIndex = 4;
            // 
            // Botonera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(txtNombres);
            Controls.Add(lbl1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnAgregar);
            Name = "Botonera";
            Text = "Botonera";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button button2;
        private Button button3;
        private Label lbl1;
        private TextBox txtNombres;
    }
}