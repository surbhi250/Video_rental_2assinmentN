namespace Video_rental_2assinment
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showpopmovie = new System.Windows.Forms.Button();
            this.customers = new System.Windows.Forms.Button();
            this.show_popcs = new System.Windows.Forms.Button();
            this.videos = new System.Windows.Forms.Button();
            this.Rentals = new System.Windows.Forms.Button();
            this.TableData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.plot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.makers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.video_PRICE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.video_Copies = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpVideo = new System.Windows.Forms.GroupBox();
            this.videoname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.cs_country = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cs_name = new System.Windows.Forms.TextBox();
            this.cs_mob = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cs_age = new System.Windows.Forms.TextBox();
            this.rental_videoid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cs_id = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.IssDate = new System.Windows.Forms.DateTimePicker();
            this.RetrnDate = new System.Windows.Forms.DateTimePicker();
            this.delete_mov = new System.Windows.Forms.Button();
            this.return_mov = new System.Windows.Forms.Button();
            this.issue_mov = new System.Windows.Forms.Button();
            this.lblRentalID = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.btnCustomerDel = new System.Windows.Forms.Button();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableData)).BeginInit();
            this.grpVideo.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showpopmovie);
            this.groupBox2.Controls.Add(this.customers);
            this.groupBox2.Controls.Add(this.show_popcs);
            this.groupBox2.Controls.Add(this.videos);
            this.groupBox2.Controls.Add(this.Rentals);
            this.groupBox2.Controls.Add(this.TableData);
            this.groupBox2.Location = new System.Drawing.Point(447, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 468);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "For Data Showing";
            // 
            // showpopmovie
            // 
            this.showpopmovie.BackColor = System.Drawing.Color.White;
            this.showpopmovie.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpopmovie.Location = new System.Drawing.Point(327, 395);
            this.showpopmovie.Name = "showpopmovie";
            this.showpopmovie.Size = new System.Drawing.Size(142, 35);
            this.showpopmovie.TabIndex = 39;
            this.showpopmovie.Text = "POP Movie";
            this.showpopmovie.UseVisualStyleBackColor = false;
            this.showpopmovie.Click += new System.EventHandler(this.showpopmovie_Click);
            // 
            // customers
            // 
            this.customers.BackColor = System.Drawing.Color.White;
            this.customers.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers.Location = new System.Drawing.Point(6, 427);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(142, 35);
            this.customers.TabIndex = 38;
            this.customers.Text = "Customers";
            this.customers.UseVisualStyleBackColor = false;
            this.customers.Click += new System.EventHandler(this.customers_Click);
            // 
            // show_popcs
            // 
            this.show_popcs.BackColor = System.Drawing.Color.White;
            this.show_popcs.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_popcs.Location = new System.Drawing.Point(166, 427);
            this.show_popcs.Name = "show_popcs";
            this.show_popcs.Size = new System.Drawing.Size(142, 35);
            this.show_popcs.TabIndex = 37;
            this.show_popcs.Text = "Pop customer";
            this.show_popcs.UseVisualStyleBackColor = false;
            this.show_popcs.Click += new System.EventHandler(this.show_popcs_Click);
            // 
            // videos
            // 
            this.videos.BackColor = System.Drawing.Color.White;
            this.videos.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videos.Location = new System.Drawing.Point(6, 376);
            this.videos.Name = "videos";
            this.videos.Size = new System.Drawing.Size(142, 35);
            this.videos.TabIndex = 35;
            this.videos.Text = "Videos";
            this.videos.UseVisualStyleBackColor = false;
            this.videos.Click += new System.EventHandler(this.videos_Click);
            // 
            // Rentals
            // 
            this.Rentals.BackColor = System.Drawing.Color.White;
            this.Rentals.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rentals.Location = new System.Drawing.Point(166, 376);
            this.Rentals.Name = "Rentals";
            this.Rentals.Size = new System.Drawing.Size(142, 35);
            this.Rentals.TabIndex = 34;
            this.Rentals.Text = "Rentals";
            this.Rentals.UseVisualStyleBackColor = false;
            this.Rentals.Click += new System.EventHandler(this.Rentals_Click);
            // 
            // TableData
            // 
            this.TableData.BackgroundColor = System.Drawing.Color.DimGray;
            this.TableData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableData.Location = new System.Drawing.Point(6, 31);
            this.TableData.Name = "TableData";
            this.TableData.Size = new System.Drawing.Size(566, 339);
            this.TableData.TabIndex = 0;
            this.TableData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableData_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Elephant", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(372, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Rental Department";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.White;
            this.add_btn.BackgroundImage = global::Video_rental_2assinment.Properties.Resources.add_button_blue_hi;
            this.add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_btn.Location = new System.Drawing.Point(6, 393);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(122, 42);
            this.add_btn.TabIndex = 0;
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.White;
            this.update_btn.BackgroundImage = global::Video_rental_2assinment.Properties.Resources.update;
            this.update_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update_btn.Location = new System.Drawing.Point(146, 393);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(110, 42);
            this.update_btn.TabIndex = 2;
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(19, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year";
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Location = new System.Drawing.Point(129, 121);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(146, 31);
            this.year.TabIndex = 7;
            this.year.TextChanged += new System.EventHandler(this.year_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(19, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Plot";
            // 
            // plot
            // 
            this.plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plot.Location = new System.Drawing.Point(129, 176);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(146, 31);
            this.plot.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(19, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Makers";
            // 
            // makers
            // 
            this.makers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makers.Location = new System.Drawing.Point(129, 230);
            this.makers.Name = "makers";
            this.makers.Size = new System.Drawing.Size(146, 31);
            this.makers.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(19, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Copies";
            // 
            // video_PRICE
            // 
            this.video_PRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_PRICE.Location = new System.Drawing.Point(129, 278);
            this.video_PRICE.Name = "video_PRICE";
            this.video_PRICE.Size = new System.Drawing.Size(146, 31);
            this.video_PRICE.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(19, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Price";
            // 
            // video_Copies
            // 
            this.video_Copies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_Copies.Location = new System.Drawing.Point(129, 325);
            this.video_Copies.Name = "video_Copies";
            this.video_Copies.Size = new System.Drawing.Size(146, 31);
            this.video_Copies.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Elephant", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(37, -3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "Videos";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Elephant", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(237, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 31);
            this.label9.TabIndex = 18;
            this.label9.Text = "Customers";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // grpVideo
            // 
            this.grpVideo.Controls.Add(this.video_Copies);
            this.grpVideo.Controls.Add(this.label7);
            this.grpVideo.Controls.Add(this.video_PRICE);
            this.grpVideo.Controls.Add(this.label6);
            this.grpVideo.Controls.Add(this.makers);
            this.grpVideo.Controls.Add(this.label5);
            this.grpVideo.Controls.Add(this.plot);
            this.grpVideo.Controls.Add(this.label4);
            this.grpVideo.Controls.Add(this.year);
            this.grpVideo.Controls.Add(this.label3);
            this.grpVideo.Controls.Add(this.videoname);
            this.grpVideo.Controls.Add(this.label2);
            this.grpVideo.Controls.Add(this.update_btn);
            this.grpVideo.Controls.Add(this.delete_btn);
            this.grpVideo.Controls.Add(this.add_btn);
            this.grpVideo.Location = new System.Drawing.Point(12, 49);
            this.grpVideo.Name = "grpVideo";
            this.grpVideo.Size = new System.Drawing.Size(411, 444);
            this.grpVideo.TabIndex = 0;
            this.grpVideo.TabStop = false;
            this.grpVideo.Text = "For Insertation and Updation";
            // 
            // videoname
            // 
            this.videoname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoname.Location = new System.Drawing.Point(129, 65);
            this.videoname.Name = "videoname";
            this.videoname.Size = new System.Drawing.Size(146, 31);
            this.videoname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Video Name";
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.White;
            this.delete_btn.BackgroundImage = global::Video_rental_2assinment.Properties.Resources.delete;
            this.delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_btn.Location = new System.Drawing.Point(274, 393);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(101, 42);
            this.delete_btn.TabIndex = 1;
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // cs_country
            // 
            this.cs_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs_country.Location = new System.Drawing.Point(103, 154);
            this.cs_country.Name = "cs_country";
            this.cs_country.Size = new System.Drawing.Size(146, 31);
            this.cs_country.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(13, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 22);
            this.label16.TabIndex = 25;
            this.label16.Text = "Country";
            // 
            // cs_name
            // 
            this.cs_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs_name.Location = new System.Drawing.Point(101, 25);
            this.cs_name.Name = "cs_name";
            this.cs_name.Size = new System.Drawing.Size(146, 31);
            this.cs_name.TabIndex = 20;
            // 
            // cs_mob
            // 
            this.cs_mob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs_mob.Location = new System.Drawing.Point(101, 105);
            this.cs_mob.Name = "cs_mob";
            this.cs_mob.Size = new System.Drawing.Size(146, 31);
            this.cs_mob.TabIndex = 24;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(13, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 22);
            this.label19.TabIndex = 19;
            this.label19.Text = "Name";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(6, 111);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 22);
            this.label17.TabIndex = 23;
            this.label17.Text = "Contact";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(13, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 22);
            this.label18.TabIndex = 21;
            this.label18.Text = "Age";
            // 
            // cs_age
            // 
            this.cs_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs_age.Location = new System.Drawing.Point(101, 65);
            this.cs_age.Name = "cs_age";
            this.cs_age.Size = new System.Drawing.Size(146, 31);
            this.cs_age.TabIndex = 22;
            // 
            // rental_videoid
            // 
            this.rental_videoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rental_videoid.Location = new System.Drawing.Point(213, 559);
            this.rental_videoid.Name = "rental_videoid";
            this.rental_videoid.Size = new System.Drawing.Size(146, 31);
            this.rental_videoid.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(103, 556);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Video ID";
            // 
            // cs_id
            // 
            this.cs_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs_id.Location = new System.Drawing.Point(517, 568);
            this.cs_id.Name = "cs_id";
            this.cs_id.Size = new System.Drawing.Size(146, 31);
            this.cs_id.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(392, 565);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 22);
            this.label13.TabIndex = 23;
            this.label13.Text = "Customer ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(688, 625);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 22);
            this.label14.TabIndex = 28;
            this.label14.Text = "ReturnDate";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(700, 568);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 22);
            this.label15.TabIndex = 27;
            this.label15.Text = "IssueDate";
            // 
            // IssDate
            // 
            this.IssDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IssDate.Location = new System.Drawing.Point(833, 570);
            this.IssDate.Name = "IssDate";
            this.IssDate.Size = new System.Drawing.Size(166, 20);
            this.IssDate.TabIndex = 29;
            // 
            // RetrnDate
            // 
            this.RetrnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RetrnDate.Location = new System.Drawing.Point(833, 627);
            this.RetrnDate.Name = "RetrnDate";
            this.RetrnDate.Size = new System.Drawing.Size(166, 20);
            this.RetrnDate.TabIndex = 30;
            // 
            // delete_mov
            // 
            this.delete_mov.BackColor = System.Drawing.Color.White;
            this.delete_mov.BackgroundImage = global::Video_rental_2assinment.Properties.Resources.delete;
            this.delete_mov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_mov.Location = new System.Drawing.Point(669, 665);
            this.delete_mov.Name = "delete_mov";
            this.delete_mov.Size = new System.Drawing.Size(101, 42);
            this.delete_mov.TabIndex = 19;
            this.delete_mov.UseVisualStyleBackColor = false;
            this.delete_mov.Click += new System.EventHandler(this.delete_mov_Click);
            // 
            // return_mov
            // 
            this.return_mov.BackColor = System.Drawing.Color.White;
            this.return_mov.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_mov.Location = new System.Drawing.Point(486, 669);
            this.return_mov.Name = "return_mov";
            this.return_mov.Size = new System.Drawing.Size(142, 35);
            this.return_mov.TabIndex = 31;
            this.return_mov.Text = "Return";
            this.return_mov.UseVisualStyleBackColor = false;
            this.return_mov.Click += new System.EventHandler(this.return_mov_Click);
            // 
            // issue_mov
            // 
            this.issue_mov.BackColor = System.Drawing.Color.White;
            this.issue_mov.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_mov.Location = new System.Drawing.Point(326, 669);
            this.issue_mov.Name = "issue_mov";
            this.issue_mov.Size = new System.Drawing.Size(142, 35);
            this.issue_mov.TabIndex = 32;
            this.issue_mov.Text = "Issue";
            this.issue_mov.UseVisualStyleBackColor = false;
            this.issue_mov.Click += new System.EventHandler(this.issue_mov_Click);
            // 
            // lblRentalID
            // 
            this.lblRentalID.AutoSize = true;
            this.lblRentalID.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRentalID.Location = new System.Drawing.Point(277, 512);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new System.Drawing.Size(0, 22);
            this.lblRentalID.TabIndex = 33;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.btnCustomerDel);
            this.grpCustomer.Controls.Add(this.btnCustomerUpdate);
            this.grpCustomer.Controls.Add(this.btnCustomerAdd);
            this.grpCustomer.Controls.Add(this.cs_country);
            this.grpCustomer.Controls.Add(this.label19);
            this.grpCustomer.Controls.Add(this.label16);
            this.grpCustomer.Controls.Add(this.cs_name);
            this.grpCustomer.Controls.Add(this.label18);
            this.grpCustomer.Controls.Add(this.cs_age);
            this.grpCustomer.Controls.Add(this.cs_mob);
            this.grpCustomer.Controls.Add(this.label17);
            this.grpCustomer.Location = new System.Drawing.Point(30, 62);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(274, 284);
            this.grpCustomer.TabIndex = 34;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customers";
            // 
            // btnCustomerDel
            // 
            this.btnCustomerDel.BackColor = System.Drawing.Color.White;
            this.btnCustomerDel.BackgroundImage = global::Video_rental_2assinment.Properties.Resources.delete;
            this.btnCustomerDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomerDel.Location = new System.Drawing.Point(66, 233);
            this.btnCustomerDel.Name = "btnCustomerDel";
            this.btnCustomerDel.Size = new System.Drawing.Size(101, 42);
            this.btnCustomerDel.TabIndex = 16;
            this.btnCustomerDel.UseVisualStyleBackColor = false;
            this.btnCustomerDel.Click += new System.EventHandler(this.btnCustomerDel_Click);
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.BackColor = System.Drawing.Color.White;
            this.btnCustomerUpdate.BackgroundImage = global::Video_rental_2assinment.Properties.Resources.update;
            this.btnCustomerUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomerUpdate.Location = new System.Drawing.Point(117, 191);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(87, 36);
            this.btnCustomerUpdate.TabIndex = 16;
            this.btnCustomerUpdate.UseVisualStyleBackColor = false;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.BackColor = System.Drawing.Color.White;
            this.btnCustomerAdd.BackgroundImage = global::Video_rental_2assinment.Properties.Resources.add_button_blue_hi;
            this.btnCustomerAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomerAdd.Location = new System.Drawing.Point(10, 191);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(89, 36);
            this.btnCustomerAdd.TabIndex = 16;
            this.btnCustomerAdd.UseVisualStyleBackColor = false;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1037, 709);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.lblRentalID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.issue_mov);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.return_mov);
            this.Controls.Add(this.delete_mov);
            this.Controls.Add(this.RetrnDate);
            this.Controls.Add(this.IssDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cs_id);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rental_videoid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpVideo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableData)).EndInit();
            this.grpVideo.ResumeLayout(false);
            this.grpVideo.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView TableData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showpopmovie;
        private System.Windows.Forms.Button customers;
        private System.Windows.Forms.Button show_popcs;
        private System.Windows.Forms.Button videos;
        private System.Windows.Forms.Button Rentals;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox plot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox makers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox video_PRICE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox video_Copies;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpVideo;
        private System.Windows.Forms.TextBox cs_country;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox cs_name;
        private System.Windows.Forms.TextBox cs_mob;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox cs_age;
        private System.Windows.Forms.TextBox videoname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rental_videoid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cs_id;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker IssDate;
        private System.Windows.Forms.DateTimePicker RetrnDate;
        private System.Windows.Forms.Button delete_mov;
        private System.Windows.Forms.Button return_mov;
        private System.Windows.Forms.Button issue_mov;
        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Button btnCustomerDel;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Button delete_btn;
    }
}

