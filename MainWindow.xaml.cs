using System;
using System.Windows;
using System.Windows.Controls;

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

        // Where picture is from  https://www.pexels.com/

            // Instantiate Variables

        public DateTime myFirstDate, mySecondDate;


        // Get First Date

        public void firstCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            firstlabel.Content = firstCalendar.SelectedDate.ToString();

            myFirstDate = firstCalendar.SelectedDate.Value;



        }

        // Get Second Date
        public void secondCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            secondlabel.Content = secondCalendar.SelectedDate.ToString();
            
            //secondlabel.Content = secondCalendar.SelectedDate.ToString();

            mySecondDate = secondCalendar.SelectedDate.Value;

            



        }


        // Button Click - Result Label and call blackout method

        private void resultButton_Click(object sender, RoutedEventArgs e)
        {

            resultLabel.Content = mySecondDate.Subtract(myFirstDate).TotalDays;

            // resultLabel.Content =  myFirstDate.Subtract(mySecondDate).ToString();



            //resultLabel.Content = myFirstDate.ToString();

            SetBlackOutDates(myFirstDate, mySecondDate);

        }

        // Black out method

        private void SetBlackOutDates(DateTime startDate, DateTime endDate)
        {
            lastCalendar.BlackoutDates.Add(new CalendarDateRange(startDate, endDate));


        }


    }
}
