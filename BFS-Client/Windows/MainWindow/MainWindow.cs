using BFS.Enums;
using BFS.Factories;
using BFS.Interfaces;
using BFS.Utils;
using System;
using System.Windows.Forms;

namespace BFSClient
{
    internal sealed partial class MainWindow : Form
    {
        IMatrix Matrix;
        IGraph Graph;
        IMatrixFactory MatrixFactory;
        bool StartSet = false;
        bool DestinationSet = false;
        bool MatrixInit = false;
        public MainWindow()
        {
            InitializeComponent();
            MatrixFactory = new MatrixFactory();
        }
        private void MatrixInitBttn_Click(object sender, EventArgs e)
        {
            int.TryParse(MatrixSizeInput.Text, out int matrixSize);

            try
            {
                Matrix = MatrixFactory.InitializeMatrix(Matrix, matrixSize);
                EmptyFields();
                DisplayMatrix();
                MatrixInit = true;
                StartSet = false;
                DestinationSet = false;
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

            try
            {
                IMatrixElement startElement = MatrixFactory.CreateMatrixElement(MatrixElementType.Start, xPosition - 1, yPosition - 1);
                Matrix.SetMatrixElement(startElement);
                DisplayMatrix();
                StartSet = true;
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
                Matrix.SetMatrixElement(destinationElement);
                DisplayMatrix();
                DestinationSet = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SearchRouteBttn_Click(object sender, EventArgs e)
        {
            if (!CanSearchRoute())
            {
                MessageBox.Show(Locales.Strings.CantSearchRoute);
                return;
            }

            Graph = MatrixConverter.ConvertMatrixToGraph(Matrix);
            DisplayGraph();
        }
        private bool CanSearchRoute() => MatrixInit && StartSet && DestinationSet;
        private bool IsStartPositionEmpty() => StartXPos.Text != "" && StartYPos.Text != "";
        private bool IsDestinationPositionEmpty() => DestinationXPos.Text != "" && DestinationYPos.Text != "";
        private bool IsMatrixInitialized() => Matrix != null;
        private void EmptyFields()
        {
            StartXPos.Text = "";
            StartYPos.Text = "";
            DestinationXPos.Text = "";
            DestinationYPos.Text = "";
        }
        private void DisplayMatrix() => MatrixDisplay.Text = Matrix.ToString();
        private void DisplayGraph()
        {
            MatrixDisplay.Text = Matrix.ToString() + Graph.ToString();
        }
    }
}
