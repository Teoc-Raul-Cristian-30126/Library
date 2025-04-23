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
    public partial class Raport : Form
    {
        // Services for managing tables
        private ICarteService carteService;
        private IAutorService autorService;
        private IEdituraService edituraService;

        public Raport(ICarteService carteService, IAutorService autorService, IEdituraService edituraService)
        {
            InitializeComponent();
            this.carteService = carteService;
            this.autorService = autorService;
            this.edituraService = edituraService;
        }

        // Load form
        private void Raport_Load(object sender, EventArgs e)
        {
            List<EdituraDTO> edituri = edituraService.GetEditura();
            comboBoxEditura.DataSource = edituri;
            comboBoxEditura.DisplayMember = "NumeEditura";
            comboBoxEditura.ValueMember = "IdEditura";
        }

        // Button action for list book in grid 
        private void btnFiltru_Click(object sender, EventArgs e)
        {
            int anMin = (int)numericUpDownAnPublicareMin.Value;
            int anMax = (int)numericUpDownAnPublicareMax.Value;
            int idEditura = (int)comboBoxEditura.SelectedValue;

            List<CarteDTO> rezultate = carteService.FiltreazaCarti(anMin, anMax, idEditura);

            var afisare = rezultate.Select(c => new
            {
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

            dataGridViewFiltrare.DataSource = null;
            dataGridViewFiltrare.DataSource = afisare;
        }
    }
}
