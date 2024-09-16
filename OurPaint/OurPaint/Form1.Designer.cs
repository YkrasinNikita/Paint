namespace OurPaint
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
            panel1 = new Panel();
            btn_back = new Button();
            cmb_thick = new ComboBox();
            cmb_colors = new ComboBox();
            btn_line = new Button();
            btn_circle = new Button();
            btn_rectangle = new Button();
            btn_rubber = new Button();
            btn_brush = new Button();
            menuStrip1 = new MenuStrip();
            toolStrip_File = new ToolStripMenuItem();
            toolStrip_New = new ToolStripMenuItem();
            toolStrip_Open = new ToolStripMenuItem();
            toolStrip_Save = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(btn_back);
            panel1.Controls.Add(cmb_thick);
            panel1.Controls.Add(cmb_colors);
            panel1.Controls.Add(btn_line);
            panel1.Controls.Add(btn_circle);
            panel1.Controls.Add(btn_rectangle);
            panel1.Controls.Add(btn_rubber);
            panel1.Controls.Add(btn_brush);
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 35);
            panel1.TabIndex = 0;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(874, 3);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(85, 29);
            btn_back.TabIndex = 7;
            btn_back.Text = "<-";
            btn_back.UseVisualStyleBackColor = true;
            // 
            // cmb_thick
            // 
            cmb_thick.FormattingEnabled = true;
            cmb_thick.Location = new Point(717, 3);
            cmb_thick.Name = "cmb_thick";
            cmb_thick.Size = new Size(151, 28);
            cmb_thick.TabIndex = 6;
            // 
            // cmb_colors
            // 
            cmb_colors.FormattingEnabled = true;
            cmb_colors.Location = new Point(560, 3);
            cmb_colors.Name = "cmb_colors";
            cmb_colors.Size = new Size(151, 28);
            cmb_colors.TabIndex = 5;
            // 
            // btn_line
            // 
            btn_line.Location = new Point(460, 3);
            btn_line.Name = "btn_line";
            btn_line.Size = new Size(94, 29);
            btn_line.TabIndex = 4;
            btn_line.Text = "Линия";
            btn_line.UseVisualStyleBackColor = true;
            // 
            // btn_circle
            // 
            btn_circle.Location = new Point(360, 3);
            btn_circle.Name = "btn_circle";
            btn_circle.Size = new Size(94, 29);
            btn_circle.TabIndex = 3;
            btn_circle.Text = "Круг";
            btn_circle.UseVisualStyleBackColor = true;
            // 
            // btn_rectangle
            // 
            btn_rectangle.Location = new Point(218, 3);
            btn_rectangle.Name = "btn_rectangle";
            btn_rectangle.Size = new Size(136, 29);
            btn_rectangle.TabIndex = 2;
            btn_rectangle.Text = "Прямоугольник";
            btn_rectangle.UseVisualStyleBackColor = true;
            // 
            // btn_rubber
            // 
            btn_rubber.Location = new Point(118, 3);
            btn_rubber.Name = "btn_rubber";
            btn_rubber.Size = new Size(94, 29);
            btn_rubber.TabIndex = 1;
            btn_rubber.Text = "Ластик";
            btn_rubber.UseVisualStyleBackColor = true;
            // 
            // btn_brush
            // 
            btn_brush.Location = new Point(18, 3);
            btn_brush.Name = "btn_brush";
            btn_brush.Size = new Size(94, 29);
            btn_brush.TabIndex = 0;
            btn_brush.Text = "Кисть";
            btn_brush.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStrip_File });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(971, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip_File
            // 
            toolStrip_File.DropDownItems.AddRange(new ToolStripItem[] { toolStrip_New, toolStrip_Open, toolStrip_Save });
            toolStrip_File.Name = "toolStrip_File";
            toolStrip_File.Size = new Size(59, 24);
            toolStrip_File.Text = "Файл";
            // 
            // toolStrip_New
            // 
            toolStrip_New.Name = "toolStrip_New";
            toolStrip_New.Size = new Size(166, 26);
            toolStrip_New.Text = "Создать";
            // 
            // toolStrip_Open
            // 
            toolStrip_Open.Name = "toolStrip_Open";
            toolStrip_Open.Size = new Size(166, 26);
            toolStrip_Open.Text = "Открыть";
            // 
            // toolStrip_Save
            // 
            toolStrip_Save.Name = "toolStrip_Save";
            toolStrip_Save.Size = new Size(166, 26);
            toolStrip_Save.Text = "Сохранить";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 544);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Paint";
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_brush;
        private Button btn_circle;
        private Button btn_rectangle;
        private Button btn_rubber;
        private Button btn_back;
        private ComboBox cmb_thick;
        private ComboBox cmb_colors;
        private Button btn_line;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStrip_File;
        private ToolStripMenuItem toolStrip_New;
        private ToolStripMenuItem toolStrip_Open;
        private ToolStripMenuItem toolStrip_Save;
    }
}
