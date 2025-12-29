# 🤖 LLM Chat Application

Bu proje, **C# ve Windows Forms** kullanılarak geliştirilmiş, yapay zeka (LLM) ile sohbet etmeyi sağlayan bir masaüstü uygulamasıdır. **Groq API** altyapısını kullanarak kullanıcılara hızlı ve akıllı cevaplar üretir.

---

## 🚀 Özellikler

* **Yapay Zeka Entegrasyonu:** Groq API üzerinden güçlü LLM modelleriyle (Llama 3, Mixtral vb.) iletişim kurar.
* **Kullanıcı Dostu Arayüz:** DevExpress bileşenleri ile modern ve temiz bir sohbet ekranı.
* **JSON Veri İşleme:** `Newtonsoft.Json` kütüphanesi ile API istekleri ve cevapları profesyonelce yönetilir.
* **Hızlı Yanıt:** Asenkron programlama yapısı sayesinde arayüz donmadan akıcı sohbet deneyimi sunar.

---

## 🛠️ Kullanılan Teknolojiler

* **Dil:** C# (.NET Framework)
* **IDE:** Visual Studio 2022
* **Arayüz (UI):** Windows Forms & DevExpress
* **API:** Groq Cloud API
* **Kütüphaneler:**
    * `Newtonsoft.Json` (Veri serileştirme için)
    * `System.Net.Http` (API haberleşmesi için)

---

## ⚙️ Kurulum ve Çalıştırma

Projenin kendi bilgisayarınızda çalışması için şu adımları izleyin:

1.  **Projeyi İndirin:**
    Bu sayfadaki yeşil **Code** butonuna basıp "Download ZIP" diyerek indirin veya git ile klonlayın.

2.  **Visual Studio ile Açın:**
    `LLMChatApp.sln` dosyasına çift tıklayarak projeyi açın.

3.  **API Anahtarını Girin:**
    Kod içerisindeki API Key bölümüne kendi **Groq API** anahtarınızı yapıştırın.
    *(Not: Güvenlik için API anahtarınızı asla GitHub'a açık şekilde yüklemeyin.)*

4.  **Başlatın:**
    F5 tuşuna basarak veya "Start" butonuna tıklayarak uygulamayı çalıştırın.

