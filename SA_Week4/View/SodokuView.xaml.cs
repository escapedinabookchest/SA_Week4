using SA_Week4.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SA_Week4.View
{
    public partial class SodokuView : Window
    {
        SodokuViewModel _sodokuViewModel;

        public SodokuView(SodokuViewModel sodokuViewModel)
        {
            _sodokuViewModel = sodokuViewModel;
            InitializeComponent();
            getGrid();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool blah = _sodokuViewModel.Game.FillIn(cmbX.SelectedIndex + 1, cmbY.SelectedIndex + 1, cmbValue.SelectedIndex + 1);

            if(blah == true)
            {
                getGrid();
            }
        }

        public void getGrid()
        {
            SudokuGrid.Children.Clear();

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    int value = _sodokuViewModel.Game.GetSquare(i, j);

                    Label lbl = new Label()
                    {
                        FontSize = 18,
                        BorderBrush = Brushes.Black,
                        BorderThickness = new Thickness(1, 1, 0, 0),
                        HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center,
                        VerticalContentAlignment = System.Windows.VerticalAlignment.Center,

                    };

                    lbl.Content = (value != 0) ? value : lbl.Content = "";

                    if ((i == 3 && j == 3) || (i == 6 && j == 3) || (i == 9 && j == 3))
                    {
                        lbl.BorderThickness = new Thickness(1, 1, 1, 1);
                    }

                    else if ((i == 3 && j == 6) || (i == 6 && j == 6) || (i == 9 && j == 6))
                    {
                        lbl.BorderThickness = new Thickness(1, 1, 1, 1);
                    }

                    else if ((i == 3 && j == 9) || (i == 6 && j == 9) || (i == 9 && j == 9))
                    {
                        lbl.BorderThickness = new Thickness(1, 1, 1, 1);
                    }

                    else if (i == 3 || i == 6 || i == 9)
                    {
                        lbl.BorderThickness = new Thickness(1, 1, 0, 1);
                    }

                    else if (j == 3 || j == 6 || j == 9)
                    {
                        lbl.BorderThickness = new Thickness(1, 1, 1, 0);
                    }

                    Grid.SetRow(lbl, i - 1);
                    Grid.SetColumn(lbl, j - 1);
                    SudokuGrid.Children.Add(lbl);
                }
            }
        }
    }
}