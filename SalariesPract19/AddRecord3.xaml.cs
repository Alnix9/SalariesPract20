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
using System.Windows.Shapes;

namespace SalariesPract19
{
    /// <summary>
    /// Логика взаимодействия для AddRecord3.xaml
    /// </summary>
    public partial class AddRecord3 : Window
    {
        public AddRecord3()
        {
            InitializeComponent();
            Height += 25;
        }
        SalariesPr19Entities db = SalariesPr19Entities.GetContext();
        TimeWorkedTimeSheetSheet p1 = new TimeWorkedTimeSheetSheet();
        private void Add_Click3(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (tbTimeSheetNumber.Text.Length == 0) errors.AppendLine("Введите табельный номер");
            if (tbTimeWorkedInDays.Text.Length == 0) errors.AppendLine("Введите кол-во отработанных дней");
            if (tbNumberOfMonth.Text.Length == 0) errors.AppendLine("Введите номер месяца");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            p1.TimeSheetNumber = Convert.ToInt32(tbTimeSheetNumber.Text);
            p1.TimeWorkedInDays = Convert.ToInt32(tbTimeWorkedInDays.Text);
            p1.NumberOfMonth = Convert.ToInt32(tbNumberOfMonth.Text);

            try
            {
                db.TimeWorkedTimeSheetSheets.Add(p1);
                db.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Cancel_Click3(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
