
namespace Fractals
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRender = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.radioButtonRandom = new System.Windows.Forms.RadioButton();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownBCon = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownGCon = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownRCon = new System.Windows.Forms.NumericUpDown();
            this.labelA = new System.Windows.Forms.Label();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.checkBoxG = new System.Windows.Forms.CheckBox();
            this.checkBoxR = new System.Windows.Forms.CheckBox();
            this.labelC = new System.Windows.Forms.Label();
            this.trackBarC = new System.Windows.Forms.TrackBar();
            this.radioButtonUnRandomColors = new System.Windows.Forms.RadioButton();
            this.radioButtonRandomColors = new System.Windows.Forms.RadioButton();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonByCReIm = new System.Windows.Forms.RadioButton();
            this.numericUpDownCRe = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCIm = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownZoom = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCRe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCIm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pre-Render";
            // 
            // buttonRender
            // 
            this.buttonRender.Enabled = false;
            this.buttonRender.Location = new System.Drawing.Point(126, 134);
            this.buttonRender.Name = "buttonRender";
            this.buttonRender.Size = new System.Drawing.Size(86, 23);
            this.buttonRender.TabIndex = 2;
            this.buttonRender.Text = "Render";
            this.buttonRender.UseVisualStyleBackColor = true;
            this.buttonRender.Click += new System.EventHandler(this.buttonRender_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(15, 134);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(90, 23);
            this.buttonGenerate.TabIndex = 3;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // radioButtonRandom
            // 
            this.radioButtonRandom.AutoSize = true;
            this.radioButtonRandom.Checked = true;
            this.radioButtonRandom.Location = new System.Drawing.Point(233, 28);
            this.radioButtonRandom.Name = "radioButtonRandom";
            this.radioButtonRandom.Size = new System.Drawing.Size(112, 17);
            this.radioButtonRandom.TabIndex = 4;
            this.radioButtonRandom.TabStop = true;
            this.radioButtonRandom.Text = "Generate Random";
            this.radioButtonRandom.UseVisualStyleBackColor = true;
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.label8);
            this.groupBoxColors.Controls.Add(this.numericUpDownBCon);
            this.groupBoxColors.Controls.Add(this.label6);
            this.groupBoxColors.Controls.Add(this.numericUpDownGCon);
            this.groupBoxColors.Controls.Add(this.label5);
            this.groupBoxColors.Controls.Add(this.numericUpDownRCon);
            this.groupBoxColors.Controls.Add(this.labelA);
            this.groupBoxColors.Controls.Add(this.trackBarA);
            this.groupBoxColors.Controls.Add(this.checkBoxB);
            this.groupBoxColors.Controls.Add(this.checkBoxG);
            this.groupBoxColors.Controls.Add(this.checkBoxR);
            this.groupBoxColors.Controls.Add(this.labelC);
            this.groupBoxColors.Controls.Add(this.trackBarC);
            this.groupBoxColors.Controls.Add(this.radioButtonUnRandomColors);
            this.groupBoxColors.Controls.Add(this.radioButtonRandomColors);
            this.groupBoxColors.Location = new System.Drawing.Point(359, 28);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(453, 157);
            this.groupBoxColors.TabIndex = 5;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "ColorsProperties";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "BCon";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownBCon
            // 
            this.numericUpDownBCon.Location = new System.Drawing.Point(367, 64);
            this.numericUpDownBCon.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownBCon.Name = "numericUpDownBCon";
            this.numericUpDownBCon.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownBCon.TabIndex = 13;
            this.numericUpDownBCon.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "GCon";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownGCon
            // 
            this.numericUpDownGCon.Location = new System.Drawing.Point(306, 64);
            this.numericUpDownGCon.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownGCon.Name = "numericUpDownGCon";
            this.numericUpDownGCon.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownGCon.TabIndex = 11;
            this.numericUpDownGCon.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "RCon";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownRCon
            // 
            this.numericUpDownRCon.Location = new System.Drawing.Point(253, 64);
            this.numericUpDownRCon.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownRCon.Name = "numericUpDownRCon";
            this.numericUpDownRCon.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownRCon.TabIndex = 9;
            this.numericUpDownRCon.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(146, 90);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(61, 13);
            this.labelA.TabIndex = 8;
            this.labelA.Text = "Alpha : 255";
            this.labelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarA
            // 
            this.trackBarA.Location = new System.Drawing.Point(121, 105);
            this.trackBarA.Maximum = 255;
            this.trackBarA.Minimum = 100;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(109, 45);
            this.trackBarA.TabIndex = 7;
            this.trackBarA.Value = 255;
            this.trackBarA.Scroll += new System.EventHandler(this.trackBarA_Scroll);
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Checked = true;
            this.checkBoxB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxB.Location = new System.Drawing.Point(367, 105);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(47, 17);
            this.checkBoxB.TabIndex = 6;
            this.checkBoxB.Text = "Blue";
            this.checkBoxB.UseVisualStyleBackColor = true;
            // 
            // checkBoxG
            // 
            this.checkBoxG.AutoSize = true;
            this.checkBoxG.Location = new System.Drawing.Point(306, 106);
            this.checkBoxG.Name = "checkBoxG";
            this.checkBoxG.Size = new System.Drawing.Size(55, 17);
            this.checkBoxG.TabIndex = 5;
            this.checkBoxG.Text = "Green";
            this.checkBoxG.UseVisualStyleBackColor = true;
            // 
            // checkBoxR
            // 
            this.checkBoxR.AutoSize = true;
            this.checkBoxR.Checked = true;
            this.checkBoxR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxR.Location = new System.Drawing.Point(253, 106);
            this.checkBoxR.Name = "checkBoxR";
            this.checkBoxR.Size = new System.Drawing.Size(46, 17);
            this.checkBoxR.TabIndex = 4;
            this.checkBoxR.Text = "Red";
            this.checkBoxR.UseVisualStyleBackColor = true;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(33, 90);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(59, 13);
            this.labelC.TabIndex = 3;
            this.labelC.Text = "Colorize : 9";
            this.labelC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarC
            // 
            this.trackBarC.Location = new System.Drawing.Point(6, 106);
            this.trackBarC.Maximum = 90;
            this.trackBarC.Minimum = 5;
            this.trackBarC.Name = "trackBarC";
            this.trackBarC.Size = new System.Drawing.Size(109, 45);
            this.trackBarC.TabIndex = 2;
            this.trackBarC.Value = 9;
            this.trackBarC.Scroll += new System.EventHandler(this.trackBarC_Scroll);
            // 
            // radioButtonUnRandomColors
            // 
            this.radioButtonUnRandomColors.AutoSize = true;
            this.radioButtonUnRandomColors.Location = new System.Drawing.Point(6, 48);
            this.radioButtonUnRandomColors.Name = "radioButtonUnRandomColors";
            this.radioButtonUnRandomColors.Size = new System.Drawing.Size(77, 17);
            this.radioButtonUnRandomColors.TabIndex = 1;
            this.radioButtonUnRandomColors.Text = "Use Preset";
            this.radioButtonUnRandomColors.UseVisualStyleBackColor = true;
            // 
            // radioButtonRandomColors
            // 
            this.radioButtonRandomColors.AutoSize = true;
            this.radioButtonRandomColors.Checked = true;
            this.radioButtonRandomColors.Location = new System.Drawing.Point(6, 19);
            this.radioButtonRandomColors.Name = "radioButtonRandomColors";
            this.radioButtonRandomColors.Size = new System.Drawing.Size(97, 17);
            this.radioButtonRandomColors.TabIndex = 0;
            this.radioButtonRandomColors.TabStop = true;
            this.radioButtonRandomColors.Text = "Random Colors";
            this.radioButtonRandomColors.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(12, 246);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownWidth.TabIndex = 6;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "RenderPresets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Width";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(12, 299);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            5400,
            0,
            0,
            0});
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownHeight.TabIndex = 9;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Height";
            // 
            // radioButtonByCReIm
            // 
            this.radioButtonByCReIm.AutoSize = true;
            this.radioButtonByCReIm.Location = new System.Drawing.Point(233, 51);
            this.radioButtonByCReIm.Name = "radioButtonByCReIm";
            this.radioButtonByCReIm.Size = new System.Drawing.Size(119, 17);
            this.radioButtonByCReIm.TabIndex = 11;
            this.radioButtonByCReIm.Text = "Generate By CReIm";
            this.radioButtonByCReIm.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCRe
            // 
            this.numericUpDownCRe.Location = new System.Drawing.Point(233, 108);
            this.numericUpDownCRe.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownCRe.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownCRe.Name = "numericUpDownCRe";
            this.numericUpDownCRe.Size = new System.Drawing.Size(119, 20);
            this.numericUpDownCRe.TabIndex = 12;
            this.numericUpDownCRe.Value = new decimal(new int[] {
            36352,
            0,
            0,
            -2147483648});
            // 
            // numericUpDownCIm
            // 
            this.numericUpDownCIm.Location = new System.Drawing.Point(233, 158);
            this.numericUpDownCIm.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownCIm.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownCIm.Name = "numericUpDownCIm";
            this.numericUpDownCIm.Size = new System.Drawing.Size(119, 20);
            this.numericUpDownCIm.TabIndex = 13;
            this.numericUpDownCIm.Value = new decimal(new int[] {
            62248,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "CRe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "CIm";
            // 
            // numericUpDownZoom
            // 
            this.numericUpDownZoom.DecimalPlaces = 2;
            this.numericUpDownZoom.Location = new System.Drawing.Point(12, 358);
            this.numericUpDownZoom.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownZoom.Name = "numericUpDownZoom";
            this.numericUpDownZoom.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownZoom.TabIndex = 17;
            this.numericUpDownZoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownZoom.ValueChanged += new System.EventHandler(this.numericUpDownZoom_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Zoom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 443);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDownZoom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownCIm);
            this.Controls.Add(this.numericUpDownCRe);
            this.Controls.Add(this.radioButtonByCReIm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.radioButtonRandom);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonRender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Fractals";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxColors.ResumeLayout(false);
            this.groupBoxColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCRe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCIm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRender;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.RadioButton radioButtonRandom;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TrackBar trackBarC;
        private System.Windows.Forms.RadioButton radioButtonUnRandomColors;
        private System.Windows.Forms.RadioButton radioButtonRandomColors;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxG;
        private System.Windows.Forms.CheckBox checkBoxR;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownBCon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownGCon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownRCon;
        private System.Windows.Forms.RadioButton radioButtonByCReIm;
        private System.Windows.Forms.NumericUpDown numericUpDownCRe;
        private System.Windows.Forms.NumericUpDown numericUpDownCIm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownZoom;
        private System.Windows.Forms.Label label10;
    }
}

