namespace SVGViewer
{
    partial class SVGControlTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.tImageViewControl1 = new Svg.TImageViewControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tImageViewControl1
            // 
            this.tImageViewControl1.ImageFilePath = "";
            this.tImageViewControl1.Is_LocalImage = true;
            this.tImageViewControl1.Location = new System.Drawing.Point(12, 12);
            this.tImageViewControl1.Name = "tImageViewControl1";
            this.tImageViewControl1.Size = new System.Drawing.Size(519, 406);
            this.tImageViewControl1.TabIndex = 0;
            // 
            // SVGControlTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tImageViewControl1);
            this.Name = "SVGControlTest";
            this.Text = "SVGControlTest";
            this.ResumeLayout(false);

        }

        #endregion

        private Svg.TImageViewControl tImageViewControl1;
        private System.Windows.Forms.Button button1;
    }
}