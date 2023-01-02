// VoxAlpha
// © Bruno DENIS, avril 2020 (confinement covid-19)

// Voir les packages et les références utilisés pour SQLite

// Version utilisant la voix de synthèse pour les mots et des fichiers son .wav pour l'alphabet.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.Data.SQLite.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Collections;
using System.IO;

namespace VoxAlpha
{
    public partial class Form1 : Form
    {
        string SelLettre = "";
        string SelMot = "";
        Queue QueueOldMots = new Queue(51);

        string RepMot = "";
        string CasseEnCours = "";
        int NiveauEnCours = 1;

        List<string> motsNiv1 = new List<string>();
        List<string> motsNiv2 = new List<string>();
        int nbMotsNiv1 = 0;
        int nbMotsNiv2 = 0;

        int posYPanelRep = 290;
        int posYlabelMot = 350;

        public SpeechSynthesizer SyntheseVocale = new SpeechSynthesizer();


        public Form1()
        {
            InitializeComponent();

            // Remplissage des listes depuis la base SQLite selon les niveaux de difficulté.
            using (var connection = new SQLiteConnection(@"Data Source=.\alphabet.db"))
            {
                try
                {
                    var context = new DataContext(connection);
                    // <DicoTim> est le nom de la classe dans le mapping :
                    var tblDico = context.GetTable<DicoTim>();
                    foreach (var enr in tblDico)
                    {
                        switch (enr.niveau)
                        {
                            case 1:
                                motsNiv1.Add(enr.mot);
                                nbMotsNiv1++;
                                break;

                            case 2:
                                motsNiv2.Add(enr.mot);
                                nbMotsNiv2++;
                                break;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Erreur d'accès BDD !");
                }
            }

            // Lecture du fichier prenom_enfant.txt
            try
            {
                using (StreamReader sr = new StreamReader(@".\prenom_enfant.txt"))
                {
                    string prenom = sr.ReadLine();
                    if (prenom.Length < 50)
                        labelPrenom.Text = prenom;
                }
            }
            catch
            {
                MessageBox.Show("Erreur dans le fichier prenom_enfant.txt,\nvérifiez sa présence et son contenu.\n", "Lecture du prénom de l'enfant");
            }
        }


        // Démarrage du process applicatif dès que le formulaire est chargé et affiché.
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Majuscules";
            CasseEnCours = "CAP";
            ConstruirePanelAlpha("CAP");
            ConstruirePanelAlpha("BDC");
            RandomChoixDuMot(NiveauEnCours);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            labelMot.Visible = true;
            Update();
            EmettreSpeech(SelMot);
        }


        // Tirage aléatoire d'un mot selon le niveau et la casse sélectionnés,
        // en évitant les mots récemment utilisés (conservés dans QueueOldMots).
        private void RandomChoixDuMot(int niv)
        {
            string sMot = SelMot;
            string sMotCap = "";
            int i = 0;

            Random rnd = new Random();

            while (sMot == "" || QueueOldMots.Contains(sMot))
            {
                switch (NiveauEnCours)
                {
                    case 1:
                        i = rnd.Next(nbMotsNiv1);
                        sMot = motsNiv1[i];
                        break;

                    case 2:
                        i = rnd.Next(nbMotsNiv2);
                        sMot = motsNiv2[i];
                        break;
                }
            }

            int lgMot = sMot.Length;
            SelMot = sMot;

            // On conserve les 50 derniers mots utilisés afin d'empêcher les répétitons
            QueueOldMots.Enqueue(sMot);
            if (QueueOldMots.Count > 50)
                QueueOldMots.Dequeue();

            if (CasseEnCours == "CAP")
            {
                sMotCap = sMot.ToUpper();
                labelMot.Text = sMotCap;
            }
            else
            {
                labelMot.Text = sMot;
            }

            ConstruirePanelRep(lgMot);
            foreach (Label c in this.tablePanelRep.Controls)
            {
                c.MouseClick += new MouseEventHandler(ClickOnTablePanelRep);
            }

            labelMot.Location = new Point((this.Width - labelMot.Width) / 2, posYlabelMot);
            try
            {
                picBoxImage.Image = new Bitmap(@".\images\" + SelMot + ".jpg");
            }
            catch
            {
                MessageBox.Show($"Erreur de chargement d'une image : {SelMot}", "Erreur image");
            }
        }


        private void ConstruirePanelAlpha(string casse)
        {
            int i = 1;
            for (i = 1; i <= 26; i++)
            {
                Label labAlpha = new Label();
                labAlpha.AutoSize = true;

                if (casse == "CAP")
                {
                    labAlpha.Font = new Font(FontFamily.GenericSansSerif, 22, FontStyle.Bold);
                    labAlpha.Text = Convert.ToChar(64 + i).ToString();
                    labAlpha.Padding = new Padding(4);
                    labAlpha.Dock = DockStyle.Fill;
                    labAlpha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    tablePanelAlphaMaj.SetColumn(labAlpha, i);
                    tablePanelAlphaMaj.Controls.Add(labAlpha);
                }
                else
                {
                    labAlpha.Font = new Font(FontFamily.GenericSansSerif, 22, FontStyle.Bold);
                    labAlpha.Text = Convert.ToChar(96 + i).ToString();
                    labAlpha.Padding = new Padding(4);
                    labAlpha.Dock = DockStyle.Fill;
                    labAlpha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    tablePanelAlphaMin.SetColumn(labAlpha, i);
                    tablePanelAlphaMin.Controls.Add(labAlpha);
                }
            }

            // Intégration des contrôles dans le Panel.
            if (casse == "CAP")
            {
                foreach (Label c in this.tablePanelAlphaMaj.Controls)
                {
                    c.MouseClick += new MouseEventHandler(ClickOnTablePanelAlpha);
                }
            }
            else
            {
                foreach (Label c in this.tablePanelAlphaMin.Controls)
                {
                    c.MouseClick += new MouseEventHandler(ClickOnTablePanelAlpha);
                }
            }

            tablePanelAlphaMaj.Location = new Point((this.Width - tablePanelAlphaMaj.Width) / 2, 120);
            tablePanelAlphaMin.Location = new Point((this.Width - tablePanelAlphaMin.Width) / 2, 120);
        }


        private void ConstruirePanelRep(int nbCells)
        {
            tablePanelRep.Visible = false;
            tablePanelRep.Controls.Clear();
            tablePanelRep.ColumnCount = nbCells;

            int i = 1;
            for (i = 1; i <= nbCells; i++)
            {
                Label labAlpha = new Label();
                labAlpha.AutoSize = true;
                labAlpha.Font = new Font(FontFamily.GenericSansSerif, 27, FontStyle.Bold);
                labAlpha.Text = "-";
                labAlpha.BackColor = Color.LightSalmon;

                tablePanelRep.SetColumn(labAlpha, i);
                tablePanelRep.Controls.Add(labAlpha);
            }

            tablePanelRep.Location = new Point((this.Width - tablePanelRep.Width)/2, posYPanelRep);
            tablePanelRep.Visible = true;
        }


        public void ClickOnTablePanelAlpha(object sender, MouseEventArgs e)
        {
            Label lettre = sender as Label;
            if (lettre != null)
            {
                CleanLabels();
                CleanListBoxes();
                lettre.BackColor = Color.LightSalmon;
                SelLettre = lettre.Text;
                lettre.Update();
                EmettreSon(SelLettre);
            }
        }


        public void ClickOnTablePanelRep(object sender, MouseEventArgs e)
        {
            if (SelLettre != "")
            {
                Label lettre = sender as Label;
                tablePanelRep.Location = new Point((this.Width - tablePanelRep.Width) / 2, posYPanelRep);

                if (lettre != null)
                {
                    lettre.Text = SelLettre;
                    MajRepMot();
                }
            }
        }

        
        // Test de l'égalité mot à saisir / mot saisi.
        private void MajRepMot()
        {
            RepMot = "";
            string sL = "";

            var lst = tablePanelRep.Controls;
            foreach (Label item in lst)
            {
                sL = item.Text;
                RepMot += sL;
            }

            RepMot = RepMot.ToLower();
            if (RepMot == SelMot)
            {
                Update();
                //EmettreSon("repexacte");
                EmettreSpeech("C'est exact, tu peux rejouer avec un autre mot.");
                buttonExact.Visible = true;
            }
            else
            {
                buttonExact.Visible = false;
            }
        }


        // Suppression de la couleur de fond des labels de panel.
        private void CleanLabels()
        {
            var lst = tablePanelAlphaMaj.Controls;
            foreach (Label item in lst)
            {
                item.BackColor = Color.Empty;
            }

            lst = tablePanelAlphaMin.Controls;
            foreach (Label item in lst)
            {
                item.BackColor = Color.Empty;
            }

            tablePanelAlphaMaj.Update();
            tablePanelAlphaMin.Update();

            // Reset sélection lettre sélectionnée et mot saisi.
            SelLettre = "";
            RepMot = "";
        }


        // Sélection/désélection des lisbox de lettres accentuées.
        private void CleanListBoxes()
        {
            if (tablePanelMinAcc.Visible == true)
            {
                var lst = tablePanelMinAcc.Controls;
                foreach (ListBox item in lst)
                {
                    item.SelectedIndex = -1;
                }
            }

            if (tablePanelMajAcc.Visible == true)
            {
                var lst = tablePanelMajAcc.Controls;
                foreach (ListBox item in lst)
                {
                    item.SelectedIndex = -1;
                }
            }
        }


        // Gestion des événements du menu du toolstrip.

        private void MajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Majuscules";
            CasseEnCours = "CAP";
            NiveauEnCours = 1;
            CleanLabels();
            buttonExact.Visible = false;
            tablePanelAlphaMin.Visible = false;
            tablePanelMinAcc.Visible = false;
            tablePanelMajAcc.Visible = false;
            tablePanelAlphaMaj.Visible = true;
            RandomChoixDuMot(NiveauEnCours);
            Update();
            EmettreSpeech(SelMot);
        }


        private void MinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Minuscules";
            CasseEnCours = "BDC";
            NiveauEnCours = 1;
            CleanLabels();
            buttonExact.Visible = false;
            tablePanelMinAcc.Visible = false;
            tablePanelMajAcc.Visible = false;
            tablePanelAlphaMaj.Visible = false;
            tablePanelAlphaMin.Visible = true;
            RandomChoixDuMot(NiveauEnCours);
            Update();
            EmettreSpeech(SelMot);
        }


