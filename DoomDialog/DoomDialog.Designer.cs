namespace DoomDialog
{
    partial class DoomDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoomDialog));
            this.singlePlayerRadio = new System.Windows.Forms.RadioButton();
            this.multiplayerRadio = new System.Windows.Forms.RadioButton();
            this.snapmapRadio = new System.Windows.Forms.RadioButton();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // singlePlayerRadio
            // 
            this.singlePlayerRadio.AutoSize = true;
            this.singlePlayerRadio.Checked = true;
            this.singlePlayerRadio.Location = new System.Drawing.Point(12, 12);
            this.singlePlayerRadio.Name = "singlePlayerRadio";
            this.singlePlayerRadio.Size = new System.Drawing.Size(85, 17);
            this.singlePlayerRadio.TabIndex = 0;
            this.singlePlayerRadio.TabStop = true;
            this.singlePlayerRadio.Text = "Single player";
            this.singlePlayerRadio.UseVisualStyleBackColor = true;
            // 
            // multiplayerRadio
            // 
            this.multiplayerRadio.AutoSize = true;
            this.multiplayerRadio.Location = new System.Drawing.Point(12, 35);
            this.multiplayerRadio.Name = "multiplayerRadio";
            this.multiplayerRadio.Size = new System.Drawing.Size(75, 17);
            this.multiplayerRadio.TabIndex = 1;
            this.multiplayerRadio.Text = "Multiplayer";
            this.multiplayerRadio.UseVisualStyleBackColor = true;
            // 
            // snapmapRadio
            // 
            this.snapmapRadio.AutoSize = true;
            this.snapmapRadio.Location = new System.Drawing.Point(12, 58);
            this.snapmapRadio.Name = "snapmapRadio";
            this.snapmapRadio.Size = new System.Drawing.Size(70, 17);
            this.snapmapRadio.TabIndex = 2;
            this.snapmapRadio.Text = "Snapmap";
            this.snapmapRadio.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(147, 81);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(228, 81);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Launch";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // DoomDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 116);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.snapmapRadio);
            this.Controls.Add(this.multiplayerRadio);
            this.Controls.Add(this.singlePlayerRadio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoomDialog";
            this.Text = "Doom Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton singlePlayerRadio;
        private System.Windows.Forms.RadioButton multiplayerRadio;
        private System.Windows.Forms.RadioButton snapmapRadio;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}

