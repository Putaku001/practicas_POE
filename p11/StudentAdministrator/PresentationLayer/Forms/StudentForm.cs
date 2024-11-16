using BusinessLayer.Services;
using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class StudentForm : Form
    {
        private StudentService _studentService;
        private CareerService _careerService;
        bool isEditing = false;

        public StudentForm()
        {
            InitializeComponent();
            _studentService = new StudentService();
            _careerService = new CareerService();

            LoadCbxCareers();
            LoadStudenData();
        }

        private void LoadCbxCareers()
        {
            cbxCareerStudent.DataSource = _careerService.GetAllCareers();
            cbxCareerStudent.DisplayMember = "nameCareer";
            cbxCareerStudent.ValueMember = "idCareer";
        }

        private void LoadStudenData()
        {
            dgvStudent.DataSource = _studentService.GetAllStudent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            if (isEditing)
            {
                student.idStudent = int.Parse(dgvStudent.CurrentRow.Cells[0].Value.ToString());
                student.nameStudent = txtNameStudent.Text;
                student.lastnameStudent = txtLastnameStudent.Text;
                student.idCareerStudent = Convert.ToInt32(cbxCareerStudent.SelectedValue);

                _studentService.UpdateStudent(student);

                isEditing = false;
            }
            else
            {
                student.nameStudent = txtNameStudent.Text;
                student.lastnameStudent = txtLastnameStudent.Text;
                student.idCareerStudent = Convert.ToInt32(cbxCareerStudent.SelectedValue);

                _studentService.AddStudent(student);
            }
            LoadStudenData();
            cleanParameters();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                txtNameStudent.Text = dgvStudent.CurrentRow.Cells[1].Value.ToString();
                txtLastnameStudent.Text = dgvStudent.CurrentRow.Cells[2].Value.ToString();
                cbxCareerStudent.SelectedValue = dgvStudent.CurrentRow.Cells[3].Value.ToString();
                isEditing = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var deleteConfirm = new DialogResult();

                deleteConfirm = MessageBox.Show("¿Está seguro que desea eliminar el dato?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteConfirm == DialogResult.Yes)
                {
                    int id = int.Parse(dgvStudent.CurrentRow.Cells[0].Value.ToString());
                    _studentService.DeleteStudente(id);
                    LoadStudenData();
                    cleanParameters();
                }
            }
        }

        public void cleanParameters()
        {
            txtNameStudent.Clear();
            txtLastnameStudent.Clear();
            txtNameStudent.Focus();
        }

        private void btnShowCareer_Click(object sender, EventArgs e)
        {
            CareerForm career = new CareerForm();
            career.FormClosed += (s, args) => LoadCbxCareers();
            career.ShowDialog();
        }
    }
}
