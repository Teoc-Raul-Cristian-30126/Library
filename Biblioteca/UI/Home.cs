using Bussiness.DTOs;
using Bussiness.IService;
using Bussiness.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Home : Form
    {
        // Services for managing tables
        private ICarteService carteService = new CarteService();
        private IAutorService autorService = new AutorService();
        private IEdituraService edituraService = new EdituraService();

        public Home()
        {
            InitializeComponent();
            RefreshGrid();
        }

        // Refresh grid in case a change has been made 
        private void RefreshGrid()
        {
            carteService.RefreshData();
            List<CarteDTO> carti = carteService.GetCarti();
            
            var list = carti.Select(c => new
            {
                c.IdCarte,
                c.Titlu,
                c.AnPublicare,
                c.Descriere,
                Editura = edituraService.GetEdituraByID(c.IdEditura).NumeEditura,
                Autori = string.Join(", ", c.IdAutori.Select(id =>
                {
                    AutorDTO autor = autorService.GetAutorByID(id);
                    return autor.NumeComplet;
                }))
            }).ToList();

            dataGridCarti.DataSource = null;
            dataGridCarti.DataSource = list;
        }

        // Button action for add book
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Form form = new Carte(carteService, autorService, edituraService);
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        // Button action for modify book
        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dataGridCarti.CurrentRow == null || dataGridCarti.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Selectati o carte!!");
                return;
            }

            int idCarte = (int)dataGridCarti.CurrentRow.Cells["IdCarte"].Value;
            CarteDTO carteSelectata = carteService.GetCarteByID(idCarte);

            if (carteSelectata != null)
            {
                Form form = new Carte(carteService, autorService, edituraService, carteSelectata);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        // Button action for delete book
        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dataGridCarti.CurrentRow == null || dataGridCarti.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Selectati o carte!!");
                return;
            }

            int idCarte = (int)dataGridCarti.CurrentRow.Cells["IdCarte"].Value;

            DialogResult confirmare = MessageBox.Show("Doriti sa stergeti cartea selectata?", 
                                                      "Confirmare stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmare == DialogResult.Yes)
            {
                carteService.StergeCarte(idCarte);
                MessageBox.Show("Cartea a fost stearsa cu succes!");
                RefreshGrid();
            }
        }

        // Button action for list book
        private void btnListeaza_Click(object sender, EventArgs e)
        {
            Form form = new Raport(carteService, autorService, edituraService);
            form.ShowDialog();
        }
    }
}
