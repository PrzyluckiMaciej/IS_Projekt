using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using YamlDotNet.Serialization;

namespace Project_app
{
    public static class DataExporter
    {
        public static void ExportData<T>(IList<T> data, string format, string when, string fileType)
        {
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("Nie wybrano danych do eksportu.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string timestamp = DateTime.Now.ToString("dd-MM-yyyy");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = $"Zapisz plik {format.ToUpper()}";
            saveFileDialog.FileName = $"{format.ToUpper()}_export_{when}_{fileType}_{timestamp}.{format.ToLower()}";
            saveFileDialog.Filter = $"Pliki {format.ToUpper()} (*.{format.ToLower()})|*.{format.ToLower()}|Wszystkie pliki (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    switch (format.ToUpper())
                    {
                        case "JSON":
                            string json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
                            File.WriteAllText(filePath, json);
                            break;

                        case "XML":
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                            using (StreamWriter writer = new StreamWriter(filePath))
                            {
                                xmlSerializer.Serialize(writer, data);
                            }
                            break;

                        case "YAML":
                            var yamlSerializer = new Serializer();
                            string yaml = yamlSerializer.Serialize(data);
                            File.WriteAllText(filePath, yaml);
                            break;

                        default:
                            MessageBox.Show("Nieznany format eksportu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    MessageBox.Show($"Dane zostały pomyślnie zapisane do pliku {format.ToUpper()}.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd podczas zapisu pliku: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
