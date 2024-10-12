namespace Anugraha_Construction
{
    partial class ac_app
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ac_app));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            clientname = new TextBox();
            clientno = new TextBox();
            projectName = new TextBox();
            panel1 = new Panel();
            proDate = new TextBox();
            locationbox = new TextBox();
            searchbutton = new Button();
            searchbox = new TextBox();
            readbutton = new Button();
            firm_card = new PictureBox();
            deletebutton = new Button();
            completed = new RadioButton();
            updatebutton = new Button();
            progressButton = new RadioButton();
            createbutton = new Button();
            label7 = new Label();
            datashow = new DataGridView();
            notifyIcon1 = new NotifyIcon(components);
            pictureBox1 = new PictureBox();
            notifyIcon2 = new NotifyIcon(components);
            caed = new FolderBrowserDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)firm_card).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datashow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(859, 98);
            label2.Name = "label2";
            label2.Size = new Size(203, 45);
            label2.TabIndex = 1;
            label2.Text = "Client Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(826, 221);
            label3.Name = "label3";
            label3.Size = new Size(273, 45);
            label3.TabIndex = 2;
            label3.Text = "Client Phone No.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(1034, 355);
            label4.Name = "label4";
            label4.Size = new Size(393, 45);
            label4.TabIndex = 3;
            label4.Text = "Construction Description";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(1803, 98);
            label5.Name = "label5";
            label5.Size = new Size(148, 45);
            label5.TabIndex = 4;
            label5.Text = "Location";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(1827, 205);
            label6.Name = "label6";
            label6.Size = new Size(111, 45);
            label6.TabIndex = 5;
            label6.Text = "Status";
            // 
            // clientname
            // 
            clientname.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientname.Location = new Point(1111, 98);
            clientname.Name = "clientname";
            clientname.Size = new Size(535, 57);
            clientname.TabIndex = 7;
            // 
            // clientno
            // 
            clientno.Font = new Font("Segoe UI", 12F);
            clientno.Location = new Point(1111, 216);
            clientno.Name = "clientno";
            clientno.Size = new Size(535, 50);
            clientno.TabIndex = 8;
            // 
            // projectName
            // 
            projectName.Font = new Font("Segoe UI", 12F);
            projectName.Location = new Point(842, 429);
            projectName.Multiline = true;
            projectName.Name = "projectName";
            projectName.Size = new Size(804, 173);
            projectName.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(proDate);
            panel1.Controls.Add(locationbox);
            panel1.Controls.Add(searchbutton);
            panel1.Controls.Add(searchbox);
            panel1.Controls.Add(readbutton);
            panel1.Controls.Add(firm_card);
            panel1.Controls.Add(deletebutton);
            panel1.Controls.Add(completed);
            panel1.Controls.Add(updatebutton);
            panel1.Controls.Add(progressButton);
            panel1.Controls.Add(createbutton);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(projectName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(clientno);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(clientname);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Cursor = Cursors.Hand;
            panel1.Font = new Font("Segoe UI", 12F);
            panel1.Location = new Point(-12, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(2844, 783);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // proDate
            // 
            proDate.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            proDate.Location = new Point(2050, 315);
            proDate.Name = "proDate";
            proDate.Size = new Size(535, 57);
            proDate.TabIndex = 20;
            // 
            // locationbox
            // 
            locationbox.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            locationbox.Location = new Point(2050, 98);
            locationbox.Name = "locationbox";
            locationbox.Size = new Size(535, 57);
            locationbox.TabIndex = 19;
            // 
            // searchbutton
            // 
            searchbutton.BackColor = SystemColors.HotTrack;
            searchbutton.Font = new Font("Segoe UI", 12F);
            searchbutton.ForeColor = SystemColors.InactiveCaption;
            searchbutton.Location = new Point(228, 525);
            searchbutton.Name = "searchbutton";
            searchbutton.Size = new Size(271, 65);
            searchbutton.TabIndex = 18;
            searchbutton.Text = "SEARCH";
            searchbutton.UseVisualStyleBackColor = false;
            searchbutton.Click += searchbutton_Click;
            // 
            // searchbox
            // 
            searchbox.BackColor = SystemColors.GradientInactiveCaption;
            searchbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchbox.Location = new Point(50, 403);
            searchbox.Name = "searchbox";
            searchbox.PlaceholderText = " Search Project by Client / Project Name";
            searchbox.Size = new Size(692, 50);
            searchbox.TabIndex = 16;
            searchbox.TextChanged += searchbox_TextChanged;
            // 
            // readbutton
            // 
            readbutton.BackColor = SystemColors.ActiveCaption;
            readbutton.Font = new Font("Segoe UI", 12F);
            readbutton.Location = new Point(2346, 496);
            readbutton.Name = "readbutton";
            readbutton.Size = new Size(243, 65);
            readbutton.TabIndex = 12;
            readbutton.Text = "READ";
            readbutton.UseVisualStyleBackColor = false;
            // 
            // firm_card
            // 
            firm_card.BackgroundImageLayout = ImageLayout.None;
            firm_card.Image = (Image)resources.GetObject("firm_card.Image");
            firm_card.Location = new Point(50, 72);
            firm_card.Name = "firm_card";
            firm_card.Size = new Size(692, 260);
            firm_card.TabIndex = 16;
            firm_card.TabStop = false;
            firm_card.Click += pictureBox1_Click;
            // 
            // deletebutton
            // 
            deletebutton.BackColor = Color.IndianRed;
            deletebutton.Font = new Font("Segoe UI", 12F);
            deletebutton.ForeColor = SystemColors.ButtonHighlight;
            deletebutton.Location = new Point(2346, 588);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(239, 63);
            deletebutton.TabIndex = 14;
            deletebutton.Text = "DELETE";
            deletebutton.UseVisualStyleBackColor = false;
            deletebutton.Click += deletebutton_Click;
            // 
            // completed
            // 
            completed.AutoSize = true;
            completed.BackColor = Color.Transparent;
            completed.Font = new Font("Segoe UI", 12F);
            completed.ForeColor = SystemColors.ControlLightLight;
            completed.Location = new Point(2346, 205);
            completed.Name = "completed";
            completed.Size = new Size(209, 49);
            completed.TabIndex = 14;
            completed.TabStop = true;
            completed.Text = "Completed";
            completed.UseVisualStyleBackColor = false;
            // 
            // updatebutton
            // 
            updatebutton.BackColor = Color.Khaki;
            updatebutton.Font = new Font("Segoe UI", 12F);
            updatebutton.Location = new Point(2009, 586);
            updatebutton.Name = "updatebutton";
            updatebutton.Size = new Size(239, 65);
            updatebutton.TabIndex = 13;
            updatebutton.Text = "UPDATE";
            updatebutton.UseVisualStyleBackColor = false;
            updatebutton.Click += button3_Click;
            // 
            // progressButton
            // 
            progressButton.AutoSize = true;
            progressButton.BackColor = Color.Transparent;
            progressButton.Font = new Font("Segoe UI", 12F);
            progressButton.ForeColor = SystemColors.ControlLightLight;
            progressButton.Location = new Point(2063, 205);
            progressButton.Name = "progressButton";
            progressButton.Size = new Size(214, 49);
            progressButton.TabIndex = 13;
            progressButton.TabStop = true;
            progressButton.Text = "In-Progress";
            progressButton.UseVisualStyleBackColor = false;
            progressButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // createbutton
            // 
            createbutton.BackColor = Color.MediumSeaGreen;
            createbutton.Font = new Font("Segoe UI", 12F);
            createbutton.ForeColor = SystemColors.ButtonHighlight;
            createbutton.Location = new Point(2009, 496);
            createbutton.Name = "createbutton";
            createbutton.Size = new Size(239, 65);
            createbutton.TabIndex = 11;
            createbutton.Text = "CREATE";
            createbutton.UseVisualStyleBackColor = false;
            createbutton.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(1746, 315);
            label7.Name = "label7";
            label7.Size = new Size(267, 45);
            label7.TabIndex = 11;
            label7.Text = "Project Deadline";
            label7.Click += label7_Click;
            // 
            // datashow
            // 
            datashow.BackgroundColor = SystemColors.GradientActiveCaption;
            datashow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datashow.Cursor = Cursors.Hand;
            datashow.Location = new Point(38, 904);
            datashow.Name = "datashow";
            datashow.RowHeadersWidth = 82;
            datashow.Size = new Size(2735, 985);
            datashow.TabIndex = 15;
            datashow.CellContentClick += dataGridView1_CellContentClick;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1422, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 52);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // notifyIcon2
            // 
            notifyIcon2.Text = "notifyIcon2";
            notifyIcon2.Visible = true;
            // 
            // caed
            // 
            caed.Description = "Choose Document";
            caed.SelectedPath = "C:\\Users\\Nikshep M P\\OneDrive\\Desktop";
            caed.Tag = "caed";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "CHOOSE FILE";
            // 
            // ac_app
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(2807, 1422);
            Controls.Add(pictureBox1);
            Controls.Add(datashow);
            Controls.Add(panel1);
            Cursor = Cursors.SizeAll;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ac_app";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anugraha_Construction";
            WindowState = FormWindowState.Minimized;
            Load += ac_app_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)firm_card).EndInit();
            ((System.ComponentModel.ISupportInitialize)datashow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox clientname;
        private TextBox clientno;
        private TextBox projectName;
        private Panel panel1;
        private RadioButton completed;
        private RadioButton progressButton;
        private Label label7;
        private Button createbutton;
        private Button readbutton;
        private Button updatebutton;
        private Button deletebutton;
        private DataGridView datashow;
        private NotifyIcon notifyIcon1;
        private PictureBox firm_card;
        private TextBox searchbox;
        private Button searchbutton;
        private PictureBox pictureBox1;
        private NotifyIcon notifyIcon2;
        private TextBox locationbox;
        private TextBox proDate;
        private FolderBrowserDialog caed;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
    }
}
