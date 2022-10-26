
namespace ICA09_StackyListDraw
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
            this.components = new System.ComponentModel.Container();
            this.Ui_numBar = new System.Windows.Forms.TrackBar();
            this.UI_btn_line = new System.Windows.Forms.Button();
            this.UI_btn_segment = new System.Windows.Forms.Button();
            this.UI_btn_Reduce = new System.Windows.Forms.Button();
            this.UI_btn_color = new System.Windows.Forms.Button();
            this.UI_lbl_thickness = new System.Windows.Forms.Label();
            this.UI_lbl_opacity = new System.Windows.Forms.Label();
            this.UI_lbl_Result = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UI_CDG = new System.Windows.Forms.ColorDialog();
            this.UI_tBar_opacity = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.Ui_numBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_tBar_opacity)).BeginInit();
            this.SuspendLayout();
            // 
            // Ui_numBar
            // 
            this.Ui_numBar.Location = new System.Drawing.Point(50, 317);
            this.Ui_numBar.Maximum = 255;
            this.Ui_numBar.Name = "Ui_numBar";
            this.Ui_numBar.Size = new System.Drawing.Size(444, 69);
            this.Ui_numBar.TabIndex = 5;
            this.Ui_numBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Ui_numBar.Scroll += new System.EventHandler(this.Ui_numBar_Scroll);
            // 
            // UI_btn_line
            // 
            this.UI_btn_line.Location = new System.Drawing.Point(50, 86);
            this.UI_btn_line.Name = "UI_btn_line";
            this.UI_btn_line.Size = new System.Drawing.Size(444, 41);
            this.UI_btn_line.TabIndex = 6;
            this.UI_btn_line.Text = "Undo Line...";
            this.UI_btn_line.UseVisualStyleBackColor = true;
            this.UI_btn_line.Click += new System.EventHandler(this.UI_btn_line_Click);
            // 
            // UI_btn_segment
            // 
            this.UI_btn_segment.Location = new System.Drawing.Point(50, 146);
            this.UI_btn_segment.Name = "UI_btn_segment";
            this.UI_btn_segment.Size = new System.Drawing.Size(444, 41);
            this.UI_btn_segment.TabIndex = 7;
            this.UI_btn_segment.Text = "Undo Segment...";
            this.UI_btn_segment.UseVisualStyleBackColor = true;
            this.UI_btn_segment.Click += new System.EventHandler(this.UI_btn_segment_Click);
            // 
            // UI_btn_Reduce
            // 
            this.UI_btn_Reduce.Location = new System.Drawing.Point(50, 203);
            this.UI_btn_Reduce.Name = "UI_btn_Reduce";
            this.UI_btn_Reduce.Size = new System.Drawing.Size(444, 41);
            this.UI_btn_Reduce.TabIndex = 8;
            this.UI_btn_Reduce.Text = "Reduce Complexity...";
            this.UI_btn_Reduce.UseVisualStyleBackColor = true;
            this.UI_btn_Reduce.Click += new System.EventHandler(this.UI_btn_Reduce_Click);
            // 
            // UI_btn_color
            // 
            this.UI_btn_color.Location = new System.Drawing.Point(50, 260);
            this.UI_btn_color.Name = "UI_btn_color";
            this.UI_btn_color.Size = new System.Drawing.Size(444, 41);
            this.UI_btn_color.TabIndex = 9;
            this.UI_btn_color.Text = "Color";
            this.UI_btn_color.UseVisualStyleBackColor = true;
            this.UI_btn_color.Click += new System.EventHandler(this.UI_btn_color_Click);
            // 
            // UI_lbl_thickness
            // 
            this.UI_lbl_thickness.AutoSize = true;
            this.UI_lbl_thickness.Location = new System.Drawing.Point(46, 380);
            this.UI_lbl_thickness.Name = "UI_lbl_thickness";
            this.UI_lbl_thickness.Size = new System.Drawing.Size(51, 20);
            this.UI_lbl_thickness.TabIndex = 10;
            this.UI_lbl_thickness.Text = "label1";
            // 
            // UI_lbl_opacity
            // 
            this.UI_lbl_opacity.AutoSize = true;
            this.UI_lbl_opacity.Location = new System.Drawing.Point(443, 380);
            this.UI_lbl_opacity.Name = "UI_lbl_opacity";
            this.UI_lbl_opacity.Size = new System.Drawing.Size(51, 20);
            this.UI_lbl_opacity.TabIndex = 11;
            this.UI_lbl_opacity.Text = "label2";
            // 
            // UI_lbl_Result
            // 
            this.UI_lbl_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_lbl_Result.Location = new System.Drawing.Point(50, 23);
            this.UI_lbl_Result.Name = "UI_lbl_Result";
            this.UI_lbl_Result.Size = new System.Drawing.Size(444, 41);
            this.UI_lbl_Result.TabIndex = 12;
            this.UI_lbl_Result.Text = "label3";
            this.UI_lbl_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UI_tBar_opacity
            // 
            this.UI_tBar_opacity.Location = new System.Drawing.Point(50, 413);
            this.UI_tBar_opacity.Maximum = 255;
            this.UI_tBar_opacity.Name = "UI_tBar_opacity";
            this.UI_tBar_opacity.Size = new System.Drawing.Size(444, 69);
            this.UI_tBar_opacity.TabIndex = 13;
            this.UI_tBar_opacity.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.UI_tBar_opacity.Scroll += new System.EventHandler(this.UI_tBar_opacity_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 494);
            this.Controls.Add(this.UI_tBar_opacity);
            this.Controls.Add(this.UI_lbl_Result);
            this.Controls.Add(this.UI_lbl_opacity);
            this.Controls.Add(this.UI_lbl_thickness);
            this.Controls.Add(this.UI_btn_color);
            this.Controls.Add(this.UI_btn_Reduce);
            this.Controls.Add(this.UI_btn_segment);
            this.Controls.Add(this.UI_btn_line);
            this.Controls.Add(this.Ui_numBar);
            this.MaximumSize = new System.Drawing.Size(578, 550);
            this.MinimumSize = new System.Drawing.Size(578, 550);
            this.Name = "Form1";
            this.Text = "StackyListDraw";
            ((System.ComponentModel.ISupportInitialize)(this.Ui_numBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_tBar_opacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar Ui_numBar;
        private System.Windows.Forms.Button UI_btn_line;
        private System.Windows.Forms.Button UI_btn_segment;
        private System.Windows.Forms.Button UI_btn_Reduce;
        private System.Windows.Forms.Button UI_btn_color;
        private System.Windows.Forms.Label UI_lbl_thickness;
        private System.Windows.Forms.Label UI_lbl_opacity;
        private System.Windows.Forms.Label UI_lbl_Result;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColorDialog UI_CDG;
        private System.Windows.Forms.TrackBar UI_tBar_opacity;
    }
}

