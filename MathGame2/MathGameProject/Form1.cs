namespace MathGameProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadGame(object sender, EventArgs e)
        {
            GameScreen gamewindow = new GameScreen();
            gamewindow.Show();
        }
    }
}
