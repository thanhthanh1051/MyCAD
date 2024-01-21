namespace MyCAD
{
    partial class GraphicsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicsForm));
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drawTab = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.drawPanel = new System.Windows.Forms.RibbonPanel();
            this.arcBtn = new System.Windows.Forms.RibbonButton();
            this.arcBtn11 = new System.Windows.Forms.RibbonButton();
            this.circleBtn = new System.Windows.Forms.RibbonButton();
            this.circleBtn21 = new System.Windows.Forms.RibbonButton();
            this.circleBtn22 = new System.Windows.Forms.RibbonButton();
            this.ellipseBtn = new System.Windows.Forms.RibbonButton();
            this.lineBtn = new System.Windows.Forms.RibbonButton();
            this.polelineBtn = new System.Windows.Forms.RibbonButton();
            this.polygonBtn = new System.Windows.Forms.RibbonButton();
            this.pointBtn = new System.Windows.Forms.RibbonButton();
            this.retangleBtn = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.drawing = new System.Windows.Forms.PictureBox();
            this.ellipseBtn31 = new System.Windows.Forms.RibbonButton();
            ((System.ComponentModel.ISupportInitialize)(this.drawing)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(61, 4);
            this.menuStrip.Text = "menuStrip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // drawTab
            // 
            this.drawTab.CaptionBarVisible = false;
            this.drawTab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.drawTab.Location = new System.Drawing.Point(0, 0);
            this.drawTab.Minimized = false;
            this.drawTab.Name = "drawTab";
            // 
            // 
            // 
            this.drawTab.OrbDropDown.BorderRoundness = 8;
            this.drawTab.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.drawTab.OrbDropDown.Name = "";
            this.drawTab.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.drawTab.OrbDropDown.TabIndex = 0;
            this.drawTab.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.drawTab.Size = new System.Drawing.Size(1258, 200);
            this.drawTab.TabIndex = 9;
            this.drawTab.Tabs.Add(this.ribbonTab1);
            this.drawTab.Text = "ribbon1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.drawPanel);
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Text = "ribbonTab1";
            // 
            // drawPanel
            // 
            this.drawPanel.ButtonMoreEnabled = false;
            this.drawPanel.ButtonMoreVisible = false;
            this.drawPanel.Image = global::MyCAD.Properties.Resources.Screenshot_2024_01_21_200029;
            this.drawPanel.Items.Add(this.arcBtn);
            this.drawPanel.Items.Add(this.circleBtn);
            this.drawPanel.Items.Add(this.ellipseBtn);
            this.drawPanel.Items.Add(this.lineBtn);
            this.drawPanel.Items.Add(this.polelineBtn);
            this.drawPanel.Items.Add(this.polygonBtn);
            this.drawPanel.Items.Add(this.pointBtn);
            this.drawPanel.Items.Add(this.retangleBtn);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Text = "";
            // 
            // arcBtn
            // 
            this.arcBtn.DropDownItems.Add(this.arcBtn11);
            this.arcBtn.Image = global::MyCAD.Properties.Resources.Screenshot_2024_01_21_202706;
            this.arcBtn.LargeImage = global::MyCAD.Properties.Resources.Screenshot_2024_01_21_202706;
            this.arcBtn.Name = "arcBtn";
            this.arcBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("arcBtn.SmallImage")));
            this.arcBtn.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.arcBtn.Text = "Arc";
            this.arcBtn.Click += new System.EventHandler(this.ArcBtn_Click);
            // 
            // arcBtn11
            // 
            this.arcBtn11.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.arcBtn11.Image = ((System.Drawing.Image)(resources.GetObject("arcBtn11.Image")));
            this.arcBtn11.LargeImage = ((System.Drawing.Image)(resources.GetObject("arcBtn11.LargeImage")));
            this.arcBtn11.Name = "arcBtn11";
            this.arcBtn11.SmallImage = ((System.Drawing.Image)(resources.GetObject("arcBtn11.SmallImage")));
            this.arcBtn11.Text = "3-Point";
            this.arcBtn11.Click += new System.EventHandler(this.ArcBtn_Click);
            // 
            // circleBtn
            // 
            this.circleBtn.DropDownItems.Add(this.circleBtn21);
            this.circleBtn.DropDownItems.Add(this.circleBtn22);
            this.circleBtn.Image = global::MyCAD.Properties.Resources.Screenshot_2024_01_21_200947;
            this.circleBtn.LargeImage = global::MyCAD.Properties.Resources.Screenshot_2024_01_21_200947;
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("circleBtn.SmallImage")));
            this.circleBtn.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.circleBtn.Text = "Cicrle";
            // 
            // circleBtn21
            // 
            this.circleBtn21.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.circleBtn21.Image = ((System.Drawing.Image)(resources.GetObject("circleBtn21.Image")));
            this.circleBtn21.LargeImage = ((System.Drawing.Image)(resources.GetObject("circleBtn21.LargeImage")));
            this.circleBtn21.Name = "circleBtn21";
            this.circleBtn21.SmallImage = ((System.Drawing.Image)(resources.GetObject("circleBtn21.SmallImage")));
            this.circleBtn21.Text = "Center,Radius";
            this.circleBtn21.Click += new System.EventHandler(this.CircleBtn_Click);
            // 
            // circleBtn22
            // 
            this.circleBtn22.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.circleBtn22.Image = ((System.Drawing.Image)(resources.GetObject("circleBtn22.Image")));
            this.circleBtn22.LargeImage = ((System.Drawing.Image)(resources.GetObject("circleBtn22.LargeImage")));
            this.circleBtn22.Name = "circleBtn22";
            this.circleBtn22.SmallImage = ((System.Drawing.Image)(resources.GetObject("circleBtn22.SmallImage")));
            this.circleBtn22.Text = "3-Points";
            this.circleBtn22.Click += new System.EventHandler(this.CircleBtn_Click);
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.DropDownItems.Add(this.ellipseBtn31);
            this.ellipseBtn.Image = global::MyCAD.Properties.Resources.Screenshot_2024_01_21_200947;
            this.ellipseBtn.LargeImage = global::MyCAD.Properties.Resources.Screenshot_2024_01_21_200947;
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("ellipseBtn.SmallImage")));
            this.ellipseBtn.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.ellipseBtn.Text = "Ellipse";
            // 
            // lineBtn
            // 
            this.lineBtn.Image = global::MyCAD.Properties.Resources.Screenshot_2024_01_21_201657;
            this.lineBtn.LargeImage = global::MyCAD.Properties.Resources.Screenshot_2024_01_21_201657;
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("lineBtn.SmallImage")));
            this.lineBtn.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.lineBtn.Text = "Line";
            // 
            // polelineBtn
            // 
            this.polelineBtn.Image = global::MyCAD.Properties.Resources.Screenshot_2024_01_21_201940;
            this.polelineBtn.LargeImage = global::MyCAD.Properties.Resources.Screenshot_2024_01_21_201940;
            this.polelineBtn.Name = "polelineBtn";
            this.polelineBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("polelineBtn.SmallImage")));
            this.polelineBtn.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.polelineBtn.Text = "Poly lne";
            // 
            // polygonBtn
            // 
            this.polygonBtn.Image = global::MyCAD.Properties.Resources.Screenshot_2024_01_21_202058;
            this.polygonBtn.LargeImage = global::MyCAD.Properties.Resources.Screenshot_2024_01_21_202058;
            this.polygonBtn.Name = "polygonBtn";
            this.polygonBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("polygonBtn.SmallImage")));
            this.polygonBtn.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.polygonBtn.Text = "Polygon";
            // 
            // pointBtn
            // 
            this.pointBtn.Image = global::MyCAD.Properties.Resources.Screenshot_2024_01_21_202333;
            this.pointBtn.LargeImage = global::MyCAD.Properties.Resources.Screenshot_2024_01_21_202333;
            this.pointBtn.Name = "pointBtn";
            this.pointBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("pointBtn.SmallImage")));
            this.pointBtn.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.pointBtn.Text = "Point";
            // 
            // retangleBtn
            // 
            this.retangleBtn.Image = global::MyCAD.Properties.Resources.Screenshot_2024_01_21_202444;
            this.retangleBtn.LargeImage = global::MyCAD.Properties.Resources.Screenshot_2024_01_21_202444;
            this.retangleBtn.Name = "retangleBtn";
            this.retangleBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("retangleBtn.SmallImage")));
            this.retangleBtn.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.retangleBtn.Text = "Retangle";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "ribbonPanel1";
            // 
            // drawing
            // 
            this.drawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawing.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawing.ContextMenuStrip = this.menuStrip;
            this.drawing.Location = new System.Drawing.Point(0, 242);
            this.drawing.Name = "drawing";
            this.drawing.Size = new System.Drawing.Size(1075, 298);
            this.drawing.TabIndex = 0;
            this.drawing.TabStop = false;
            this.drawing.Paint += new System.Windows.Forms.PaintEventHandler(this.drawing_Paint);
            this.drawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawing_MouseDown);
            this.drawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawing_MouseMove);
            // 
            // ellipseBtn31
            // 
            this.ellipseBtn31.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ellipseBtn31.Image = ((System.Drawing.Image)(resources.GetObject("ellipseBtn31.Image")));
            this.ellipseBtn31.LargeImage = ((System.Drawing.Image)(resources.GetObject("ellipseBtn31.LargeImage")));
            this.ellipseBtn31.Name = "ellipseBtn31";
            this.ellipseBtn31.SmallImage = ((System.Drawing.Image)(resources.GetObject("ellipseBtn31.SmallImage")));
            this.ellipseBtn31.Text = "Full Ellipse";
            this.ellipseBtn31.Click += new System.EventHandler(this.EllipseBtn_Click);
            // 
            // GraphicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 655);
            this.Controls.Add(this.drawTab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawing);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GraphicsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GraphicsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Ribbon drawTab;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel drawPanel;
        private System.Windows.Forms.RibbonButton arcBtn;
        private System.Windows.Forms.RibbonButton arcBtn11;
        private System.Windows.Forms.RibbonButton circleBtn;
        private System.Windows.Forms.RibbonButton circleBtn21;
        private System.Windows.Forms.RibbonButton circleBtn22;
        private System.Windows.Forms.RibbonButton ellipseBtn;
        private System.Windows.Forms.RibbonButton lineBtn;
        private System.Windows.Forms.RibbonButton polelineBtn;
        private System.Windows.Forms.RibbonButton polygonBtn;
        private System.Windows.Forms.RibbonButton pointBtn;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton retangleBtn;
        private System.Windows.Forms.RibbonButton ellipseBtn31;
    }
}

