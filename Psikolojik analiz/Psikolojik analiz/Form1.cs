using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void btntrue() {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            
        }
        public void btnfalse() {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
            

        }
        int soru = 0;
        int toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            toplam += 1;
            btnfalse();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button7.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            button8.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(soru <= 12){
                soru++;

            }
          
            button6.Text = "Sonraki Soru";
            btntrue();
            button6.Enabled = false;
            if (soru == 1)
            {
                textBox1.Text = "1-Sevgilinizle ya da eşinizle “mükemmel bir akşam” size aşağıdakilerden hangisini çağrıştırıyor?";
                button1.Text = "Bir rock konserine gitmek";
                button2.Text = "Lunaparka gitmek";
                button3.Text = "Sinemaya gitmek ";
                button4.Text = "Mum ışığında romantik bir yemek";
                button5.Text = "Arabayla turlamak";

            }
            if (soru == 2)
            {
                textBox1.Text = "2) En sevdiğiniz müzik türü hangisi?";
                button1.Text = "Alternatif";
                button2.Text = "Rock And Roll";
                button3.Text = "Pop";
                button4.Text = "Soft Rock";
                button5.Text = "RAP!";
            }
            if (soru == 3)
            {
                textBox1.Text = "3)En çok hangi tür filmleri seversiniz?";
                button1.Text = "Korku";
                button2.Text = "Komedi";
                button3.Text = "Müzikal";
                button4.Text = "Romantik ";
                button5.Text = "Belgesel";
            }
            if (soru == 4)
            {
                textBox1.Text = "4) Aşağıdaki mesleklerden birini seçmeniz gerekseydi hangisi olurdunuz?";
                button1.Text = "Barmen/Barmaid";
                button2.Text = "Polis";
                button3.Text = "Öğretmen";
                button4.Text = "Garson ";
                button5.Text = "Futbolcu";
            }
            if (soru == 5)
            {
                textBox1.Text = "5) Bir saat boş vaktinizi değerlendirmek için hangisi size daha uygun?";
                button1.Text = "TV izlemek ";
                button2.Text = "İnternete Girmek";
                button3.Text = "Uyumak";
                button4.Text = "Okumak ";
                button5.Text = "Dışarıda Çalışmak";
            }
            if (soru == 6)
            {
                textBox1.Text = "6) Aşağıdaki renklerden birini seçiniz.";
                button1.Text = "Sarı";
                button2.Text = "Kahverengi";
                button3.Text = "Mavi";
                button4.Text = "Kırmızı ";
                button5.Text = "Beyaz";
            }
            if (soru == 7)
            {
                textBox1.Text = "7) Şu an önünüzde aşağıdaki yiyeceklerden hangisi olsa dayanamayıp götürürsünüz?";
                button1.Text = "Suşi";
                button2.Text = "Pizza";
                button3.Text = "Dondurma";
                button4.Text = "Makarna ";
                button5.Text = "Salata";
            }
            if (soru == 8)
            {
                textBox1.Text = "8 ) En sevdiğiniz tatil, bayram ya da özel gün hangisi?";
                button1.Text = " 23 Nisan Çocuk Bayramı ";
                button2.Text = "Yılbaşı Tatili ";
                button3.Text = "Ramazan Bayramı";
                button4.Text = "Sevgililer Günü";
                button5.Text = "Kurban Bayramı";
            }
            if (soru == 9)
            {
                textBox1.Text = "9) Şu an aşağıdakilerden hangisinde olmak isterdiniz?";
                button1.Text = "Las Vegas’ta ";
                button2.Text = "Hawaii’de";
                button3.Text = "Hollywood’da";
                button4.Text = "Paris’te";
                button5.Text = "İspanya'da";
            }
            if (soru == 10)
            {
                textBox1.Text = "10) Nasıl biriyle vakit geçirmekten hoşlanırsınız?";
                button1.Text = "Bir parti canavarıyla ";
                button2.Text = "Güzel/Yakışıklı biriyle ";
                button3.Text = " Komik biriyle ";
                button4.Text = "Duygusal biriyle  ";
                button5.Text = " Akıllı biriyle ";
            }
            if (soru == 11)
            {
                button7.Visible = true;
                button6.Enabled = false;
                label2.Text = toplam.ToString();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                label1.Visible = true;
                label2.Visible = true;
                
            }
            
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //burdaki kod butonlar verdiğimiz değerlerin toplamında kaç çıkıyorsa ona göre yazı yazdırmak
            if (toplam >= 10 && toplam <= 17)//toplam 10dan büyükeşit ve 17den küçük eşitse
            {
                button8.Visible = true;
                textBox1.Text = "Siz vahşi ve çılgın birisiniz. Eğleneyim derken uçuyorsunuz. Ama her zaman ne yaptığınızın farkındasınız, hayatınızın kontrolünü kaybetmiyorsunuz. İnsanlar olaylara sizin gibi bakmadığında bu sizi durdurmuyor.Tavsiye: Bu vahşi karakterinizle kendinizi ve etrafınızdakileri incitebilirsiniz. Dikkatli olun.";
               
            }
            button8.Visible = true;

            if (toplam >= 18 && toplam <= 26)
            {
                button8.Visible = true;
                textBox1.Text = "Siz eğlenceli, arkadaş canlısı ve popülersiniz. Cıvıl cıvıl halinizle etrafa neşe saçıyorsunuz. Çoğu zaman ikili ilişkilerinizde uçuk kaçık davransanız da inandığınız değerlerden asla taviz vermiyorsunuz. Evlilik ve çocuk sahibi olmak sizin için önemli ama öncelikle yeterince tecrübe edinmek istiyorsunuz.Tavsiye: İnsanların aldığınız kararlarda sizi bu kadar etkilemelerine izin vermeyin.";
            }
            if (toplam >= 27 && toplam <= 34)
            {
                button8.Visible = true;
                textBox1.Text = "Öyle tatlısınız ki sizi sevmemek imkansız. Siz insanların asla kaybetmek istemeyeceği türden bir dostsunuz. Kimseyi incitmemek için kendinizi incittiğiniz bile oluyor. Siz genellikle olaylar karşısında olgun ve sakin bir tavır takınırsınız.Tavsiye: Herkes göründüğü gibi değildir, bunu unutmayın. Biraz kurnaz olun.";

            }
            if (toplam >= 35 && toplam <= 42)
            {
                button8.Visible = true;
                textBox1.Text = "Siz iflah olmaz bir romantiksiniz. Şarap, kırmızı güller, bunlar sizin yaşam tarzınız. Söz verirsiniz ve o sözü ne olursa olsun yerine getirirsiniz. Ailenize çok bağlısınız. Annenizi her haftasonu ararsınız, özel günleri asla unutmazsınız.Tavsiye: Fazla romantizmin sizi gerçeklerden uzaklaştırmasına izin vermeyin.";
            }
            if (toplam >= 43 && toplam <= 50)
            {
                button8.Visible = true;
                textBox1.Text = "Belirgin özelliğiniz hızlı ve doğru karar verebilmeniz. Her olay için kafanızda bir planınız vardır. Fiziksel ve zihinsel gücünüz çok fazla. Mantıklı, ılımlı ve yapıcı tavırlarınızla çoğu kişinin kendine örnek aldığı birisiniz.Tavsiye: Küçük gibi görünen bazı olayları gözardı etmeniz ileride büyük sorunlara yol açabilir.";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toplam += 2;
            btnfalse();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toplam += 3;
            btnfalse();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            toplam += 4;
            btnfalse();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            toplam += 5;
            btnfalse();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (soru == 11)
            {
                toplam = 0;
                soru = 0;
                button7.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                button6.Enabled = true;
                button8.Visible = false;

            }
        }
    }
}
