using System;
using System.Printing;
using System.Windows;
using CLib1;

namespace WPF1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cbox.ItemsSource = new object[]
            {
                FuncEnum.CosSin,
                FuncEnum.CoshSinh,
                FuncEnum.Polynomials
            };
            cbox.SelectedIndex = 0;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            V3DataList empty_list = new(ID_input.Text, DateTime.Now);

            UniformGrid uform = new(-10, 1, Int32.Parse(nItem_input.Text));
            V3DataUGrid ugrid = new(ID_input.Text, DateTime.Now, uform, (FuncEnum)cbox.SelectedItem);

            empty_list.AddDefaults(Int32.Parse(nItem_input.Text), (FuncEnum)cbox.SelectedItem);
            base_tb.Text = empty_list.ToString();
            list_tb.ItemsSource = empty_list.Items;
            gridU_tb.ItemsSource = ugrid;
        }
    }
}
