﻿
namespace PaintApplication
{
    partial class PaintApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintApplication));
            this.topMenuBar = new System.Windows.Forms.MenuStrip();
            this.fileTopMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newTopMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTopMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTopMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.informationTopMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProgramTopMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolBar = new System.Windows.Forms.Panel();
            this.pencilButton = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            this.redoPaint = new System.Windows.Forms.Button();
            this.undoPaint = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.elipseButton = new System.Windows.Forms.Button();
            this.fillColorButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.selectAreaButton = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.Panel();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.topMenuBar.SuspendLayout();
            this.leftToolBar.SuspendLayout();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // topMenuBar
            // 
            this.topMenuBar.BackColor = System.Drawing.Color.White;
            this.topMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTopMenu});
            this.topMenuBar.Location = new System.Drawing.Point(0, 0);
            this.topMenuBar.Name = "topMenuBar";
            this.topMenuBar.Size = new System.Drawing.Size(864, 24);
            this.topMenuBar.TabIndex = 0;
            this.topMenuBar.Text = "menuStrip1";
            this.topMenuBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.topMenuBar.Click += new System.EventHandler(this.topMenuBar_Click);
            // 
            // fileTopMenu
            // 
            this.fileTopMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTopMenu,
            this.loadTopMenu,
            this.saveTopMenu,
            this.informationTopMenu,
            this.closeProgramTopMenu});
            this.fileTopMenu.Name = "fileTopMenu";
            this.fileTopMenu.Size = new System.Drawing.Size(61, 20);
            this.fileTopMenu.Text = "Bestand";
            // 
            // newTopMenu
            // 
            this.newTopMenu.Name = "newTopMenu";
            this.newTopMenu.Size = new System.Drawing.Size(180, 22);
            this.newTopMenu.Text = "Nieuw...";
            this.newTopMenu.Click += new System.EventHandler(this.newTopMenu_Click);
            // 
            // loadTopMenu
            // 
            this.loadTopMenu.Name = "loadTopMenu";
            this.loadTopMenu.Size = new System.Drawing.Size(180, 22);
            this.loadTopMenu.Text = "Openen...";
            this.loadTopMenu.Click += new System.EventHandler(this.loadFileTopMenuItem_Click);
            // 
            // saveTopMenu
            // 
            this.saveTopMenu.Name = "saveTopMenu";
            this.saveTopMenu.Size = new System.Drawing.Size(180, 22);
            this.saveTopMenu.Text = "Opslaan";
            this.saveTopMenu.Click += new System.EventHandler(this.saveTopMenu_Click);
            // 
            // informationTopMenu
            // 
            this.informationTopMenu.Name = "informationTopMenu";
            this.informationTopMenu.Size = new System.Drawing.Size(180, 22);
            this.informationTopMenu.Text = "Informatie";
            this.informationTopMenu.Click += new System.EventHandler(this.informationTopMenuItem_Click);
            // 
            // closeProgramTopMenu
            // 
            this.closeProgramTopMenu.Name = "closeProgramTopMenu";
            this.closeProgramTopMenu.Size = new System.Drawing.Size(180, 22);
            this.closeProgramTopMenu.Text = "Afsluiten";
            this.closeProgramTopMenu.Click += new System.EventHandler(this.exitProgramTopMenuItem_Click);
            // 
            // leftToolBar
            // 
            this.leftToolBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.leftToolBar.AutoSize = true;
            this.leftToolBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.leftToolBar.Controls.Add(this.pencilButton);
            this.leftToolBar.Controls.Add(this.eraseButton);
            this.leftToolBar.Controls.Add(this.redoPaint);
            this.leftToolBar.Controls.Add(this.undoPaint);
            this.leftToolBar.Controls.Add(this.squareButton);
            this.leftToolBar.Controls.Add(this.triangleButton);
            this.leftToolBar.Controls.Add(this.lineButton);
            this.leftToolBar.Controls.Add(this.elipseButton);
            this.leftToolBar.Controls.Add(this.fillColorButton);
            this.leftToolBar.Controls.Add(this.selectButton);
            this.leftToolBar.Controls.Add(this.selectAreaButton);
            this.leftToolBar.ForeColor = System.Drawing.Color.Transparent;
            this.leftToolBar.Location = new System.Drawing.Point(-4, 25);
            this.leftToolBar.Name = "leftToolBar";
            this.leftToolBar.Size = new System.Drawing.Size(102, 484);
            this.leftToolBar.TabIndex = 1;
            // 
            // pencilButton
            // 
            this.pencilButton.AccessibleName = "erase";
            this.pencilButton.BackColor = System.Drawing.Color.Transparent;
            this.pencilButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pencilButton.BackgroundImage")));
            this.pencilButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pencilButton.Location = new System.Drawing.Point(13, 47);
            this.pencilButton.Name = "pencilButton";
            this.pencilButton.Size = new System.Drawing.Size(35, 35);
            this.pencilButton.TabIndex = 11;
            this.pencilButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pencilButton.UseVisualStyleBackColor = false;
            this.pencilButton.Click += new System.EventHandler(this.pencilButton_click);
            // 
            // eraseButton
            // 
            this.eraseButton.AccessibleName = "erase";
            this.eraseButton.BackColor = System.Drawing.Color.Transparent;
            this.eraseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eraseButton.BackgroundImage")));
            this.eraseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eraseButton.Location = new System.Drawing.Point(13, 170);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(35, 35);
            this.eraseButton.TabIndex = 10;
            this.eraseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.eraseButton.UseVisualStyleBackColor = false;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // redoPaint
            // 
            this.redoPaint.BackColor = System.Drawing.Color.Transparent;
            this.redoPaint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redoPaint.BackgroundImage")));
            this.redoPaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redoPaint.Location = new System.Drawing.Point(54, 349);
            this.redoPaint.Name = "redoPaint";
            this.redoPaint.Size = new System.Drawing.Size(35, 35);
            this.redoPaint.TabIndex = 9;
            this.redoPaint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.redoPaint.UseVisualStyleBackColor = false;
            this.redoPaint.Click += new System.EventHandler(this.redoPaint_Click);
            // 
            // undoPaint
            // 
            this.undoPaint.BackColor = System.Drawing.Color.Transparent;
            this.undoPaint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("undoPaint.BackgroundImage")));
            this.undoPaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.undoPaint.Location = new System.Drawing.Point(13, 349);
            this.undoPaint.Name = "undoPaint";
            this.undoPaint.Size = new System.Drawing.Size(35, 35);
            this.undoPaint.TabIndex = 8;
            this.undoPaint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.undoPaint.UseVisualStyleBackColor = false;
            this.undoPaint.Click += new System.EventHandler(this.undoPaint_Click);
            // 
            // squareButton
            // 
            this.squareButton.BackColor = System.Drawing.Color.Transparent;
            this.squareButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("squareButton.BackgroundImage")));
            this.squareButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.squareButton.Location = new System.Drawing.Point(57, 129);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(35, 35);
            this.squareButton.TabIndex = 7;
            this.squareButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.squareButton.UseVisualStyleBackColor = false;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.BackColor = System.Drawing.Color.Transparent;
            this.triangleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("triangleButton.BackgroundImage")));
            this.triangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.triangleButton.Location = new System.Drawing.Point(13, 129);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(35, 35);
            this.triangleButton.TabIndex = 6;
            this.triangleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.triangleButton.UseVisualStyleBackColor = false;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.BackColor = System.Drawing.Color.Transparent;
            this.lineButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lineButton.BackgroundImage")));
            this.lineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lineButton.Location = new System.Drawing.Point(57, 88);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(35, 35);
            this.lineButton.TabIndex = 5;
            this.lineButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.lineButton.UseVisualStyleBackColor = false;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // elipseButton
            // 
            this.elipseButton.BackColor = System.Drawing.Color.Transparent;
            this.elipseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("elipseButton.BackgroundImage")));
            this.elipseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.elipseButton.Location = new System.Drawing.Point(13, 88);
            this.elipseButton.Name = "elipseButton";
            this.elipseButton.Size = new System.Drawing.Size(35, 35);
            this.elipseButton.TabIndex = 4;
            this.elipseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.elipseButton.UseVisualStyleBackColor = false;
            this.elipseButton.Click += new System.EventHandler(this.elipseButton_Click);
            // 
            // fillColorButton
            // 
            this.fillColorButton.BackColor = System.Drawing.Color.Transparent;
            this.fillColorButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fillColorButton.BackgroundImage")));
            this.fillColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fillColorButton.Location = new System.Drawing.Point(57, 47);
            this.fillColorButton.Name = "fillColorButton";
            this.fillColorButton.Size = new System.Drawing.Size(35, 35);
            this.fillColorButton.TabIndex = 2;
            this.fillColorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.fillColorButton.UseVisualStyleBackColor = false;
            // 
            // selectButton
            // 
            this.selectButton.AccessibleName = "select";
            this.selectButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectButton.BackgroundImage")));
            this.selectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectButton.Location = new System.Drawing.Point(57, 6);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(35, 35);
            this.selectButton.TabIndex = 1;
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // selectAreaButton
            // 
            this.selectAreaButton.AccessibleName = "selectArea";
            this.selectAreaButton.BackColor = System.Drawing.Color.Transparent;
            this.selectAreaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectAreaButton.BackgroundImage")));
            this.selectAreaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectAreaButton.Location = new System.Drawing.Point(13, 6);
            this.selectAreaButton.Name = "selectAreaButton";
            this.selectAreaButton.Size = new System.Drawing.Size(35, 35);
            this.selectAreaButton.TabIndex = 0;
            this.selectAreaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.selectAreaButton.UseVisualStyleBackColor = false;
            // 
            // background
            // 
            this.background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background.AutoSize = true;
            this.background.BackColor = System.Drawing.Color.White;
            this.background.Controls.Add(this.canvas);
            this.background.ForeColor = System.Drawing.Color.Coral;
            this.background.Location = new System.Drawing.Point(98, 25);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(766, 484);
            this.background.TabIndex = 2;
            // 
            // canvas
            // 
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(766, 484);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_Click);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // PaintApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.background);
            this.Controls.Add(this.leftToolBar);
            this.Controls.Add(this.topMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.topMenuBar;
            this.Name = "PaintApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaintApplication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topMenuBar.ResumeLayout(false);
            this.topMenuBar.PerformLayout();
            this.leftToolBar.ResumeLayout(false);
            this.background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenuBar;
        private System.Windows.Forms.ToolStripMenuItem fileTopMenu;
        private System.Windows.Forms.ToolStripMenuItem newTopMenu;
        private System.Windows.Forms.ToolStripMenuItem saveTopMenu;
        private System.Windows.Forms.ToolStripMenuItem loadTopMenu;
        private System.Windows.Forms.ToolStripMenuItem closeProgramTopMenu;
        private System.Windows.Forms.ToolStripMenuItem informationTopMenu;
        private System.Windows.Forms.Panel leftToolBar;
        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Button selectAreaButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button redoPaint;
        private System.Windows.Forms.Button undoPaint;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button elipseButton;
        private System.Windows.Forms.Button fillColorButton;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button pencilButton;
        private System.Windows.Forms.Button eraseButton;
    }
}

