namespace Calculate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.математическиеДействияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьИсходныеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьРезультатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.value1 = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.Label();
            this.value2 = new System.Windows.Forms.TextBox();
            this.txtOperat = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.математическиеДействияToolStripMenuItem,
            this.редактированиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // математическиеДействияToolStripMenuItem
            // 
            this.математическиеДействияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.математическиеДействияToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.математическиеДействияToolStripMenuItem.Name = "математическиеДействияToolStripMenuItem";
            this.математическиеДействияToolStripMenuItem.Size = new System.Drawing.Size(166, 20);
            this.математическиеДействияToolStripMenuItem.Text = "Математические действия";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 24);
            this.toolStripMenuItem2.Text = "+";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuPlus_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 24);
            this.toolStripMenuItem3.Text = "-";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuMinus_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(86, 24);
            this.toolStripMenuItem4.Text = "*";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuMultiply_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(86, 24);
            this.toolStripMenuItem5.Text = "/";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuDivision_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьИсходныеДанныеToolStripMenuItem,
            this.очиститьРезультатToolStripMenuItem,
            this.очиститьВсеToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // очиститьИсходныеДанныеToolStripMenuItem
            // 
            this.очиститьИсходныеДанныеToolStripMenuItem.Name = "очиститьИсходныеДанныеToolStripMenuItem";
            this.очиститьИсходныеДанныеToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.очиститьИсходныеДанныеToolStripMenuItem.Text = "Очистить исходные данные";
            this.очиститьИсходныеДанныеToolStripMenuItem.Click += new System.EventHandler(this.очиститьИсходныеДанныеToolStripMenuItem_Click);
            // 
            // очиститьРезультатToolStripMenuItem
            // 
            this.очиститьРезультатToolStripMenuItem.Name = "очиститьРезультатToolStripMenuItem";
            this.очиститьРезультатToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.очиститьРезультатToolStripMenuItem.Text = "Очистить результат";
            this.очиститьРезультатToolStripMenuItem.Click += new System.EventHandler(this.очиститьРезультатToolStripMenuItem_Click);
            // 
            // очиститьВсеToolStripMenuItem
            // 
            this.очиститьВсеToolStripMenuItem.Name = "очиститьВсеToolStripMenuItem";
            this.очиститьВсеToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.очиститьВсеToolStripMenuItem.Text = "Очистить все";
            this.очиститьВсеToolStripMenuItem.Click += new System.EventHandler(this.очиститьВсеToolStripMenuItem_Click);
            // 
            // value1
            // 
            this.value1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.value1.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value1.Location = new System.Drawing.Point(82, 118);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(110, 57);
            this.value1.TabIndex = 1;
            this.value1.Text = "57";
            this.value1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnswer
            // 
            this.txtAnswer.AutoSize = true;
            this.txtAnswer.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAnswer.Location = new System.Drawing.Point(389, 118);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(96, 50);
            this.txtAnswer.TabIndex = 3;
            this.txtAnswer.Text = "= 80";
            // 
            // value2
            // 
            this.value2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.value2.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value2.Location = new System.Drawing.Point(256, 118);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(110, 57);
            this.value2.TabIndex = 4;
            this.value2.Text = "23";
            this.value2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOperat
            // 
            this.txtOperat.AutoSize = true;
            this.txtOperat.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOperat.Location = new System.Drawing.Point(198, 118);
            this.txtOperat.Name = "txtOperat";
            this.txtOperat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOperat.Size = new System.Drawing.Size(52, 50);
            this.txtOperat.TabIndex = 5;
            this.txtOperat.Text = " : ";
            this.txtOperat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(561, 280);
            this.Controls.Add(this.txtOperat);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem математическиеДействияToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem редактированиеToolStripMenuItem;
        private ToolStripMenuItem очиститьИсходныеДанныеToolStripMenuItem;
        private ToolStripMenuItem очиститьРезультатToolStripMenuItem;
        private ToolStripMenuItem очиститьВсеToolStripMenuItem;
        private TextBox value1;
        private Label txtAnswer;
        private TextBox value2;
        private Label txtOperat;
    }
}