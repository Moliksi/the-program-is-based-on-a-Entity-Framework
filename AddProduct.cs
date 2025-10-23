using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinEntityKozlow
{
    public partial class AddProduct : Form
    {
        ApplicationContext db;
        public AddProduct(ApplicationContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a = true;
            int ka = 0;
            string nameProd = textBox1.Text;
            string nameCat = textBox2.Text;
            Category cat = new Category();
            if (db.Categories.Count() == 0)
            {
                cat = new Category { Name_Category = nameCat };
                db.Categories.Add(cat);
                db.SaveChanges();
            }
            else
            {
                foreach (var user in db.Categories.ToList())
                {
                    ++ka;
                    if (nameCat.Equals(user.Name_Category))
                    {
                        cat = user;
                        break;
                    }
                    else if (ka == db.Categories.Count())
                    {
                        cat = new Category { Name_Category = nameCat };
                        db.Categories.Add(cat);
                        db.SaveChanges();
                        break;
                    }
                }
            }
            foreach (var item in db.Products.ToList())
            {
                if (nameProd.Equals(item.Name_Product))
                {
                    a = false;
                    break;
                }
            }
            if (a)
            {
                Product c = new Product { Name_Product = nameProd, Category = cat };
                db.Products.Add(c);
                db.SaveChanges();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
