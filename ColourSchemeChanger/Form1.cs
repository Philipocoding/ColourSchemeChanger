namespace ColourSchemeChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDark_Click(object sender, EventArgs e)
        {
            ColourSettings.colourOne = "0, 0, 0";
            ColourSettings.ColourTwo = "117, 107, 107";
            pnlTest.BackColor = ColourSettings.ConvertToColour(ColourSettings.colourOne);
            BtnTestColour.ForeColor = ColourSettings.ConvertToColour(ColourSettings.colourOne);

        }

        private void btnLight_Click(object sender, EventArgs e)
        {
            ColourSettings.colourOne = "255,255,255";
            ColourSettings.ColourTwo = "0,0,0";
            pnlTest.BackColor = ColourSettings.ConvertToColour(ColourSettings.colourOne);
            BtnTestColour.ForeColor = ColourSettings.ConvertToColour(ColourSettings.colourOne);

        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            ColourSettings.colourOne = "3, 227, 252";
            ColourSettings.ColourTwo = "16, 53, 222";
            pnlTest.BackColor = ColourSettings.ConvertToColour(ColourSettings.colourOne);
            BtnTestColour.ForeColor = ColourSettings.ConvertToColour(ColourSettings.colourOne);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlTest.BringToFront();
            pnlTest.BackColor = ColourSettings.ConvertToColour(ColourSettings.colourOne);

        }
    }
}
