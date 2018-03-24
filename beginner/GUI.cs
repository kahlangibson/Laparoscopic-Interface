using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;

namespace cam_aforge1
{
    public partial class GUI : Form
    {
        private bool DeviceExist = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource = null;
        GUIElements myCanvas;

        int tickCount = 0;

        //Constructs the gui
        public GUI()
        {
            myCanvas = new GUIElements(this);
            InitializeComponent();
            //Add custom events here, ie
            //viewFinder.MouseDown += new MouseEventHandler(viewFinder_MouseDown);
        }

        //Generally don't have to change this
        private void getCamList()
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                vidSrc.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
                foreach (FilterInfo device in videoDevices)
                {
                    vidSrc.Items.Add(device.Name);
                }
                vidSrc.SelectedIndex = 0; //make dafault to first cam
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
                vidSrc.Items.Add("No capture device on your system");
            }
        }

        //Generally don't have to change this
        private void rfsh_Click(object sender, EventArgs e)
        {
            getCamList();
        }

        //Generally don't have to change this
        private void start_Click(object sender, EventArgs e)
        {
            if (start.Text == "&Start")
            {
                if (DeviceExist)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[vidSrc.SelectedIndex].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                    CloseVideoSource();
                    videoSource.DesiredFrameSize = new Size(160, 120);
                    //videoSource.DesiredFrameRate = 10;
                    videoSource.Start();
                    label2.Text = "Device running...";
                    start.Text = "&Stop";
                    timer1.Enabled = true;
                    
                }
                else
                {
                    label2.Text = "Error: No Device selected.";
                }
            }
            else
            {
                if (videoSource.IsRunning)
                {
                    timer1.Enabled = false;
                    CloseVideoSource();
                    label2.Text = "Device stopped.";
                    start.Text = "&Start";                    
                }
            }
        }

        //Generally don't have to change this
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            
            myCanvas.g = Graphics.FromImage(img);
            myCanvas.Run();
            
            viewFinder.Image = img;
            myCanvas.g.Dispose();
        }

        //Generally don't have to change this
        private void CloseVideoSource()
        {
            if (!(videoSource == null))
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource = null;
                }
        }

        //Generally don't have to change this
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "Device running... " + videoSource.FramesReceived.ToString() + " FPS";
        }

        //Generally don't have to change this
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseVideoSource();
        }
        
        //Button for changing camera control
        private void ctrl_Click(object sender, EventArgs e)
        {
            CamControl.show_Controls();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Step 7: Let's activate this button. Uncomment lines 143-144 to add functionality
            //to the button.
            tickCount++;
            countDisp.Text = tickCount.ToString();

            //Step 8: The button_Click method can be used to call a method that you wrote
            //on the GUIElements Class. Uncomment line 149 to call the ButtonWasClicked method
            //from GUIElements.
            myCanvas.ButtonWasClicked();

            //Note that the syntax for calling methods in the GUIElements class is always in the form of
            //`myCanvas.NameOfMethod();`.
        }

        private void viewFinder_Click(object sender, EventArgs e)
        {
            //myCanvas.UpdatePosition(e.X, e.Y);
        }

        private void viewFinder_FindClick(object sender, MouseEventArgs e)
        {
            myCanvas.UpdatePosition(e.X, e.Y);
        }
    }
}