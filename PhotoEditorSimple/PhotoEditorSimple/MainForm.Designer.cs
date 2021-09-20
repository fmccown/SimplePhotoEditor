
namespace PhotoEditorSimple
{
    partial class MainForm
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
            this.photoListComboBox = new System.Windows.Forms.ComboBox();
            this.photoDirLabel = new System.Windows.Forms.Label();
            this.transformButton = new System.Windows.Forms.Button();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // photoListComboBox
            // 
            this.photoListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.photoListComboBox.FormattingEnabled = true;
            this.photoListComboBox.Location = new System.Drawing.Point(30, 35);
            this.photoListComboBox.Name = "photoListComboBox";
            this.photoListComboBox.Size = new System.Drawing.Size(210, 21);
            this.photoListComboBox.TabIndex = 0;
            this.photoListComboBox.SelectedIndexChanged += new System.EventHandler(this.photoListComboBox_SelectedIndexChanged);
            // 
            // photoDirLabel
            // 
            this.photoDirLabel.AutoSize = true;
            this.photoDirLabel.Location = new System.Drawing.Point(27, 19);
            this.photoDirLabel.Name = "photoDirLabel";
            this.photoDirLabel.Size = new System.Drawing.Size(48, 13);
            this.photoDirLabel.TabIndex = 1;
            this.photoDirLabel.Text = "photo dir";
            // 
            // transformButton
            // 
            this.transformButton.Location = new System.Drawing.Point(270, 33);
            this.transformButton.Name = "transformButton";
            this.transformButton.Size = new System.Drawing.Size(75, 23);
            this.transformButton.TabIndex = 2;
            this.transformButton.Text = "Transform";
            this.transformButton.UseVisualStyleBackColor = true;
            this.transformButton.Click += new System.EventHandler(this.transformButton_Click);
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.photoPictureBox.Location = new System.Drawing.Point(30, 79);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(315, 330);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 3;
            this.photoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.transformButton);
            this.Controls.Add(this.photoDirLabel);
            this.Controls.Add(this.photoListComboBox);
            this.Name = "MainForm";
            this.Text = "Simple Photo Editor";
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox photoListComboBox;
        private System.Windows.Forms.Label photoDirLabel;
        private System.Windows.Forms.Button transformButton;
        private System.Windows.Forms.PictureBox photoPictureBox;
    }
}

