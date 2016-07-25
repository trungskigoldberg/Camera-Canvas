using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

//MARK: Check out the designer and its code to see the initialization of UI controls
namespace CameraCaptureWithHAARCascade
{
    public partial class CameraCapture : Form
    {
        //Capture obj to capture the image/video from the system camera as its frames
        private Capture capture;
        //private bool captureInProgress;
        private HaarCascade haar;           //the Viola-Jones detector
        int totalFaces; 

        public CameraCapture()
        {
            InitializeComponent();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            Image<Bgr, Byte> ImageFrame = capture.QueryFrame();

            #region
            //convert the frame into grayscale after safely checking if it's non=null
            if (ImageFrame  != null) 
            {
                Image<Gray, Byte> grayFrame = ImageFrame.Convert<Gray, Byte>();
                //create the HAAR facial detector matrix based on 
                //HAAR object, precision factor, min neighbor points in the detector path,
                //HAAR detection type, and  choosen rectangle detector path
                var facesDetected = grayFrame.DetectHaarCascade(haar, 1.5, 4,
                    Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, 
                    new Size(25, 25))[0];

                //iterate through each points in the matrix to draw the path 
                foreach (var face in facesDetected)
                {
                    Rectangle rect = face.rect;
                    ImageFrame.Draw(rect, new Bgr(Color.Green), 3);
                }    
                CamImageBox.Image = ImageFrame; //display the image 
                totalFaces = facesDetected.Length;
            }
            #endregion
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void caption_TextChanged(object sender, EventArgs e)
        { 
        }

        private void cbCamIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set the camera number to the one selected via comsbo 
         int camnumber = 0;
           camnumber = int.Parse(cbCamIndex.Text);

            //start the camera with the selected number 
            if (capture == null) {
                try
                {
                    capture = new Capture(camnumber);
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }

            //start showing the stream from camera
            btnStart_Click(sender, e);
            btnStart.Enabled = true;   //enable the button for pause/resume
            //MessageBox.Show("The total faces: " + totalFaces.ToString());
            totalFaceNum.Text = totalFaces.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            #region if capture is not created, create it now
            //if (capture != null)
            //{
            //    //if the button is paused, then resume it 
            //    if (btnStart.Text == "Pause")
            //    {
            //        btnStart.Text = "Resume";
            //        Application.Idle -= ProcessFrame; //hold the capture 
            //    }
            //    else //otherwise, pause it 
            //    {
            //        btnStart.Text = "Pause";
            //        Application.Idle += ProcessFrame;
            //    }
            //} 
            #endregion
            if (capture != null)
            { 
                if (btnStart.Text == "Pause")
                {
                    btnStart.Text = "Resume";
                    Application.Idle -= ProcessFrame;
                }
                else
                {
                    btnStart.Text = "Pause";
                    Application.Idle += ProcessFrame;
                }
            }
        }

        //safely take care of closing the application 
        private void ReleaseData()
        {
            if (capture != null)
            {
                capture.Dispose();
            }
        }

        //load the HAAR cascade in the app interface
        private void CameraCapture_Load(object sender, EventArgs e)
        {
            haar = new HaarCascade("haarcascade_frontalface_alt_tree.xml");
        }

        private void selectedCamera_Click(object sender, EventArgs e)
        {

        }
    }
}