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
    /// Логика взаимодействия для AddRecord4.xaml
    /// </summary>
    public partial class AddRecord4 : Window
    {
        public AddRecord4()
        {
            InitializeComponent();
            Height += 25;
        }
        SalariesPr19Entities db = SalariesPr19Entities.GetContext();
        DepartmentHandbook p1 = new DepartmentHandbook();
        private void Add_Click4(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (tbDepartment.Text.Length == 0) errors.AppendLine("Введите номер отдела");
            if (tbNameOfDepartment.Text.Length == 0) errors.AppendLine("Введите название отдела");
            if (tbHead.Text.Length == 0) errors.AppendLine("Введите начальника");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            p1.Department = Convert.ToInt32(tbDepartment.Text);
            p1.NameOfDepartment = tbNameOfDepartment.Text;
            p1.Head = tbHead.Text;

            try
            {
                db.DepartmentHandbooks.Add(p1);
                db.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Cancel_Click4(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
