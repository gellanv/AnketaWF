using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ4_4
{
    public partial class Form1 : Form
    {

        List<Person> lstPerson = new List<Person>();
        string nameFoto = "";
        public Form1()
        {
            InitializeComponent();            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //ButtonSave.Enabled = false;
            //ButtonDell.Enabled = false;
            //ButtonCancel.Enabled = false;
            ButtonSave.Hide();
            ButtonDell.Hide();
            ButtonCancel.Hide();
            ReadText("ankets.txt");
        }
        private void TextBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsLetter(e.KeyChar)) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void TextBoxEmail_Validated(object sender, EventArgs e)
        {
            string emailPattern = @"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$";
            Regex regex = new Regex(emailPattern);
            if (!regex.IsMatch(TextBoxEmail.Text))
            {
                MessageBox.Show("Incorrect e - mail!");          
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
           
            if (TextBoxName.Text==""||TextBoxSurname.Text==""|| TextBoxEmail.Text==""|| MaskedTBPhone.Text=="")
                MessageBox.Show("Вы ввели не все данные!");
            else
                {
                    if (lstPerson.Find(x => x.email.Contains(TextBoxEmail.Text)) != null)
                        MessageBox.Show("В Базе уже есть анкета с указанным email");
                    else if (lstPerson.Find(x => x.phone.Contains(MaskedTBPhone.Text)) != null)
                        MessageBox.Show("В Базе уже есть анкета с указанным телефоном");
                    else
                    {
                        Person temp = new Person(TextBoxSurname.Text, TextBoxName.Text, MaskedTBPhone.Text, TextBoxEmail.Text);
                        if (nameFoto != "")
                        {
                        temp.picture = nameFoto;
                        }
                        lstPerson.Add(temp);                            
                        ListBox1.Items.Add(temp.surname + " " + temp.name);
                        CLearFields();
                    }
                }
            nameFoto = "";
            PictureBox1.Image = Image.FromFile(@"..\..\foto\fotocap.jpg");
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PictureBox1.Image = Image.FromFile(@"..\..\foto\fotocap.jpg");
            try { 

                    for (int i = 0; i < lstPerson.Count; i++)
                    {
                        if ((lstPerson[i].surname + " " + lstPerson[i].name) == ListBox1.SelectedItem.ToString())
                        {
                         TextBoxSurname.Text = lstPerson[i].surname;
                            TextBoxName.Text = lstPerson[i].name;
                            MaskedTBPhone.Text = lstPerson[i].phone;
                            TextBoxEmail.Text = lstPerson[i].email;
                            LabelNumber.Text = lstPerson[i].number.ToString();
                        if (lstPerson[i].picture != "")
                        {
                            PictureBox1.Image = Image.FromFile(lstPerson[i].picture);
                            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                            ButtonAdd.Hide();
                            ButtonCLear.Hide();
                            ButtonSave.Show();
                            ButtonDell.Show();
                            ButtonCancel.Show();
                        break;
                        }
                    }
                }
            catch (NullReferenceException) { }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            int tem = Convert.ToInt32(LabelNumber.Text);
            for (int i = 0; i < lstPerson.Count; i++)
            {
                if (lstPerson[i].number == tem)
                {
                    if (TextBoxName.Text == "" || TextBoxSurname.Text == "" || TextBoxEmail.Text == "" || MaskedTBPhone.Text == "")
                        MessageBox.Show("Заполнены не все данные!");
                    else
                    {
                        lstPerson[i].surname = TextBoxSurname.Text;
                        lstPerson[i].name = TextBoxName.Text;
                        lstPerson[i].phone = MaskedTBPhone.Text;
                        lstPerson[i].email = TextBoxEmail.Text;
                        if (nameFoto!="")
                        {
                            lstPerson[i].picture = nameFoto;
                        }
                        ListBox1.Items[ListBox1.SelectedIndex] = lstPerson[i].surname + " " + lstPerson[i].name;
                        CLearFields();
                        ButtonAdd.Show();
                        ButtonCLear.Show();
                        ButtonSave.Hide();
                        ButtonDell.Hide();
                        ButtonCancel.Hide();
                        break;
                    }                    
                }
            }
            nameFoto = "";
            PictureBox1.Image = Image.FromFile(@"..\..\foto\fotocap.jpg");
        }

        private void ButtonDell_Click(object sender, EventArgs e)
        {
            int tem = Convert.ToInt32(LabelNumber.Text);

            for (int i = 0; i < lstPerson.Count; i++)
            {
                if (lstPerson[i].number == tem)
                {
                    lstPerson.RemoveAt(i);
                    ListBox1.Items.RemoveAt(ListBox1.SelectedIndex);
                    CLearFields();
                    ButtonAdd.Show();
                    ButtonCLear.Show();
                    ButtonSave.Hide();
                    ButtonDell.Hide();
                    ButtonCancel.Hide();
                    break;
                }
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ListBox1.ClearSelected();
            CLearFields();
            ButtonAdd.Show();
            ButtonCLear.Show();

            ButtonSave.Hide();
            ButtonDell.Hide();
            ButtonCancel.Hide();
        }

        private void ButtonCLear_Click(object sender, EventArgs e)
        {
            CLearFields();
        }
        public void CLearFields()
        {
            TextBoxSurname.Clear();
            TextBoxName.Clear();
            MaskedTBPhone.Clear();
            TextBoxEmail.Clear();
            LabelNumber.Text = "";
        }

        private void ButtonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            string filePath = openFileDialog1.FileName;
            ReadText(filePath);
        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
                SaveFileDialog1.DefaultExt = ".txt";
                SaveFileDialog1.Filter = "Text files(*.txt)|*.txt";
                SaveFileDialog1.AddExtension = true;
                if (SaveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = SaveFileDialog1.FileName;
                WriteText(filename);
                MessageBox.Show("Файл сохранен");
            }
            catch (Exception)
            {
                MessageBox.Show("Файл не удалось сохранить!");
            }
        }

        private void ReadText (string arg)
        {
            try
            {
                using (FileStream fs = new FileStream(arg, FileMode.Open, FileAccess.Read))
                {
                    StreamReader sr = new StreamReader(fs, Encoding.Unicode);
                    while (!sr.EndOfStream)
                    {
                        string[] subs = sr.ReadLine().Split(' ');
                        if (lstPerson.Find(x => x.email.Contains(subs[3])) != null || lstPerson.Find(x => x.phone.Contains(subs[2])) != null)
                            continue;
                        else
                           {
                            Person temp = new Person(subs[0], subs[1], subs[2], subs[3]);
                            if (subs.Count() == 5)
                                temp.picture = subs[4];
                            lstPerson.Add(temp);
                            ListBox1.Items.Add(temp.surname + " " + temp.name);
                           }  
                    }
                    fs.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка чтения файла!");
            }
        }
        private void WriteText(string arg)
        {
            using (FileStream fs = new FileStream(arg, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    foreach (Person pr in lstPerson)
                    {
                        sw.WriteLine(pr.surname + " " + pr.name + " " + pr.phone.Replace(" ", "") + " " + pr.email+" "+pr.picture);
                    }
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            string filePath = openFileDialog1.FileName;        
            string onlyName = openFileDialog1.SafeFileName;
            string newfilePath = @"..\..\foto\" + onlyName;            
            FileInfo fileInf = new FileInfo(filePath);
            if (fileInf.Exists)
            {
                fileInf.CopyTo(newfilePath, true);
                PictureBox1.Image = Image.FromFile(newfilePath);
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                nameFoto = newfilePath;                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteText("ankets.txt");
        }
    }
}
