using BattleShip.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BattleShip.View
{
    public partial class ShipsSetupUserControl : UserControl
    {
        private int LincoreSet { get; set; } = 1;
        private int FregateSet { get; set; } = 2;
        private int CorvetteSet { get; set; } = 3;
        private int BriggSet { get; set; } = 4;

        private Board board;

        private readonly int boardCells = 10;
        private readonly int boardCellSize = 30;
        private readonly int boardPaddingLeft = 220;
        private readonly int boardPaddingTop = 30;
        public ShipsSetupUserControl()
        {
            board = new Board();
            InitializeComponent();
            Paint += ShipsSetupUserControl_Paint;
        }

        private void ShipsSetupUserControl_Paint(object? sender, PaintEventArgs e)
        {
            DrawBorderTopString();
            AddPictureBoxes();
            DrawBorderLeftString();
        }
        private void AddPictureBoxes()
        {
            for (int i = 0; i < boardCells; ++i)
            {
                for (int j = 0; j < boardCells; ++j)
                {
                    PictureBox cellPictureBox = new PictureBox
                    {
                        Size = new Size(boardCellSize, boardCellSize),
                        Margin = new Padding(0),
                        Location = new Point(boardPaddingLeft + i * boardCellSize, boardPaddingTop + j * boardCellSize),
                        Tag = $"{i}:{j}",
                        BackColor = Color.LightGray,
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    cellsFlowLayoutPanel.Controls.Add(cellPictureBox);
                    cellPictureBox.Click += CellPictureBox_Click;
                }
            }
        }
        private void CellPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            foreach (var ship in board.Ships)
            {
                if (lincoreRadioButton.Checked && !rotateCheckBox.Checked)
                {
                    SetLincoreHorizontal(ship, clickedPictureBox);                    
                }
                else if (lincoreRadioButton.Checked && rotateCheckBox.Checked)
                {
                    SetLincoreVertical(ship, clickedPictureBox);
                }

                else if (fregateRadioButton.Checked && !rotateCheckBox.Checked)
                {
                    SetFregateHorizontal(ship, clickedPictureBox);
                }
                else if (fregateRadioButton.Checked && rotateCheckBox.Checked)
                {
                    SetFregateVertical(ship, clickedPictureBox);
                }

                else if (corvetteRadioButton.Checked && !rotateCheckBox.Checked)
                {
                    SetCorvetteHorizontal(ship, clickedPictureBox);
                }
                else if (corvetteRadioButton.Checked && rotateCheckBox.Checked)
                {
                    SetCorvetteVertical(ship, clickedPictureBox);
                }

                else if (briggRadioButton.Checked)
                {
                    SetBrigg(ship, clickedPictureBox);
                }
            }
        }
        private void DrawBorderLeftString()
        {
            using (Graphics g = CreateGraphics())
            {
                int topStringOffset = 190;
                int leftStringOffset = 0;
                string leftString = "1234567890";

                foreach (var digit in leftString)
                {
                    leftStringOffset += boardCellSize;
                    g.DrawString(digit.ToString(), this.Font, Brushes.Ivory, new PointF(topStringOffset + boardCellSize / 4, leftStringOffset + boardCellSize / 4));
                }
            }
        }
        private void DrawBorderTopString()
        {
            using (Graphics g = CreateGraphics())
            {
                int topStringOffset = 190;
                string topString = "RESPUBLICA";

                foreach (var letter in topString)
                {
                    topStringOffset += boardCellSize;
                    g.DrawString(letter.ToString(), this.Font, Brushes.Ivory, new PointF(topStringOffset + boardCellSize / 4, boardCellSize / 4));
                }
            }
        }
        private void SetLincoreHorizontal(Ship ship, PictureBox? clickedPictureBox)
        {
            if (ship.Size == 4 && LincoreSet > 0)
            {
                string[] coordinates = clickedPictureBox.Tag.ToString().Split(':');

                if (coordinates.Length == 2 && int.TryParse(coordinates[0], out int i) && int.TryParse(coordinates[1], out int j))
                {
                    if (j < 7)
                    {
                        ship.PosX = new int[] { i, i, i, i };
                        ship.PosY = new int[] { j, j + 1, j + 2, j + 3 };

                        LincoreSet--;

                        lincoreRadioButton.Enabled = false;

                        foreach (Control control in cellsFlowLayoutPanel.Controls)
                        {
                            if (control is PictureBox pictureBox && pictureBox.Tag.ToString() == $"{i}:{j}")
                            {
                                pictureBox.BackColor = Color.Green;
                            }
                            else if (control is PictureBox nextPictureBox && nextPictureBox.Tag.ToString() == $"{i}:{j + 1}")
                            {
                                nextPictureBox.BackColor = Color.Green;
                            }
                            else if (control is PictureBox nextPictureBox2 && nextPictureBox2.Tag.ToString() == $"{i}:{j + 2}")
                            {
                                nextPictureBox2.BackColor = Color.Green;
                            }
                            else if (control is PictureBox nextPictureBox3 && nextPictureBox3.Tag.ToString() == $"{i}:{j + 3}")
                            {
                                nextPictureBox3.BackColor = Color.Green;
                            }
                        }
                    }
                }
            }
        }
        private void SetLincoreVertical(Ship ship, PictureBox? clickedPictureBox)
        {
            if (ship.Size == 4 && LincoreSet != 0)
            {
                string[] coordinates = clickedPictureBox.Tag.ToString().Split(':');

                if (coordinates.Length == 2 && int.TryParse(coordinates[0], out int i) && int.TryParse(coordinates[1], out int j))
                {
                    if (i < 7)
                    {
                        ship.PosX = new int[] { i, i + 1, i + 2, i + 3 };
                        ship.PosY = new int[] { j, j, j, j };

                        LincoreSet--;

                        lincoreRadioButton.Enabled = false;

                        foreach (Control control in cellsFlowLayoutPanel.Controls)
                        {
                            if (control is PictureBox pictureBox && pictureBox.Tag.ToString() == $"{i}:{j}")
                            {
                                pictureBox.BackColor = Color.Green;
                            }
                            else if (control is PictureBox nextPictureBox && nextPictureBox.Tag.ToString() == $"{i + 1}:{j}")
                            {
                                nextPictureBox.BackColor = Color.Green;
                            }
                            else if (control is PictureBox nextPictureBox2 && nextPictureBox2.Tag.ToString() == $"{i + 2}:{j}")
                            {
                                nextPictureBox2.BackColor = Color.Green;
                            }
                            else if (control is PictureBox nextPictureBox3 && nextPictureBox3.Tag.ToString() == $"{i + 3}:{j}")
                            {
                                nextPictureBox3.BackColor = Color.Green;
                            }
                        }
                    }
                }
            }
        }
        private void SetFregateVertical(Ship ship, PictureBox? clickedPictureBox)
        {
            if (ship.Size == 3 && FregateSet != 0)
            {
                string[] coordinates = clickedPictureBox.Tag.ToString().Split(':');

                if (coordinates.Length == 2 && int.TryParse(coordinates[0], out int i) && int.TryParse(coordinates[1], out int j))
                {
                    if (i < 8)
                    {
                        ship.PosX = new int[] { i, i + 1, i + 2 };
                        ship.PosY = new int[] { j, j, j };

                        FregateSet--;

                        if (FregateSet == 0)
                        {
                            fregateRadioButton.Enabled = false;
                        }

                        foreach (Control control in cellsFlowLayoutPanel.Controls)
                        {
                            if (control is PictureBox pictureBox && pictureBox.Tag.ToString() == $"{i}:{j}")
                            {
                                pictureBox.BackColor = Color.Green;
                            }
                            else if (control is PictureBox nextPictureBox && nextPictureBox.Tag.ToString() == $"{i + 1}:{j}")
                            {
                                nextPictureBox.BackColor = Color.Green;
                            }
                            else if (control is PictureBox nextPictureBox2 && nextPictureBox2.Tag.ToString() == $"{i + 2}:{j}")
                            {
                                nextPictureBox2.BackColor = Color.Green;
                            }
                        }
                    }
                }
            }
        }
        private void SetFregateHorizontal(Ship ship, PictureBox? clickedPictureBox)
        {
            if (ship.Size == 3 && FregateSet != 0)
            {
                string[] coordinates = clickedPictureBox.Tag.ToString().Split(':');

                if (coordinates.Length == 2 && int.TryParse(coordinates[0], out int i) && int.TryParse(coordinates[1], out int j))
                {
                    if (j < 8)
                    {
                        ship.PosX = new int[] { i, i, i };
                        ship.PosY = new int[] { j, j + 1, j + 2 };

                        FregateSet--;

                        if (FregateSet == 0)
                        {
                            fregateRadioButton.Enabled = false;
                        }

                        foreach (Control control in cellsFlowLayoutPanel.Controls)
                        {
                            if (control is PictureBox pictureBox && pictureBox.Tag.ToString() == $"{i}:{j}")
                            {
                                pictureBox.BackColor = Color.Green;
                            }
                            else if (control is PictureBox nextPictureBox && nextPictureBox.Tag.ToString() == $"{i}:{j + 1}")
                            {
                                nextPictureBox.BackColor = Color.Green;
                            }
                            else if (control is PictureBox nextPictureBox2 && nextPictureBox2.Tag.ToString() == $"{i}:{j + 2}")
                            {
                                nextPictureBox2.BackColor = Color.Green;
                            }
                        }
                    }
                }
            }
        }
        private void SetCorvetteVertical(Ship ship, PictureBox? clickedPictureBox)
        {
            if (ship.Size == 2 && CorvetteSet != 0)
            {
                string[] coordinates = clickedPictureBox.Tag.ToString().Split(':');

                if (coordinates.Length == 2 && int.TryParse(coordinates[0], out int i) && int.TryParse(coordinates[1], out int j))
                {
                    if (i < 9)
                    {
                        ship.PosX = new int[] { i, i + 1, i + 2 };
                        ship.PosY = new int[] { j, j, j };

                        CorvetteSet--;

                        if (CorvetteSet == 0)
                        {
                            corvetteRadioButton.Enabled = false;
                        }

                        foreach (Control control in cellsFlowLayoutPanel.Controls)
                        {
                            if (control is PictureBox pictureBox && pictureBox.Tag.ToString() == $"{i}:{j}")
                            {
                                pictureBox.BackColor = Color.Green;
                            }
                            else if (control is PictureBox nextPictureBox && nextPictureBox.Tag.ToString() == $"{i + 1}:{j}")
                            {
                                nextPictureBox.BackColor = Color.Green;
                            }
                        }
                    }
                }
            }
        }

        private void SetCorvetteHorizontal(Ship ship, PictureBox? clickedPictureBox)
        {
            if (ship.Size == 2 && CorvetteSet != 0)
            {
                string[] coordinates = clickedPictureBox.Tag.ToString().Split(':');

                if (coordinates.Length == 2 && int.TryParse(coordinates[0], out int i) && int.TryParse(coordinates[1], out int j))
                {
                    if (j < 9)
                    {
                        ship.PosX = new int[] { i, i };
                        ship.PosY = new int[] { j, j + 1 };

                        CorvetteSet--;

                        if (CorvetteSet == 0)
                        {
                            corvetteRadioButton.Enabled = false;
                        }

                        foreach (Control control in cellsFlowLayoutPanel.Controls)
                        {
                            if (control is PictureBox pictureBox && pictureBox.Tag.ToString() == $"{i}:{j}")
                            {
                                pictureBox.BackColor = Color.Green;
                            }
                            else if (control is PictureBox nextPictureBox && nextPictureBox.Tag.ToString() == $"{i}:{j + 1}")
                            {
                                nextPictureBox.BackColor = Color.Green;
                            }
                        }
                    }
                }
            }
        }
        private void SetBrigg(Ship ship, PictureBox? clickedPictureBox)
        {
            if (ship.Size == 1 && BriggSet != 0)
            {
                string[] coordinates = clickedPictureBox.Tag.ToString().Split(':');

                if (coordinates.Length == 2 && int.TryParse(coordinates[0], out int i) && int.TryParse(coordinates[1], out int j))
                {
                    ship.PosX = new int[] { i };
                    ship.PosY = new int[] { j };

                    BriggSet--;

                    if (BriggSet == 0)
                    {
                        briggRadioButton.Enabled = false;
                    }

                    foreach (Control control in cellsFlowLayoutPanel.Controls)
                    {
                        if (control is PictureBox pictureBox && pictureBox.Tag.ToString() == $"{i}:{j}")
                        {
                            pictureBox.BackColor = Color.Green;
                        }
                    }
                }
            }
        }
    }
}