using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories;


namespace GUI
{
    public partial class UpdateFlower : Form
    {
        private Flower _flowerToUpdate; // Store the flower to update

        public UpdateFlower(Flower flower)
        {
            InitializeComponent();

            // Store the flower to update
            _flowerToUpdate = flower;

            // Initialize form fields with flower data
            txtName.Text = flower.Name;
            cmbSeason.Text = flower.Season;
            txtPrice.Text = flower.UnitPrice.ToString();
            txtColor.Text = flower.Description;
            txtStock.Text = flower.Stock.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(cmbSeason.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtColor.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal unitPrice) || unitPrice <= 0)
            {
                MessageBox.Show("Please enter a valid unit price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Please enter a valid stock quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the flower object
            _flowerToUpdate.Name = txtName.Text;
            _flowerToUpdate.Season = cmbSeason.Text;
            _flowerToUpdate.UnitPrice = unitPrice;
            _flowerToUpdate.Description = txtColor.Text;
            _flowerToUpdate.Stock = stock;

            // Update the flower in the repository or wherever it's stored
            FlowerRepository flowerRepository = new FlowerRepository();
            flowerRepository.UpdateFlower(_flowerToUpdate);

            MessageBox.Show("Flower updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
