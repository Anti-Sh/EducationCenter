using System;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using Education_Center.Forms;

namespace Education_Center.Classes
{
	internal class DirectionTreeNode : ManagerTreeNode
	{
		private string directionName;
		internal string DirectionName
		{
			get { return directionName; }
			set { directionName = value; }
		}

		private string managerFirstName;
		internal string ManagerFirstName
		{
			get { return managerFirstName; }
			set { managerFirstName = value; }
		}

		private string managerLastName;
		internal string ManagerLastName
		{
			get { return managerLastName; }
			set { managerLastName = value; }
		}

		private string managerFatherName;
		internal string ManagerFatherName
		{
			get { return managerFatherName; }
			set { managerFatherName = value; }
		}

		private int directionID;
		internal int DirectionID
		{
			get { return directionID; }
			set { directionID = value; }
		}

		private string directionNote;
		internal string DirectionNote
		{
			get { return directionNote; }
			set { directionNote = value; }
		}

		private int managerID;
		internal int ManagerID
		{
			get { return managerID;}
			set { managerID = value;}
		}

		public override string ToString()
		{
			return directionName;
		}

		internal override void GetChilds()
		{
			DataView dvCourse = new DataView(MySQL.GetDataBase("course"));
			dvCourse.RowFilter = "directionID = " + this.directionID.ToString();
			
			CourseTreeNode[] ctns = new CourseTreeNode[dvCourse.Count];
			CourseTreeNode ctn = null;

			int i = 0;
			foreach (DataRowView drv in dvCourse)
			{
				DataRow dr = drv.Row;
				ctn = new CourseTreeNode();

				ctn.DirectionID = this.directionID;
				ctn.CourseID = int.Parse(dr["courseID"].ToString());
				ctn.CourseName = ctn.Text = dr["courseName"].ToString();
				ctn.CoursePrice = (decimal)dr["priceNumber"];

            ctn.ImageIndex = 10;
				ctn.ForeColor = Color.Green;
				ctn.GetChilds();

				ctn.Tag = dr; // Теперь мы можем обращаться к элементам в ListView по tag-у

				ctns[i++] = ctn;
				ctn = null;
			}
			
			this.ForeColor = Color.RoyalBlue;
			this.Nodes.AddRange(ctns);
		}
	}
}