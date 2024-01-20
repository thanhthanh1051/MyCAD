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
            this.drawing = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pointBtn = new System.Windows.Forms.Button();
            this.lineBtn = new System.Windows.Forms.Button();
            this.circleBtn = new System.Windows.Forms.Button();
            this.ellipseBtn = new System.Windows.Forms.Button();
            this.circleBtn1 = new System.Windows.Forms.Button();
            this.arcBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawing)).BeginInit();
            this.SuspendLayout();
            // 
            // drawing
            // 
            this.drawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawing.BackColor = System.Drawing.SystemColors.ControlLight;
            this.drawing.ContextMenuStrip = this.menuStrip;
            this.drawing.Location = new System.Drawing.Point(0, 0);
            this.drawing.Name = "drawing";
            this.drawing.Size = new System.Drawing.Size(1074, 512);
            this.drawing.TabIndex = 0;
            this.drawing.TabStop = false;
            this.drawing.Paint += new System.Windows.Forms.PaintEventHandler(this.drawing_Paint);
            this.drawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawing_MouseDown);
            this.drawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawing_MouseMove);
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
            // pointBtn
            // 
            this.pointBtn.Location = new System.Drawing.Point(1108, 32);
            this.pointBtn.Name = "pointBtn";
            this.pointBtn.Size = new System.Drawing.Size(118, 32);
            this.pointBtn.TabIndex = 3;
            this.pointBtn.Text = "Point";
            this.pointBtn.UseVisualStyleBackColor = true;
            this.pointBtn.Click += new System.EventHandler(this.pointBtn_Click);
            // 
            // lineBtn
            // 
            this.lineBtn.Location = new System.Drawing.Point(1108, 92);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(117, 37);
            this.lineBtn.TabIndex = 4;
            this.lineBtn.Text = "Line";
            this.lineBtn.UseVisualStyleBackColor = true;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // circleBtn
            // 
            this.circleBtn.Location = new System.Drawing.Point(1108, 149);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(116, 39);
            this.circleBtn.TabIndex = 5;
            this.circleBtn.Text = "Circle";
            this.circleBtn.UseVisualStyleBackColor = true;
            this.circleBtn.Click += new System.EventHandler(this.circleBtn_Click);
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.Location = new System.Drawing.Point(1108, 210);
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(115, 37);
            this.ellipseBtn.TabIndex = 6;
            this.ellipseBtn.Text = "Ellipse";
            this.ellipseBtn.UseVisualStyleBackColor = true;
            this.ellipseBtn.Click += new System.EventHandler(this.ellipseBtn_Click);
            // 
            // circleBtn1
            // 
            this.circleBtn1.Location = new System.Drawing.Point(1098, 264);
            this.circleBtn1.Name = "circleBtn1";
            this.circleBtn1.Size = new System.Drawing.Size(137, 37);
            this.circleBtn1.TabIndex = 7;
            this.circleBtn1.Text = "Circle w 3p";
            this.circleBtn1.UseVisualStyleBackColor = true;
            this.circleBtn1.Click += new System.EventHandler(this.circleBtn1_Click);
            // 
            // arcBtn
            // 
            this.arcBtn.Location = new System.Drawing.Point(1098, 324);
            this.arcBtn.Name = "arcBtn";
            this.arcBtn.Size = new System.Drawing.Size(137, 38);
            this.arcBtn.TabIndex = 8;
            this.arcBtn.Text = "Arc";
            this.arcBtn.UseVisualStyleBackColor = true;
            this.arcBtn.Click += new System.EventHandler(this.arcBtn_Click);
            // 
            // GraphicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 627);
            this.Controls.Add(this.arcBtn);
            this.Controls.Add(this.circleBtn1);
            this.Controls.Add(this.ellipseBtn);
            this.Controls.Add(this.circleBtn);
            this.Controls.Add(this.lineBtn);
            this.Controls.Add(this.pointBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawing);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
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
        private System.Windows.Forms.Button pointBtn;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button circleBtn;
        private System.Windows.Forms.Button ellipseBtn;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
        private System.Windows.Forms.Button circleBtn1;
        private System.Windows.Forms.Button arcBtn;
    }
}

