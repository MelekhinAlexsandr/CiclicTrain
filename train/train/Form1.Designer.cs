namespace train
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TrainText = new System.Windows.Forms.Label();
            this.countVagon = new System.Windows.Forms.Label();
            this.countWagon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trainText2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "решить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кол-во вагонов";
            // 
            // TrainText
            // 
            this.TrainText.AutoSize = true;
            this.TrainText.Location = new System.Drawing.Point(31, 72);
            this.TrainText.Name = "TrainText";
            this.TrainText.Size = new System.Drawing.Size(15, 20);
            this.TrainText.TabIndex = 2;
            this.TrainText.Text = "-";
            // 
            // countVagon
            // 
            this.countVagon.AutoSize = true;
            this.countVagon.Location = new System.Drawing.Point(156, 36);
            this.countVagon.Name = "countVagon";
            this.countVagon.Size = new System.Drawing.Size(17, 20);
            this.countVagon.TabIndex = 3;
            this.countVagon.Text = "0";
            // 
            // countWagon
            // 
            this.countWagon.AutoSize = true;
            this.countWagon.Location = new System.Drawing.Point(156, 200);
            this.countWagon.Name = "countWagon";
            this.countWagon.Size = new System.Drawing.Size(17, 20);
            this.countWagon.TabIndex = 5;
            this.countWagon.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кол-во вагонов";
            // 
            // trainText2
            // 
            this.trainText2.AutoSize = true;
            this.trainText2.Location = new System.Drawing.Point(31, 245);
            this.trainText2.Name = "trainText2";
            this.trainText2.Size = new System.Drawing.Size(15, 20);
            this.trainText2.TabIndex = 6;
            this.trainText2.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trainText2);
            this.Controls.Add(this.countWagon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countVagon);
            this.Controls.Add(this.TrainText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label TrainText;
        private Label countVagon;
        private Label countWagon;
        private Label label3;
        private Label trainText2;
    }
}