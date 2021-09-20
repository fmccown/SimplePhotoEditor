using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PhotoEditorSimple
{
    public partial class MainForm : Form
    {
        private string photoRootDirectory;
        private List<FileInfo> photoFiles;

        public MainForm()
        {
            InitializeComponent();

            photoRootDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            photoDirLabel.Text = photoRootDirectory;

            PopulateImageList();
        }

        private void PopulateImageList()
        {
            photoFiles = new List<FileInfo>();

            DirectoryInfo homeDir = new DirectoryInfo(photoRootDirectory);
            foreach (FileInfo file in homeDir.GetFiles("*.jpg"))
            {
                photoFiles.Add(file);
            }

            photoListComboBox.Items.AddRange(photoFiles.ToArray());
        }

        private void photoListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedFile = (FileInfo) photoListComboBox.SelectedItem;
            photoPictureBox.Image = LoadImage(selectedFile.FullName);
        }

        private Image LoadImage(string filename)
        {
            // Use this method to load images so the image files do not remain locked
            byte[] bytes = File.ReadAllBytes(filename);
            MemoryStream ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }

        private void transformButton_Click(object sender, EventArgs e)
        {
            var transformedBitmap = new Bitmap(photoPictureBox.Image);

            // This could take a long time... should be done in a thread
            InvertColors(transformedBitmap);

            photoPictureBox.Image = transformedBitmap;
        }

        // Inverts each pixel
        private void InvertColors(Bitmap transformedBitmap)
        {
            for (int y = 0; y < transformedBitmap.Height; y++)
            {
                for (int x = 0; x < transformedBitmap.Width; x++)
                {
                    var color = transformedBitmap.GetPixel(x, y);
                    int newRed = Math.Abs(color.R - 255);
                    int newGreen = Math.Abs(color.G - 255);
                    int newBlue = Math.Abs(color.B - 255);
                    Color newColor = Color.FromArgb(newRed, newGreen, newBlue);
                    transformedBitmap.SetPixel(x, y, newColor);
                }
            }
        }

        // Tints image with chosen color
        private void AlterColors(Bitmap transformedBitmap, Color chosenColor)
        {
            for (int y = 0; y < transformedBitmap.Height; y++)
            {
                for (int x = 0; x < transformedBitmap.Width; x++)
                {
                    var color = transformedBitmap.GetPixel(x, y);
                    int ave = (color.R + color.G + color.B) / 3;
                    double percent = ave / 255.0;
                    int newRed = Convert.ToInt32(chosenColor.R * percent);
                    int newGreen = Convert.ToInt32(chosenColor.G * percent);
                    int newBlue = Convert.ToInt32(chosenColor.B * percent);
                    var newColor = Color.FromArgb(newRed, newGreen, newBlue);
                    transformedBitmap.SetPixel(x, y, newColor);
                }
            }
        }

        // brightness is a value between 0 – 100. Values < 50 makes the image darker, > 50 makes lighter
        private void ChangeBrightness(Bitmap transformedBitmap, int brightness)
        {
            // Calculate amount to change RGB
            int amount = Convert.ToInt32(2 * (50 - brightness) * 0.01 * 255);
            for (int y = 0; y < transformedBitmap.Height; y++)
            {
                for (int x = 0; x < transformedBitmap.Width; x++)
                {
                    var color = transformedBitmap.GetPixel(x, y);
                    int newRed = Math.Max(0, Math.Min(color.R - amount, 255));
                    int newGreen = Math.Max(0, Math.Min(color.G - amount, 255));
                    int newBlue = Math.Max(0, Math.Min(color.B - amount, 255));
                    var newColor = Color.FromArgb(newRed, newGreen, newBlue);
                    transformedBitmap.SetPixel(x, y, newColor);
                }
            }
        }
    }
}
