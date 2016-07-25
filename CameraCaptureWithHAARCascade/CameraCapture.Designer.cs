namespace CameraCaptureWithHAARCascade
{
    partial class CameraCapture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbCamIndex = new System.Windows.Forms.ComboBox();
            this.CamImageBox = new Emgu.CV.UI.ImageBox();
            this.selectedCamera = new System.Windows.Forms.Label();
            this.caption = new System.Windows.Forms.Label();
            this.totalFaceCaption = new System.Windows.Forms.Label();
            this.totalFaceNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(862, 684);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 56);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbCamIndex
            // 
            this.cbCamIndex.FormattingEnabled = true;
            this.cbCamIndex.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbCamIndex.Location = new System.Drawing.Point(666, 695);
            this.cbCamIndex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCamIndex.Name = "cbCamIndex";
            this.cbCamIndex.Size = new System.Drawing.Size(127, 36);
            this.cbCamIndex.TabIndex = 3;
            this.cbCamIndex.Text = "NONE";
            this.cbCamIndex.SelectedIndexChanged += new System.EventHandler(this.cbCamIndex_SelectedIndexChanged);
            // 
            // CamImageBox
            // 
            this.CamImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CamImageBox.Location = new System.Drawing.Point(15, 39);
            this.CamImageBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CamImageBox.Name = "CamImageBox";
            this.CamImageBox.Size = new System.Drawing.Size(800, 600);
            this.CamImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CamImageBox.TabIndex = 2;
            this.CamImageBox.TabStop = false;
            // 
            // selectedCamera
            // 
            this.selectedCamera.AutoSize = true;
            this.selectedCamera.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCamera.Location = new System.Drawing.Point(465, 701);
            this.selectedCamera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedCamera.Name = "selectedCamera";
            this.selectedCamera.Size = new System.Drawing.Size(137, 25);
            this.selectedCamera.TabIndex = 7;
            this.selectedCamera.Text = "Select Camera:";
            this.selectedCamera.Click += new System.EventHandler(this.selectedCamera_Click);
            // 
            // caption
            // 
            this.caption.AutoSize = true;
            this.caption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.caption.Location = new System.Drawing.Point(22, 698);
            this.caption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(355, 28);
            this.caption.TabIndex = 8;
            this.caption.Text = "Welcome to the Camera Canvas Booth!\r\n";
            // 
            // totalFaceCaption
            // 
            this.totalFaceCaption.AutoSize = true;
            this.totalFaceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFaceCaption.Location = new System.Drawing.Point(870, 396);
            this.totalFaceCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalFaceCaption.Name = "totalFaceCaption";
            this.totalFaceCaption.Size = new System.Drawing.Size(130, 25);
            this.totalFaceCaption.TabIndex = 9;
            this.totalFaceCaption.Text = "The total faces:";
            // 
            // totalFaceNum
            // 
            this.totalFaceNum.AutoSize = true;
            this.totalFaceNum.Location = new System.Drawing.Point(923, 466);
            this.totalFaceNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalFaceNum.Name = "totalFaceNum";
            this.totalFaceNum.Size = new System.Drawing.Size(0, 28);
            this.totalFaceNum.TabIndex = 10;
            // 
            // CameraCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 775);
            this.Controls.Add(this.totalFaceNum);
            this.Controls.Add(this.totalFaceCaption);
            this.Controls.Add(this.caption);
            this.Controls.Add(this.selectedCamera);
            this.Controls.Add(this.CamImageBox);
            this.Controls.Add(this.cbCamIndex);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CameraCapture";
            this.Text = "Camera Output";
            this.Load += new System.EventHandler(this.CameraCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;

        //Combo Box to choose the number of cameras to capture
        private System.Windows.Forms.ComboBox cbCamIndex;

        //access to the EMGU.CV.UI-type image box (quite in similarity to PictureBox of Windows.Forms)
        private Emgu.CV.UI.ImageBox CamImageBox;
        private System.Windows.Forms.Label selectedCamera;
        private System.Windows.Forms.Label caption;
        private System.Windows.Forms.Label totalFaceCaption;
        private System.Windows.Forms.Label totalFaceNum;
    }
}

