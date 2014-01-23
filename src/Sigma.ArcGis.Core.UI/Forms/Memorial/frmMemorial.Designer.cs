namespace Sigma.Arcgis.Core.UI.Forms.Memorial
{
    partial class frmMemorial
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
            this.lblFeature = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textDestino = new System.Windows.Forms.TextBox();
            this.textEntrada = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAbrirPasta = new System.Windows.Forms.Button();
            this.btnAbrirFeature = new System.Windows.Forms.Button();
            this.dialogDestino = new System.Windows.Forms.SaveFileDialog();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblFeature
            // 
            this.lblFeature.AutoSize = true;
            this.lblFeature.Location = new System.Drawing.Point(6, 122);
            this.lblFeature.Name = "lblFeature";
            this.lblFeature.Size = new System.Drawing.Size(0, 13);
            this.lblFeature.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Destino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Entrada:";
            // 
            // textDestino
            // 
            this.textDestino.Location = new System.Drawing.Point(9, 78);
            this.textDestino.Name = "textDestino";
            this.textDestino.ReadOnly = true;
            this.textDestino.Size = new System.Drawing.Size(335, 20);
            this.textDestino.TabIndex = 16;
            // 
            // textEntrada
            // 
            this.textEntrada.Location = new System.Drawing.Point(9, 28);
            this.textEntrada.Name = "textEntrada";
            this.textEntrada.ReadOnly = true;
            this.textEntrada.Size = new System.Drawing.Size(335, 20);
            this.textEntrada.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(76, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Ok";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAbrirPasta
            // 
            this.btnAbrirPasta.Location = new System.Drawing.Point(366, 78);
            this.btnAbrirPasta.Name = "btnAbrirPasta";
            this.btnAbrirPasta.Size = new System.Drawing.Size(52, 23);
            this.btnAbrirPasta.TabIndex = 12;
            this.btnAbrirPasta.Text = "Abrir";
            this.btnAbrirPasta.UseVisualStyleBackColor = true;
            this.btnAbrirPasta.Click += new System.EventHandler(this.btnAbrirPasta_Click);
            // 
            // btnAbrirFeature
            // 
            this.btnAbrirFeature.Location = new System.Drawing.Point(366, 28);
            this.btnAbrirFeature.Name = "btnAbrirFeature";
            this.btnAbrirFeature.Size = new System.Drawing.Size(52, 23);
            this.btnAbrirFeature.TabIndex = 11;
            this.btnAbrirFeature.Text = "Abrir";
            this.btnAbrirFeature.UseVisualStyleBackColor = true;
            this.btnAbrirFeature.Click += new System.EventHandler(this.btnAbrirFeature_Click);
            // 
            // frmMemorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 176);
            this.Controls.Add(this.lblFeature);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDestino);
            this.Controls.Add(this.textEntrada);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAbrirPasta);
            this.Controls.Add(this.btnAbrirFeature);
            this.Name = "frmMemorial";
            this.Text = "Memorial Descritivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFeature;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDestino;
        private System.Windows.Forms.TextBox textEntrada;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAbrirPasta;
        private System.Windows.Forms.Button btnAbrirFeature;
        private System.Windows.Forms.SaveFileDialog dialogDestino;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;

    }
}