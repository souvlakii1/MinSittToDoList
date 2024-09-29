namespace ToDoListtuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addtask(object sender, EventArgs e)
        {
            string task = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(task))
            {
                listBox1.Items.Add(task);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task", "Message");
            }
        }

        private void removetask(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a task to remove", "Message");
            }
        }

        private void clearall(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string t = textBox1.Text.Trim();
                if (!string.IsNullOrEmpty(t))
                {
                    listBox1.Items.Add(t);
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a task", "Message");
                }
                e.SuppressKeyPress = true;

            }
        }
    }
}
