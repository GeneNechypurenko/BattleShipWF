﻿namespace BattleShip.View
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
            rotateCheckBox = new CheckBox();
            briggRadioButton = new RadioButton();
            corvetteRadioButton = new RadioButton();
            fregateRadioButton = new RadioButton();
            lincoreRadioButton = new RadioButton();
            groupBox1 = new GroupBox();
            label1 = new Label();
            briggSetLabel = new Label();
            corvetteSetLabel = new Label();
            fregateSetLabel = new Label();
            lincoreSetLabel = new Label();
            orientationSelectedLabel = new Label();
            shipSelectedLabel = new Label();
            notificationLabel = new Label();
            cellsFlowLayoutPanel = new FlowLayoutPanel();
            fleetGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // fleetGroupBox
            // 
            fleetGroupBox.Controls.Add(rotateCheckBox);
            fleetGroupBox.Controls.Add(briggRadioButton);
            fleetGroupBox.Controls.Add(corvetteRadioButton);
            fleetGroupBox.Controls.Add(fregateRadioButton);
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
            // rotateCheckBox
            // 
            rotateCheckBox.AutoSize = true;
            rotateCheckBox.Location = new Point(86, 293);
            rotateCheckBox.Name = "rotateCheckBox";
            rotateCheckBox.Padding = new Padding(10);
            rotateCheckBox.Size = new Size(101, 48);
            rotateCheckBox.TabIndex = 4;
            rotateCheckBox.Text = "ROTATE";
            rotateCheckBox.UseVisualStyleBackColor = true;
            // 
            // briggRadioButton
            // 
            briggRadioButton.AutoSize = true;
            briggRadioButton.Location = new Point(10, 237);
            briggRadioButton.Name = "briggRadioButton";
            briggRadioButton.Padding = new Padding(10);
            briggRadioButton.Size = new Size(90, 48);
            briggRadioButton.TabIndex = 3;
            briggRadioButton.Tag = "BRIGG";
            briggRadioButton.Text = "BRIGG";
            briggRadioButton.UseVisualStyleBackColor = true;
            // 
            // corvetteRadioButton
            // 
            corvetteRadioButton.AutoSize = true;
            corvetteRadioButton.Location = new Point(10, 173);
            corvetteRadioButton.Name = "corvetteRadioButton";
            corvetteRadioButton.Padding = new Padding(10);
            corvetteRadioButton.Size = new Size(116, 48);
            corvetteRadioButton.TabIndex = 2;
            corvetteRadioButton.Tag = "CORVETTE";
            corvetteRadioButton.Text = "CORVETTE";
            corvetteRadioButton.UseVisualStyleBackColor = true;
            // 
            // fregateRadioButton
            // 
            fregateRadioButton.AutoSize = true;
            fregateRadioButton.Location = new Point(10, 109);
            fregateRadioButton.Name = "fregateRadioButton";
            fregateRadioButton.Padding = new Padding(10);
            fregateRadioButton.Size = new Size(107, 48);
            fregateRadioButton.TabIndex = 1;
            fregateRadioButton.Tag = "FREGATE";
            fregateRadioButton.Text = "FREGATE";
            fregateRadioButton.UseVisualStyleBackColor = true;
            // 
            // lincoreRadioButton
            // 
            lincoreRadioButton.AutoSize = true;
            lincoreRadioButton.Checked = true;
            lincoreRadioButton.Location = new Point(10, 45);
            lincoreRadioButton.Name = "lincoreRadioButton";
            lincoreRadioButton.Padding = new Padding(10);
            lincoreRadioButton.Size = new Size(105, 48);
            lincoreRadioButton.TabIndex = 0;
            lincoreRadioButton.TabStop = true;
            lincoreRadioButton.Tag = "LINCORE";
            lincoreRadioButton.Text = "LINCORE";
            lincoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(briggSetLabel);
            groupBox1.Controls.Add(corvetteSetLabel);
            groupBox1.Controls.Add(fregateSetLabel);
            groupBox1.Controls.Add(lincoreSetLabel);
            groupBox1.Controls.Add(orientationSelectedLabel);
            groupBox1.Controls.Add(shipSelectedLabel);
            groupBox1.Controls.Add(notificationLabel);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.ForeColor = Color.Ivory;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(10);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(184, 344);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 173);
            label1.Name = "label1";
            label1.Size = new Size(169, 24);
            label1.TabIndex = 7;
            label1.Text = "SHIPS FOR DEPLOYMENT:";
            // 
            // briggSetLabel
            // 
            briggSetLabel.AutoSize = true;
            briggSetLabel.Location = new Point(3, 269);
            briggSetLabel.Name = "briggSetLabel";
            briggSetLabel.Size = new Size(55, 24);
            briggSetLabel.TabIndex = 6;
            briggSetLabel.Text = "BRIGG: ";
            // 
            // corvetteSetLabel
            // 
            corvetteSetLabel.AutoSize = true;
            corvetteSetLabel.Location = new Point(3, 245);
            corvetteSetLabel.Name = "corvetteSetLabel";
            corvetteSetLabel.Size = new Size(82, 24);
            corvetteSetLabel.TabIndex = 5;
            corvetteSetLabel.Text = "CORVETTE: ";
            // 
            // fregateSetLabel
            // 
            fregateSetLabel.AutoSize = true;
            fregateSetLabel.Location = new Point(3, 221);
            fregateSetLabel.Name = "fregateSetLabel";
            fregateSetLabel.Size = new Size(73, 24);
            fregateSetLabel.TabIndex = 4;
            fregateSetLabel.Text = "FREGATE: ";
            // 
            // lincoreSetLabel
            // 
            lincoreSetLabel.AutoSize = true;
            lincoreSetLabel.Location = new Point(3, 197);
            lincoreSetLabel.Name = "lincoreSetLabel";
            lincoreSetLabel.Size = new Size(71, 24);
            lincoreSetLabel.TabIndex = 3;
            lincoreSetLabel.Text = "LINCORE: ";
            // 
            // orientationSelectedLabel
            // 
            orientationSelectedLabel.AutoSize = true;
            orientationSelectedLabel.Location = new Point(3, 131);
            orientationSelectedLabel.Name = "orientationSelectedLabel";
            orientationSelectedLabel.Size = new Size(0, 24);
            orientationSelectedLabel.TabIndex = 2;
            // 
            // shipSelectedLabel
            // 
            shipSelectedLabel.AutoSize = true;
            shipSelectedLabel.Location = new Point(3, 107);
            shipSelectedLabel.Name = "shipSelectedLabel";
            shipSelectedLabel.Size = new Size(0, 24);
            shipSelectedLabel.TabIndex = 1;
            // 
            // notificationLabel
            // 
            notificationLabel.AutoSize = true;
            notificationLabel.ForeColor = Color.Crimson;
            notificationLabel.Location = new Point(3, 57);
            notificationLabel.Name = "notificationLabel";
            notificationLabel.Size = new Size(0, 24);
            notificationLabel.TabIndex = 0;
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox fleetGroupBox;
        private RadioButton lincoreRadioButton;
        private RadioButton briggRadioButton;
        private RadioButton corvetteRadioButton;
        private RadioButton fregateRadioButton;
        private CheckBox rotateCheckBox;
        private GroupBox groupBox1;
        private FlowLayoutPanel cellsFlowLayoutPanel;
        private Label notificationLabel;
        private Label shipSelectedLabel;
        private Label briggSetLabel;
        private Label corvetteSetLabel;
        private Label fregateSetLabel;
        private Label lincoreSetLabel;
        private Label orientationSelectedLabel;
        private Label label1;
    }
}
