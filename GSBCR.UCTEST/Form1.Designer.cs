namespace GSBCR.UCTEST
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_medoc = new System.Windows.Forms.ComboBox();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.ucMedicament1 = new GSBCR.UC.UcMedicament();
            this.bsMedoc = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsMedoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultation medicament";
            // 
            // cbx_medoc
            // 
            this.cbx_medoc.FormattingEnabled = true;
            this.cbx_medoc.Location = new System.Drawing.Point(104, 76);
            this.cbx_medoc.Name = "cbx_medoc";
            this.cbx_medoc.Size = new System.Drawing.Size(150, 21);
            this.cbx_medoc.TabIndex = 1;
            this.cbx_medoc.SelectedIndexChanged += new System.EventHandler(this.cbx_medoc_SelectedIndexChanged);
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(354, 67);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(109, 37);
            this.btn_quitter.TabIndex = 2;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            // 
            // ucMedicament1
            // 
            this.ucMedicament1.LeMedicament = null;
            this.ucMedicament1.Location = new System.Drawing.Point(36, 110);
            this.ucMedicament1.Name = "ucMedicament1";
            this.ucMedicament1.Size = new System.Drawing.Size(509, 527);
            this.ucMedicament1.TabIndex = 3;
            // 
            // bsMedoc
            // 
            this.bsMedoc.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 647);
            this.Controls.Add(this.ucMedicament1);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.cbx_medoc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMedoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_medoc;
        private System.Windows.Forms.Button btn_quitter;
        private UC.UcMedicament ucMedicament1;
        private System.Windows.Forms.BindingSource bsMedoc;
    }
}

