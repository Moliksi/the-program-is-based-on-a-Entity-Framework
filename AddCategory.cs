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
    public partial class AddCategory : Form
    {
        ApplicationContext db;
        public AddCategory(ApplicationContext db)
        {
            InitializeComponent();
            this.db = db;
        
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //using (ApplicationContext db = new ApplicationContext())
            {
                int ka = 0;
                string nameCat = nameTextBox.Text;
                Category cat = new Category { Name_Category = nameCat };
                if (db.Categories != null)
                {
                    foreach (var item in db.Categories.ToList())
                    {
                        ++ka;
                        if (nameCat.Equals(item.Name_Category))
                        {
                            break;
                        }
                        
                    }
                    if (ka == db.Categories.Count())
                    {

                        db.Categories.Add(cat);

                    }
                }
                else
                {

                    db.Categories.Add(cat);
                }
               
                db.SaveChanges();

            }
            this.Close();
        }
    }
}
