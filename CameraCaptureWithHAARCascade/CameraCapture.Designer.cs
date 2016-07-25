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
            this.captionText = new System.Windows.Forms.TextBox();
            this.CamImageBox = new Emgu.CV.UI.ImageBox();
            this.selectedCamera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(799, 634);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 39);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // cbCamIndex
            // 
            this.cbCamIndex.FormattingEnabled = true;
            this.cbCamIndex.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbCamIndex.Location = new System.Drawing.Point(641, 643);
            this.cbCamIndex.Name = "cbCamIndex";
            this.cbCamIndex.Size = new System.Drawing.Size(105, 28);
            this.cbCamIndex.TabIndex = 3;
            this.cbCamIndex.Text = "NONE";
            this.cbCamIndex.SelectedIndexChanged += new System.EventHandler(this.cbCamIndex_SelectedIndexChanged);
            // 
            // captionText
            // 
            this.captionText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.captionText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionText.Location = new System.Drawing.Point(12, 641);
            this.captionText.Name = "captionText";
            this.captionText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.captionText.Size = new System.Drawing.Size(392, 29);
            this.captionText.TabIndex = 6;
            this.captionText.Text = "Welcome to the Camera Canvas Booth!\r\n\r\n  ";
            this.captionText.TextChanged += new System.EventHandler(this.caption_TextChanged);
            // 
            // CamImageBox
            // 
            this.CamImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CamImageBox.Location = new System.Drawing.Point(12, 12);
            this.CamImageBox.Name = "CamImageBox";
            this.CamImageBox.Size = new System.Drawing.Size(900, 600);
            this.CamImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CamImageBox.TabIndex = 2;
            this.CamImageBox.TabStop = false;
            // 
            // selectedCamera
            // 
            this.selectedCamera.AutoSize = true;
            this.selectedCamera.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCamera.Location = new System.Drawing.Point(472, 645);
            this.selectedCamera.Name = "selectedCamera";
            this.selectedCamera.Size = new System.Drawing.Size(127, 25);
            this.selectedCamera.TabIndex = 7;
            this.selectedCamera.Text = "Select Camera:";
            // 
            // CameraCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.selectedCamera);
            this.Controls.Add(this.CamImageBox);
            this.Controls.Add(this.captionText);
            this.Controls.Add(this.cbCamIndex);
            this.Controls.Add(this.btnStart);
            this.Name = "CameraCapture";
            this.Text = "Camera Output";
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;

        //Combo Box to choose the number of cameras to capture
        private System.Windows.Forms.ComboBox cbCamIndex;
        private System.Windows.Forms.TextBox captionText;

        //access to the EMGU.CV.UI-type image box (quite in similarity to PictureBox of Windows.Forms)
        private Emgu.CV.UI.ImageBox CamImageBox;
        private System.Windows.Forms.Label selectedCamera;
    }
}

