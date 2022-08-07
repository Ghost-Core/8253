using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab7.Models;

namespace Lab7
{
	public partial class AddStudent : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnAdd_Click(object sender, System.EventArgs e)
		{

			if ((txtStudentName.Text == "" && drpStudentType.SelectedValue.ToString() == "-1" && Session["StudentList"] == null) || (txtStudentName.Text == "" && Session["StudentList"] == null))
			{

				TableRow rowNew = new TableRow();
				tblStudents.Rows.Add(rowNew);

				TableCell cell = new TableCell();
				rowNew.Cells.Add(cell);

				cell = new TableCell();
				rowNew.Cells.Add(cell);
				cell.Text = "No Student Yet!";
				cell.ForeColor = System.Drawing.Color.Red;

			}
			else if (drpStudentType.SelectedValue.ToString() == "-1" && Session["StudentList"] == null)
			{
				TableRow rowNew = new TableRow();
				tblStudents.Rows.Add(rowNew);

				TableCell cell = new TableCell();
				rowNew.Cells.Add(cell);

				cell = new TableCell();
				rowNew.Cells.Add(cell);
				cell.Text = "No Student Type Yet!";
				cell.ForeColor = System.Drawing.Color.Red;
			}
			else if ((txtStudentName.Text == "" && drpStudentType.SelectedValue.ToString() == "-1") || (txtStudentName.Text == "") || (drpStudentType.SelectedValue.ToString() == "-1"))
			{
				List<Student> students = new List<Student>();
				students = (List<Student>)Session["StudentList"];

				foreach (Student s in students)
				{
					TableRow rowNew = new TableRow();
					tblStudents.Rows.Add(rowNew);

					TableCell cell = new TableCell();
					rowNew.Cells.Add(cell);
					cell.Text = s.Id.ToString();

					cell = new TableCell();
					rowNew.Cells.Add(cell);
					cell.Text = s.Name;
				}
			}
			else
			{
				List<Student> students = new List<Student>();

				if (Session["StudentList"] == null)
				{
					Session["StudentList"] = students;
					Student student = new Student(txtStudentName.Text);
					students.Add(student);

					TableRow rowNew = new TableRow();
					tblStudents.Rows.Add(rowNew);

					TableCell cell = new TableCell();
					rowNew.Cells.Add(cell);
					cell.Text = student.Id.ToString();

					cell = new TableCell();
					rowNew.Cells.Add(cell);
					cell.Text = student.Name;
					cell.ForeColor = System.Drawing.Color.Empty;

				}
				else
				{
					students = (List<Student>)Session["StudentList"];
					Student student = new Student(txtStudentName.Text);
					students.Add(student);
					Session["StudentList"] = students;


					foreach (Student s in students) //error here
					{
						TableRow rowNew = new TableRow();
						tblStudents.Rows.Add(rowNew);

						TableCell cell = new TableCell();
						rowNew.Cells.Add(cell);
						cell.Text = s.Id.ToString();

						cell = new TableCell();
						rowNew.Cells.Add(cell);
						cell.Text = s.Name;
					}
				}
			}
			pnlResult.Visible = true;
			txtStudentName.Text = "";
			drpStudentType.SelectedValue = "-1";
		}
	}

}