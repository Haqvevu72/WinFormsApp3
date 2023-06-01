namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            
            int first = random.Next(1, 816);
            int second = random.Next(1, 489);

            int red = random.Next(256);
            int green = random.Next(256);
            int blue = random.Next(256);

            // Create a Color object with the random RGB values
            Color randomColor = Color.FromArgb(red, green, blue);
            button1.Location = new Point(first,second);
            button1.BackColor = randomColor;
        }
    }
}