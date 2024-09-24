namespace Lab3
{
    partial class fMain
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
            tbCamerasInfo = new TextBox();
            btnAddCamera = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // tbCamerasInfo
            // 
            tbCamerasInfo.Location = new Point(12, 12);
            tbCamerasInfo.Multiline = true;
            tbCamerasInfo.Name = "tbCamerasInfo";
            tbCamerasInfo.ReadOnly = true;
            tbCamerasInfo.Size = new Size(617, 426);
            tbCamerasInfo.TabIndex = 0;
            // 
            // btnAddCamera
            // 
            btnAddCamera.Location = new Point(635, 12);
            btnAddCamera.Name = "btnAddCamera";
            btnAddCamera.Size = new Size(153, 29);
            btnAddCamera.TabIndex = 1;
            btnAddCamera.Text = "Додати камеру";
            btnAddCamera.UseVisualStyleBackColor = true;
            btnAddCamera.Click += btnAddCamera_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(635, 409);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(153, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Закрити";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnAddCamera);
            Controls.Add(tbCamerasInfo);
            MaximizeBox = false;
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота №3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbCamerasInfo;
        private Button btnAddCamera;
        private Button btnClose;
    }
}
