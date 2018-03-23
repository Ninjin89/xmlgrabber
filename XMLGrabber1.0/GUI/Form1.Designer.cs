namespace XMLGrabber1._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.getprod = new MetroFramework.Controls.MetroButton();
            this.getpackets = new MetroFramework.Controls.MetroButton();
            this.getobjectsandtiles = new MetroFramework.Controls.MetroButton();
            this.ProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tilesxml = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // tbConsole
            // 
            this.tbConsole.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbConsole.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConsole.Location = new System.Drawing.Point(180, 32);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.Size = new System.Drawing.Size(342, 87);
            this.tbConsole.TabIndex = 0;
            // 
            // getprod
            // 
            this.getprod.Highlight = true;
            this.getprod.Location = new System.Drawing.Point(6, 32);
            this.getprod.Name = "getprod";
            this.getprod.Size = new System.Drawing.Size(168, 25);
            this.getprod.TabIndex = 0;
            this.getprod.TabStop = false;
            this.getprod.Text = "Get Prod-Client";
            this.getprod.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.getprod.UseSelectable = true;
            this.getprod.Click += new System.EventHandler(this.getprod_Click_1);
            // 
            // getpackets
            // 
            this.getpackets.Highlight = true;
            this.getpackets.Location = new System.Drawing.Point(6, 64);
            this.getpackets.Name = "getpackets";
            this.getpackets.Size = new System.Drawing.Size(168, 25);
            this.getpackets.TabIndex = 0;
            this.getpackets.TabStop = false;
            this.getpackets.Text = "Get Packets XML";
            this.getpackets.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.getpackets.UseSelectable = true;
            this.getpackets.Click += new System.EventHandler(this.getpackets_Click_1);
            // 
            // getobjectsandtiles
            // 
            this.getobjectsandtiles.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.getobjectsandtiles.Highlight = true;
            this.getobjectsandtiles.Location = new System.Drawing.Point(6, 95);
            this.getobjectsandtiles.Name = "getobjectsandtiles";
            this.getobjectsandtiles.Size = new System.Drawing.Size(168, 25);
            this.getobjectsandtiles.TabIndex = 0;
            this.getobjectsandtiles.TabStop = false;
            this.getobjectsandtiles.Text = "Get Objects XML";
            this.getobjectsandtiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.getobjectsandtiles.UseSelectable = true;
            this.getobjectsandtiles.Click += new System.EventHandler(this.getobjectsandtiles_Click_1);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(180, 126);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(342, 25);
            this.ProgressBar.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProgressBar.TabIndex = 4;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(6, 167);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(131, 15);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Made by Ninjin @ MPGH";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Enabled = false;
            this.metroLabel2.Location = new System.Drawing.Point(6, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "XMLGrabber 1.1";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(469, 157);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(53, 25);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.TabStop = false;
            this.metroButton1.Text = "Exit";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tilesxml
            // 
            this.tilesxml.Highlight = true;
            this.tilesxml.Location = new System.Drawing.Point(6, 126);
            this.tilesxml.Name = "tilesxml";
            this.tilesxml.Size = new System.Drawing.Size(168, 25);
            this.tilesxml.TabIndex = 0;
            this.tilesxml.TabStop = false;
            this.tilesxml.Text = "Get Tiles XML";
            this.tilesxml.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tilesxml.UseSelectable = true;
            this.tilesxml.Click += new System.EventHandler(this.tilesxml_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(533, 194);
            this.ControlBox = false;
            this.Controls.Add(this.tilesxml);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.getobjectsandtiles);
            this.Controls.Add(this.getpackets);
            this.Controls.Add(this.getprod);
            this.Controls.Add(this.tbConsole);
            this.DisplayHeader = false;
            this.DoubleBuffered = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 32, 20, 22);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbConsole;
        private MetroFramework.Controls.MetroButton getprod;
        private MetroFramework.Controls.MetroButton getpackets;
        private MetroFramework.Controls.MetroButton getobjectsandtiles;
        private MetroFramework.Controls.MetroProgressBar ProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton tilesxml;
    }
}

