namespace TVprogram.UIForms
{
    partial class AddEditForm
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
            okButton = new Button();
            cancelButton = new Button();
            titleLabel = new Label();
            channelLabel = new Label();
            genreLabel = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            timePicker = new DateTimePicker();
            label2 = new Label();
            datePicker = new DateTimePicker();
            label1 = new Label();
            countryTextBox = new TextBox();
            countryLabel = new Label();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            genreTextBox = new TextBox();
            channelTextBox = new TextBox();
            titleTextBox = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            okButton.Location = new Point(660, 799);
            okButton.Name = "okButton";
            okButton.Size = new Size(211, 70);
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(887, 799);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(219, 70);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Скасувати";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = SystemColors.GradientInactiveCaption;
            titleLabel.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(32, 218);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(154, 56);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Назва:";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // channelLabel
            // 
            channelLabel.BackColor = SystemColors.GradientInactiveCaption;
            channelLabel.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            channelLabel.Location = new Point(32, 309);
            channelLabel.Name = "channelLabel";
            channelLabel.Size = new Size(154, 56);
            channelLabel.TabIndex = 4;
            channelLabel.Text = "Канал:";
            channelLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // genreLabel
            // 
            genreLabel.BackColor = SystemColors.GradientInactiveCaption;
            genreLabel.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genreLabel.Location = new Point(32, 484);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(154, 56);
            genreLabel.TabIndex = 5;
            genreLabel.Text = "Жанр:";
            genreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.InactiveCaption;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(1126, 83);
            label5.TabIndex = 10;
            label5.Text = "Додати нову телепрограму";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(timePicker);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(datePicker);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(countryTextBox);
            groupBox1.Controls.Add(countryLabel);
            groupBox1.Controls.Add(descriptionTextBox);
            groupBox1.Controls.Add(descriptionLabel);
            groupBox1.Controls.Add(genreTextBox);
            groupBox1.Controls.Add(channelTextBox);
            groupBox1.Controls.Add(titleTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(titleLabel);
            groupBox1.Controls.Add(channelLabel);
            groupBox1.Controls.Add(genreLabel);
            groupBox1.Location = new Point(12, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1126, 664);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "   ";
            // 
            // timePicker
            // 
            timePicker.CalendarFont = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timePicker.CustomFormat = "HH:mm";
            timePicker.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.Location = new Point(218, 130);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(876, 56);
            timePicker.TabIndex = 17;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 132);
            label2.Name = "label2";
            label2.Size = new Size(154, 56);
            label2.TabIndex = 16;
            label2.Text = "Час:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // datePicker
            // 
            datePicker.CalendarFont = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datePicker.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datePicker.Location = new Point(218, 39);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(876, 56);
            datePicker.TabIndex = 15;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 39);
            label1.Name = "label1";
            label1.Size = new Size(154, 56);
            label1.TabIndex = 14;
            label1.Text = "Дата:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // countryTextBox
            // 
            countryTextBox.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countryTextBox.Location = new Point(218, 396);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(876, 56);
            countryTextBox.TabIndex = 13;
            // 
            // countryLabel
            // 
            countryLabel.BackColor = SystemColors.GradientInactiveCaption;
            countryLabel.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countryLabel.Location = new Point(32, 396);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(154, 56);
            countryLabel.TabIndex = 12;
            countryLabel.Text = "Країна:";
            countryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionTextBox.Location = new Point(218, 571);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(876, 56);
            descriptionTextBox.TabIndex = 11;
            // 
            // descriptionLabel
            // 
            descriptionLabel.BackColor = SystemColors.GradientInactiveCaption;
            descriptionLabel.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionLabel.Location = new Point(32, 570);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(154, 56);
            descriptionLabel.TabIndex = 10;
            descriptionLabel.Text = "Опис:";
            descriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // genreTextBox
            // 
            genreTextBox.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genreTextBox.Location = new Point(218, 484);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new Size(876, 56);
            genreTextBox.TabIndex = 9;
            // 
            // channelTextBox
            // 
            channelTextBox.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            channelTextBox.Location = new Point(218, 310);
            channelTextBox.Name = "channelTextBox";
            channelTextBox.Size = new Size(876, 56);
            channelTextBox.TabIndex = 8;
            // 
            // titleTextBox
            // 
            titleTextBox.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleTextBox.Location = new Point(218, 218);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(876, 56);
            titleTextBox.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(420, 218);
            label6.Name = "label6";
            label6.Size = new Size(0, 37);
            label6.TabIndex = 0;
            // 
            // AddEditForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 908);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Name = "AddEditForm";
            Text = "AddEditForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button okButton;
        private Button cancelButton;
        private Label titleLabel;
        private Label channelLabel;
        private Label genreLabel;
        private Label label5;
        private GroupBox groupBox1;
        private Label label6;
        private TextBox channelTextBox;
        private TextBox titleTextBox;
        private TextBox genreTextBox;
        private Label descriptionLabel;
        private TextBox descriptionTextBox;
        private TextBox countryTextBox;
        private Label countryLabel;
        private DateTimePicker datePicker;
        private Label label1;
        private Label label2;
        private DateTimePicker timePicker;
    }
}