namespace TVprogram
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            genreComboBox = new ComboBox();
            channelComboBox = new ComboBox();
            datePicker = new DateTimePicker();
            titleTextBox = new TextBox();
            searchButton = new Button();
            showsDataGridView = new DataGridView();
            Time = new DataGridViewTextBoxColumn();
            ShowName = new DataGridViewTextBoxColumn();
            GenreColumn = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            CountryColumn = new DataGridViewTextBoxColumn();
            AddButtonColumn = new DataGridViewButtonColumn();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            label7 = new Label();
            watchlistListBox = new ListBox();
            deleteButton = new Button();
            clearButton = new Button();
            addShowButton = new Button();
            editShowButton = new Button();
            deleteShowButton = new Button();
            saveWatchlistButton = new Button();
            groupBox1 = new GroupBox();
            descriptionDisplayBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)showsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(34, 35);
            label1.Name = "label1";
            label1.Size = new Size(2354, 91);
            label1.TabIndex = 0;
            label1.Text = "Телепрограма";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Enabled = false;
            label2.Location = new Point(34, 126);
            label2.Name = "label2";
            label2.Size = new Size(2354, 87);
            label2.TabIndex = 1;
            label2.Text = " ";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(732, 131);
            label3.Name = "label3";
            label3.Size = new Size(142, 82);
            label3.TabIndex = 2;
            label3.Text = "Жанр:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1166, 131);
            label4.Name = "label4";
            label4.Size = new Size(142, 82);
            label4.TabIndex = 3;
            label4.Text = "Канал:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(1821, 131);
            label5.Name = "label5";
            label5.Size = new Size(142, 82);
            label5.TabIndex = 4;
            label5.Text = "Дата:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(34, 131);
            label6.Name = "label6";
            label6.Size = new Size(306, 82);
            label6.TabIndex = 5;
            label6.Text = "Назва передачі:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // genreComboBox
            // 
            genreComboBox.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Location = new Point(880, 149);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(252, 45);
            genreComboBox.TabIndex = 6;
            // 
            // channelComboBox
            // 
            channelComboBox.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            channelComboBox.FormattingEnabled = true;
            channelComboBox.Location = new Point(1326, 146);
            channelComboBox.Name = "channelComboBox";
            channelComboBox.Size = new Size(271, 45);
            channelComboBox.TabIndex = 7;
            // 
            // datePicker
            // 
            datePicker.CalendarFont = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datePicker.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datePicker.Location = new Point(1987, 149);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(372, 45);
            datePicker.TabIndex = 8;
            datePicker.ValueChanged += datePicker_ValueChanged;
            // 
            // titleTextBox
            // 
            titleTextBox.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleTextBox.Location = new Point(347, 146);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(379, 45);
            titleTextBox.TabIndex = 9;
            // 
            // searchButton
            // 
            searchButton.BackColor = SystemColors.InactiveCaption;
            searchButton.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.Location = new Point(1632, 146);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(172, 45);
            searchButton.TabIndex = 10;
            searchButton.Text = "Знайти";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // showsDataGridView
            // 
            showsDataGridView.AllowUserToAddRows = false;
            showsDataGridView.AllowUserToDeleteRows = false;
            showsDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            showsDataGridView.BorderStyle = BorderStyle.None;
            showsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            showsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Time, ShowName, GenreColumn, Column3, CountryColumn, AddButtonColumn });
            showsDataGridView.Dock = DockStyle.Fill;
            showsDataGridView.Location = new Point(0, 0);
            showsDataGridView.Name = "showsDataGridView";
            showsDataGridView.ReadOnly = true;
            showsDataGridView.RowHeadersWidth = 92;
            showsDataGridView.Size = new Size(1557, 730);
            showsDataGridView.TabIndex = 13;
            showsDataGridView.CellContentClick += dataGridView1_CellContentClick;
            showsDataGridView.SelectionChanged += showsDataGridView_SelectionChanged;
            // 
            // Time
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Time.DefaultCellStyle = dataGridViewCellStyle1;
            Time.HeaderText = "Час";
            Time.MinimumWidth = 11;
            Time.Name = "Time";
            Time.ReadOnly = true;
            Time.Width = 225;
            // 
            // ShowName
            // 
            ShowName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ShowName.HeaderText = "Назва передачі";
            ShowName.MinimumWidth = 11;
            ShowName.Name = "ShowName";
            ShowName.ReadOnly = true;
            // 
            // GenreColumn
            // 
            GenreColumn.HeaderText = "Жанр";
            GenreColumn.MinimumWidth = 11;
            GenreColumn.Name = "GenreColumn";
            GenreColumn.ReadOnly = true;
            GenreColumn.Width = 225;
            // 
            // Column3
            // 
            Column3.HeaderText = "Канал";
            Column3.MinimumWidth = 11;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 225;
            // 
            // CountryColumn
            // 
            CountryColumn.HeaderText = "Країна";
            CountryColumn.MinimumWidth = 11;
            CountryColumn.Name = "CountryColumn";
            CountryColumn.ReadOnly = true;
            CountryColumn.Width = 225;
            // 
            // AddButtonColumn
            // 
            AddButtonColumn.HeaderText = "Дія";
            AddButtonColumn.MinimumWidth = 11;
            AddButtonColumn.Name = "AddButtonColumn";
            AddButtonColumn.ReadOnly = true;
            AddButtonColumn.Text = "+Додати";
            AddButtonColumn.UseColumnTextForButtonValue = true;
            AddButtonColumn.Width = 225;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(34, 233);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(showsDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(2354, 730);
            splitContainer1.SplitterDistance = 1557;
            splitContainer1.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label7, 0, 0);
            tableLayoutPanel1.Controls.Add(watchlistListBox, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 680F));
            tableLayoutPanel1.Size = new Size(793, 730);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(787, 48);
            label7.TabIndex = 20;
            label7.Text = "Мій список перегляду";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // watchlistListBox
            // 
            watchlistListBox.BorderStyle = BorderStyle.None;
            watchlistListBox.Dock = DockStyle.Bottom;
            watchlistListBox.FormattingEnabled = true;
            watchlistListBox.ItemHeight = 37;
            watchlistListBox.Location = new Point(3, 61);
            watchlistListBox.Name = "watchlistListBox";
            watchlistListBox.Size = new Size(787, 666);
            watchlistListBox.TabIndex = 2;
            watchlistListBox.SelectedIndexChanged += watchlistListBox_SelectedIndexChanged;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(1601, 984);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(240, 52);
            deleteButton.TabIndex = 15;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.Location = new Point(1847, 984);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(301, 52);
            clearButton.TabIndex = 16;
            clearButton.Text = "Очистити мій список";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // addShowButton
            // 
            addShowButton.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addShowButton.Location = new Point(56, 984);
            addShowButton.Name = "addShowButton";
            addShowButton.Size = new Size(454, 52);
            addShowButton.TabIndex = 17;
            addShowButton.Text = "Додати телепрограму";
            addShowButton.UseVisualStyleBackColor = true;
            addShowButton.Click += addShowButton_Click;
            // 
            // editShowButton
            // 
            editShowButton.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editShowButton.Location = new Point(516, 984);
            editShowButton.Name = "editShowButton";
            editShowButton.Size = new Size(454, 52);
            editShowButton.TabIndex = 18;
            editShowButton.Text = "Редагувати";
            editShowButton.UseVisualStyleBackColor = true;
            editShowButton.Click += editShowButton_Click;
            // 
            // deleteShowButton
            // 
            deleteShowButton.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteShowButton.Location = new Point(976, 984);
            deleteShowButton.Name = "deleteShowButton";
            deleteShowButton.Size = new Size(454, 52);
            deleteShowButton.TabIndex = 19;
            deleteShowButton.Text = "Видалити телепрограму";
            deleteShowButton.UseVisualStyleBackColor = true;
            deleteShowButton.Click += deleteShowButton_Click;
            // 
            // saveWatchlistButton
            // 
            saveWatchlistButton.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveWatchlistButton.Location = new Point(2154, 984);
            saveWatchlistButton.Name = "saveWatchlistButton";
            saveWatchlistButton.Size = new Size(231, 52);
            saveWatchlistButton.TabIndex = 20;
            saveWatchlistButton.Text = "Зберегти у TXT";
            saveWatchlistButton.UseVisualStyleBackColor = true;
            saveWatchlistButton.Click += saveWatchlistButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(descriptionDisplayBox);
            groupBox1.Location = new Point(34, 1053);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1487, 256);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Опис обраної передачі";
            // 
            // descriptionDisplayBox
            // 
            descriptionDisplayBox.Dock = DockStyle.Fill;
            descriptionDisplayBox.Location = new Point(3, 39);
            descriptionDisplayBox.Multiline = true;
            descriptionDisplayBox.Name = "descriptionDisplayBox";
            descriptionDisplayBox.ReadOnly = true;
            descriptionDisplayBox.ScrollBars = ScrollBars.Vertical;
            descriptionDisplayBox.Size = new Size(1481, 214);
            descriptionDisplayBox.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(2416, 1506);
            Controls.Add(groupBox1);
            Controls.Add(saveWatchlistButton);
            Controls.Add(deleteButton);
            Controls.Add(deleteShowButton);
            Controls.Add(editShowButton);
            Controls.Add(addShowButton);
            Controls.Add(clearButton);
            Controls.Add(splitContainer1);
            Controls.Add(searchButton);
            Controls.Add(titleTextBox);
            Controls.Add(datePicker);
            Controls.Add(channelComboBox);
            Controls.Add(genreComboBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Телепрограма";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)showsDataGridView).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox genreComboBox;
        private ComboBox channelComboBox;
        private DateTimePicker datePicker;
        private TextBox titleTextBox;
        private Button searchButton;
        private DataGridView showsDataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn Column4;
        private SplitContainer splitContainer1;
        private Button deleteButton;
        private Button clearButton;
        private Button addShowButton;
        private Button editShowButton;
        private Button deleteShowButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label7;
        private ListBox watchlistListBox;
        private Button saveWatchlistButton;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn ShowName;
        private DataGridViewTextBoxColumn GenreColumn;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn CountryColumn;
        private DataGridViewButtonColumn AddButtonColumn;
        private GroupBox groupBox1;
        private TextBox descriptionDisplayBox;
    }
}
