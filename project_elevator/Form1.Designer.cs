namespace project_elevator
{
    partial class Form1
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
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            open_timer = new System.Windows.Forms.Timer(components);
            close_timer = new System.Windows.Forms.Timer(components);
            up_timer = new System.Windows.Forms.Timer(components);
            down_timer = new System.Windows.Forms.Timer(components);
            btn5 = new Button();
            btn6 = new Button();
            fifth_timer = new System.Windows.Forms.Timer(components);
            sixth_timer = new System.Windows.Forms.Timer(components);
            dataGridView1 = new DataGridView();
            btn7 = new Button();
            btn8 = new Button();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.door;
            pictureBox3.Location = new Point(94, 364);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 201);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.door;
            pictureBox4.Location = new Point(151, 364);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 201);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.door;
            pictureBox1.Location = new Point(94, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.ev11;
            pictureBox5.InitialImage = Properties.Resources.elv2;
            pictureBox5.Location = new Point(96, 364);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(108, 201);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.door;
            pictureBox2.Location = new Point(151, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 201);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.back1;
            pictureBox6.Location = new Point(83, 55);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(137, 207);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.back1;
            pictureBox7.Location = new Point(83, 358);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(137, 207);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // btn1
            // 
            btn1.Location = new Point(350, 201);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 29);
            btn1.TabIndex = 7;
            btn1.Text = "Open";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(350, 236);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 29);
            btn2.TabIndex = 8;
            btn2.Text = "Close";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(350, 413);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 29);
            btn3.TabIndex = 9;
            btn3.Text = "1";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(350, 448);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 29);
            btn4.TabIndex = 10;
            btn4.Text = "0";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // open_timer
            // 
            open_timer.Interval = 30;
            open_timer.Tick += open_timer_Tick;
            // 
            // close_timer
            // 
            close_timer.Interval = 30;
            close_timer.Tick += close_timer_Tick;
            // 
            // up_timer
            // 
            up_timer.Interval = 10;
            up_timer.Tick += up_timer_Tick;
            // 
            // down_timer
            // 
            down_timer.Interval = 10;
            down_timer.Tick += down_timer_Tick;
            // 
            // btn5
            // 
            btn5.Location = new Point(650, 49);
            btn5.Name = "btn5";
            btn5.Size = new Size(94, 29);
            btn5.TabIndex = 11;
            btn5.Text = "Clear log";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(845, 49);
            btn6.Name = "btn6";
            btn6.Size = new Size(94, 29);
            btn6.TabIndex = 12;
            btn6.Text = "Exit";
            btn6.UseVisualStyleBackColor = true;
            // 
            // fifth_timer
            // 
            fifth_timer.Interval = 3000;
            fifth_timer.Tick += fifth_timer_Tick;
            // 
            // sixth_timer
            // 
            sixth_timer.Interval = 3000;
            sixth_timer.Tick += sixth_timer_Tick;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(542, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(612, 481);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn7
            // 
            btn7.Image = Properties.Resources.down_image;
            btn7.Location = new Point(239, 166);
            btn7.Name = "btn7";
            btn7.Size = new Size(59, 48);
            btn7.TabIndex = 14;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Image = Properties.Resources.up_image1;
            btn8.Location = new Point(239, 422);
            btn8.Name = "btn8";
            btn8.Size = new Size(59, 49);
            btn8.TabIndex = 15;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.bb;
            pictureBox8.Location = new Point(350, 293);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(108, 89);
            pictureBox8.TabIndex = 16;
            pictureBox8.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 664);
            Controls.Add(pictureBox8);
            Controls.Add(dataGridView1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Name = "Form1";
            Text = "Elevator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private System.Windows.Forms.Timer open_timer;
        private System.Windows.Forms.Timer close_timer;
        private System.Windows.Forms.Timer up_timer;
        private System.Windows.Forms.Timer down_timer;
        private Button btn5;
        private Button btn6;
        private System.Windows.Forms.Timer fifth_timer;
        private System.Windows.Forms.Timer sixth_timer;
        private DataGridView dataGridView1;
        private Button btn7;
        private Button btn8;
        private PictureBox pictureBox8;
    }
}