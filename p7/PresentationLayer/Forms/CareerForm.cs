using BusinessLayer.Services;
using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
	public partial class CareerForm : Form
	{
		private CareerService _careerService;
		bool isEditing = false;

		public CareerForm()
		{
			_careerService = new CareerService();
			InitializeComponent();
			LoadCareerData();
		}

		private void LoadCareerData()
		{
			dgvCareers.DataSource = _careerService.GetAllDoctors();
		}

	}
}
