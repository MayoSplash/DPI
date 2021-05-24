
namespace DesignCalculator
{
    partial class Engineer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.режимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.обычныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инженерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.длинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.весToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.режимToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // режимToolStripMenuItem
            // 
            this.режимToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обычныйToolStripMenuItem,
            this.программистToolStripMenuItem,
            this.инженерToolStripMenuItem,
            this.объемToolStripMenuItem,
            this.длинаToolStripMenuItem,
            this.весToolStripMenuItem});
            this.режимToolStripMenuItem.Name = "режимToolStripMenuItem";
            this.режимToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.режимToolStripMenuItem.Text = "Режим";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(382, 525);
            this.splitContainer1.SplitterDistance = 80;
            this.splitContainer1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Century Schoolbook", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(382, 80);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // обычныйToolStripMenuItem
            // 
            this.обычныйToolStripMenuItem.Name = "обычныйToolStripMenuItem";
            this.обычныйToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.обычныйToolStripMenuItem.Text = "Обычный";
            // 
            // программистToolStripMenuItem
            // 
            this.программистToolStripMenuItem.Name = "программистToolStripMenuItem";
            this.программистToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.программистToolStripMenuItem.Text = "Программист";
            // 
            // инженерToolStripMenuItem
            // 
            this.инженерToolStripMenuItem.Name = "инженерToolStripMenuItem";
            this.инженерToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.инженерToolStripMenuItem.Text = "Инженер";
            // 
            // объемToolStripMenuItem
            // 
            this.объемToolStripMenuItem.Name = "объемToolStripMenuItem";
            this.объемToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.объемToolStripMenuItem.Text = "Объем";
            // 
            // длинаToolStripMenuItem
            // 
            this.длинаToolStripMenuItem.Name = "длинаToolStripMenuItem";
            this.длинаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.длинаToolStripMenuItem.Text = "Длина";
            // 
            // весToolStripMenuItem
            // 
            this.весToolStripMenuItem.Name = "весToolStripMenuItem";
            this.весToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.весToolStripMenuItem.Text = "Вес";
            // 
            // Common
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "Common";
            this.Text = "Калькулятор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem режимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem обычныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программистToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инженерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem объемToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem длинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem весToolStripMenuItem;
    }
}

