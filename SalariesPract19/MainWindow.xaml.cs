using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace SalariesPract19
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Height += 25;
        }
        SalariesPr19Entities db = SalariesPr19Entities.GetContext();
        SalaryHandbook p1 = new SalaryHandbook();
        StaffingTable p2 = new StaffingTable();
        TimeWorkedTimeSheetSheet p3 = new TimeWorkedTimeSheetSheet();
        DepartmentHandbook p4 = new DepartmentHandbook();
        StructuralEnterprise p5 = new StructuralEnterprise();

        //localhost\sqlexpress поставить в App.Config

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.SalaryHandbooks.Load();
            DataGridSalaries.ItemsSource = db.SalaryHandbooks.Local.ToBindingList();

            db.StaffingTables.Load();
            DataGridStaffingTable.ItemsSource = db.StaffingTables.Local.ToBindingList();

            db.TimeWorkedTimeSheetSheets.Load();
            DataGridTimeWorkedTimeSheetSheet.ItemsSource = db.TimeWorkedTimeSheetSheets.Local.ToBindingList();

            db.DepartmentHandbooks.Load();
            DataGridDepartmentHandbooks.ItemsSource = db.DepartmentHandbooks.Local.ToBindingList();

            db.StructuralEnterprises.Load();
            DataGridStructuralEnterprise.ItemsSource = db.StructuralEnterprises.Local.ToBindingList();
        }
        private void Requests_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Add_Click1(object sender, RoutedEventArgs e)
        {
            AddRecord1 f = new AddRecord1();
            f.ShowDialog();
            DataGridSalaries.Focus();
        }

        private void Delete_Click1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("Удалить запись?", "Удаление записи",
            MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    SalaryHandbook row = (SalaryHandbook)DataGridSalaries.SelectedItems[0];
                    db.SalaryHandbooks.Remove(row);
                    db.SaveChanges();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Выберите запись");
                }
            }
        }

        private void Add_Click2(object sender, RoutedEventArgs e)
        {
            AddRecord2 f = new AddRecord2();
            f.ShowDialog();
            DataGridStaffingTable.Focus();
        }

        private void Delete_Click2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("Удалить запись?", "Удаление записи",
            MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    StaffingTable row = (StaffingTable)DataGridStaffingTable.SelectedItems[0];
                    db.StaffingTables.Remove(row);
                    db.SaveChanges();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Выберите запись");
                }
            }
        }

        private void Add_Click3(object sender, RoutedEventArgs e)
        {
            AddRecord3 f = new AddRecord3();
            f.ShowDialog();
            DataGridTimeWorkedTimeSheetSheet.Focus();
        }

        private void Delete_Click3(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("Удалить запись?", "Удаление записи",
            MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    TimeWorkedTimeSheetSheet row = (TimeWorkedTimeSheetSheet)DataGridTimeWorkedTimeSheetSheet.SelectedItems[0];
                    db.TimeWorkedTimeSheetSheets.Remove(row);
                    db.SaveChanges();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Выберите запись");
                }
            }
        }

        private void Add_Click4(object sender, RoutedEventArgs e)
        {
            AddRecord4 f = new AddRecord4();
            f.ShowDialog();
            DataGridDepartmentHandbooks.Focus();
        }

        private void Delete_Click4(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("Удалить запись?", "Удаление записи",
            MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    DepartmentHandbook row = (DepartmentHandbook)DataGridDepartmentHandbooks.SelectedItems[0];
                    db.DepartmentHandbooks.Remove(row);
                    db.SaveChanges();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Выберите запись");
                }
            }
        }

        private void Add_Click5(object sender, RoutedEventArgs e)
        {
            AddRecord5 f = new AddRecord5();
            f.ShowDialog();
            DataGridStructuralEnterprise.Focus();
        }

        private void Delete_Click5(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("Удалить запись?", "Удаление записи",
            MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    StructuralEnterprise row = (StructuralEnterprise)DataGridStructuralEnterprise.SelectedItems[0];
                    db.StructuralEnterprises.Remove(row);
                    db.SaveChanges();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Выберите запись");
                }
            }
        }

        private void Find1_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < DataGridSalaries.Items.Count; i++)
            {
                var row = (SalaryHandbook)DataGridSalaries.Items[i];
                string findContent = row.Post;
                try
                {
                    if (findContent != null && findContent.Contains(tbFind1Text.Text))
                    {
                        object item = DataGridSalaries.Items[i];
                        DataGridSalaries.SelectedItem = item;
                        DataGridSalaries.ScrollIntoView(item);
                        DataGridSalaries.Focus();
                        break;
                    }
                }
                catch
                {
                }
            }
        }
        private void Find2_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < DataGridStaffingTable.Items.Count; i++)
            {
                var row = (StaffingTable)DataGridStaffingTable.Items[i];
                string findContent = row.Department.ToString();
                try
                {
                    if (findContent != null && findContent.Contains(tbFind2Text.Text))
                    {
                        object item = DataGridStaffingTable.Items[i];
                        DataGridStaffingTable.SelectedItem = item;
                        DataGridStaffingTable.ScrollIntoView(item);
                        DataGridStaffingTable.Focus();
                        break;
                    }
                }
                catch
                {
                }
            }
        }
        private void Find3_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < DataGridTimeWorkedTimeSheetSheet.Items.Count; i++)
            {
                var row = (TimeWorkedTimeSheetSheet)DataGridTimeWorkedTimeSheetSheet.Items[i];
                string findContent = row.TimeSheetNumber.ToString();
                try
                {
                    if (findContent != null && findContent.Contains(tbFind3Text.Text))
                    {
                        object item = DataGridTimeWorkedTimeSheetSheet.Items[i];
                        DataGridTimeWorkedTimeSheetSheet.SelectedItem = item;
                        DataGridTimeWorkedTimeSheetSheet.ScrollIntoView(item);
                        DataGridTimeWorkedTimeSheetSheet.Focus();
                        break;
                    }
                }
                catch
                {
                }
            }
        }
        private void Find4_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < DataGridDepartmentHandbooks.Items.Count; i++)
            {
                var row = (DepartmentHandbook)DataGridDepartmentHandbooks.Items[i];
                string findContent = row.Head;
                try
                {
                    if (findContent != null && findContent.Contains(tbFind4Text.Text))
                    {
                        object item = DataGridDepartmentHandbooks.Items[i];
                        DataGridDepartmentHandbooks.SelectedItem = item;
                        DataGridDepartmentHandbooks.ScrollIntoView(item);
                        DataGridDepartmentHandbooks.Focus();
                        break;
                    }
                }
                catch
                {
                }
            }
        }
        private void Find5_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < DataGridStructuralEnterprise.Items.Count; i++)
            {
                var row = (StructuralEnterprise)DataGridStructuralEnterprise.Items[i];
                string findContent = row.Department.ToString();
                try
                {
                    if (findContent != null && findContent.Contains(tbFind5Text.Text))
                    {
                        object item = DataGridStructuralEnterprise.Items[i];
                        DataGridStructuralEnterprise.SelectedItem = item;
                        DataGridStructuralEnterprise.ScrollIntoView(item);
                        DataGridDepartmentHandbooks.Focus();
                        break;
                    }
                }
                catch
                {
                }
            }
        }

        private void Department210ForRequest1(object sender, RoutedEventArgs e)
        {
            var Department1 = from p1 in db.StaffingTables
                              where p1.Department == 210
                              select p1;
            DataGridStaffingTable.ItemsSource = Department1.ToList();
        }

        private void Department211ForRequest1(object sender, RoutedEventArgs e)
        {
            var Department2 = from p1 in db.StaffingTables
                              where p1.Department == 211
                              select p1;
            DataGridStaffingTable.ItemsSource = Department2.ToList();

        }

        private void Department212ForRequest1(object sender, RoutedEventArgs e)
        {
            var Department3 = from p1 in db.StaffingTables
                              where p1.Department == 212
                              select p1;
            DataGridStaffingTable.ItemsSource = Department3.ToList();
        }

        private void Department213ForRequest1(object sender, RoutedEventArgs e)
        {
            var Department3 = from p1 in db.StaffingTables
                              where p1.Department == 213
                              select p1;
            DataGridStaffingTable.ItemsSource = Department3.ToList();
        }


        private void Department214ForRequest1(object sender, RoutedEventArgs e)
        {
            var Department3 = from p1 in db.StaffingTables
                              where p1.Department == 214
                              select p1;
            DataGridStaffingTable.ItemsSource = Department3.ToList();
        }
        private void Request2(object sender, RoutedEventArgs e)
        {
            var TimeWorkedInDays = from p1 in db.TimeWorkedTimeSheetSheets
                              where p1.TimeWorkedInDays == 22
                              select p1;
            DataGridTimeWorkedTimeSheetSheet.ItemsSource = TimeWorkedInDays.ToList();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }   
}
