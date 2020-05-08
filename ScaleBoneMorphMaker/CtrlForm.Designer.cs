namespace ScaleBoneMorphMaker
{
    partial class CtrlForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            this.numericZ = new System.Windows.Forms.NumericUpDown();
            this.buttonMake = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelUsage = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZ)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.numericX, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericY, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericZ, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonMake, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelX, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelY, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelZ, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelUsage, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 111);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // numericX
            // 
            this.numericX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericX.DecimalPlaces = 3;
            this.numericX.Location = new System.Drawing.Point(5, 41);
            this.numericX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(157, 27);
            this.numericX.TabIndex = 0;
            // 
            // numericY
            // 
            this.numericY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericY.DecimalPlaces = 3;
            this.numericY.Location = new System.Drawing.Point(171, 41);
            this.numericY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(158, 27);
            this.numericY.TabIndex = 0;
            // 
            // numericZ
            // 
            this.numericZ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericZ.DecimalPlaces = 3;
            this.numericZ.Location = new System.Drawing.Point(338, 41);
            this.numericZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericZ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericZ.Name = "numericZ";
            this.numericZ.Size = new System.Drawing.Size(159, 27);
            this.numericZ.TabIndex = 0;
            // 
            // buttonMake
            // 
            this.buttonMake.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMake.Location = new System.Drawing.Point(337, 75);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(162, 33);
            this.buttonMake.TabIndex = 1;
            this.buttonMake.Text = "作成";
            this.buttonMake.UseVisualStyleBackColor = true;
            this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
            // 
            // labelX
            // 
            this.labelX.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(3, 16);
            this.labelX.Margin = new System.Windows.Forms.Padding(3, 0, 150, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 20);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "X";
            // 
            // labelY
            // 
            this.labelY.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(170, 16);
            this.labelY.Margin = new System.Windows.Forms.Padding(3, 0, 150, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 20);
            this.labelY.TabIndex = 2;
            this.labelY.Text = "Y";
            // 
            // labelZ
            // 
            this.labelZ.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(337, 16);
            this.labelZ.Margin = new System.Windows.Forms.Padding(3, 0, 150, 0);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(15, 20);
            this.labelZ.TabIndex = 2;
            this.labelZ.Text = "Z";
            // 
            // labelUsage
            // 
            this.labelUsage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUsage.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelUsage, 2);
            this.labelUsage.Location = new System.Drawing.Point(3, 72);
            this.labelUsage.Name = "labelUsage";
            this.labelUsage.Size = new System.Drawing.Size(193, 39);
            this.labelUsage.TabIndex = 3;
            this.labelUsage.Text = "ビューから対象ボーンを選択\r\n倍率を入力し作成ボタンを押す";
            // 
            // CtrlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 151);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(550, 190);
            this.Name = "CtrlForm";
            this.Text = "拡縮ボーンモーフ作成";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CtrlForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numericX;
        private System.Windows.Forms.NumericUpDown numericY;
        private System.Windows.Forms.NumericUpDown numericZ;
        private System.Windows.Forms.Button buttonMake;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelUsage;
    }
}