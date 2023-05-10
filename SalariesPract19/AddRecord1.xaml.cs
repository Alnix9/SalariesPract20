using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
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
    /// Логика взаимодействия для AddRecord1.xaml
    /// </summary>
    public partial class AddRecord1 : Window
    {
        public AddRecord1()
        {
            InitializeComponent();
            Height += 25;
        }
        SalariesPr19Entities db = SalariesPr19Entities.GetContext();
        SalaryHandbook p1 = new SalaryHandbook();
        private void Add_Click1(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (tbPost.Text.Length == 0) errors.AppendLine("Введите должность");
            if (tbSalary.Text.Length == 0) errors.AppendLine("Введите номер отдела");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            p1.Post = tbPost.Text;
            p1.Salary = Convert.ToInt32(tbSalary.Text);

            try
            {
                db.SalaryHandbooks.Add(p1);
                db.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Cancel_Click1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
