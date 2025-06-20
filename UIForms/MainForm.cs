using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using TVprogram.Develop;
using TVprogram.Models;
using TVprogram.UIForms;

namespace TVprogram
{
    public partial class MainForm : Form
    {
        private readonly TVShowsCollection showCollection = new TVShowsCollection();
        private const string FilePath = "shows.json";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            showCollection.LoadFromFile(FilePath);
            UpdateFilterComboBoxes();
            ApplyFiltersAndRefreshGrid();

        }

        private void RefreshDataGridView(List<TVShow> showsToDisplay)
        {
            showsDataGridView.Rows.Clear();
            foreach (var show in showsToDisplay)
            {
                int rowIndex = showsDataGridView.Rows.Add(
                     show.StartDateTime.ToString("HH:mm"),
                     show.Title,
                     show.Genre,
                     show.Channel.Name,
                     show.Channel.Country,
                     null
                 );
                showsDataGridView.Rows[rowIndex].Tag = show;

            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == showsDataGridView.Columns["AddButtonColumn"].Index && e.RowIndex >= 0)
            {
                TVShow selectedShow = showsDataGridView.Rows[e.RowIndex].Tag as TVShow;

                if (selectedShow != null && !watchlistListBox.Items.Contains(selectedShow))
                {
                    watchlistListBox.Items.Add(selectedShow);
                    SortWatchlist();
                }
                else if (selectedShow != null)
                {
                    MessageBox.Show("Ця телепрограма вже є у вашому списку перегляду.",
                        "Інформація",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
        private void ApplyFiltersAndRefreshGrid()
        {
            DateTime selectedDate = datePicker.Value.Date;
            string selectedGenre = genreComboBox.SelectedItem?.ToString() ?? "Всі жанри";
            string selectedChannel = channelComboBox.SelectedItem?.ToString() ?? "Всі канали";
            string titleFilter = titleTextBox.Text;

            var filteredShows = showCollection.GetFilteredShows(selectedDate, selectedGenre, selectedChannel, titleFilter);

            RefreshDataGridView(filteredShows);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            showCollection.SaveToFile(FilePath);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (watchlistListBox.SelectedItem != null)
            {
                watchlistListBox.Items.Remove(watchlistListBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть елемент для видалення.",
                    "Інформація");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (watchlistListBox.Items.Count > 0)
            {
                var result = MessageBox.Show("Ви впевнені, що хочете очистити список перегляду?",
                    "Підтвердження",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    watchlistListBox.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("Ваш список перегляду вже порожній.",
                    "Інформація");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ApplyFiltersAndRefreshGrid();
        }

        private void deleteShowButton_Click(object sender, EventArgs e)
        {
            if (showsDataGridView.SelectedRows.Count > 0)
            {
                TVShow showToDelete = showsDataGridView.SelectedRows[0].Tag as TVShow;
                if (showToDelete != null)
                {
                    var result = MessageBox.Show($"Ви впевнені, що хочете видалити '{showToDelete.Title}'?",
                                                 "Підтвердження видалення",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        showCollection.RemoveShow(showToDelete);

                        ApplyFiltersAndRefreshGrid();
                        UpdateFilterComboBoxes();
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть програму для видалення.");
            }
        }

        private void addShowButton_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    showCollection.AddShow(form.ShowData);

                    ApplyFiltersAndRefreshGrid();
                    UpdateFilterComboBoxes();
                }
            }
        }

        private void editShowButton_Click(object sender, EventArgs e)
        {
            if (showsDataGridView.SelectedRows.Count > 0)
            {
                TVShow showToEdit = showsDataGridView.SelectedRows[0].Tag as TVShow;
                if (showToEdit != null)
                {
                    using (var form = new AddEditForm(showToEdit))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            ApplyFiltersAndRefreshGrid();
                            UpdateFilterComboBoxes();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть програму для редагування.");
            }
        }

        private void SortWatchlist()
        {
            List<TVShow> items = watchlistListBox.Items.OfType<TVShow>().ToList();

            var sortedItems = items.OrderBy(show => show.StartDateTime).ToList();

            watchlistListBox.Items.Clear();
            foreach (var item in sortedItems)
            {
                watchlistListBox.Items.Add(item);
            }
        }

        private void UpdateFilterComboBoxes()
        {
            var uniqueGenres = showCollection.GetAllShows()
                .Select(show => show.Genre)
                .Distinct()
                .OrderBy(genre => genre)
                .ToList();
            genreComboBox.Items.Clear();
            genreComboBox.Items.Add("Всі жанри");
            foreach (var genre in uniqueGenres)
            {
                genreComboBox.Items.Add(genre);
            }
            genreComboBox.SelectedIndex = 0;

            var uniqueChannels = showCollection.GetAllShows()
                .Select(show => show.Channel.Name)
                .Distinct()
                .OrderBy(channel => channel)
                .ToList();
            channelComboBox.Items.Clear();
            channelComboBox.Items.Add("Всі канали");
            foreach (var channel in uniqueChannels)
            {
                channelComboBox.Items.Add(channel);
            }
            channelComboBox.SelectedIndex = 0;
        }

        private void saveWatchlistButton_Click(object sender, EventArgs e)
        {
            if (watchlistListBox.Items.Count == 0)
            {
                MessageBox.Show("Ваш список перегляду порожній. Немає що зберігати.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.FileName = "Мій список перегляду.txt";
                saveFileDialog.Title = "Зберегти список перегляду";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<TVShow> watchlistShows = watchlistListBox.Items.OfType<TVShow>().ToList();

                    showCollection.SaveWatchlistAsTxt(saveFileDialog.FileName, watchlistShows);

                    MessageBox.Show("Список успішно збережено!", "Завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void DisplayShowDescrioption(TVShow show)
        {
            if (show != null)
            {
                descriptionDisplayBox.Text = show.Description;
            }
            else
            {
                descriptionDisplayBox.Text = string.Empty;
            }
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            ApplyFiltersAndRefreshGrid();
        }

        private void showsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (showsDataGridView.SelectedRows.Count > 0)
            {
                TVShow selectedShow = showsDataGridView.SelectedRows[0].Tag as TVShow;
                DisplayShowDescrioption(selectedShow);
            }
        }

        private void watchlistListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TVShow selectedShow = watchlistListBox.SelectedItem as TVShow;
            DisplayShowDescrioption(selectedShow);
        }
    }
}
