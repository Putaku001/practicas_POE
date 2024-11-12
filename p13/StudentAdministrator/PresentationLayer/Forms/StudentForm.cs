using BusinessLayer.Services;
using CommonLayer.Entities;
using CommonLayer.Enums;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.ComponentModel;

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

			QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

			_studentService = new StudentService();
			_careerService = new CareerService();

			LoadCbxCareers();
			LoadStudenData();
			dgvStudent.Columns["idCareerStudent"].Visible = false;

			SetPermissions();
		}

		private void SetPermissions()
		{
			if (AuthUser.idRol == (int)RolEnum.admin)
			{
				btnSave.Enabled = true;
				btnSave.Visible = true;

				btnEdit.Enabled = true;
				btnEdit.Visible = true;

				btnDelete.Enabled = true;
				btnDelete.Visible = true;

				btnShowCareer.Enabled = true;
				btnShowCareer.Visible = true;

				btnGeneratePDF.Enabled = true;
				btnGeneratePDF.Visible = true;
			}

			if (AuthUser.idRol == (int)RolEnum.teacher)
			{
				btnSave.Enabled = true;
				btnSave.Visible = true;

				btnEdit.Enabled = true;
				btnEdit.Visible = true;

				btnDelete.Enabled = false;
				btnDelete.Visible = false;

				btnShowCareer.Enabled = false;
				btnShowCareer.Visible = false;

				btnGeneratePDF.Enabled = true;
				btnGeneratePDF.Visible = true;
			}
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

		private void btnGeneratePDF_Click(object sender, EventArgs e)
		{
			var studentList = new List<Student>();

			foreach (DataGridViewRow row in dgvStudent.Rows)
			{
				if (row.IsNewRow) continue;

				var student = new Student
				{
					idStudent = Convert.ToInt32(row.Cells[0].Value),
					nameStudent = row.Cells[1].Value.ToString(),
					lastnameStudent = row.Cells[2].Value.ToString(),
					nameCareerStudent = row.Cells[4].Value.ToString()
				};

				studentList.Add(student);
			}

			Document.Create(container =>
			{
				container.Page(page =>
				{
					page.Margin(1, Unit.Centimetre);

					page.Header().Height(35).Background(Colors.Green.Accent4).Text("Reporte de Estudiantes")
					.Bold().AlignCenter().FontSize(20).FontColor(Colors.White);

					page.Content()
						.Column(column =>
						{

							column.Item().PaddingLeft(1, Unit.Centimetre).PaddingTop(1, Unit.Centimetre).Table(table =>
							{
								table.ColumnsDefinition(columns =>
								{
									columns.RelativeColumn();
									columns.RelativeColumn();
									columns.RelativeColumn();
									columns.RelativeColumn();
								});

								table.Header(header =>
								{
									header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1)
										.Text("ID Estudiante").Bold().FontColor(Colors.White);

									header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1)
										.Text("Nombre").Bold().FontColor(Colors.White);

									header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1)
										.Text("Apellido").Bold().FontColor(Colors.White);

									header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1)
										.Text("Carrera").Bold().FontColor(Colors.White);
								});


								bool isAlternate = false;
								foreach (var student in studentList)
								{
									var backgroundColor = isAlternate ? Colors.Grey.Lighten3 : Colors.White;
									isAlternate = !isAlternate;

									table.Cell().Element(CellStyle).Background(backgroundColor).Text(student.idStudent);
									table.Cell().Element(CellStyle).Background(backgroundColor).Text(student.nameStudent);
									table.Cell().Element(CellStyle).Background(backgroundColor).Text(student.lastnameStudent);
									table.Cell().Element(CellStyle).Background(backgroundColor).Text(student.nameCareerStudent);
								}

								QuestPDF.Infrastructure.IContainer CellStyle(QuestPDF.Infrastructure.IContainer container) => container
									.Border(1)
									.BorderColor(Colors.Grey.Darken1);
							});
						});
				});
			}).GeneratePdfAndShow();
			MessageBox.Show("Reporte PDF generado exitosamente!");
		}

		private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Hide();
			LoginForm loginForm = new LoginForm();
			loginForm.ShowDialog();
		}
	}
}
