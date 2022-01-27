using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Collections;

namespace FitnessCenter
{
    public partial class CustomerForm : MetroFramework.Forms.MetroForm
    {
        MainForm parent;
        Customer model = new Customer();
        public CustomerForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            
            customerLabel.Text = "Все клиенты:";
            trainerLabel.Text = "Все тренеры:";
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            Clear(true);
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
            this.Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(surnameTB.Text.Trim()))
            {
                MessageBox.Show("Введите фамилию клиента!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(nameTB.Text.Trim()))
            {
                MessageBox.Show("Введите имя клиента!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(middleNameTB.Text.Trim()))
            {
                MessageBox.Show("Введите отчество клиента!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!maleRB.Checked && !femaleRB.Checked)
            {
                MessageBox.Show("Выберите пол клиента!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (bDate.Value > DateTime.Now)
            {
                MessageBox.Show("Введенная дата рождения клиента больше текущей, что невозможно. Повторите ввод даты корректно!", "Некорректный ввод данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(emailTB.Text.Trim()))
            {
                MessageBox.Show("Введите адрес электронной почты клиента!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(phoneTB.Text.Trim()))
            {
                MessageBox.Show("Введите номер телефона клиента!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(phoneTB.Text.Trim(), @"^8\(0\d{2}\)\d{3}-\d{2}-\d{2}$"))
            {
                MessageBox.Show("Введите номер телефона клиента, соответствующий шаблону 8(0ЦЦ)ЦЦЦ-ЦЦ-ЦЦ, где Ц - цифра от 0 до 9!", "Некорректный ввод данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(occupationTB.Text.Trim()))
            {
                MessageBox.Show("Введите род деятельности клиента!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
            model.surname = surnameTB.Text.Trim();
            model.name = nameTB.Text.Trim();
            model.middlename = middleNameTB.Text.Trim();
            if (maleRB.Checked)
            {
                model.gender = "м";
            }
            else
            {
                model.gender = "ж";
            }
            model.birthdate = bDate.Value;
            model.email = emailTB.Text.Trim();
            model.phone = phoneTB.Text.Trim();
            model.occupation = occupationTB.Text.Trim();
            using (GymDBEntities db = new GymDBEntities())
            {
                if (model.id == 0) //insert
                {
                    db.Customer.Add(model);
                }
                else // update
                {
                    db.Entry(model).State = EntityState.Modified;
                }                
                db.SaveChanges();
            }
            Clear(true);
            FillClientDataGridView();
            MessageBox.Show(
                "Операция выполнена успешно!", 
                "Успешная операция",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить этого клиента?","Вопрос",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                using (GymDBEntities db = new GymDBEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Customer.Attach(model);
                    }
                    db.Customer.Remove(model);
                    db.SaveChanges();
                    FillClientDataGridView();
                    Clear(true);
                    MessageBox.Show(
                        "Операция удаления выполнена успешно!",
                        "Успешная операция",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Clear(true);
        }

        private void Clear(bool all)
        {
            surnameTB.Text = nameTB.Text = middleNameTB.Text = emailTB.Text = phoneTB.Text = occupationTB.Text = string.Empty;
            maleRB.Checked = false; //
            femaleRB.Checked = false;
            bDate.Value = DateTime.Now;
            saveButton.Text = "Сохранить";
            deleteButton.Enabled = false;
            if (all)
            {
                FillClientDataGridView();
            }
            FillTrainerDataGridView();
            model.id = 0;
            
        }

        private void FillClientDataGridView()
        {
            clientdataGridView.AutoGenerateColumns = false;
            using (GymDBEntities db = new GymDBEntities()) 
            {
                clientdataGridView.DataSource = db.Customer.ToList<Customer>();
            }
            customerLabel.Text = "Все клиенты:";
        }

        private void FillTrainerDataGridView()
        {
            trainersDataGridView.AutoGenerateColumns = false;
            using (GymDBEntities db = new GymDBEntities())
            {
                trainersDataGridView.DataSource = db.Trainer.ToList<Trainer>();
            }
            trainerLabel.Text = "Все тренеры:";
        }

        private void clientdataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (clientdataGridView.CurrentRow.Index != -1) 
            {
                model.id = Convert.ToInt32(clientdataGridView.CurrentRow.Cells["id_2"].Value);
                using (GymDBEntities db = new GymDBEntities())
                {
                    model = db.Customer.Where(x => x.id == model.id).FirstOrDefault();
                    surnameTB.Text = model.surname;
                    nameTB.Text = model.name;
                    middleNameTB.Text = model.middlename;
                    emailTB.Text = model.email;
                    phoneTB.Text = model.phone;
                    occupationTB.Text = model.occupation;
                    if (model.gender == "м")
                    {
                        maleRB.Checked = true;
                        femaleRB.Checked = false;
                    }
                    else
                    {
                        femaleRB.Checked = true;
                        maleRB.Checked = false;
                    }
                    bDate.Value = model.birthdate;

                    trainersDataGridView.AutoGenerateColumns = false;
                    SqlParameter param = new SqlParameter("@cl_id", model.id);
                    trainersDataGridView.DataSource = db.Database.SqlQuery<Trainer>("select t.* from trainer t join schedule s on t.id = s.trainer_id where s.customer_id = @cl_id and s.enddate is null", param).ToList<Trainer>();

                    trainerLabel.Text = $"Тренеры клиента {model.surname + " " + model.name + " " + model.middlename}:";
                }
                saveButton.Text = "Обновить";
                deleteButton.Enabled = true;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string expr = "select * from customer where 1=1 ";
            if (!string.IsNullOrEmpty(surnameTB.Text.Trim()))
            {
                expr += "and lower(surname) like '%" + surnameTB.Text.Trim().ToLower() + "%' ";
            }
            if (!string.IsNullOrEmpty(nameTB.Text.Trim()))
            {
                expr += "and lower(name) like '%" + nameTB.Text.Trim().ToLower() + "%' ";
            }
            if (!string.IsNullOrEmpty(middleNameTB.Text.Trim()))
            {
                expr += "and lower(middlename) like '%" + middleNameTB.Text.Trim().ToLower() + "%' ";
            }
            if (maleRB.Checked || femaleRB.Checked)
            {
                string a = (maleRB.Checked) ? "м" : "ж";
                expr += "and gender = '" + a + "' ";
            }
            if (!string.IsNullOrEmpty(emailTB.Text.Trim()))
            {
                expr += "and lower(email) like '%" + emailTB.Text.Trim().ToLower() + "%' ";
            }
            if (!string.IsNullOrEmpty(phoneTB.Text.Trim()))
            {
                expr += "and lower(phone) like '%" + phoneTB.Text.Trim().ToLower() + "%' ";
            }
            if (!string.IsNullOrEmpty(occupationTB.Text.Trim()))
            {
                expr += "and lower(occupation) like '%" + occupationTB.Text.Trim().ToLower() + "%' ";
            }
            using (GymDBEntities db = new GymDBEntities())
            {
                clientdataGridView.AutoGenerateColumns = false;
                clientdataGridView.DataSource = db.Database.SqlQuery<Customer>(expr).ToList<Customer>();
            }
            Clear(false);
            customerLabel.Text = "Отобранные клиенты:";
        }

        private void showTrainersList_Click(object sender, EventArgs e)
        {
            FillTrainerDataGridView();
        }

        private void addCoachButton_Click(object sender, EventArgs e)
        {

        }

        private void addCoachButton_Click_1(object sender, EventArgs e)
        {
            int cust_id, train_id;
            if (clientdataGridView.CurrentRow.Index != -1)
            {
                cust_id = Convert.ToInt32(clientdataGridView.CurrentRow.Cells["id_2"].Value);
                if (trainersDataGridView.CurrentRow.Index != -1)
                {
                    train_id = Convert.ToInt32(trainersDataGridView.CurrentRow.Cells["id"].Value);
                    using (GymDBEntities db = new GymDBEntities())
                    {
                        var str = db.Schedule.Where(x => x.trainer_id == train_id && x.customer_id == cust_id && x.enddate == null).FirstOrDefault();
                        if (str == null)
                        {
                            db.Database.ExecuteSqlCommand($"insert into schedule values ({train_id},{cust_id},getdate(),null)");
                            MessageBox.Show("Запись успешно создана!", "Успешная операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear(true);
                        }
                        else
                        {
                            MessageBox.Show("Занятия уже проводятся! Повторная запись невозможна до завершения текущих сеансов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не выбран ни один тренер из списка. Повторите выбор!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Не выбран ни один клиент из списка. Повторите выбор!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
