using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisioForge.Types.OutputFormat;

namespace WindowsRobotControl
{
    internal class ScreenUtil
    {
        Form1 form1;
        public ScreenUtil (Form1 form1 ) {
            this.form1 = form1; 
        }
        public  void checkScreenShot()
        {
            try
            {
                string folderPath = @"C:\snapshots";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                string folderPath1 = @"C:\snapshots\Screenshots";
                if (!Directory.Exists(folderPath1))
                {
                    Directory.CreateDirectory(folderPath1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                // Get the application window's bounds.
                Rectangle appBounds = form1.Bounds;

                // Create a Bitmap object with the size of the application window.
                Bitmap screenshot = new Bitmap(appBounds.Width, appBounds.Height);

                // Capture the screenshot of the application window using a Graphics object.
                using (Graphics graphics = Graphics.FromImage(screenshot))
                {
                    graphics.CopyFromScreen(appBounds.Location, new Point(0, 0), appBounds.Size);
                }

                // Get the file path to save the screenshot (let's save it on the desktop for example).
                string desktopPath = @"C:\snapshots\Screenshots";
                string fileName = "screenshot_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";
                string filePath = System.IO.Path.Combine(desktopPath, fileName);

                // Save the screenshot to the file.
                screenshot.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

                // Notify the user.
                MessageBox.Show("Application screen was successfully saved:\n" + filePath, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Show a warning message in case of an error.
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void initScreenRecord()
        {
            try
            {
             
                string folderPath = @"C:\snapshots";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                string folderPath1 = @"C:\snapshots\Video_Records";
                if (!Directory.Exists(folderPath1))
                {
                    Directory.CreateDirectory(folderPath1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            form1.videoCapture1.Screen_Capture_Source = new VisioForge.Types.Sources.ScreenCaptureSourceSettings() { FullScreen = true };

            form1.videoCapture1.Audio_PlayAudio = form1.videoCapture1.Audio_RecordAudio = true;


            form1.videoCapture1.Output_Format = new VFMP4HWOutput();
            form1.videoCapture1.Output_Filename = @"C:\snapshots\Video_Records" + "\\output " + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".mp4";

            form1.videoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.ScreenCapture;
            


        }

        public void openGallery()
        {
            try
            {
                string folderPath = @"C:\snapshots";
                if (Directory.Exists(folderPath))
                {
                    Process.Start(folderPath);
                }
                else
                {
                    MessageBox.Show("Folder not found: " + folderPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