        private void majusculesAccentuéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Majuscules accentuées";
            CasseEnCours = "CAP";
            NiveauEnCours = 2;
            CleanLabels();
            buttonExact.Visible = false;
            tablePanelAlphaMin.Visible = false;
            tablePanelMinAcc.Visible = false;
            tablePanelAlphaMaj.Visible = true;
            tablePanelMajAcc.Location = new Point((this.Width - tablePanelMajAcc.Width) / 2, 225);
            tablePanelMajAcc.Visible = true;
            RandomChoixDuMot(NiveauEnCours);
            Update();
            EmettreSpeech(SelMot);
        }


        private void minusculesAccentuéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Minuscules accentuées";
            CasseEnCours = "BDC";
            NiveauEnCours = 2;
            CleanLabels();
            buttonExact.Visible = false;
            tablePanelAlphaMaj.Visible = false;
            tablePanelMajAcc.Visible = false;
            tablePanelAlphaMin.Visible = true;
            tablePanelMinAcc.Location = new Point((this.Width - tablePanelMinAcc.Width) / 2, 225);
            tablePanelMinAcc.Visible = true;
            RandomChoixDuMot(NiveauEnCours);
            Update();
            EmettreSpeech(SelMot);
        }


        // Gestion des listBox de lettres accentuées.
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CleanLabels();
            var lb = sender as ListBox;
            SelLettre = lb.SelectedItem.ToString();
            int i = lb.SelectedIndex;
            CleanListBoxes();
            lb.SelectedIndex = i;
            EmettreSon(SelLettre);
        }


        public void EmettreSon(string fichier)
        {
            string son = @".\sons\" + fichier + ".wav";

            SoundPlayer player = null;
            try
            {
                player = new SoundPlayer();
                player.SoundLocation = son;
                player.Load();
                player.PlaySync();
            }
            catch
            {
                MessageBox.Show($"Ce fichier de son .wav n'est pas valide :\n\n{son}\n", "Fichier son .wav");
                return;
            }
            finally
            {
                if (player != null) player.Dispose();
            }
        }


        public void EmettreSpeech(string texte)
        {
            try
            {
                SyntheseVocale.SetOutputToDefaultAudioDevice();
                SyntheseVocale.Rate = -1;
                SyntheseVocale.Speak(texte);
            }
            catch
            {
                MessageBox.Show($"Le texte \"{texte}\" ne peut être lu par la synthèse vocale\n\n", "Synthèse vocale");
                return;
            }
        }


        private void labelMot_Click(object sender, EventArgs e)
        {
            EmettreSpeech(SelMot);
        }


        private void buttonExact_Click(object sender, EventArgs e)
        {
            CleanLabels();
            RandomChoixDuMot(NiveauEnCours);
            buttonExact.Visible = false;
            Update();
            EmettreSpeech(SelMot);
        }

        private void toolButtonAide_Click(object sender, EventArgs e)
        {
            try
            {
                Help.ShowHelp(this, @".\VoxAlpha.chm");
            }
            catch
            {
                MessageBox.Show("Le fichier d'aide n'est pas accessible,\nil a été supprimé ou déplacé.\nRéinstallez le programme.\n", "Aide Alphabet");
                return;
            }
        }
    }


    // mapping pour LINQ
    // Table Name est le nom de la table SQLite à accéder
    // aligner le type des propriétés sur celui des champs de la BDD

    [Table(Name = "Dico")]
    class DicoTim
    {
        [Column(Name = "rowid")]
        public int RowId { get; set; }

        [Column(Name = "Niveau")]
        public int niveau { get; set; }

        [Column(Name = "Mot")]
        public string mot { get; set; }
    }

}
