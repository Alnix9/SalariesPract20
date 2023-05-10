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
    /// Логика взаимодействия для AddRecord2.xaml
    /// </summary>
    public partial class AddRecord2 : Window
    {
        public AddRecord2()
        {
            InitializeComponent();
            Height += 25;
        }
        SalariesPr19Entities db = SalariesPr19Entities.GetContext();
        StaffingTable p1 = new StaffingTable();
        private void Add_Click2(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (tbTimeSheetNumber.Text.Length == 0) errors.AppendLine("Введите табельный номер");
            if (tbFIO.Text.Length == 0) errors.AppendLine("Введите ФИО");
            if (tbPost.Text.Length == 0) errors.AppendLine("Введите должность");
            if (tbDepartment.Text.Length == 0) errors.AppendLine("Введите номер отдела");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            p1.TimeSheetNumber = Convert.ToInt32(tbTimeSheetNumber.Text);
            p1.FIO = tbFIO.Text;
            p1.Post = tbPost.Text;
            p1.Department = Convert.ToInt32(tbDepartment.Text);

            try
            {
                db.StaffingTables.Add(p1);
                db.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Cancel_Click2(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
