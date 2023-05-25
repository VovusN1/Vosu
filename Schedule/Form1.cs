using System;
using Microsoft.EntityFrameworkCore;
using Schedule.Models.ReferenceBooksModule;
using Schedule.Models.ReferenceBookModule;
using Schedule.Models.ContingentModule;
using Schedule.Models.GeneralModule;
using Schedule.Context;
using Schedule.Controllers;
using Microsoft.Extensions.DependencyInjection;
using System.Data.Entity;
using System.Xml.Linq;
using Microsoft.IdentityModel.Tokens;

namespace Schedule
{
    public partial class Form1 : Form
    {
        private MainContext _dbContext;
        private ControllerEmp _ControllerEmp;
        public Form1()
        {
            InitializeComponent();
            _dbContext = new MainContext();
            _ControllerEmp = new ControllerEmp(_dbContext);
        }

        //private void Output(object sender, EventArgs e)
        //{
        //    dataGridView1.AutoGenerateColumns = false;
        //    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Id", DataPropertyName = "Id" });
        //    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Фамилия", DataPropertyName = "FirstName" });
        //    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Имя", DataPropertyName = "LastName" });
        //    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Отчество", DataPropertyName = "Patronymic" });

        //    dataGridView1.DataSource = _ControllerEmp.GetAll();
        //}

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var employee = _ControllerEmp.GetAllEMP().FirstOrDefault(p => p.Id == id);
                if (employee != null)
                {
                    employee.FirstName = textBox1.Text;
                    employee.LastName = textBox2.Text;
                    employee.Patronymic = textBox3.Text;
                    _ControllerEmp.Update(employee);
                    dataGridView1.DataSource = _ControllerEmp.GetAllEMP();
                    //dataGridView1.DataSource = _ControllerEmp.GetAll();
                }
            }
        }
        private void GridLoad()
        {
            if (tabControl1.TabPages.IndexOfKey("PageTeachers") == 0)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Id", DataPropertyName = "Id" });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Фамилия", DataPropertyName = "FirstName" });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Имя", DataPropertyName = "LastName" });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Отчество", DataPropertyName = "Patronymic" });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Кабинет", DataPropertyName = "Auditorium.Name"}); 
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.DataSource = _ControllerEmp.GetAllEMP();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //tabControl1.TabPages.Equals("PageTeachers")
            GridLoad();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                var employee = new Employee()
                {
                    FirstName = textBox1.Text,
                    LastName = textBox2.Text,
                    Patronymic = textBox3.Text,
                    Active = true,
                    IdPost = 10,
                    IdAuditorium = 1,
                };
                _ControllerEmp.Add(employee);
                dataGridView1.DataSource = _ControllerEmp.GetAllEMP();

            }
            else
            {
                MessageBox.Show("Введите Данные!");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                _ControllerEmp.Delete(id);
                dataGridView1.DataSource = _ControllerEmp.GetAllEMP();

            }
        }
    }
}