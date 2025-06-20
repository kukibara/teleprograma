using System;
using System.Windows.Forms;
using TVprogram.Models;

namespace TVprogram.UIForms
{
    public partial class AddEditForm : Form
    {
        public TVShow ShowData { get; private set; }

        public AddEditForm()
        {
            InitializeComponent();
            datePicker.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
        }

        public AddEditForm(TVShow showToEdit)
        {
            InitializeComponent();

            ShowData = showToEdit;

            Text = "Редагувати телепрограму";
            okButton.Text = "Зберегти зміни";

            datePicker.Value = ShowData.StartDateTime.Date;
            timePicker.Value = ShowData.StartDateTime;
            titleTextBox.Text = ShowData.Title;
            channelTextBox.Text = ShowData.Channel?.Name;
            countryTextBox.Text = ShowData.Channel?.Country;
            genreTextBox.Text = ShowData.Genre;
            descriptionTextBox.Text = ShowData.Description;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text))
            {
                MessageBox.Show("Будь ласка, заповніть назву передачі.", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isNewShow = (ShowData == null);
            if (isNewShow)
            {
                ShowData = new TVShow();
                ShowData.Channel = new Channel();
            }

            DateTime datePart = datePicker.Value.Date;
            TimeSpan timePart = timePicker.Value.TimeOfDay;
            ShowData.StartDateTime = datePart + timePart;

            ShowData.Title = titleTextBox.Text;
            ShowData.Genre = genreTextBox.Text;
            ShowData.Description = descriptionTextBox.Text;
            ShowData.Channel.Name = channelTextBox.Text;
            ShowData.Channel.Country = countryTextBox.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}