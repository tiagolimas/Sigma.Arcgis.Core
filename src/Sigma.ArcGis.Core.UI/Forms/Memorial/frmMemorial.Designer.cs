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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemorial));
            this.lblFeature = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textDestino = new System.Windows.Forms.TextBox();
            this.textEntrada = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Destino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
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
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(76, 149);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(61, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(9, 149);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(61, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Fechar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAbrirPasta);
            this.Controls.Add(this.btnAbrirFeature);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAbrirPasta;
        private System.Windows.Forms.Button btnAbrirFeature;
        private System.Windows.Forms.SaveFileDialog dialogDestino;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;

    }
}