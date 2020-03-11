using System;
using System.Collections.Generic;
using System.Data;
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

namespace ConnectionBDTryOut
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

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            LoadStudent();
            DeleteButton.IsEnabled = true;
            UpdateButton.IsEnabled = true;
        }

        private void LoadStudent()
        {
            StudentList.Items.Clear();
            Student student = new Student();
            for (int i = 0; i < student.ListOfStudent().Count; i++)
            {
                StudentList.Items.Add(student.ListOfStudent()[i]);
            }
        }

        private void StudentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student student = new Student();
            int aux = StudentList.SelectedItem.ToString().IndexOf("-", 0);
            int Id = int.Parse(StudentList.SelectedItem.ToString().Substring(0, aux).ToString().Trim());

            student = student.getStudent(Id);

            IDText.Text = student.Id.ToString();
            FirstNameText.Text = student.FirstName.ToString();
            LastNameText.Text = student.LastName.ToString();

            DeleteButton.IsEnabled = true;
            UpdateButton.IsEnabled = true;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student();
            int aux = StudentList.SelectedItem.ToString().IndexOf("-", 0);
            int Id = int.Parse(StudentList.SelectedItem.ToString().Substring(0, aux).ToString().Trim());
            if (student.DeleteStudent(Id))
            {
                MessageBox.Show("Student has been deleted!", "Delete");
            }
            else
            {
                MessageBox.Show("Something goes wrong, try again!", "Delete");
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {

            Student student = new Student();

            student.Id = int.Parse(IDText.Text);
            student.FirstName = FirstNameText.Text;
            student.LastName = LastNameText.Text;

            if (student.UpdateStudent(student))
            {
                MessageBox.Show("Student has been updated!", "Delete");
            }
            else
            {
                MessageBox.Show("Something goes wrong, try again!", "Delete");
            }
        }

        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            if(IDText.Text != "")
            {
                DeleteButton.IsEnabled = false;
                UpdateButton.IsEnabled = false;
                FirstNameText.Focus();
                IDText.Text = "";
                FirstNameText.Text = "";
                LastNameText.Text = "";
            }
            else
            {
                Student student = new Student();
                student.FirstName = FirstNameText.Text;
                student.LastName = LastNameText.Text;
                if(FirstNameText.Text == "" && LastNameText.Text == "")
                {
                    MessageBox.Show("Please, Fill the gaps", "Insert");
                }
                else
                {
                    student.InsertStudent(student);
                    MessageBox.Show("Student has been inserted", "Insert");
                }
                
            }
        }
    }
}
