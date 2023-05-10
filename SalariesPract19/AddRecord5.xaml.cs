using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для AddRecord5.xaml
    /// </summary>
    public partial class AddRecord5 : Window
    {
        public AddRecord5()
        {
            InitializeComponent();
            Height += 25;
        }
        SalariesPr19Entities db = SalariesPr19Entities.GetContext();
        StructuralEnterprise p1 = new StructuralEnterprise();
        private void Add_Click5(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (tbStructuralUnit.Text.Length == 0) errors.AppendLine("Введите структурное подразделение");
            if (tbDepartment.Text.Length == 0) errors.AppendLine("Введите номер отдела");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            p1.StructuralUnit = tbStructuralUnit.Text;
            p1.Department = Convert.ToInt32(tbDepartment.Text);

            try
            {
                db.StructuralEnterprises.Add(p1);
                db.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Cancel_Click5(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
