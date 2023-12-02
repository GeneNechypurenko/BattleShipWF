using BattleShip.View;
using BattleShip.ViewModel;

namespace BattleShip
{
    public partial class MainForm : Form
    {
        private ShipsSetupUserControl shipsSetupUserControl;
        private Button startGameButton;
        public Button StartGameButton { get => startGameButton; }
        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        private void startScreenButton_Click(object sender, EventArgs e)
        {
            RenderScreen();
            shipsSetupUserControl = new ShipsSetupUserControl(this);
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
            startGameButton = new Button();
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