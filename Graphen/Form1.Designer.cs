namespace Graphen
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.X = new System.Windows.Forms.ToolStripButton();
            this.Square = new System.Windows.Forms.ToolStripButton();
            this.Sin = new System.Windows.Forms.ToolStripButton();
            this.Cos = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 554);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.X,
            this.Square,
            this.Sin,
            this.Cos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1067, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // X
            // 
            this.X.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.X.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.X.Image = ((System.Drawing.Image)(resources.GetObject("X.Image")));
            this.X.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(29, 24);
            this.X.Text = "X";
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // Square
            // 
            this.Square.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Square.Image = ((System.Drawing.Image)(resources.GetObject("Square.Image")));
            this.Square.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(40, 24);
            this.Square.Text = "X^2";
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Sin
            // 
            this.Sin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Sin.Image = ((System.Drawing.Image)(resources.GetObject("Sin.Image")));
            this.Sin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(33, 24);
            this.Sin.Text = "Sin";
            this.Sin.Click += new System.EventHandler(this.Sin_Click);
            // 
            // Cos
            // 
            this.Cos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Cos.Image = ((System.Drawing.Image)(resources.GetObject("Cos.Image")));
            this.Cos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(37, 24);
            this.Cos.Text = "Cos";
            this.Cos.Click += new System.EventHandler(this.Cos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 587);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton X;
        private System.Windows.Forms.ToolStripButton Square;
        private System.Windows.Forms.ToolStripButton Sin;
        private System.Windows.Forms.ToolStripButton Cos;
    }
}

