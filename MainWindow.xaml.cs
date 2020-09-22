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

namespace WpfApp9
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

        public DateTime myFirstDate, mySecondDate;


        // Get First Date

        public void firstCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            firstlabel.Content = firstCalendar.SelectedDate.ToString();

            myFirstDate = firstCalendar.SelectedDate.Value;



        }


        public void secondCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            secondlabel.Content = secondCalendar.SelectedDate.ToString();
            
            //secondlabel.Content = secondCalendar.SelectedDate.ToString();

            mySecondDate = secondCalendar.SelectedDate.Value;

            



        }




        private void resultButton_Click(object sender, RoutedEventArgs e)
        {

            resultLabel.Content = mySecondDate.Subtract(myFirstDate).TotalDays;

            // resultLabel.Content =  myFirstDate.Subtract(mySecondDate).ToString();



            //resultLabel.Content = myFirstDate.ToString();

            SetBlackOutDates(myFirstDate, mySecondDate);

        }


        private void SetBlackOutDates(DateTime startDate, DateTime endDate)
        {
            lastCalendar.BlackoutDates.Add(new CalendarDateRange(startDate, endDate));


        }


    }
}
