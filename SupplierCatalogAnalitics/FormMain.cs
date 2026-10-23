using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using SupplierCatalogAnalitics;

namespace SupplierCatalogAnalitics
{
    public partial class FormMain : Form
    {
        private readonly CatalogService catalogService;
        private List<Product> displayedProducts;
        public FormMain()
        {
            InitializeComponent();
            MessageBox.Show("Внимание! В данной программе реализованы методы сравнения и объединения каталогов поставщиков с учетом регистра букв в названиях товаров и категорий. Для корректного отображения результатов рекомендуется использовать одинаковый регистр букв в названиях товаров и категорий.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            catalogService = new CatalogService();
            displayedProducts = catalogService.GetConsolidatedCatalog();
            dgvCatalog.AutoGenerateColumns = true;
            dgvCatalog.ReadOnly = true;
            dgvCatalog.AllowUserToAddRows = false;
            dgvCatalog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rdbDesc.Checked = true;
            dgvCatalog.DataSource = displayedProducts;
            UpdateStatus();
            btnExcept.Click += btnExcept_Click;
            btnIntersect.Click += btnIntersect_Click;
            btnUnionSorted.Click += btnUnionSorted_Click;
            btnConcatDistinct.Click += btnConcatDistinct_Click;
            btnSort.Click += btnSort_Click;
        }
        private void ShowProducts(List<Product> products)
        {
            displayedProducts = products;
            dgvCatalog.DataSource = null;
            dgvCatalog.DataSource = displayedProducts;
            UpdateStatus();
        }

        private void dgvCatalog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcept_Click(object sender, EventArgs e)
        {
            ShowProducts(catalogService.GetExclusiveProductsA());
        }

        private void btnIntersect_Click(object sender, EventArgs e)
        {
            ShowProducts(catalogService.GetCommonProducts());
        }

        private void btnUnionSorted_Click(object sender, EventArgs e)
        {
            ShowProducts(catalogService.GetConsolidatedCatalog());
        }

        private void btnConcatDistinct_Click(object sender, EventArgs e)
        {
            ShowProducts(catalogService.GetFullRegistry());
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (rdbAsc.Checked)
            {
                ShowProducts(displayedProducts.OrderBy(p => p.Price).ToList());
            }
            else
            {
                ShowProducts(displayedProducts.OrderByDescending(p => p.Price).ToList());
            }

        }
        private void UpdateStatus()
        {
            int count = displayedProducts.Count();
            decimal averagePrice = count > 0 ? displayedProducts.Average(p => p.Price) : 0m;
            lblStatus.Text = $"Записей {count} | Средняя стоимость: " + $"{averagePrice:N2} тенге";
        }
    }
}
