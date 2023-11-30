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

namespace BattleShip.View
{
    public partial class ShipsSetupUserControl : UserControl
    {
        private readonly int boardCells = 10;
        private readonly int boardCellSize = 30;
        private readonly int boardPaddingLeft = 220;
        private readonly int boardPaddingTop = 30;
        public ShipsSetupUserControl()
        {
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
                        Tag = i + j,
                        BackColor = Color.LightGray,
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    cellsFlowLayoutPanel.Controls.Add(cellPictureBox);
                }
            }
        }
        private void CellPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = (PictureBox)sender;

            int index = cellsFlowLayoutPanel.Controls.IndexOf(clickedPictureBox);
            int row = index / boardCells;
            int col = index % boardCells;

            clickedPictureBox.BackColor = Color.SlateGray;

            for (int i = 1; i <= 3; i++)
            {
                int nextCol = col + i;
                if (nextCol < boardCells)
                {
                    int nextIndex = row * boardCells + nextCol;
                    PictureBox nextPictureBox = (PictureBox)cellsFlowLayoutPanel.Controls[nextIndex];
                    nextPictureBox.BackColor = Color.SlateGray;
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
    }
}