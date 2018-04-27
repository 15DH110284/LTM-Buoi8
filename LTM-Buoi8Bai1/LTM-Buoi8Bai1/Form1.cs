using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace LTM_Buoi8Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential(txtsender.Text.Trim(), txtpass.Text.Trim());
                //smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;

                using (MailMessage mm = new MailMessage(txtsender.Text.Trim(), txtto.Text.Trim()))
                {
                    mm.Subject = txtsub.Text;
                    mm.Body = txtbody.Text;

                    mm.IsBodyHtml = false;



                    smtp.Send(mm);
                    MessageBox.Show("Email sent.", "Message");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
