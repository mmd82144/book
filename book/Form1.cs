using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using book;

namespace book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            book book = new book
            {
                name_book = "یکی از ما دروغ میگوید",
                author = "کارن ام . مک منس",
                year = int.Parse("2017")
            };
            book.printi();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            member mb = new member
            {
                name = "نیما",
                memeberid = 1,
                phone = "09031332233"
            };
            mb.member_info();
        }
    }

    public class book
    {
        public string name_book;
        public string author;
        public int year;
        public void printi()
        {
            MessageBox.Show("اطلاعات کتاب \n" + "عنوان کتاب:" + name_book + "\n" + " نویسنده: " + author + "\n" + "سال انتشار:" + year + "\n");
        }
    }
    public class member
    {
        public string name;
        public int memeberid;
        public string phone;
        public void member_info()
        {
            MessageBox.Show("اطلاعات کاربر\n " + "اسم کاربر:" + name + "\n" + "ایدی کاربر:" + memeberid + "\n" + "شماره تماس:" + phone);
        }
    }
}
