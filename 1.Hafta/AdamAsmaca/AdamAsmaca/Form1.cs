using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdamAsmaca
{
    public partial class Form1 : Form
    {
        private string kelime = "PROGRAMMING"; // Gizli kelime
        private char[] gizliKelime; // Kullanıcıya gösterilecek kelime
        private int kalanHak; // Kullanıcının kalan hakları

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Başlat(); // Oyunu başlat
        }

        private void Başlat()
        {
            gizliKelime = new string('_', kelime.Length).ToCharArray(); // Gizli kelimeyi başlat
            kalanHak = 6; // Kullanıcının 6 tahmin hakkı var
            lblWord.Text = new string(gizliKelime); // Gizli kelimeyi label'da göster
            lblAttempts.Text = "Kalan Hak: " + kalanHak; // Kalan hakları göster
            pictureBoxHangman.Image = null; // Başlangıçta görseli temizle
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string tahmin = txtGuess.Text.ToUpper(); // Kullanıcının tahmini

            if (tahmin.Length == 1)
            {
                if (kelime.Contains(tahmin))
                {
                    for (int i = 0; i < kelime.Length; i++)
                    {
                        if (kelime[i] == tahmin[0])
                        {
                            gizliKelime[i] = tahmin[0]; // Gizli kelimeyi güncelle
                        }
                    }
                    lblWord.Text = new string(gizliKelime); // Label'ı güncelle
                }
                else
                {
                    kalanHak--; // Kalan hakları azalt
                    lblAttempts.Text = "Kalan Hak: " + kalanHak; // Kalan hakları güncelle
                    UpdateHangmanImage(); // Görsel güncelle
                }

                // Oyun bitiş kontrolü
                if (kalanHak == 0)
                {
                    MessageBox.Show("Kaybettiniz! Kelime: " + kelime);
                    Başlat(); // Oyunu yeniden başlat
                }
                else if (new string(gizliKelime) == kelime)
                {
                    MessageBox.Show("Tebrikler! Kelimeyi bildiniz.");
                    Başlat(); // Oyunu yeniden başlat
                }
            }
            else
            {
                MessageBox.Show("Lütfen yalnızca bir harf girin.");
            }

            txtGuess.Clear(); // Tahmin kutusunu temizle
        }

        private void UpdateHangmanImage()
        {
            switch (kalanHak)
            {
                case 6:
                    pictureBoxHangman.Image = Image.FromFile("Images/hangman0.png");
                    break;
                case 5:
                    pictureBoxHangman.Image = Image.FromFile("Images/hangman1.png");
                    break;
                case 4:
                    pictureBoxHangman.Image = Image.FromFile("Images/hangman2.png");
                    break;
                case 3:
                    pictureBoxHangman.Image = Image.FromFile("Images/hangman3.png");
                    break;
                case 2:
                    pictureBoxHangman.Image = Image.FromFile("Images/hangman4.png");
                    break;
                case 1:
                    pictureBoxHangman.Image = Image.FromFile("Images/hangman5.png");
                    break;
                case 0:
                    pictureBoxHangman.Image = Image.FromFile("Images/hangman6.png");
                    break;
            }
        }

        private void lblWord_Click(object sender, EventArgs e)
        {
            // Bu metodu boş bırakabilirsiniz
        }
    }
}
