using BFS.Enums;
using BFS.Factories;
using BFS.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BFS
{
    internal partial class MainWindow : Form
    {
        IMatrix matrix;
        IMatrixFactory MatrixFactory;
        int matrixSize = 0;

        public MainWindow()
        {
            InitializeComponent();
            MatrixFactory = new MatrixFactory();
        }

        private void MatrixInitBttn_Click(object sender, EventArgs e)
        {
            int.TryParse(MatrixSizeInput.Text, out matrixSize);

            try
            {
                matrix = MatrixFactory.InitializeMatrix(matrix, matrixSize);
                EmptyFields();
                DisplayMatrix();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetStartPositionBttn_Click(object sender, EventArgs e)
        {
            if (!IsStartPositionEmpty())
            {
                MessageBox.Show(Locales.Strings.EmptyPosition);
                return;
            }

            if (!IsMatrixInitialized())
            {
                MessageBox.Show(Locales.Strings.MatrixNotInitialized);
                return;
            }

            int.TryParse(StartXPos.Text, out int xPosition);
            int.TryParse(StartYPos.Text, out int yPosition);

            IMatrixElement robotElement = MatrixFactory.CreateMatrixElement(MatrixElementType.Robot, xPosition - 1, yPosition - 1);
            try
            {
                matrix.SetMatrixElement(robotElement);
                DisplayMatrix();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetDestinationButton_Click(object sender, EventArgs e)
        {
            if (!IsDestinationPositionEmpty())
            {
                MessageBox.Show(Locales.Strings.EmptyPosition);
                return;
            }

            if (!IsMatrixInitialized())
            {
                MessageBox.Show(Locales.Strings.MatrixNotInitialized);
                return;
            }

            int.TryParse(DestinationXPos.Text, out int xPosition);
            int.TryParse(DestinationYPos.Text, out int yPosition);

            IMatrixElement destinationElement = MatrixFactory.CreateMatrixElement(MatrixElementType.Destination, xPosition - 1, yPosition - 1);
            try
            {
                matrix.SetMatrixElement(destinationElement);
                DisplayMatrix();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisplayMatrix() => MatrixDisplay.Text = matrix.ToString();

        private bool IsStartPositionEmpty() => StartXPos.Text != "" && StartYPos.Text != "";

        private bool IsDestinationPositionEmpty() => DestinationXPos.Text != "" && DestinationYPos.Text != "";

        private bool IsMatrixInitialized() => matrix != null;

        private void EmptyFields()
        {
            StartXPos.Text = "";
            StartYPos.Text = "";
            DestinationXPos.Text = "";
            DestinationYPos.Text = "";
        }
    }
}
