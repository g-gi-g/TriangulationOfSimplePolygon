namespace TriangulationDrawer
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
            this.xCoord = new System.Windows.Forms.TextBox();
            this.yCoord = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.addPointBtn = new System.Windows.Forms.Button();
            this.generatePolygonBtn = new System.Windows.Forms.Button();
            this.vertCountLab = new System.Windows.Forms.Label();
            this.verticlesCountTb = new System.Windows.Forms.TextBox();
            this.triangulateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xCoord
            // 
            this.xCoord.Location = new System.Drawing.Point(615, 34);
            this.xCoord.Name = "xCoord";
            this.xCoord.Size = new System.Drawing.Size(125, 27);
            this.xCoord.TabIndex = 0;
            // 
            // yCoord
            // 
            this.yCoord.Location = new System.Drawing.Point(615, 82);
            this.yCoord.Name = "yCoord";
            this.yCoord.Size = new System.Drawing.Size(125, 27);
            this.yCoord.TabIndex = 1;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(593, 37);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(16, 20);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "x";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(593, 85);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(16, 20);
            this.yLabel.TabIndex = 3;
            this.yLabel.Text = "y";
            // 
            // addPointBtn
            // 
            this.addPointBtn.Location = new System.Drawing.Point(625, 125);
            this.addPointBtn.Name = "addPointBtn";
            this.addPointBtn.Size = new System.Drawing.Size(94, 29);
            this.addPointBtn.TabIndex = 4;
            this.addPointBtn.Text = "Add";
            this.addPointBtn.UseVisualStyleBackColor = true;
            this.addPointBtn.Click += new System.EventHandler(this.addPointBtn_Click);
            // 
            // generatePolygonBtn
            // 
            this.generatePolygonBtn.Location = new System.Drawing.Point(625, 248);
            this.generatePolygonBtn.Name = "generatePolygonBtn";
            this.generatePolygonBtn.Size = new System.Drawing.Size(94, 29);
            this.generatePolygonBtn.TabIndex = 5;
            this.generatePolygonBtn.Text = "Generate";
            this.generatePolygonBtn.UseVisualStyleBackColor = true;
            this.generatePolygonBtn.Click += new System.EventHandler(this.generatePolygonBtn_Click);
            // 
            // vertCountLab
            // 
            this.vertCountLab.AutoSize = true;
            this.vertCountLab.Location = new System.Drawing.Point(625, 181);
            this.vertCountLab.Name = "vertCountLab";
            this.vertCountLab.Size = new System.Drawing.Size(105, 20);
            this.vertCountLab.TabIndex = 7;
            this.vertCountLab.Text = "Verticles count";
            // 
            // verticlesCountTb
            // 
            this.verticlesCountTb.Location = new System.Drawing.Point(615, 204);
            this.verticlesCountTb.Name = "verticlesCountTb";
            this.verticlesCountTb.Size = new System.Drawing.Size(125, 27);
            this.verticlesCountTb.TabIndex = 6;
            // 
            // triangulateBtn
            // 
            this.triangulateBtn.Location = new System.Drawing.Point(615, 350);
            this.triangulateBtn.Name = "triangulateBtn";
            this.triangulateBtn.Size = new System.Drawing.Size(134, 59);
            this.triangulateBtn.TabIndex = 8;
            this.triangulateBtn.Text = "Triangulate";
            this.triangulateBtn.UseVisualStyleBackColor = true;
            this.triangulateBtn.Click += new System.EventHandler(this.triangulateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(636, 304);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 29);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.triangulateBtn);
            this.Controls.Add(this.vertCountLab);
            this.Controls.Add(this.verticlesCountTb);
            this.Controls.Add(this.generatePolygonBtn);
            this.Controls.Add(this.addPointBtn);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.yCoord);
            this.Controls.Add(this.xCoord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox xCoord;
        private TextBox yCoord;
        private Label xLabel;
        private Label yLabel;
        private Button addPointBtn;
        private Button generatePolygonBtn;
        private Label vertCountLab;
        private TextBox verticlesCountTb;
        private Button triangulateBtn;
        private Button clearBtn;
    }
}