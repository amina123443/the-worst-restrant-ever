namespace the_worst_restrant_ever
{
    public partial class Form2 : Form
    {
        int current = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            refresh(true, true);
        }

        private void next_MouseClick(object sender, MouseEventArgs e)
        {
            current++;
            refresh(true, false);
        }

        private void refresh(bool increased, bool ignore)
        {
            UserControl[] pages = { page11, page21, page31 };
            if (!ignore)
            {
                if (increased)
                {
                    pages[current - 1].Hide();
                }
                else
                {
                    pages[current + 1].Hide();
                }
            }
            pages[current].Show();
            pages[current].BringToFront();

            next.Enabled = true;
            previous.Enabled = true;
            if (current == 0)
            {
                previous.Enabled = false;
            }
            else if (current == pages.Length - 1)
            {
                next.Enabled = false;
            }
        }

        private void LastPage(object sender, MouseEventArgs e)
        {
            current--;
            refresh(false, false);
        }

        private void page11_Load(object sender, EventArgs e)
        {

        }
    }
}
