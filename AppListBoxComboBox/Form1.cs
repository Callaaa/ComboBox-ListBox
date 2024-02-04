namespace AppListBoxComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(textBox1.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            listBox.Items.Insert(0, textBox1.Text);
        }

        private void btnRemoveST_Click(object sender, EventArgs e)
        {
            listBox.Items.RemoveAt(0);
        }

        private void btnRLast_Click(object sender, EventArgs e)
        {
            listBox.Items.RemoveAt(listBox.Items.Count - 1);
        }

        private void btnInstances_Click(object sender, EventArgs e)
        {
            while (listBox.Items.Contains(textBox1.Text))
            {
                listBox.Items.Remove(textBox1.Text);
            }
        }

        private void btnAddMiddle_Click(object sender, EventArgs e)
        {
            listBox.Items.Insert(listBox.Items.Count / 2, textBox1.Text);
        }

        private void cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox.Items.Add(cmbBox.Text);
        }
    }
}
