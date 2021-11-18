using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product()
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            LoadProducts();
            MessageBox.Show("Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgwProducts.CurrentRow != null)
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                    Name = tbxNameUpdate.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                    StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
                };

                _productDal.Update(product);
                LoadProducts();
                MessageBox.Show("Updated!");
            }
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwProducts.CurrentRow != null)
            {
                tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
                tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
                tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgwProducts.CurrentRow != null)
            {
                _productDal.Delete(new Product()
                {
                    Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
                });

                LoadProducts();
                MessageBox.Show("Deleted.");
            }
        }

        public void SearchProducts(string key)
        {
            //Burada GetAll ile ver tabanına sorgu atılıp tüm products listesi alındıktan sonra collections'a where koşulu atar.
            //Csharpda küçük büyük harf duyarlılığı vardır. Bu yüzden collectionlarda filtreleme yaparken tolower kullanırız.
            //dgwProducts.DataSource = _productDal.GetAll().Where(p => p.Name.ToLower().Contains(key.ToLower())).ToList();
            dgwProducts.DataSource = _productDal.GetName(key);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }
    }
}