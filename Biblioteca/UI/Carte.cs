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
    public partial class Carte : Form
    {
        // Services for managing tables
        private ICarteService carteService;
        private IAutorService autorService;
        private IEdituraService edituraService;
        private CarteDTO carteEditata;

        // Constructor for add book
        public Carte(ICarteService carteService, IAutorService autorService, IEdituraService edituraService)
        {
            InitializeComponent();
            this.carteService = carteService;
            this.autorService = autorService;
            this.edituraService = edituraService;
            this.carteEditata = null;
        }

        // Constructor for modify book
        public Carte(ICarteService carteService, IAutorService autorService, IEdituraService edituraService, CarteDTO carte)
        {
            InitializeComponent();
            this.carteService = carteService;
            this.autorService = autorService;
            this.edituraService = edituraService;
            this.carteEditata = carte;
        }

        // Load form
        private void Carte_Load(object sender, EventArgs e)
        {
            List<EdituraDTO> edituri = edituraService.GetEditura();
            comboBoxEditura.DataSource = edituri;
            comboBoxEditura.DisplayMember = "NumeEditura";
            comboBoxEditura.ValueMember = "IdEditura";

            List<AutorDTO> autori = autorService.GetAutori();
            checkedListBoxAutor.DataSource = autori;
            checkedListBoxAutor.DisplayMember = "NumeComplet";
            checkedListBoxAutor.ValueMember = "IdAutor";

            // Only for modify book
            if (carteEditata != null)
            {
                textBoxTitlu.Text = carteEditata.Titlu;
                numericUpDownAn.Value = carteEditata.AnPublicare;
                textBoxDescriere.Text = carteEditata.Descriere;
                comboBoxEditura.SelectedValue = carteEditata.IdEditura;

                for (int i = 0; i < checkedListBoxAutor.Items.Count; ++i)
                {
                    AutorDTO autor = (AutorDTO)checkedListBoxAutor.Items[i];
                    checkedListBoxAutor.SetItemChecked(i, carteEditata.IdAutori.Contains(autor.IdAutor));
                }
            }
        }

        // Button action for save book
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTitlu.Text))
            {
                MessageBox.Show("Introduceti titlul cartii!");
                return;
            }

            CarteDTO carte = new CarteDTO
            {
                Titlu = textBoxTitlu.Text,
                AnPublicare = (int)numericUpDownAn.Value,
                Descriere = textBoxDescriere.Text,
                IdEditura = (int)comboBoxEditura.SelectedValue,
                IdAutori = new List<int>()
            };

            foreach (var item in checkedListBoxAutor.CheckedItems)
            {
                AutorDTO autor = (AutorDTO)item;
                carte.IdAutori.Add(autor.IdAutor);
            }

            if (carteEditata != null) // Modify book
            {
                carte.IdCarte = carteEditata.IdCarte;
                carteService.ModificaCarte(carte);
                MessageBox.Show("Cartea a fost actualizata!");
            }
            else // Add new book
            {
                carteService.AdaugaCarte(carte);
                MessageBox.Show("Cartea a fost adaugata!");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Button action for exit form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
