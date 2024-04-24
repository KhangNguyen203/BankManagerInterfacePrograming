using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManager.Test
{
    public partial class YourForm : Form
    {
        private List<Person> people; // Danh sách đối tượng dữ liệu

        public YourForm()
        {
            InitializeComponent();
        }

        private void YourForm_Load(object sender, EventArgs e)
        {
            // Đặt cấu hình cho DataGridView
            dataGridView.AutoGenerateColumns = false;

            // Tạo các cột cho DataGridView
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Name";
            dataGridView.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn ageColumn = new DataGridViewTextBoxColumn();
            ageColumn.DataPropertyName = "Age";
            ageColumn.HeaderText = "Age";
            dataGridView.Columns.Add(ageColumn);

            DataGridViewTextBoxColumn addressColumn = new DataGridViewTextBoxColumn();
            addressColumn.DataPropertyName = "Address";
            addressColumn.HeaderText = "Address";
            dataGridView.Columns.Add(addressColumn);

            // Chuẩn bị dữ liệu
                people = new List<Person>
            {
                new Person { Name = "John", Age = 30, Address = "123 Main St" },
                new Person { Name = "Jane", Age = 25, Address = "456 Elm St" },
                new Person { Name = "Bob", Age = 40, Address = "789 Oak St" }
            };

            // Gán dữ liệu cho DataGridView
            dataGridView.DataSource = people;
            // Gán danh sách đối tượng vào ListBox
            listBox.DataSource = people;



            // Đặt cấu hình cho ListView
            listView.View = View.Details;
            listView.FullRowSelect = true;

            // Tạo các cột cho ListView
            listView.Columns.Add("Name", 120);
            listView.Columns.Add("Age", 50);
            listView.Columns.Add("Address", 200);

            // Hiển thị dữ liệu trong ListView
            foreach (Person person in people)
            {
                ListViewItem item = new ListViewItem(person.Name);
                item.SubItems.Add(person.Age.ToString());
                item.SubItems.Add(person.Address);
                listView.Items.Add(item);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi mục trong ListBox được chọn
            Person selectedPerson = listBox.SelectedItem as Person;
            if (selectedPerson != null)
            {
                // Hiển thị thông tin chi tiết của Person
                MessageBox.Show($"Name: {selectedPerson.Name}\nAge: {selectedPerson.Age}\nAddress: {selectedPerson.Address}");
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi mục trong ListView được chọn
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];
                string name = selectedItem.Text;
                string age = selectedItem.SubItems[1].Text;
                string address = selectedItem.SubItems[2].Text;

                // Hiển thị thông tin chi tiết của Person
                MessageBox.Show($"Name: {name}\nAge: {age}\nAddress: {address}");
            }
        }
    }
}
