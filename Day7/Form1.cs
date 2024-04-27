namespace Day7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Text = "Hello intake 44";
            //BackColor = Color.FromArgb(100, 150, 50); //Color.RebeccaPurple;

            this.Load += Form1_Load;
            this.MouseEnter += Form1_MouseEnter;

            Button btn = new Button();
            btn.Text = "OK";
            btn.Location = new Point(100, 50);

            btn.Click += Btn_Click;

            this.Controls.Add(btn);
        }
        private void Btn_Click(object? sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }
        private void Form1_MouseEnter(object? sender, EventArgs e)
        {
            //BackColor = Color.Yellow;
        }
        private void Form1_Load(object? sender, EventArgs e)
        {
            //BackColor = Color.DarkRed;
        }
        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            //BackColor = Color.DarkRed;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = $"X = {e.X} \t Y = {e.Y}";
        }
        private void btnMsg_Click(object sender, EventArgs e)
        {
            lblMsg.Text = txtMsg.Text;
        }
        private void radColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
                BackColor = Color.Red;
            else if (radGreen.Checked)
                BackColor = Color.Green;
            else
                BackColor = Color.Blue;
        }
        private void txtMsg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}