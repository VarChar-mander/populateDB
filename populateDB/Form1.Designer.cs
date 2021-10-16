namespace populateDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.productInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sweetBox = new System.Windows.Forms.ComboBox();
            this.saltBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.crunchBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sourBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hotbox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cheesyBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.porkBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.beefBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chickenBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sugaryBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.spiceBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.coldBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.frozenBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.bakedBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dinnerBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lunchBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.breakfastBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.vegBox = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.chewBox = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.coldDrink = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.hotDrink = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.bitterBox = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.softBox = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.snackBox = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.meatBox = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.fruitBox = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productInput
            // 
            this.productInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInput.ForeColor = System.Drawing.Color.Green;
            this.productInput.Location = new System.Drawing.Point(338, 38);
            this.productInput.Name = "productInput";
            this.productInput.Size = new System.Drawing.Size(177, 20);
            this.productInput.TabIndex = 0;
            this.productInput.Text = "Enter Product Name";
            this.productInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.productInput.Click += new System.EventHandler(this.productInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Food Product to be rated";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sweet:";
            // 
            // sweetBox
            // 
            this.sweetBox.FormattingEnabled = true;
            this.sweetBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.sweetBox.Location = new System.Drawing.Point(73, 79);
            this.sweetBox.Name = "sweetBox";
            this.sweetBox.Size = new System.Drawing.Size(71, 21);
            this.sweetBox.TabIndex = 3;
            this.sweetBox.Text = "0";
            // 
            // saltBox
            // 
            this.saltBox.FormattingEnabled = true;
            this.saltBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.saltBox.Location = new System.Drawing.Point(73, 125);
            this.saltBox.Name = "saltBox";
            this.saltBox.Size = new System.Drawing.Size(71, 21);
            this.saltBox.TabIndex = 5;
            this.saltBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salty:";
            // 
            // crunchBox
            // 
            this.crunchBox.FormattingEnabled = true;
            this.crunchBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.crunchBox.Location = new System.Drawing.Point(73, 173);
            this.crunchBox.Name = "crunchBox";
            this.crunchBox.Size = new System.Drawing.Size(71, 21);
            this.crunchBox.TabIndex = 7;
            this.crunchBox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Crunchy:";
            // 
            // sourBox
            // 
            this.sourBox.FormattingEnabled = true;
            this.sourBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.sourBox.Location = new System.Drawing.Point(73, 221);
            this.sourBox.Name = "sourBox";
            this.sourBox.Size = new System.Drawing.Size(71, 21);
            this.sourBox.TabIndex = 9;
            this.sourBox.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sour:";
            // 
            // hotbox
            // 
            this.hotbox.FormattingEnabled = true;
            this.hotbox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.hotbox.Location = new System.Drawing.Point(73, 269);
            this.hotbox.Name = "hotbox";
            this.hotbox.Size = new System.Drawing.Size(71, 21);
            this.hotbox.TabIndex = 11;
            this.hotbox.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hot:";
            // 
            // sizeBox
            // 
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.sizeBox.Location = new System.Drawing.Point(235, 267);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(71, 21);
            this.sizeBox.TabIndex = 21;
            this.sizeBox.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(181, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Size:";
            // 
            // cheesyBox
            // 
            this.cheesyBox.FormattingEnabled = true;
            this.cheesyBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cheesyBox.Location = new System.Drawing.Point(235, 219);
            this.cheesyBox.Name = "cheesyBox";
            this.cheesyBox.Size = new System.Drawing.Size(71, 21);
            this.cheesyBox.TabIndex = 19;
            this.cheesyBox.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(181, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cheesy:";
            // 
            // porkBox
            // 
            this.porkBox.FormattingEnabled = true;
            this.porkBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.porkBox.Location = new System.Drawing.Point(235, 171);
            this.porkBox.Name = "porkBox";
            this.porkBox.Size = new System.Drawing.Size(71, 21);
            this.porkBox.TabIndex = 17;
            this.porkBox.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(181, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Pork:";
            // 
            // beefBox
            // 
            this.beefBox.FormattingEnabled = true;
            this.beefBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.beefBox.Location = new System.Drawing.Point(235, 123);
            this.beefBox.Name = "beefBox";
            this.beefBox.Size = new System.Drawing.Size(71, 21);
            this.beefBox.TabIndex = 15;
            this.beefBox.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(181, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Beef:";
            // 
            // chickenBox
            // 
            this.chickenBox.FormattingEnabled = true;
            this.chickenBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.chickenBox.Location = new System.Drawing.Point(235, 77);
            this.chickenBox.Name = "chickenBox";
            this.chickenBox.Size = new System.Drawing.Size(71, 21);
            this.chickenBox.TabIndex = 13;
            this.chickenBox.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(181, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Chicken:";
            // 
            // sugaryBox
            // 
            this.sugaryBox.FormattingEnabled = true;
            this.sugaryBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.sugaryBox.Location = new System.Drawing.Point(427, 267);
            this.sugaryBox.Name = "sugaryBox";
            this.sugaryBox.Size = new System.Drawing.Size(71, 21);
            this.sugaryBox.TabIndex = 31;
            this.sugaryBox.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(352, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 15);
            this.label12.TabIndex = 30;
            this.label12.Text = "Sugary:";
            // 
            // spiceBox
            // 
            this.spiceBox.FormattingEnabled = true;
            this.spiceBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.spiceBox.Location = new System.Drawing.Point(427, 219);
            this.spiceBox.Name = "spiceBox";
            this.spiceBox.Size = new System.Drawing.Size(71, 21);
            this.spiceBox.TabIndex = 29;
            this.spiceBox.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(352, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "Spicy:";
            // 
            // coldBox
            // 
            this.coldBox.FormattingEnabled = true;
            this.coldBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.coldBox.Location = new System.Drawing.Point(427, 171);
            this.coldBox.Name = "coldBox";
            this.coldBox.Size = new System.Drawing.Size(71, 21);
            this.coldBox.TabIndex = 27;
            this.coldBox.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(352, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 15);
            this.label14.TabIndex = 26;
            this.label14.Text = "Eaten cold:";
            // 
            // frozenBox
            // 
            this.frozenBox.FormattingEnabled = true;
            this.frozenBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.frozenBox.Location = new System.Drawing.Point(427, 123);
            this.frozenBox.Name = "frozenBox";
            this.frozenBox.Size = new System.Drawing.Size(71, 21);
            this.frozenBox.TabIndex = 25;
            this.frozenBox.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(352, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 15);
            this.label15.TabIndex = 24;
            this.label15.Text = "Frozen food:";
            // 
            // bakedBox
            // 
            this.bakedBox.FormattingEnabled = true;
            this.bakedBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.bakedBox.Location = new System.Drawing.Point(427, 77);
            this.bakedBox.Name = "bakedBox";
            this.bakedBox.Size = new System.Drawing.Size(71, 21);
            this.bakedBox.TabIndex = 23;
            this.bakedBox.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(352, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "Baked:";
            // 
            // dinnerBox
            // 
            this.dinnerBox.FormattingEnabled = true;
            this.dinnerBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.dinnerBox.Location = new System.Drawing.Point(612, 269);
            this.dinnerBox.Name = "dinnerBox";
            this.dinnerBox.Size = new System.Drawing.Size(71, 21);
            this.dinnerBox.TabIndex = 41;
            this.dinnerBox.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(543, 269);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 15);
            this.label17.TabIndex = 40;
            this.label17.Text = "Dinner:";
            // 
            // lunchBox
            // 
            this.lunchBox.FormattingEnabled = true;
            this.lunchBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.lunchBox.Location = new System.Drawing.Point(612, 221);
            this.lunchBox.Name = "lunchBox";
            this.lunchBox.Size = new System.Drawing.Size(71, 21);
            this.lunchBox.TabIndex = 39;
            this.lunchBox.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(543, 221);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 15);
            this.label18.TabIndex = 38;
            this.label18.Text = "Lunch:";
            // 
            // breakfastBox
            // 
            this.breakfastBox.FormattingEnabled = true;
            this.breakfastBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.breakfastBox.Location = new System.Drawing.Point(612, 173);
            this.breakfastBox.Name = "breakfastBox";
            this.breakfastBox.Size = new System.Drawing.Size(71, 21);
            this.breakfastBox.TabIndex = 37;
            this.breakfastBox.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(543, 173);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 15);
            this.label19.TabIndex = 36;
            this.label19.Text = "Breakfast:";
            // 
            // vegBox
            // 
            this.vegBox.FormattingEnabled = true;
            this.vegBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.vegBox.Location = new System.Drawing.Point(612, 125);
            this.vegBox.Name = "vegBox";
            this.vegBox.Size = new System.Drawing.Size(71, 21);
            this.vegBox.TabIndex = 35;
            this.vegBox.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(543, 125);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 15);
            this.label20.TabIndex = 34;
            this.label20.Text = "Vegetarian:";
            // 
            // chewBox
            // 
            this.chewBox.FormattingEnabled = true;
            this.chewBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.chewBox.Location = new System.Drawing.Point(612, 79);
            this.chewBox.Name = "chewBox";
            this.chewBox.Size = new System.Drawing.Size(71, 21);
            this.chewBox.TabIndex = 33;
            this.chewBox.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(543, 79);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 15);
            this.label21.TabIndex = 32;
            this.label21.Text = "Chewy:";
            // 
            // coldDrink
            // 
            this.coldDrink.FormattingEnabled = true;
            this.coldDrink.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.coldDrink.Location = new System.Drawing.Point(801, 269);
            this.coldDrink.Name = "coldDrink";
            this.coldDrink.Size = new System.Drawing.Size(71, 21);
            this.coldDrink.TabIndex = 51;
            this.coldDrink.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(734, 269);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 15);
            this.label22.TabIndex = 50;
            this.label22.Text = "Cold Drink:";
            // 
            // hotDrink
            // 
            this.hotDrink.FormattingEnabled = true;
            this.hotDrink.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.hotDrink.Location = new System.Drawing.Point(801, 221);
            this.hotDrink.Name = "hotDrink";
            this.hotDrink.Size = new System.Drawing.Size(71, 21);
            this.hotDrink.TabIndex = 49;
            this.hotDrink.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(734, 221);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 15);
            this.label23.TabIndex = 48;
            this.label23.Text = "Hot Drink:";
            // 
            // bitterBox
            // 
            this.bitterBox.FormattingEnabled = true;
            this.bitterBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.bitterBox.Location = new System.Drawing.Point(801, 173);
            this.bitterBox.Name = "bitterBox";
            this.bitterBox.Size = new System.Drawing.Size(71, 21);
            this.bitterBox.TabIndex = 47;
            this.bitterBox.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(734, 173);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 15);
            this.label24.TabIndex = 46;
            this.label24.Text = "Bitter:";
            // 
            // softBox
            // 
            this.softBox.FormattingEnabled = true;
            this.softBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.softBox.Location = new System.Drawing.Point(801, 125);
            this.softBox.Name = "softBox";
            this.softBox.Size = new System.Drawing.Size(71, 21);
            this.softBox.TabIndex = 45;
            this.softBox.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(734, 125);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(31, 15);
            this.label25.TabIndex = 44;
            this.label25.Text = "Soft:";
            // 
            // snackBox
            // 
            this.snackBox.FormattingEnabled = true;
            this.snackBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.snackBox.Location = new System.Drawing.Point(801, 79);
            this.snackBox.Name = "snackBox";
            this.snackBox.Size = new System.Drawing.Size(71, 21);
            this.snackBox.TabIndex = 43;
            this.snackBox.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(734, 79);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 15);
            this.label26.TabIndex = 42;
            this.label26.Text = "Snack:";
            // 
            // meatBox
            // 
            this.meatBox.FormattingEnabled = true;
            this.meatBox.ItemHeight = 13;
            this.meatBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.meatBox.Location = new System.Drawing.Point(73, 38);
            this.meatBox.Name = "meatBox";
            this.meatBox.Size = new System.Drawing.Size(71, 21);
            this.meatBox.TabIndex = 53;
            this.meatBox.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(18, 38);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(43, 15);
            this.label27.TabIndex = 52;
            this.label27.Text = "Meaty:";
            // 
            // fruitBox
            // 
            this.fruitBox.FormattingEnabled = true;
            this.fruitBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.fruitBox.Location = new System.Drawing.Point(801, 32);
            this.fruitBox.Name = "fruitBox";
            this.fruitBox.Size = new System.Drawing.Size(71, 21);
            this.fruitBox.TabIndex = 55;
            this.fruitBox.Text = "0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(734, 32);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(39, 15);
            this.label28.TabIndex = 54;
            this.label28.Text = "Fruity:";
            // 
            // priceBox
            // 
            this.priceBox.FormattingEnabled = true;
            this.priceBox.Items.AddRange(new object[] {
            "0",
            "10"});
            this.priceBox.Location = new System.Drawing.Point(427, 313);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(71, 21);
            this.priceBox.TabIndex = 57;
            this.priceBox.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(352, 313);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(69, 15);
            this.label29.TabIndex = 56;
            this.label29.Text = "Price <= $2";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.Green;
            this.submitButton.Location = new System.Drawing.Point(752, 304);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(121, 30);
            this.submitButton.TabIndex = 58;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(21, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 59;
            this.button1.Text = "Exit Program";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.fruitBox);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.meatBox);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.coldDrink);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.hotDrink);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.bitterBox);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.softBox);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.snackBox);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.dinnerBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lunchBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.breakfastBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.vegBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.chewBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.sugaryBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.spiceBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.coldBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.frozenBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.bakedBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cheesyBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.porkBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.beefBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chickenBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.hotbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sourBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.crunchBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saltBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sweetBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Product Database Insertion Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sweetBox;
        private System.Windows.Forms.ComboBox saltBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox crunchBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sourBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox hotbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cheesyBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox porkBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox beefBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox chickenBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox sugaryBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox spiceBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox coldBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox frozenBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox bakedBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox dinnerBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox lunchBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox breakfastBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox vegBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox chewBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox coldDrink;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox hotDrink;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox bitterBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox softBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox snackBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox meatBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox fruitBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox priceBox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button button1;
    }
}

