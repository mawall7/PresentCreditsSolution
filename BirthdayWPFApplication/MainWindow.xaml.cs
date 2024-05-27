using PresentCreditsApplication;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using static BirthdayWPFApplication.MainWindow.ReadText;

namespace BirthdayWPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        public void MoveBox(object sender, EventArgs e)
        {
            RollText();

        }
        public void RollText() //Single Responsibility to do
        {

            IDividable text = new Text();
            var reader = new TextReader(text);
            text1.Text = reader.Read(text.ReadChunks());//ReadChunks move to ReadText

            ThicknessAnimation tanimation = new ThicknessAnimation();
            DoubleAnimation animation = new DoubleAnimation();
            tanimation.From = new Thickness(0, -4650, 0, 0);/*/-5000*/

            tanimation.To = new Thickness(0, 500, 0, 0);//500
            tanimation.Duration = new Duration(TimeSpan.FromSeconds(5));
            tanimation.AutoReverse = true;
            tanimation.RepeatBehavior = RepeatBehavior.Forever;
            tanimation.SpeedRatio = 0.05;
            text1.BeginAnimation(MarginProperty, tanimation);

        }
           
            //public interface IReversable //could be inmplemented, but since it doesnt add much to the functionality it is left out.
            //{
            //    public string Reverse();
            //}



    }
}
