
namespace Sorting
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AlgorithmsComboBox = new System.Windows.Forms.ComboBox();
            this.ArrayPanel = new System.Windows.Forms.Panel();
            this.RandomizeButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.AlgLabel = new System.Windows.Forms.Label();
            this.ArraySizeLabel = new System.Windows.Forms.Label();
            this.ArraySizeComboBox = new System.Windows.Forms.ComboBox();
            this.SlowModeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AlgorithmsComboBox
            // 
            this.AlgorithmsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlgorithmsComboBox.FormattingEnabled = true;
            this.AlgorithmsComboBox.Location = new System.Drawing.Point(112, 12);
            this.AlgorithmsComboBox.Name = "AlgorithmsComboBox";
            this.AlgorithmsComboBox.Size = new System.Drawing.Size(147, 28);
            this.AlgorithmsComboBox.TabIndex = 0;
            // 
            // ArrayPanel
            // 
            this.ArrayPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ArrayPanel.Location = new System.Drawing.Point(19, 129);
            this.ArrayPanel.Name = "ArrayPanel";
            this.ArrayPanel.Size = new System.Drawing.Size(980, 465);
            this.ArrayPanel.TabIndex = 2;
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomizeButton.Location = new System.Drawing.Point(277, 70);
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Size = new System.Drawing.Size(135, 42);
            this.RandomizeButton.TabIndex = 3;
            this.RandomizeButton.Text = "Shuffle";
            this.RandomizeButton.UseVisualStyleBackColor = true;
            this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortButton.Location = new System.Drawing.Point(662, 70);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(135, 42);
            this.SortButton.TabIndex = 4;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // AlgLabel
            // 
            this.AlgLabel.AutoSize = true;
            this.AlgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlgLabel.Location = new System.Drawing.Point(12, 13);
            this.AlgLabel.Name = "AlgLabel";
            this.AlgLabel.Size = new System.Drawing.Size(84, 20);
            this.AlgLabel.TabIndex = 5;
            this.AlgLabel.Text = "Algorithms";
            // 
            // ArraySizeLabel
            // 
            this.ArraySizeLabel.AutoSize = true;
            this.ArraySizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArraySizeLabel.Location = new System.Drawing.Point(297, 13);
            this.ArraySizeLabel.Name = "ArraySizeLabel";
            this.ArraySizeLabel.Size = new System.Drawing.Size(77, 20);
            this.ArraySizeLabel.TabIndex = 6;
            this.ArraySizeLabel.Text = "ArraySize";
            // 
            // ArraySizeComboBox
            // 
            this.ArraySizeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArraySizeComboBox.FormattingEnabled = true;
            this.ArraySizeComboBox.Location = new System.Drawing.Point(404, 12);
            this.ArraySizeComboBox.Name = "ArraySizeComboBox";
            this.ArraySizeComboBox.Size = new System.Drawing.Size(144, 28);
            this.ArraySizeComboBox.TabIndex = 7;
            // 
            // SlowModeCheckBox
            // 
            this.SlowModeCheckBox.AutoSize = true;
            this.SlowModeCheckBox.Enabled = false;
            this.SlowModeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlowModeCheckBox.Location = new System.Drawing.Point(662, 14);
            this.SlowModeCheckBox.Name = "SlowModeCheckBox";
            this.SlowModeCheckBox.Size = new System.Drawing.Size(102, 24);
            this.SlowModeCheckBox.TabIndex = 9;
            this.SlowModeCheckBox.Text = "SlowMode";
            this.SlowModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 630);
            this.Controls.Add(this.SlowModeCheckBox);
            this.Controls.Add(this.ArraySizeComboBox);
            this.Controls.Add(this.ArraySizeLabel);
            this.Controls.Add(this.AlgLabel);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.RandomizeButton);
            this.Controls.Add(this.ArrayPanel);
            this.Controls.Add(this.AlgorithmsComboBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sorting Visualizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AlgorithmsComboBox;
        private System.Windows.Forms.Panel ArrayPanel;
        private System.Windows.Forms.Button RandomizeButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Label AlgLabel;
        private System.Windows.Forms.Label ArraySizeLabel;
        private System.Windows.Forms.ComboBox ArraySizeComboBox;
        private System.Windows.Forms.CheckBox SlowModeCheckBox;
    }
}

