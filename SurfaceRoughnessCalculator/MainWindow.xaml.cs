using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SurfaceRoughnessCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<float> txtIList = new List<float>();
        List<float> txtSList = new List<float>();
        public MainWindow()
        {
            InitializeComponent();
            //InitCompnentList();
        }

        public Tuple<double,double> CalculateSR()
        {
            float alpha_m = 0.0461f;
            List<float> alpha_c = new List<float>();

            for (int i=0; i<7; i++)
            {
                alpha_c.Add(((txtIList[2*i+1]-txtIList[2*i]-6)/(txtSList[2*i+1]-txtSList[2*i]))-alpha_m);
            }

            float alpha_avg;
            float sum = 0;

            for (int j=0; j<15; j++)
            {
                sum = sum + alpha_c[j];
            }

            alpha_avg = sum / 16;

            double x = alpha_avg;
            double y = Math.Pow(5.2458 * 2.71828, 0.0152 * x);

            Tuple<double, double> res = Tuple.Create<double, double>(x, y); // x,y values should be displayed

            return res;
        }

        public void InitCompnentList()
        {
            txtIList.Add(float.Parse(txtI1.Text));
            txtIList.Add(float.Parse(txtI2.Text));
            txtIList.Add(float.Parse(txtI3.Text));
            txtIList.Add(float.Parse(txtI4.Text));
            txtIList.Add(float.Parse(txtI5.Text));
            txtIList.Add(float.Parse(txtI6.Text));
            txtIList.Add(float.Parse(txtI7.Text));
            txtIList.Add(float.Parse(txtI8.Text));
            txtIList.Add(float.Parse(txtI9.Text));
            txtIList.Add(float.Parse(txtI10.Text));
            txtIList.Add(float.Parse(txtI11.Text));
            txtIList.Add(float.Parse(txtI12.Text));
            txtIList.Add(float.Parse(txtI13.Text));
            txtIList.Add(float.Parse(txtI14.Text));
            txtIList.Add(float.Parse(txtI15.Text));
            txtIList.Add(float.Parse(txtI16.Text));

            txtSList.Add(float.Parse(txtS1.Text));
            txtSList.Add(float.Parse(txtS2.Text));
            txtSList.Add(float.Parse(txtS3.Text));
            txtSList.Add(float.Parse(txtS4.Text));
            txtSList.Add(float.Parse(txtS5.Text));
            txtSList.Add(float.Parse(txtS6.Text));
            txtSList.Add(float.Parse(txtS7.Text));
            txtSList.Add(float.Parse(txtS8.Text));
            txtSList.Add(float.Parse(txtS9.Text));
            txtSList.Add(float.Parse(txtS10.Text));
            txtSList.Add(float.Parse(txtS11.Text));
            txtSList.Add(float.Parse(txtS12.Text));
            txtSList.Add(float.Parse(txtS13.Text));
            txtSList.Add(float.Parse(txtS14.Text));
            txtSList.Add(float.Parse(txtS15.Text));
            txtSList.Add(float.Parse(txtS16.Text));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
