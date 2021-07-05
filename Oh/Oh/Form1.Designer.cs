
namespace Oh
{
    partial class palet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(palet));
            this.Result = new System.Windows.Forms.Label();
            this.RED_SLB = new System.Windows.Forms.HScrollBar();
            this.RED = new System.Windows.Forms.Label();
            this.GREEN = new System.Windows.Forms.Label();
            this.GREEN_SLB = new System.Windows.Forms.HScrollBar();
            this.BLUE_SLB = new System.Windows.Forms.HScrollBar();
            this.BLUE = new System.Windows.Forms.Label();
            this.RESULT_HEX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("메이플스토리", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Result.Location = new System.Drawing.Point(13, 13);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(211, 48);
            this.Result.TabIndex = 0;
            this.Result.Text = "EXAMPLE";
            // 
            // RED_SLB
            // 
            this.RED_SLB.LargeChange = 1;
            this.RED_SLB.Location = new System.Drawing.Point(46, 62);
            this.RED_SLB.Maximum = 255;
            this.RED_SLB.Name = "RED_SLB";
            this.RED_SLB.Size = new System.Drawing.Size(383, 37);
            this.RED_SLB.TabIndex = 1;
            this.RED_SLB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RED_SLB_Scroll);
            // 
            // RED
            // 
            this.RED.AutoSize = true;
            this.RED.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RED.Location = new System.Drawing.Point(7, 64);
            this.RED.Name = "RED";
            this.RED.Size = new System.Drawing.Size(30, 35);
            this.RED.TabIndex = 0;
            this.RED.Text = "R";
            // 
            // GREEN
            // 
            this.GREEN.AutoSize = true;
            this.GREEN.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GREEN.Location = new System.Drawing.Point(7, 99);
            this.GREEN.Name = "GREEN";
            this.GREEN.Size = new System.Drawing.Size(33, 35);
            this.GREEN.TabIndex = 0;
            this.GREEN.Text = "G";
            // 
            // GREEN_SLB
            // 
            this.GREEN_SLB.LargeChange = 1;
            this.GREEN_SLB.Location = new System.Drawing.Point(46, 99);
            this.GREEN_SLB.Maximum = 255;
            this.GREEN_SLB.Name = "GREEN_SLB";
            this.GREEN_SLB.Size = new System.Drawing.Size(383, 37);
            this.GREEN_SLB.TabIndex = 2;
            this.GREEN_SLB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GREEN_SLB_Scroll);
            // 
            // BLUE_SLB
            // 
            this.BLUE_SLB.LargeChange = 1;
            this.BLUE_SLB.Location = new System.Drawing.Point(46, 136);
            this.BLUE_SLB.Maximum = 255;
            this.BLUE_SLB.Name = "BLUE_SLB";
            this.BLUE_SLB.Size = new System.Drawing.Size(383, 37);
            this.BLUE_SLB.TabIndex = 3;
            this.BLUE_SLB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BLUE_SLB_Scroll);
            // 
            // BLUE
            // 
            this.BLUE.AutoSize = true;
            this.BLUE.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BLUE.Location = new System.Drawing.Point(7, 138);
            this.BLUE.Name = "BLUE";
            this.BLUE.Size = new System.Drawing.Size(30, 35);
            this.BLUE.TabIndex = 0;
            this.BLUE.Text = "B";
            // 
            // RESULT_HEX
            // 
            this.RESULT_HEX.AutoSize = true;
            this.RESULT_HEX.Font = new System.Drawing.Font("메이플스토리", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RESULT_HEX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RESULT_HEX.Location = new System.Drawing.Point(235, 13);
            this.RESULT_HEX.Name = "RESULT_HEX";
            this.RESULT_HEX.Size = new System.Drawing.Size(194, 48);
            this.RESULT_HEX.TabIndex = 0;
            this.RESULT_HEX.Text = "000000";
            this.RESULT_HEX.Click += new System.EventHandler(this.RESULT_HEX_Click);
            // 
            // palet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 186);
            this.Controls.Add(this.RESULT_HEX);
            this.Controls.Add(this.BLUE_SLB);
            this.Controls.Add(this.BLUE);
            this.Controls.Add(this.GREEN_SLB);
            this.Controls.Add(this.GREEN);
            this.Controls.Add(this.RED);
            this.Controls.Add(this.RED_SLB);
            this.Controls.Add(this.Result);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "palet";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Color Palet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.HScrollBar RED_SLB;
        private System.Windows.Forms.Label RED;
        private System.Windows.Forms.Label GREEN;
        private System.Windows.Forms.HScrollBar GREEN_SLB;
        private System.Windows.Forms.HScrollBar BLUE_SLB;
        private System.Windows.Forms.Label BLUE;
        private System.Windows.Forms.Label RESULT_HEX;
    }
}

