namespace LeftClick_Modifier
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
            this.main = new dll.ThirteenForm();
            this.thirteenControlBox1 = new dll.ThirteenControlBox();
            this.thirteenButton1 = new dll.ThirteenButton();
            this.thirteenButton2 = new dll.ThirteenButton();
            this.thirteenButton3 = new dll.ThirteenButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.AccentColor = System.Drawing.Color.SeaGreen;
            this.main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.main.ColorScheme = dll.ThirteenForm.ColorSchemes.Dark;
            this.main.Controls.Add(this.treeView1);
            this.main.Controls.Add(this.thirteenButton3);
            this.main.Controls.Add(this.thirteenButton2);
            this.main.Controls.Add(this.thirteenButton1);
            this.main.Controls.Add(this.thirteenControlBox1);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.main.ForeColor = System.Drawing.Color.White;
            this.main.Location = new System.Drawing.Point(0, 0);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(500, 298);
            this.main.TabIndex = 0;
            this.main.Text = "LeftClick Modifier";
            // 
            // thirteenControlBox1
            // 
            this.thirteenControlBox1.AccentColor = System.Drawing.Color.SeaGreen;
            this.thirteenControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.thirteenControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenControlBox1.ColorScheme = dll.ThirteenControlBox.ColorSchemes.Dark;
            this.thirteenControlBox1.ForeColor = System.Drawing.Color.White;
            this.thirteenControlBox1.Location = new System.Drawing.Point(400, 4);
            this.thirteenControlBox1.Name = "thirteenControlBox1";
            this.thirteenControlBox1.Size = new System.Drawing.Size(100, 25);
            this.thirteenControlBox1.TabIndex = 0;
            this.thirteenControlBox1.Text = "thirteenControlBox1";
            // 
            // thirteenButton1
            // 
            this.thirteenButton1.AccentColor = System.Drawing.Color.SeaGreen;
            this.thirteenButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenButton1.ColorScheme = dll.ThirteenButton.ColorSchemes.Dark;
            this.thirteenButton1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.thirteenButton1.ForeColor = System.Drawing.Color.White;
            this.thirteenButton1.Location = new System.Drawing.Point(12, 49);
            this.thirteenButton1.Name = "thirteenButton1";
            this.thirteenButton1.Size = new System.Drawing.Size(116, 23);
            this.thirteenButton1.TabIndex = 1;
            this.thirteenButton1.Text = "...";
            this.thirteenButton1.UseVisualStyleBackColor = false;
            this.thirteenButton1.Click += new System.EventHandler(this.thirteenButton1_Click);
            // 
            // thirteenButton2
            // 
            this.thirteenButton2.AccentColor = System.Drawing.Color.SeaGreen;
            this.thirteenButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenButton2.ColorScheme = dll.ThirteenButton.ColorSchemes.Dark;
            this.thirteenButton2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.thirteenButton2.ForeColor = System.Drawing.Color.White;
            this.thirteenButton2.Location = new System.Drawing.Point(12, 90);
            this.thirteenButton2.Name = "thirteenButton2";
            this.thirteenButton2.Size = new System.Drawing.Size(116, 23);
            this.thirteenButton2.TabIndex = 2;
            this.thirteenButton2.Text = "Ajouter";
            this.thirteenButton2.UseVisualStyleBackColor = false;
            this.thirteenButton2.Click += new System.EventHandler(this.thirteenButton2_Click);
            // 
            // thirteenButton3
            // 
            this.thirteenButton3.AccentColor = System.Drawing.Color.SeaGreen;
            this.thirteenButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenButton3.ColorScheme = dll.ThirteenButton.ColorSchemes.Dark;
            this.thirteenButton3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.thirteenButton3.ForeColor = System.Drawing.Color.White;
            this.thirteenButton3.Location = new System.Drawing.Point(134, 49);
            this.thirteenButton3.Name = "thirteenButton3";
            this.thirteenButton3.Size = new System.Drawing.Size(354, 23);
            this.thirteenButton3.TabIndex = 3;
            this.thirteenButton3.Text = "Actualiser";
            this.thirteenButton3.UseVisualStyleBackColor = false;
            this.thirteenButton3.Click += new System.EventHandler(this.thirteenButton3_Click);
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Location = new System.Drawing.Point(134, 78);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(354, 208);
            this.treeView1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 26);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 298);
            this.Controls.Add(this.main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.main.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private dll.ThirteenForm main;
        private dll.ThirteenButton thirteenButton1;
        private dll.ThirteenControlBox thirteenControlBox1;
        private System.Windows.Forms.TreeView treeView1;
        private dll.ThirteenButton thirteenButton3;
        private dll.ThirteenButton thirteenButton2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}

