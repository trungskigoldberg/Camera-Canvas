using System;
using CameraCaptureWithHAARCascade;

namespace CameraCanvas.Toolbox
{
    public partial class CameraCCButton : CCButton
    {
        public CameraCCButton(CCToolbar ccToolBar)
            :base(ccToolBar, "&Camera", "Camera", "Icons/Photo.png")
        {
            this.Click += new EventHandler(CameraCCButton_Click);
        }

        void CameraCCButton_Click(object sender, EventArgs e)
        {
            CameraCapture cc = new CameraCapture();
            cc.ShowDialog();
        }


    }
}
