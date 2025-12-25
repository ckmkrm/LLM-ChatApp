using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LLMChatApp
{
    public partial class Form1 : Form
    {
        
        // Groq API Anahtarınızı buraya yapıştırın (gsk_... ile başlayan)
        private const string ApiKey = "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";

        // Groq URL adresi (OpenAI uyumlu olduğu için yapısı benzerdir)
        private const string ApiUrl = "https://api.groq.com/openai/v1/chat/completions";

        // HttpClient nesnesi
        private static readonly HttpClient client = new HttpClient();

        // Sohbet geçmişi listesi
        private List<Message> chatHistory = new List<Message>();

        public Form1()
        {
            InitializeComponent();
            InitializeHttpClient();
        }

        private void InitializeHttpClient()
        {
            // API Key'i header'a ekliyoruz
            if (!client.DefaultRequestHeaders.Contains("Authorization"))
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {ApiKey}");
            }
        }

        // GÖNDER BUTONU
        private async void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(userInput)) return;

            // 1. Kullanıcı mesajını ekrana ve geçmişe ekle
            AppendToChat("Siz: " + userInput);
            chatHistory.Add(new Message { Role = "user", Content = userInput });

            // Arayüzü kilitle
            txtInput.Clear();
            txtInput.Enabled = false;
            btnSend.Enabled = false;
            lblStatus.Text = "Yapay Zeka düşünüyor...";

            try
            {
                // 2. API'ye istek gönder (GetAIResponse BURADA ÇAĞRILIYOR)
                string responseContent = await GetAIResponse();

                // 3. Gelen cevabı işle
                AppendToChat("AI: " + responseContent);

                // Cevabı geçmişe ekle
                chatHistory.Add(new Message { Role = "assistant", Content = responseContent });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Arayüzü aç
                txtInput.Enabled = true;
                btnSend.Enabled = true;
                lblStatus.Text = "Hazır";
                txtInput.Focus();
            }
        }

        
        private async Task<string> GetAIResponse()
        {
            // Groq için istek hazırlıyoruz
            var requestData = new CompletionRequest
            {
                // Groq'un ücretsiz ve hızlı modeli: Llama 3
                Model = "llama-3.3-70b-versatile",
                Messages = chatHistory
            };

            // JSON'a çevir
            string jsonContent = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            // İsteği gönder
            HttpResponseMessage response = await client.PostAsync(ApiUrl, content);

            // Cevabı oku
            string responseString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"API Hatası: {response.StatusCode} - {responseString}");
            }

            // JSON cevabını çöz
            var result = JsonConvert.DeserializeObject<CompletionResponse>(responseString);

            // Mesajı döndür
            return result.Choices[0].Message.Content;
        }

        // Ekrana yazı yazma yardımcısı
        private void AppendToChat(string text)
        {
            rtbOutput.AppendText(text + Environment.NewLine + Environment.NewLine);
            rtbOutput.ScrollToCaret();
        }
    }
}