using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.Office.Interop.Excel;
using exportWord= Microsoft.Office.Interop.Word;
using System.IO;

namespace WinEntityKozlow
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
       
       
        ApplicationContext db = new ApplicationContext();
        
        /*
        private void Button1_Click(object sender, EventArgs e)
        {
            bool a = true;
            int ka = 0;
            nameProd = textBox1.Text;
            nameCat = textBox2.Text;
            Category cat = new Category();
            if (db.Categories.Count() == 0)
            {
                cat = new Category { Name_Category = nameCat };
                comboBox1.Items.Add(cat.Name_Category);
                comboBox3.Items.Add(cat.Name_Category);
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
                        comboBox1.Items.Add(cat.Name_Category);
                        comboBox3.Items.Add(cat.Name_Category);
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
                comboBox2.Items.Add(nameProd);
                db.Products.Add(c);
                db.SaveChanges();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int ka = 0;
            nameCat = textBox3.Text;
            Category cat= new Category();
            if (db.Categories != null)
            {
                foreach (var item in db.Categories.ToList())
                {
                    ++ka;
                    if (nameCat.Equals(item.Name_Category))
                    {
                        break;
                    }
                    else if (ka == db.Categories.Count())
                    {
                        
                        cat = new Category { Name_Category = nameCat };
                        comboBox1.Items.Add(cat.Name_Category);
                        comboBox3.Items.Add(cat.Name_Category);
                    }
                }
            }
            else
            {
                cat = new Category { Name_Category = nameCat };
                comboBox1.Items.Add(cat.Name_Category);
                comboBox3.Items.Add(cat.Name_Category);
            }
            db.Categories.Add(cat);
            db.SaveChanges();
        }
        
        private void Button3_Click(object sender, EventArgs e)
        {

            int a = (int)dataGridView1.CurrentRow.Cells[0].Value;
           
                if (db.Categories.Find(a).Product.Count >0)
                {
                    MessageBox.Show("Категория не пустая");
                }   
                else
                {
                    Category cat = db.Categories.Find(a);
                    db.Categories.Remove(cat);
                    db.SaveChanges();
                    DataGridRefrashe();
                    DataGridRefrashe1();
                }
             
            
           
                
            
            
            /*                
            Category cat = new Category();
            nameCat = comboBox1.Text;
            foreach (var item in db.Categories.ToList())
            {
              
                if (nameCat.Equals(item.Name_Category))
                {
                    cat = item;
                }
                
            }
            if (cat != null)
            {
                try
                {
                    if (cat.Product.Count != 0)
                    {
                        MessageBox.Show("Категория не пустая");
                    }
                    else
                    {
                        for (int i = 0; i < comboBox1.Items.Count; i++)
                        {
                            if (comboBox1.Items[i].ToString().Equals(cat.Name_Category))
                            {
                                comboBox1.Items.RemoveAt(i);
                                comboBox3.Items.RemoveAt(i);
                            }
                        }
                        db.Categories.Remove(cat);
                        db.SaveChanges();
                    }
                }
                catch {
                    for (int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        if (comboBox1.Items[i].ToString().Equals(cat.Name_Category))
                        {
                            comboBox1.Items.RemoveAt(i);
                            comboBox3.Items.RemoveAt(i);
                        }
                    }
                    db.Categories.Remove(cat);
                    db.SaveChanges();
                }
                
            }
            
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            int a = (int)dataGridView2.CurrentRow.Cells[0].Value;
                db.Products.Remove(db.Products.Find(a));
                db.SaveChanges();
                DataGridRefrashe1();
                DataGridRefrashe();
            /*
            nameProd = comboBox2.Text;
            Category cat = new Category();
            foreach (var item in db.Products.ToList())
            {
                if (nameProd.Equals(item.Name_Product))
                {
                    for (int i = 0; i < comboBox2.Items.Count; i++)
                    {
                        if (comboBox2.Items[i].ToString().Equals(item.Name_Product))
                        {
                            comboBox2.Items.RemoveAt(i);
                            break;
                        }
                    }
                    db.Products.Remove(item);
                    db.SaveChanges();
                    break;
                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            nameCat = comboBox3.Text;
            foreach (var item in db.Categories.ToList())
            {
                
                if (nameCat.Equals(item.Name_Category))
                {
                    foreach (var item1 in item.Product)
                    {
                        textBox4.Text+=item1.Name_Product + Environment.NewLine;
                    }
                    break;
                }
                
            }
        }
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void DataGridRefrashe()
        {
            var p = db.Categories.ToList();
            var source = new BindingSource();
            source.DataSource = p;
            dataGridView1.DataSource = source;

           // comboBox3.DataSource = source;
           // comboBox3.DisplayMember = "Name_Category";

        }
        private void DataGridRefrashe1()
        {
            var p = db.Products.ToList();
            var source = new BindingSource();
            source.DataSource = p;
            dataGridView2.DataSource = source;
            dataGridView2.Columns.RemoveAt(3);
        }
        

        private void ДобавитьКатегориюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategory ADD = new AddCategory(db);
            ADD.ShowDialog();
            DataGridRefrashe();
        }

        private void ДобавитьПродуктToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct ADD = new AddProduct(db);
            ADD.ShowDialog();
            DataGridRefrashe1();
            DataGridRefrashe();
        }

        private void удалитьКатегориюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = 0;
            int a = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var t = db.Products.Include(u => u.Category).ToList();
            foreach(var product in t)
            {
                if(product.Category.Name_Category==db.Categories.Find(a).Name_Category)
                count++;
            }
            if (count>0)
            {
                MessageBox.Show("Категория не пустая");
            }
            else
            {
                Category cat = db.Categories.Find(a);
                db.Categories.Remove(cat);
                db.SaveChanges();
                DataGridRefrashe();
                DataGridRefrashe1();
            }
        }

        private void удалитьПродуктToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = (int)dataGridView2.CurrentRow.Cells[0].Value;
            db.Products.Remove(db.Products.Find(a));
            
            db.SaveChanges();
            DataGridRefrashe1();
            DataGridRefrashe();
        }

        

        private void сортировкаОтАДоЯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var order = db.Products.OrderBy(p => p.Name_Product).ToList();
            var source = new BindingSource();
            source.DataSource = order;
            dataGridView2.DataSource = source;
            dataGridView2.Columns.RemoveAt(3);          
        }

        private void сортировкаОтЯДоАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var order = db.Products.OrderByDescending(p => p.Name_Product).ToList();
            var source = new BindingSource();
            source.DataSource = order;
            dataGridView2.DataSource = source;
            dataGridView2.Columns.RemoveAt(3);
        }

        private void toolStripTextBox1_Leave(object sender, EventArgs e)
        {
           if(toolStripTextBox1.Text!="")
            {
                var order = db.Products.Where(p => p.Name_Product == toolStripTextBox1.Text).ToList();
                var source = new BindingSource();
                source.DataSource = order;
                dataGridView2.DataSource = order;
                dataGridView2.Columns.RemoveAt(3);
            }
        }

        private void отменитьФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridRefrashe1();
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox2.Text != "")
            {
                var order = db.Products.Where(p => EF.Functions.Like(p.Name_Product!,"%"+toolStripTextBox2.Text+"%")).ToList();
                var source = new BindingSource();
                source.DataSource = order;
                dataGridView2.DataSource = order;
                dataGridView2.Columns.RemoveAt(3);
            }
        }

        private void экспортироватьДанныеВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application XlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook XlWorkBook = XlApp.Workbooks.Add(); //создать новый файл: XlApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet XlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)XlWorkBook.Worksheets.get_Item(1); //1-й лист по порядку
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    XlWorkSheet.Cells[i + 1, j + 1] = dataGridView2.Rows[i].Cells[j].Value;
                }
            }
            XlApp.Visible = true;
        }
        
        private void ЭкспортироватьДанныеВWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportWord.Application wordapp = new exportWord.Application();
            wordapp.Application.Documents.Add(Type.Missing);
            exportWord.Table table = wordapp.Application.ActiveDocument.Tables.Add(wordapp.Selection.Range, dataGridView1.Rows.Count, dataGridView1.Columns.Count, Type.Missing);
            table.Borders.OutsideLineStyle = exportWord.WdLineStyle.wdLineStyleSingle;
            table.Borders.InsideLineStyle = exportWord.WdLineStyle.wdLineStyleSingle;
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    table.Cell(i + 1, j + 1).Range.Text = dataGridView1[j, i].Value.ToString();
                }
            }
            wordapp.Visible = true;
        }

        private void ОтчётОКатегорииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportWord.Application wordapp = new exportWord.Application();
            wordapp.Application.Documents.Add(Type.Missing);
            exportWord.Table table = wordapp.Application.ActiveDocument.Tables.Add(wordapp.Selection.Range, dataGridView1.Rows.Count+1, dataGridView1.Columns.Count+1, Type.Missing);
            table.Borders.OutsideLineStyle = exportWord.WdLineStyle.wdLineStyleSingle;
            table.Borders.InsideLineStyle = exportWord.WdLineStyle.wdLineStyleSingle;
            table.Cell(1, 1).Range.Text = "Id Категории";
            table.Cell(1, 2).Range.Text = "Имя категории";
            table.Cell(1, 3).Range.Text = "Количество продуктов в категории";
            for (int i = 1; i < dataGridView1.Rows.Count+1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    table.Cell(i + 1, j + 1).Range.Text = dataGridView1[j, i-1].Value.ToString();
                }
                try
                {
                    table.Cell(i + 1, dataGridView1.Columns.Count + 1).Range.Text = db.Categories.ToList()[i-1].Product.Count.ToString();
                }
                catch {
                    table.Cell(i + 1, dataGridView1.Columns.Count + 1).Range.Text = "0";
                }
            }
            wordapp.Visible = true;
        }
    }

    [Table("Product")]
    public class Product
    {
        [Column("ProductId")]
        public int Id { get; set; }

        public string Name_Product { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public Category Category { get; set; }

    }

    [Table("Category")]
    public class Category
    {

        public int CategoryId { get; set; }
        public string Name_Category { get; set; }
        public List<Product> Product { get; set; }
    }
    public class ApplicationContext : DbContext
    {
        // public DbSet<User> Users => Set<User>();
        // public DbSet<Groupa> Groupas => Set<Groupa>();
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }

    }
}
