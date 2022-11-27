using System;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using Education_Center.Forms;

namespace Education_Center.Classes
{
	internal class CourseTreeNode : ManagerTreeNode
	{
		private int directionID;
		internal int DirectionID
		{
			get { return directionID; }
			set { directionID = value; }
		}

		private int courseID;
		internal int CourseID
		{
			get { return courseID; }
			set { courseID = value; }
		}
		
		private string courseName;
		internal string CourseName
		{
			get {return courseName;}
			set {courseName = value;}
		}

		private decimal coursePrice;
		internal decimal CoursePrice
		{
			get { return coursePrice; }
			set { coursePrice = value; }
		}

		public override string ToString()
		{
			return courseName;
		}

		internal override void GetChilds()
		{
			DataView dvGroups = new DataView(MySQL.GetDataBase("groups"));
			dvGroups.RowFilter = "courseID = " + this.courseID.ToString();

			GroupTreeNode[] gtns = new GroupTreeNode[dvGroups.Count];
			GroupTreeNode gtn = null;
			
			int i = 0;
			foreach (DataRowView drv in dvGroups)
			{
				DataRow dr = drv.Row;
				gtn = new GroupTreeNode();
				
				gtn.CourseID = this.courseID;
				gtn.GroupID = (int)dr["groupID"];

				gtn.BeginDate = (DateTime)dr["beginDate"];
				gtn.EndDate = (DateTime)dr["endDate"];
				gtn.BeginTime = (DateTime)dr["beginTime"];
				gtn.EndTime = (DateTime)dr["endTime"];

				gtn.ClientsCount = (int)dr["clientsCount"];
				gtn.ClassNumber = (int)dr["classNumber"];
				gtn.CourseID = (int)dr["courseID"];
				gtn.EmployeeID = (int)dr["employeeID"];
		      gtn.GroupNote = dr["note"].ToString();
				gtn.Status = (int)dr["statusID"];

				gtn.Text = gtn.GroupID.ToString();
				gtn.ImageIndex = 6;

				if ((int)dr["StatusID"] == 1) // Группа набирается
				{
					gtn.ForeColor = Color.Red;
				}
				else if ((int)dr["StatusID"] == 2) // Группа обучается
				{
					gtn.ForeColor = Color.Green;
				}
				else if ((int)dr["StatusID"] == 3) // Группа закончила обучение
				{
					gtn.ForeColor = Color.Blue;
				}

				gtn.Tag = dr;
			
				gtns[i++] = gtn;
				gtn = null;
			}
			

			this.ForeColor = Color.Green;
			
			this.Nodes.AddRange(gtns);		
		}
	}
}