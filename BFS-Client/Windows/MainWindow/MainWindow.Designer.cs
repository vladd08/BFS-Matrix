namespace BFSClient
{
    partial class MainWindow
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
            this.MatrixInitGroup = new System.Windows.Forms.GroupBox();
            this.MatrixInitBttn = new System.Windows.Forms.Button();
            this.MatrixSizeLabel = new System.Windows.Forms.Label();
            this.MatrixSizeInput = new System.Windows.Forms.TextBox();
            this.MatrixDisplay = new System.Windows.Forms.RichTextBox();
            this.StartPositionGroup = new System.Windows.Forms.GroupBox();
            this.StartYLabel = new System.Windows.Forms.Label();
            this.StartYPos = new System.Windows.Forms.TextBox();
            this.SetStartPositionBttn = new System.Windows.Forms.Button();
            this.StartXLabel = new System.Windows.Forms.Label();
            this.StartXPos = new System.Windows.Forms.TextBox();
            this.DestinationGroup = new System.Windows.Forms.GroupBox();
            this.DestinationYLabel = new System.Windows.Forms.Label();
            this.DestinationYPos = new System.Windows.Forms.TextBox();
            this.SetDestinationButton = new System.Windows.Forms.Button();
            this.DestinationXLabel = new System.Windows.Forms.Label();
            this.DestinationXPos = new System.Windows.Forms.TextBox();
            this.MatrixInitGroup.SuspendLayout();
            this.StartPositionGroup.SuspendLayout();
            this.DestinationGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MatrixInitGroup
            // 
            this.MatrixInitGroup.Controls.Add(this.MatrixInitBttn);
            this.MatrixInitGroup.Controls.Add(this.MatrixSizeLabel);
            this.MatrixInitGroup.Controls.Add(this.MatrixSizeInput);
            this.MatrixInitGroup.Location = new System.Drawing.Point(12, 12);
            this.MatrixInitGroup.Name = "MatrixInitGroup";
            this.MatrixInitGroup.Size = new System.Drawing.Size(183, 81);
            this.MatrixInitGroup.TabIndex = 0;
            this.MatrixInitGroup.TabStop = false;
            this.MatrixInitGroup.Text = "Initializare Careu";
            // 
            // MatrixInitBttn
            // 
            this.MatrixInitBttn.Location = new System.Drawing.Point(99, 52);
            this.MatrixInitBttn.Name = "MatrixInitBttn";
            this.MatrixInitBttn.Size = new System.Drawing.Size(75, 23);
            this.MatrixInitBttn.TabIndex = 3;
            this.MatrixInitBttn.Text = "Initializeaza";
            this.MatrixInitBttn.UseVisualStyleBackColor = true;
            this.MatrixInitBttn.Click += new System.EventHandler(this.MatrixInitBttn_Click);
            // 
            // MatrixSizeLabel
            // 
            this.MatrixSizeLabel.AutoSize = true;
            this.MatrixSizeLabel.Location = new System.Drawing.Point(6, 32);
            this.MatrixSizeLabel.Name = "MatrixSizeLabel";
            this.MatrixSizeLabel.Size = new System.Drawing.Size(65, 13);
            this.MatrixSizeLabel.TabIndex = 2;
            this.MatrixSizeLabel.Text = "Dimensiune:";
            // 
            // MatrixSizeInput
            // 
            this.MatrixSizeInput.Location = new System.Drawing.Point(74, 29);
            this.MatrixSizeInput.Name = "MatrixSizeInput";
            this.MatrixSizeInput.Size = new System.Drawing.Size(100, 20);
            this.MatrixSizeInput.TabIndex = 1;
            // 
            // MatrixDisplay
            // 
            this.MatrixDisplay.Location = new System.Drawing.Point(211, 12);
            this.MatrixDisplay.Name = "MatrixDisplay";
            this.MatrixDisplay.ReadOnly = true;
            this.MatrixDisplay.Size = new System.Drawing.Size(472, 353);
            this.MatrixDisplay.TabIndex = 1;
            this.MatrixDisplay.Text = "";
            // 
            // StartPositionGroup
            // 
            this.StartPositionGroup.Controls.Add(this.StartYLabel);
            this.StartPositionGroup.Controls.Add(this.StartYPos);
            this.StartPositionGroup.Controls.Add(this.SetStartPositionBttn);
            this.StartPositionGroup.Controls.Add(this.StartXLabel);
            this.StartPositionGroup.Controls.Add(this.StartXPos);
            this.StartPositionGroup.Location = new System.Drawing.Point(12, 99);
            this.StartPositionGroup.Name = "StartPositionGroup";
            this.StartPositionGroup.Size = new System.Drawing.Size(183, 81);
            this.StartPositionGroup.TabIndex = 4;
            this.StartPositionGroup.TabStop = false;
            this.StartPositionGroup.Text = "Pozitionare Robot";
            // 
            // StartYLabel
            // 
            this.StartYLabel.AutoSize = true;
            this.StartYLabel.Location = new System.Drawing.Point(57, 36);
            this.StartYLabel.Name = "StartYLabel";
            this.StartYLabel.Size = new System.Drawing.Size(14, 13);
            this.StartYLabel.TabIndex = 5;
            this.StartYLabel.Text = "Y";
            // 
            // StartYPos
            // 
            this.StartYPos.Location = new System.Drawing.Point(50, 52);
            this.StartYPos.Name = "StartYPos";
            this.StartYPos.Size = new System.Drawing.Size(35, 20);
            this.StartYPos.TabIndex = 4;
            // 
            // SetStartPositionBttn
            // 
            this.SetStartPositionBttn.Location = new System.Drawing.Point(99, 50);
            this.SetStartPositionBttn.Name = "SetStartPositionBttn";
            this.SetStartPositionBttn.Size = new System.Drawing.Size(75, 23);
            this.SetStartPositionBttn.TabIndex = 3;
            this.SetStartPositionBttn.Text = "Plaseaza";
            this.SetStartPositionBttn.UseVisualStyleBackColor = true;
            // 
            // StartXLabel
            // 
            this.StartXLabel.AutoSize = true;
            this.StartXLabel.Location = new System.Drawing.Point(20, 36);
            this.StartXLabel.Name = "StartXLabel";
            this.StartXLabel.Size = new System.Drawing.Size(14, 13);
            this.StartXLabel.TabIndex = 2;
            this.StartXLabel.Text = "X";
            // 
            // StartXPos
            // 
            this.StartXPos.Location = new System.Drawing.Point(9, 52);
            this.StartXPos.Name = "StartXPos";
            this.StartXPos.Size = new System.Drawing.Size(35, 20);
            this.StartXPos.TabIndex = 1;
            // 
            // DestinationGroup
            // 
            this.DestinationGroup.Controls.Add(this.DestinationYLabel);
            this.DestinationGroup.Controls.Add(this.DestinationYPos);
            this.DestinationGroup.Controls.Add(this.SetDestinationButton);
            this.DestinationGroup.Controls.Add(this.DestinationXLabel);
            this.DestinationGroup.Controls.Add(this.DestinationXPos);
            this.DestinationGroup.Location = new System.Drawing.Point(12, 186);
            this.DestinationGroup.Name = "DestinationGroup";
            this.DestinationGroup.Size = new System.Drawing.Size(183, 81);
            this.DestinationGroup.TabIndex = 5;
            this.DestinationGroup.TabStop = false;
            this.DestinationGroup.Text = "Marcheaza pozitii";
            // 
            // DestinationYLabel
            // 
            this.DestinationYLabel.AutoSize = true;
            this.DestinationYLabel.Location = new System.Drawing.Point(57, 36);
            this.DestinationYLabel.Name = "DestinationYLabel";
            this.DestinationYLabel.Size = new System.Drawing.Size(14, 13);
            this.DestinationYLabel.TabIndex = 5;
            this.DestinationYLabel.Text = "Y";
            // 
            // DestinationYPos
            // 
            this.DestinationYPos.Location = new System.Drawing.Point(50, 52);
            this.DestinationYPos.Name = "DestinationYPos";
            this.DestinationYPos.Size = new System.Drawing.Size(35, 20);
            this.DestinationYPos.TabIndex = 4;
            // 
            // SetDestinationButton
            // 
            this.SetDestinationButton.Location = new System.Drawing.Point(99, 50);
            this.SetDestinationButton.Name = "SetDestinationButton";
            this.SetDestinationButton.Size = new System.Drawing.Size(75, 23);
            this.SetDestinationButton.TabIndex = 3;
            this.SetDestinationButton.Text = "Marcheaza";
            this.SetDestinationButton.UseVisualStyleBackColor = true;
            // 
            // DestinationXLabel
            // 
            this.DestinationXLabel.AutoSize = true;
            this.DestinationXLabel.Location = new System.Drawing.Point(20, 36);
            this.DestinationXLabel.Name = "DestinationXLabel";
            this.DestinationXLabel.Size = new System.Drawing.Size(14, 13);
            this.DestinationXLabel.TabIndex = 2;
            this.DestinationXLabel.Text = "X";
            // 
            // DestinationXPos
            // 
            this.DestinationXPos.Location = new System.Drawing.Point(9, 52);
            this.DestinationXPos.Name = "DestinationXPos";
            this.DestinationXPos.Size = new System.Drawing.Size(35, 20);
            this.DestinationXPos.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(699, 377);
            this.Controls.Add(this.DestinationGroup);
            this.Controls.Add(this.StartPositionGroup);
            this.Controls.Add(this.MatrixDisplay);
            this.Controls.Add(this.MatrixInitGroup);
            this.MinimumSize = new System.Drawing.Size(715, 416);
            this.Name = "MainWindow";
            this.Text = "BFS Matrix";
            this.MatrixInitGroup.ResumeLayout(false);
            this.MatrixInitGroup.PerformLayout();
            this.StartPositionGroup.ResumeLayout(false);
            this.StartPositionGroup.PerformLayout();
            this.DestinationGroup.ResumeLayout(false);
            this.DestinationGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MatrixInitGroup;
        private System.Windows.Forms.Button MatrixInitBttn;
        private System.Windows.Forms.Label MatrixSizeLabel;
        private System.Windows.Forms.TextBox MatrixSizeInput;
        private System.Windows.Forms.RichTextBox MatrixDisplay;
        private System.Windows.Forms.GroupBox StartPositionGroup;
        private System.Windows.Forms.Label StartYLabel;
        private System.Windows.Forms.TextBox StartYPos;
        private System.Windows.Forms.Button SetStartPositionBttn;
        private System.Windows.Forms.Label StartXLabel;
        private System.Windows.Forms.TextBox StartXPos;
        private System.Windows.Forms.GroupBox DestinationGroup;
        private System.Windows.Forms.Label DestinationYLabel;
        private System.Windows.Forms.TextBox DestinationYPos;
        private System.Windows.Forms.Button SetDestinationButton;
        private System.Windows.Forms.Label DestinationXLabel;
        private System.Windows.Forms.TextBox DestinationXPos;
    }
}

