using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using MTGDeckbuilder.MtgJsonObjects;
using Newtonsoft.Json;

namespace MTGDeckbuilder.Forms
{
    public partial class SettingsForm : Form
    {
        private const string BaseUrl = "https://www.mtgjson.com";

        private const string AllPrintingsUrl = "/files/AllPrintings.json";

        //Die noch durch konfigurierbare Einstellungen ersetzen
        private const string AllPrintingsPath = "D:\\Downloads\\AllPrintings.json";

        private const string AllCardsPath = "D:\\Downloads\\AllCards.json";
        //

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnDeckFolder_Click(object sender, EventArgs e)
        {
            if (fbdDeckFolder.ShowDialog() == DialogResult.OK)
            {
                txtDeckFolder.Text = fbdDeckFolder.SelectedPath;
                //Brauche irgendwie noch einen Zentralen Ort, wo ich alles mache.
                
                    //Vielleicht auch eine .config Datei mit den Grundeinstellungen machen und die immer laden.
                    //Beim ersten Starten, also wenn keine .config da ist oder diese Fehler hat, Grundeinstellungen vorgeben 
                    //oder vorher in einem INSTALLER konfigurieren lassen.
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            var requestUrl = BaseUrl + AllPrintingsUrl;
            using (var wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileAsync(
                    // Param1 = Link of file
                    new Uri(requestUrl),
                    // Param2 = AllCardsPath to save
                    AllPrintingsPath);
                wc.DownloadFileCompleted += wc_DownloadFileCompleted;
            }
        }

        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            var prettyJson = JsonPrettify(File.ReadAllText(AllPrintingsPath));
            File.WriteAllText(AllPrintingsPath, prettyJson);
            ConvertJson(prettyJson);
            MessageBox.Show(@"Download Complete");
            progressBarDownload.Value = 0;
        }

        private static void ConvertJson(string json)
        {
            //Funktioniert!
            var allPrintingsDictionary = JsonConvert.DeserializeObject<Dictionary<string, Set>>(json);

            //Hier in json von allen einzelnen Karten konvertieren
            //Doppelte Einträge, wegen gleichen Karten in verschiedenen Sets sind erstmal ok

            IList<Card> allCardsList = new List<Card>();

            foreach (var pair in allPrintingsDictionary)
            {
                foreach (var card in pair.Value.Cards)
                {
                    allCardsList.Add(card);
                }
            }

            File.WriteAllText(AllCardsPath, JsonConvert.SerializeObject(allCardsList.ToArray(), Formatting.Indented));
        }

        private static string JsonPrettify(string json)
        {
            using (var stringReader = new StringReader(json))
            using (var stringWriter = new StringWriter())
            {
                var jsonReader = new JsonTextReader(stringReader);
                var jsonWriter = new JsonTextWriter(stringWriter) { Formatting = Formatting.Indented };
                jsonWriter.WriteToken(jsonReader);
                return stringWriter.ToString();
            }
        }

        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarDownload.Value = e.ProgressPercentage;
        }
    }
}
