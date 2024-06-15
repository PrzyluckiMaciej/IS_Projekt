using Insight.Database;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Project_app.ORM_classes;
using Project_app.ORM_interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using YamlDotNet.Serialization;

namespace Project_app
{
    public partial class DeathsUC : UserControl
    {
        private string connectionStr;
        private MySqlConnection con;
        private ICountryRepository repo;
        private string when;
        public DeathsUC()
        {
            connectionStr = "SERVER=localhost;DATABASE=covid;UID=covidAdmin;PASSWORD=covid;";
            con = new MySqlConnection(connectionStr);
            repo = con.As<ICountryRepository>();
            InitializeComponent();
        }

        private void beforeButton_Click(object sender, EventArgs e)
        {
            IList<CountrySet> results = repo.GetAllDeathsBefore();
            dataGridView.DataSource = results;
            when = "before";
        }

        private void afterButton_Click(object sender, EventArgs e)
        {
            IList<CountrySet> results = repo.GetAllDeathsAfter();
            dataGridView.DataSource = results;
            when = "after";
        }

        private void export_Click(object sender, EventArgs e)
        {
            // Pobierz dane z dataGridView
            IList<CountrySet> results = dataGridView.DataSource as IList<CountrySet>;

            if (results == null || results.Count == 0)
            {
                MessageBox.Show("Wybierz czy dane przed czy po pandemii.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string timestamp = DateTime.Now.ToString("dd-MM-yyyy");
            // Sprawdź wybrany format w ComboBox
            string selectedFormat = ChoiceExportDeaths.SelectedItem.ToString();

            if (selectedFormat == "JSON")
            {
                // Konwertuj do JSON
                string json = JsonConvert.SerializeObject(results, Newtonsoft.Json.Formatting.Indented);

                // Zapisz do pliku
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Pliki JSON (*.json)|*.json|Wszystkie pliki (*.*)|*.*";
                saveFileDialog.Title = "Zapisz plik JSON";
                saveFileDialog.FileName = $"JSON_export_{when}_deaths_{timestamp}.json";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        File.WriteAllText(filePath, json);
                        MessageBox.Show("Dane zostały pomyślnie zapisane do pliku JSON.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Wystąpił błąd podczas zapisu pliku: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (selectedFormat == "XML")
            {
                // Konwertuj do XML
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<CountrySet>));
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Pliki XML (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
                saveFileDialog.Title = "Zapisz plik XML";
                saveFileDialog.FileName = $"XML_export_{when}_deaths_{timestamp}.xml";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            xmlSerializer.Serialize(writer, results);
                        }
                        MessageBox.Show("Dane zostały pomyślnie zapisane do pliku XML.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Wystąpił błąd podczas zapisu pliku: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (selectedFormat == "YAML")
            {
                // Konwertuj do YAML
                var serializer = new YamlDotNet.Serialization.Serializer();
                string yaml = serializer.Serialize(results);

                // Zapisz do pliku
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Pliki YAML (*.yaml)|*.yaml|Wszystkie pliki (*.*)|*.*";
                saveFileDialog.Title = "Zapisz plik YAML";
                saveFileDialog.FileName = $"YAML_export_{when}_deaths_{timestamp}.yaml";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        File.WriteAllText(filePath, yaml);
                        MessageBox.Show("Dane zostały pomyślnie zapisane do pliku YAML.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Wystąpił błąd podczas zapisu pliku: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else
            {
                MessageBox.Show("Nieznany format eksportu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void import_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Import do zrobienia.", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

