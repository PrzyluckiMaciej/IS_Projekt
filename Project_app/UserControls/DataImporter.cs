using Azure;
using Library.Forms;
using MySqlX.XDevAPI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Project_app.ORM_classes;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using YamlDotNet.Core.Tokens;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Project_app.UserControls
{
    public static class DataImporter
    {
        public static void sendRequest<T>(RestClient client, string fileType, string when, T item)
        {
            var request = new RestRequest(fileType + "/insert_" + when, Method.Post);
            request.AddHeader("Content-type", "application/json");
            request.AddBody(item);
            var response = client.Execute(request);
            HttpStatusCode statusCode = response.StatusCode;
            int numericStatusCode = (int)statusCode;
            if (numericStatusCode != 200)
            {
                MessageBox.Show("Odmowa dostępu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public static void ImportData<T>(string format, string when, string fileType, string token)
        {
            if (when == null)
            {
                MessageBox.Show("Nie wybrano danych do importu.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string timestamp = DateTime.Now.ToString("dd-MM-yyyy");
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = $"Wybierz plik {format.ToUpper()}";
            openFileDialog.Filter = $"Pliki {format.ToUpper()} (*.{format.ToLower()})|*.{format.ToLower()}|Wszystkie pliki (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileString = File.ReadAllText(filePath);
                FileStream fileStream = File.OpenRead(filePath);

                try
                {
                    RestClient client = new RestClient("http://localhost:8080/api");
                    client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", token));
                    var request = new RestRequest(fileType+"/clear_"+when, Method.Delete);
                    request.RequestFormat = DataFormat.None;
                    var response = client.Execute(request);
                    HttpStatusCode statusCode = response.StatusCode;
                    int numericStatusCode = (int)statusCode;
                    if (numericStatusCode != 200)
                    {
                        MessageBox.Show("Odmowa dostępu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    switch (format.ToUpper())
                    {
                        case "JSON":
                            var json = JsonConvert.DeserializeObject<List<T>>(fileString.ToString());
                            foreach (T item in json)
                            {
                                sendRequest(client, fileType, when, item);
                            }
                            break;

                        case "XML":
                            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                            var xml = (List<T>)serializer.Deserialize(fileStream);
                            foreach (T item in xml)
                            {
                                sendRequest(client, fileType, when, item);
                            }
                            break;

                        case "YAML":
                            var deserialiser = new DeserializerBuilder()
                                .WithNamingConvention(UnderscoredNamingConvention.Instance)
                                .Build();
                            var yml = deserialiser.Deserialize<List<T>>(fileString);
                            foreach (T item in yml)
                            {
                                sendRequest(client, fileType, when, item);
                            }
                            break;

                        default:
                            MessageBox.Show("Nieznany format eksportu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    fileStream.Close();
                    MessageBox.Show($"Dane zostały pomyślnie zaimportowane do bazy.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd podczas zapisu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
