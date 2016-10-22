namespace TopicosExamen1
{
    partial class SolitaDatos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.btnAgrearU = new System.Windows.Forms.Button();
            this.btnCancelarU = new System.Windows.Forms.Button();
            this.NumCartones = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumCartones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cartones";
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(80, 64);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNomUsuario.TabIndex = 5;
            // 
            // btnAgrearU
            // 
            this.btnAgrearU.Location = new System.Drawing.Point(133, 131);
            this.btnAgrearU.Name = "btnAgrearU";
            this.btnAgrearU.Size = new System.Drawing.Size(75, 23);
            this.btnAgrearU.TabIndex = 8;
            this.btnAgrearU.Text = "Agregar";
            this.btnAgrearU.UseVisualStyleBackColor = true;
            this.btnAgrearU.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelarU
            // 
            this.btnCancelarU.Location = new System.Drawing.Point(271, 131);
            this.btnCancelarU.Name = "btnCancelarU";
            this.btnCancelarU.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarU.TabIndex = 9;
            this.btnCancelarU.Text = "Cancelar";
            this.btnCancelarU.UseVisualStyleBackColor = true;
            this.btnCancelarU.Click += new System.EventHandler(this.button2_Click);
            // 
            // NumCartones
            // 
            this.NumCartones.Location = new System.Drawing.Point(308, 65);
            this.NumCartones.Name = "NumCartones";
            this.NumCartones.Size = new System.Drawing.Size(100, 20);
            this.NumCartones.TabIndex = 10;
            this.NumCartones.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // SolitaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 189);
            this.Controls.Add(this.NumCartones);
            this.Controls.Add(this.btnCancelarU);
            this.Controls.Add(this.btnAgrearU);
            this.Controls.Add(this.txtNomUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SolitaDatos";
            this.Text = "SolitaDatos";
            ((System.ComponentModel.ISupportInitialize)(this.NumCartones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.Button btnAgrearU;
        private System.Windows.Forms.Button btnCancelarU;
        private System.Windows.Forms.NumericUpDown NumCartones;
    }
}