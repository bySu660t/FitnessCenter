using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessCenter
{
    public partial class TrainerForm : MetroFramework.Forms.MetroForm
    {
        MainForm parent;
        Trainer model = new Trainer();
        public TrainerForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;

            customerLabel.Text = "Все клиенты:";
            trainerLabel.Text = "Все тренеры:";
        }

        private void TrainerForm_Load(object sender, EventArgs e)
        {
            Clear(true);
        }

        private void TrainerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
            this.Hide();
        }

        private void Clear(bool all)
        {
            surnameTB.Text = nameTB.Text = middleNameTB.Text = phoneTB.Text = skillTB.Text = passpSer.Text = passpNoTB .Text = string.Empty;
            maleRB.Checked = false; //
            femaleRB.Checked = false;
            bDate.Value = DateTime.Now;
            hireD.Value = DateTime.Now;
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(surnameTB.Text.Trim()))
            {
                MessageBox.Show("Введите фамилию тренера!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(nameTB.Text.Trim()))
            {
                MessageBox.Show("Введите имя тренера!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(middleNameTB.Text.Trim()))
            {
                MessageBox.Show("Введите отчество тренера!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!maleRB.Checked && !femaleRB.Checked)
            {
                MessageBox.Show("Выберите пол тренера!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (bDate.Value > DateTime.Now)
            {
                MessageBox.Show("Введенная дата рождения тренера больше текущей, что невозможно. Повторите ввод даты корректно!", "Некорректный ввод данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(phoneTB.Text.Trim()))
            {
                MessageBox.Show("Введите номер телефона тренера!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(phoneTB.Text.Trim(), @"^8\(0\d{2}\)\d{3}-\d{2}-\d{2}$"))
            {
                MessageBox.Show("Введите номер телефона тренера, соответствующий шаблону 8(0ЦЦ)ЦЦЦ-ЦЦ-ЦЦ, где Ц - цифра от 0 до 9!", "Некорректный ввод данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (hireD.Value > DateTime.Now)
            {
                MessageBox.Show("Введенная дата приема на работу тренера больше текущей, что невозможно. Повторите ввод даты корректно!", "Некорректный ввод данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(passpSer.Text.Trim()))
            {
                MessageBox.Show("Введите серию паспорта тренера!", "Некорректный ввод данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(passpNoTB.Text.Trim()))
            {
                MessageBox.Show("Введите номер паспорта тренера!", "Некорректный ввод данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(passpNoTB.Text.Trim(), @"^\d{7}$"))
            {
                MessageBox.Show("Введите номер паспорта тренера, соответствующий шаблону ЦЦЦЦЦЦЦ, где Ц - цифра от 0 до 9!", "Некорректный ввод данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(skillTB.Text.Trim()))
            {
                MessageBox.Show("Введите род деятельности тренера!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            model.phone = phoneTB.Text.Trim();
            model.hiredate = hireD.Value;
            model.passportseries = passpSer.Text.Trim();
            model.passportno = passpNoTB.Text.Trim();
            model.skill = skillTB.Text.Trim();
            using (GymDBEntities db = new GymDBEntities())
            {
                if (model.id == 0) //insert
                {
                    db.Trainer.Add(model);
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
            if (MessageBox.Show("Вы уверены, что хотите удалить этого тренера?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (GymDBEntities db = new GymDBEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Trainer.Attach(model);
                    }
                    db.Trainer.Remove(model);
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            string expr = "select * from trainer where 1=1 ";
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
            if (!string.IsNullOrEmpty(phoneTB.Text.Trim()))
            {
                expr += "and lower(phone) like '%" + phoneTB.Text.Trim().ToLower() + "%' ";
            }
            if (!string.IsNullOrEmpty(skillTB.Text.Trim()))
            {
                expr += "and lower(skill) like '%" + skillTB.Text.Trim().ToLower() + "%' ";
            }
            using (GymDBEntities db = new GymDBEntities())
            {
                trainersDataGridView.AutoGenerateColumns = false;
                trainersDataGridView.DataSource = db.Database.SqlQuery<Trainer>(expr).ToList<Trainer>();
            }
            Clear(false);
            trainerLabel.Text = "Отобранные тренера:";
        }

        private void trainersDataGridView_DoubleClick(object sender, EventArgs e)
        {
              if (trainersDataGridView.CurrentRow.Index != -1)
              {
                  model.id = Convert.ToInt32(trainersDataGridView.CurrentRow.Cells["id"].Value);
                  using (GymDBEntities db = new GymDBEntities())
                  {
                      model = db.Trainer.Where(x => x.id == model.id).FirstOrDefault();
                      surnameTB.Text = model.surname;
                      nameTB.Text = model.name;
                      middleNameTB.Text = model.middlename;
                      hireD.Value = model.hiredate;
                      passpSer.Text = model.passportseries;
                      passpNoTB.Text = model.passportno;
                      skillTB.Text = model.skill;
                      phoneTB.Text = model.phone;
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
                      clientdataGridView.AutoGenerateColumns = false;
                      SqlParameter param = new SqlParameter("@cl_id", model.id);
                      clientdataGridView.DataSource = db.Database.SqlQuery<Customer>("select c.* from customer c join schedule s on c.id = s.customer_id where s.trainer_id = @cl_id and s.enddate is null", param).ToList<Customer>();
              
                      customerLabel.Text = $"Клиенты тренера {model.surname + " " + model.name + " " + model.middlename}:";
                  }
                  saveButton.Text = "Обновить";
                  deleteButton.Enabled = true;
              }
        }
    }
}
