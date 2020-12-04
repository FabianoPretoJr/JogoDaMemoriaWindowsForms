namespace JogoDaMemoria
{
    partial class Form3
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Fabiano",
            "454"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lvlScore = new System.Windows.Forms.ListView();
            this.clhNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 62F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(346, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 95);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = global::JogoDaMemoria.Properties.Resources.left_arrow2;
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(91, 76);
            this.btnVoltar.TabIndex = 21;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lvlScore
            // 
            this.lvlScore.AllowColumnReorder = true;
            this.lvlScore.BackColor = System.Drawing.Color.Teal;
            this.lvlScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvlScore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhNome,
            this.clhScore});
            this.lvlScore.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlScore.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvlScore.HideSelection = false;
            this.lvlScore.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvlScore.Location = new System.Drawing.Point(197, 164);
            this.lvlScore.Name = "lvlScore";
            this.lvlScore.Size = new System.Drawing.Size(582, 97);
            this.lvlScore.TabIndex = 22;
            this.lvlScore.UseCompatibleStateImageBehavior = false;
            this.lvlScore.View = System.Windows.Forms.View.Details;
            // 
            // clhNome
            // 
            this.clhNome.Text = "Nome";
            this.clhNome.Width = 330;
            // 
            // clhScore
            // 
            this.clhScore.Text = "Score";
            this.clhScore.Width = 252;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogoDaMemoria.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(979, 602);
            this.Controls.Add(this.lvlScore);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Memória Dev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ListView lvlScore;
        public System.Windows.Forms.ColumnHeader clhNome;
        public System.Windows.Forms.ColumnHeader clhScore;
    }
}