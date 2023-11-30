using BattleShip.View;

namespace BattleShip
{
    public partial class MainForm : Form
    {
        ShipsSetupUserControl shipsSetupUserControl;
        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        private void startScreenButton_Click(object sender, EventArgs e)
        {
            RenderScreen();
            shipsSetupUserControl = new ShipsSetupUserControl();
            Controls.Add(shipsSetupUserControl);
            shipsSetupUserControl.Show();
        }

        private void RenderScreen()
        {
            Controls.Remove(startScreenPanel);
            buttonPanel.Controls.Clear();
            AddButton();
        }

        private void AddButton()
        {
            Button startGameButton = new Button();
            buttonPanel.Controls.Add(startGameButton);
            startGameButton.FlatStyle = FlatStyle.Flat;
            startGameButton.FlatAppearance.BorderSize = 0;
            startGameButton.Text = "START BATTLE!";
            startGameButton.Dock = DockStyle.Fill;
            startGameButton.Enabled = false;
            startGameButton.Click += (s, e) =>
            {

            };
        }
    }
}