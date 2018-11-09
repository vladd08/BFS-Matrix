using BFS.Enums;
using BFS.Factories;
using BFS.Interfaces;
using BFSClient.Exceptions;
using System;
using System.Collections.Generic;
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

        private IMatrix InitializeMatrixWithSize(int size)
        {
            if (matrixSize == 0)
                throw new InvalidOrNotExistentMatrixSizeException(Message: Locales.Strings.InvalidMatrixSize);

            List<IMatrixLine> lineList = new List<IMatrixLine>();
            for (int i = 0; i < size; i++)
            {
                List<IMatrixElement> elementList = new List<IMatrixElement>();
                for (int j = 0; j < size; j++)
                {
                    IMatrixElement matrixElement;
                    matrixElement = factory.CreateMatrixElement(MatrixElementType.Available, i, j);
                    elementList.Add(matrixElement);
                }
                IMatrixLine matrixLine = factory.CreateMatrixLine(elementList);
                lineList.Add(matrixLine);
            }
            IMatrix matrix = factory.CreateMatrix(lineList);
            return matrix;
        }

        private void MatrixInitBttn_Click(object sender, EventArgs e)
        {
            Int32.TryParse(MatrixSizeInput.Text, out matrixSize);

            try
            {
                matrix = InitializeMatrixWithSize(matrixSize);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
