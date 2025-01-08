namespace WinFormsAmpGui
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            // Set the ListBox to not display items in multiple columns.
            listBoxPresets.MultiColumn = false;
            // Shutdown the painting of the ListBox as items are added.
            listBoxPresets.BeginUpdate();
            // Loop through and add 50 items to the ListBox.
            for (int x = 1; x <= 50; x++)
            {
                listBoxPresets.Items.Add("Item " + x.ToString());
            }
            // Allow the ListBox to repaint and display the new items.
            listBoxPresets.EndUpdate();

            // Select first item from the ListBox.
            listBoxPresets.SetSelected(1, true);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSelectPreset_Click(object sender, EventArgs e)
        {

        }
    }
}
