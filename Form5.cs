using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;
using System.IO;
using System.Threading;

namespace Polivalans
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        #region FIELDS
        string mailSMTP = "";
        bool isPassShown = false;
        MailMessage mail;
        #endregion

        #region SUPPORTS FUNCTIONS
        //Deletes User E-Mail and Password
        private void DeleteUserInformations()
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = null;
            }
            if (textBox2.Text != null)
            {
                textBox2.Text = null;
            }
            if(checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }
            if(comboBox1.Text!=null)
            {
                comboBox1.Text = null;
            }
            if(richTextBox1.Text!=null)
            {
                richTextBox1.Clear();
            }
        }

        //Sends E-Mail
        private void SendEmail()
        {
            OpenFileDialog open;
            mail = new MailMessage();
            string fileName = "";

            //E-Mail Atttachments Handling
            open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                mail.Attachments.Add(new Attachment(open.FileName));
                fileName = Path.GetFileName(open.FileName);
                richTextBox1.AppendText("Attachment File: " + fileName);
            }

            if (MessageBox.Show("Mesajı Göndermek İstediğinizden Emin Misiniz?", "Kalmaksan Kalıp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SmtpClient source;
                try
                {
                    source = new SmtpClient();
                    source.Port = 587;
                    source.EnableSsl = true;

                    string hostType = GetHostType();

                    //SMTP SERVER
                    source.Host = "smtp."+hostType+".com";


                    //E-mail and Password (the one who sends)
                    source.Credentials = new NetworkCredential(textBox2.Text, textBox1.Text);

                    //E-mail and Name (the one who sends)
                    mail.From = new MailAddress(textBox2.Text, "Kalmaksan Kalıp");

                    //E-mail (the one who receives)
                    mail.To.Add(textBox3.Text);

                    //E-mail Subject
                    mail.Subject = textBox4.Text;

                    //E-mail Mesage
                    mail.Body = richTextBox1.Text;

                    mail.IsBodyHtml = true;

                    source.Send(mail);
                    MessageBox.Show("Mesaj Gönderildi", "Kalmaksan Kalıp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mesaj Gönderilemedi\nLütfen Tekrar Deneyiniz!", "Kalmaksan Kalıp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        //Gets Host Type
        private string GetHostType()
        {
            return mailSMTP;
        }

        //Checks Whether is PasswordChar prop is set to true or not
        private void isPasswordBeingShown()
        {
            if (checkBox1.Checked) { isPassShown = true; }
            if (!checkBox1.Checked) { isPassShown = false; }
        }

        //Checks Errors
        private void CheckErrors()
        {
            string[] err = new string[6] {textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,richTextBox1.Text,comboBox1.Text };
            for (int i = 0; i < err.Length; i++)
            {
                if (err[i] == "")
                {
                    MessageBox.Show("Lütfen Bütün Kutucuklara İlgili Değerleri Yazınız", "Kalmaksan Kalıp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            SendEmail();
        }
        #endregion

        //Deletes Username and Password fields for new Informations
        private void button2_Click(object sender, EventArgs e)
        {
            DeleteUserInformations();
            if(mail.Attachments.Count!=0)
            {
                mail.Attachments.Clear();
            }
        }

        //Sends E-Mail
        private void button3_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Seçiniz")
            {
                MessageBox.Show("Lütfen Bir E-Mail Tipi Seçiniz", "Kalmaksan Kalıp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Check Errors And Send E-Mail
            CheckErrors();
            textBox3.Text = "";
            textBox4.Text = "";
            richTextBox1.Text = "";
        }

        //Checks whether It shows Password or not
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isPasswordBeingShown();
            if(isPassShown)     {this.textBox1.PasswordChar = '\0';}
            if (!isPassShown)   {this.textBox1.PasswordChar = '*'; }
        }

        //Checks E-Mail Type
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Hotmail")    { mailSMTP = "live"; }
            if(comboBox1.Text=="Gmail")         { mailSMTP = "gmail"; }
            if(comboBox1.Text=="Yahoo")         { mailSMTP = "mail.yahoo"; }
        }

        //Executes When Program Starts up
        private void Form5_Load(object sender, EventArgs e)
        {
            richTextBox1.AppendText("\n\n\n\n");
        }
    }
}
