using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace HR_Department
{
    public partial class Form1 : Form
    {
        string path1;
        string path2;
        XDocument doc1;
        XDocument doc2;
        string photoPath;
        string photoName;
        public Form1()
        {
            InitializeComponent();
            path1= @"..\..\Data\Departments.xml";
            path2 = @"..\..\Data\Employees.xml";
            doc1 = XDocument.Load(path1);
            doc2 = XDocument.Load(path2);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var deps = doc1.Element("root").Elements("department").ToList();
            foreach (var dep in deps)
                depList.Items.Add(dep.Attribute("name").Value);
            if (depList.Items.Count>0)
                depList.SelectedIndex = 0;
        }
        private void depAdd_Click(object sender, EventArgs e)
        {
            string name = depName.Text;
            if(String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Вы не указали имя департамента", "Предупреждение",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                depList.Items.Add(name);
                doc1.Element("root").Add(
                    new XElement("department",
                    new XAttribute("name", name)));
                doc1.Save(path1);
                depName.Clear();
                MessageBox.Show("Департамент успешно добавлен", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void depDel_Click(object sender, EventArgs e)
        {
            if (depList.SelectedItem==null)
            {
                MessageBox.Show("Вы не указали имя департамента", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var result = MessageBox.Show($"Вы уверены что хотите удалить департамент {depList.SelectedItem}?", "Предупреждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    doc1.Element("root").Elements("department")
                    .Where(x => x.Attribute("name").Value == depList.SelectedItem.ToString()).Remove();
                    depList.Items.Remove(depList.SelectedItem);
                    doc1.Save(path1);
                    MessageBox.Show("Департамент успешно удалён", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void depSave_Click(object sender, EventArgs e)
        {
            string name = depName.Text;
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Вы не указали новое имя департамента", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string newName = depName.Text;
                string dep_name = depList.SelectedItem.ToString();
                depList.Items.Remove(dep_name);
                depList.Items.Add(newName);
                var deps = doc1.Element("root").Elements("department")
                    .Where(x => x.Attribute("name").Value == dep_name).FirstOrDefault();
                deps.Attribute("name").Value = newName.ToString();
                doc1.Save(path1);
                depName.Clear();
                MessageBox.Show("Название департамента успешно изменено", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void depList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dep_name = depList.SelectedItem.ToString();
            var emps = doc2.Element("root").Elements("employee")
                .Where(emp => emp.Attribute("dep_name").Value == dep_name).ToList();
            empList.Items.Clear();
            foreach (var emp in emps)
                empList.Items.Add(emp.Attribute("name").Value);
        }
        private void empList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empList.SelectedIndex>-1)
            { 
            string emp_name = empList.SelectedItem.ToString();
            var emp = doc2.Element("root").Elements("employee")
                .Where(x => x.Attribute("name").Value == emp_name)
                .FirstOrDefault();
                if (emp != null)
                {
                    string file = emp.Attribute("photo").Value;
                    string path = @"..\..\Images\" + file;
                    empPhoto.Image = Image.FromFile(path);
                    empName.Text = emp.Attribute("name").Value;
                    empBirth.Text = emp.Attribute("birth").Value;
                    empAddress.Text = emp.Attribute("addr").Value;
                    empPhone.Text = emp.Attribute("phone").Value;
                    empEmail.Text = emp.Attribute("email").Value;
                    empExperience.Text = emp.Attribute("exp").Value;
                    empPosition.Text = emp.Attribute("pos").Value;
                    empSalary.Text = emp.Attribute("sal").Value;
                }
            }
        }
        private void photoAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpeg Files (*.jpg)|*.jpg|Png Files (*.png)|*.png|All Files (*.*)|*.*";
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                photoPath = ofd.FileName;
                photoName = ofd.SafeFileName;
                empPhoto.Image = Image.FromFile(photoPath);
            }
        }
        private void clearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            empList.SelectedIndex = -1;
            empName.Clear();
            empBirth.Value = DateTime.Now;
            empAddress.Clear();
            empPhone.Clear();
            empEmail.Clear();
            empPosition.Clear();
            empSalary.Value = 0.0M;
            empExperience.Value = 0.0M;
            empPhoto.Image = Image.FromFile(@"..\..\Images\profile.png");
        }
        private void empAdd_Click(object sender, EventArgs e)
        {
            string dName = depList.SelectedItem.ToString();
            string eName = empName.Text;
            string eBirth = empBirth.Value.ToShortDateString();
            string eAddress = empAddress.Text;
            string ePhone = empPhone.Text;
            string eEmail = empEmail.Text;
            string ePosition = empPosition.Text;
            string eExperience = empExperience.Text;
            string eSalary = empSalary.Text;
            string ePhoto = photoName;
            doc2.Element("root").Add(new XElement("employee",
                new XAttribute("dep_name",dName),
                new XAttribute("name",eName),
                new XAttribute("birth",eBirth),
                new XAttribute("addr",eAddress),
                new XAttribute("phone",ePhone),
                new XAttribute("email",eEmail),
                new XAttribute("pos", ePosition),
                new XAttribute("sal", eSalary),
                new XAttribute("exp", eExperience),
                new XAttribute("photo", ePhoto)
                ));
            doc2.Save(path2);
            string path = @"..\..\Images\" + ePhoto;
            if (!File.Exists(path))
            {
                File.Copy(photoPath, path);
            }
            MessageBox.Show("Сотрудник успешно добавлен", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            depList.SelectedIndex = 0;
            ClearFields();
        }
                
        private void photoDel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Вы уверены что хотите удалить фото?", "Предупреждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var emps = doc2.Element("root").Elements("employee")
                .Where(x => x.Attribute("name").Value == empList.SelectedItem.ToString()).FirstOrDefault();
                string file = "profile.png";
                string path = @"..\..\Images\" + file;
                empPhoto.Image = Image.FromFile(path);
                emps.Attribute("photo").Value = file.ToString();
                doc2.Save(path2);
                MessageBox.Show("Фото успешно удалено", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
         }

        private void empSave_Click(object sender, EventArgs e)
        {
            string oldName = empList.SelectedItem.ToString();
            string eName = empName.Text;
            string eBirth = empBirth.Value.ToShortDateString();
            string eAddress = empAddress.Text;
            string ePhone = empPhone.Text;
            string eEmail = empEmail.Text;
            string ePosition = empPosition.Text;
            string eExperience = empExperience.Text;
            string eSalary = empSalary.Text;
            string ePhoto = photoName;
            var emps = doc2.Element("root").Elements("employee")
                .Where(x => x.Attribute("name").Value == oldName).FirstOrDefault();
            emps.Attribute("name").Value = eName.ToString();
            emps.Attribute("birth").Value = eBirth.ToString();
            emps.Attribute("addr").Value = eAddress.ToString();
            emps.Attribute("phone").Value = ePhone.ToString();
            emps.Attribute("email").Value = eEmail.ToString();
            emps.Attribute("exp").Value = eExperience.ToString();
            emps.Attribute("pos").Value = ePosition.ToString();
            emps.Attribute("sal").Value = eSalary.ToString();
            empList.Items.Remove(oldName);
            empList.Items.Add(eName);       
            string path = @"..\..\Images\" + ePhoto;
            if (!File.Exists(path))
            {
                File.Copy(photoPath, path);
            }
            emps.Attribute("photo").Value = ePhoto.ToString();
            doc2.Save(path2);
            MessageBox.Show("Данные успешно изменены", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void empDel_Click(object sender, EventArgs e)
        {
            if (depList.SelectedItem == null)
            {
                MessageBox.Show("Вы не указали сотрудника", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var result = MessageBox.Show($"Вы уверены что хотите удалить сотрудника {empList.SelectedItem}?", "Предупреждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    doc2.Element("root").Elements("employee")
                        .Where(x => x.Attribute("name").Value == empList.SelectedItem.ToString()).Remove();                   
                    empList.Items.Remove(empList.SelectedItem);
                    doc2.Save(path2);
                    MessageBox.Show("Сотрудник успешно удалён", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
            }
        }
    }
}
