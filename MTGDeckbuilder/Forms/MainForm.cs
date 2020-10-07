using System;
using System.Windows.Forms;
using MTGDeckbuilder.Forms;

namespace MTGDeckbuilder
{
    public partial class MainForm : Form
    {
        private Form _activeChildForm;

        public MainForm()
        {
            InitializeComponent();
            panelSlideForm.Visible = false;
            OpenWorkbenchForm();
        }

        private void OpenWorkbenchForm()
        {
            var workbenchForm = new WorkbenchForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panelMain.Controls.Add(workbenchForm);
            panelMain.Tag = workbenchForm;
            panelMain.Width = workbenchForm.Width;
            panelMain.Height = workbenchForm.Height;
            panelMain.Visible = true;
            workbenchForm.BringToFront();
            workbenchForm.Show();
        }

        private void OpenWorkbenchForm(Form workbenchForm)
        {
            workbenchForm.TopLevel = false;
            workbenchForm.FormBorderStyle = FormBorderStyle.None;
            workbenchForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(workbenchForm);
            panelMain.Tag = workbenchForm;
            panelMain.Width = workbenchForm.Width;
            panelMain.Height = workbenchForm.Height;
            panelMain.Visible = true;
            workbenchForm.BringToFront();
            workbenchForm.Show();
        }

        private void OpenChildForm(Form childForm)
        {
            if (_activeChildForm != null && _activeChildForm.Name == childForm.Name)
            {
                CloseChildFormIfOpen();
            }
            else
            {
                _activeChildForm = childForm;

                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelSlideForm.Controls.Add(childForm);
                panelSlideForm.Tag = childForm;
                panelSlideForm.Width = childForm.Width;
                panelSlideForm.Height = childForm.Height;
                panelSlideForm.Visible = true;
                childForm.BringToFront();
                childForm.Show();
            }
        }

        private void CloseChildFormIfOpen()
        {
            _activeChildForm.Close();
            _activeChildForm = null;
            panelSlideForm.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchForm();
            OpenChildForm(searchForm);
            //Form 
        }

        private void btnViewSort_Click(object sender, EventArgs e)
        {
            //Form zum Auswählen der verschiedenen Ansichten, vielleicht mit Beispielbildern
            var viewSortForm = new ViewSortForm();
            OpenChildForm(viewSortForm);
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            //Form zum Anzeigen der Deckstatistiken
            var statsForm = new StatsForm();
            OpenChildForm(statsForm);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Speichern, childForm muss nicht geöffnet/geschlossen werden
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Form zum Export des Decks, vielleicht in .txt, .dec, Zwischenablage etc.
            var exportForm = new ExportForm();
            OpenChildForm(exportForm);
        }

        private void btnDecks_Click(object sender, EventArgs e)
        {
            //Form zur Auswahl des jetzigen Decks, vielleicht mit Öffnungs-Dialog
            var decksForm = new DecksForm();
            OpenChildForm(decksForm);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Form zur Auswahl der Einstellungen
            var settingsForm = new SettingsForm();
            OpenChildForm(settingsForm);
        }
    }
}
