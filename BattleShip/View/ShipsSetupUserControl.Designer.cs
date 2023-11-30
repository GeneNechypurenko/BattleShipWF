namespace BattleShip.View
{
    partial class ShipsSetupUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fleetGroupBox = new GroupBox();
            checkBox1 = new CheckBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            lincoreRadioButton = new RadioButton();
            groupBox1 = new GroupBox();
            cellsFlowLayoutPanel = new FlowLayoutPanel();
            fleetGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // fleetGroupBox
            // 
            fleetGroupBox.Controls.Add(checkBox1);
            fleetGroupBox.Controls.Add(radioButton3);
            fleetGroupBox.Controls.Add(radioButton2);
            fleetGroupBox.Controls.Add(radioButton1);
            fleetGroupBox.Controls.Add(lincoreRadioButton);
            fleetGroupBox.Dock = DockStyle.Right;
            fleetGroupBox.FlatStyle = FlatStyle.Flat;
            fleetGroupBox.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            fleetGroupBox.ForeColor = Color.Ivory;
            fleetGroupBox.Location = new Point(552, 0);
            fleetGroupBox.Margin = new Padding(10);
            fleetGroupBox.Name = "fleetGroupBox";
            fleetGroupBox.Padding = new Padding(10);
            fleetGroupBox.Size = new Size(190, 344);
            fleetGroupBox.TabIndex = 0;
            fleetGroupBox.TabStop = false;
            fleetGroupBox.Text = "SHIP SELECTION";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(86, 293);
            checkBox1.Name = "checkBox1";
            checkBox1.Padding = new Padding(10);
            checkBox1.Size = new Size(101, 48);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "ROTATE";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(10, 237);
            radioButton3.Name = "radioButton3";
            radioButton3.Padding = new Padding(10);
            radioButton3.Size = new Size(90, 48);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "BRIGG";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(10, 173);
            radioButton2.Name = "radioButton2";
            radioButton2.Padding = new Padding(10);
            radioButton2.Size = new Size(116, 48);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "CORVETTE";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(10, 109);
            radioButton1.Name = "radioButton1";
            radioButton1.Padding = new Padding(10);
            radioButton1.Size = new Size(107, 48);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "FREGATE";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // lincoreRadioButton
            // 
            lincoreRadioButton.AutoSize = true;
            lincoreRadioButton.Location = new Point(10, 45);
            lincoreRadioButton.Name = "lincoreRadioButton";
            lincoreRadioButton.Padding = new Padding(10);
            lincoreRadioButton.Size = new Size(105, 48);
            lincoreRadioButton.TabIndex = 0;
            lincoreRadioButton.TabStop = true;
            lincoreRadioButton.Text = "LINCORE";
            lincoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Dock = DockStyle.Left;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.ForeColor = Color.Ivory;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(10);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(180, 344);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "HINTS";
            // 
            // cellsFlowLayoutPanel
            // 
            cellsFlowLayoutPanel.Location = new Point(220, 30);
            cellsFlowLayoutPanel.Margin = new Padding(0);
            cellsFlowLayoutPanel.Name = "cellsFlowLayoutPanel";
            cellsFlowLayoutPanel.Size = new Size(300, 300);
            cellsFlowLayoutPanel.TabIndex = 2;
            // 
            // ShipsSetupUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            Controls.Add(cellsFlowLayoutPanel);
            Controls.Add(groupBox1);
            Controls.Add(fleetGroupBox);
            Name = "ShipsSetupUserControl";
            Size = new Size(742, 344);
            fleetGroupBox.ResumeLayout(false);
            fleetGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox fleetGroupBox;
        private RadioButton lincoreRadioButton;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private FlowLayoutPanel cellsFlowLayoutPanel;
    }
}
