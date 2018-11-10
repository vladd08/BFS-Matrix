using BFS.Factories;
using BFS.Interfaces;
using System;
using System.Windows.Forms;

namespace BFSClient
{
    internal partial class MainWindow : Form
    {
        IMatrix matrix;
        IMatrixFactory factory;
        int matrixSize = 0;

        public MainWindow()
        {
            InitializeComponent();
            factory = new MatrixFactory();
        }

        private void MatrixInitBttn_Click(object sender, EventArgs e)
        {
            int.TryParse(MatrixSizeInput.Text, out matrixSize);

            try
            {
                matrix = factory.InitializeMatrix(matrix, matrixSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
