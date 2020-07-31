using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zsákbamacska_Generátor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            zsmacska.Visible = true;
            int num;
            try
            {
                num = Convert.ToInt32(textBox1.Text);
                switch(num)
                {
                    case 0:
                        zsmacska.Text = "tudtad hogy régesrég nem létezett nulla";
                        MessageBox.Show("ezt az üzenetet nem láttad sicc");
                        zsmacska.Visible = false;
                        break;
                    case 1:
                        zsmacska.Text = "1? ne csináld már ez nagyon kicsi szám";
                        break;
                    case 2:
                        zsmacska.Text = "Bill gatesnek is ez a kedvenc száma";
                        break;
                    case 3:
                        zsmacska.Text = "Három , bekapod a károm";
                        break;
                    case 4:
                        zsmacska.Text = "4? hmm azthiszem ez 2x2 nek az eredménye";
                        break;
                    case 5:
                        zsmacska.Text = "5x5 = 25 , jó tudni";
                        break;
                    case 6:
                        zsmacska.Text = "6+6 az 12 , mostmár ezt is tudod";
                        break;
                    case 7:
                        zsmacska.Text = "macskák is szeretik a 7days kroassont";
                        break;
                    case 8:
                        zsmacska.Text = "8x8 64 hmm";
                        break;
                    case 9:
                        zsmacska.Text = "nem szeretem a 9et";
                        break;
                    case 10:
                        zsmacska.Text = "MIAU";
                        break;
                    case 11:
                        zsmacska.Text = "Grr";
                        break;
                    case 12:
                        zsmacska.Text = "májmimáj";
                        break;
                    case 13:
                        zsmacska.Text = "ROBLOX:O0f";
                        break;
                    case 14:
                        zsmacska.Text = "ha 2x rakod fel a win7 et akkor 64bites lesz és win14 lesz";
                        break;
                    case 15:
                        zsmacska.Text = "ha unatkozol találd fel magad";
                        break;
                    case 16:
                        zsmacska.Text = "a dió kemény , vagyis csak a héja";
                        break;
                    case 17:
                        zsmacska.Text = "firefox > chrome";
                        break;
                    case 18:
                        zsmacska.Text = "18 évesen majd ne legyél balfasz";
                        break;
                    case 19:
                        zsmacska.Text = "asd = null;";
                        break;
                    case 20:
                        zsmacska.Text = "0620 - bekapod meghúsz";
                        break;
                    case 21:
                        zsmacska.Text = "nincs jöbb ötletem";
                        break;
                    case 22:
                        zsmacska.Text = "soha ne add fel";
                        break;
                    case 23:
                        zsmacska.Text = "faszább gyerek vagy mint a tesód";
                        break;
                    case 24:
                        zsmacska.Text = "soha ne mondd hogy soha";
                        break;
                    case 25:
                        zsmacska.Text = "ez a progi ossza az észt";
                        break;
                    case 26:
                        zsmacska.Text = "a mcskák okosak ezt jól jegyezd meg";
                        break;
                    case 27:
                        zsmacska.Text = "a kreativitás határtalan";
                        break;
                    case 28:
                        zsmacska.Text = "a minecraft community egy nagy szar";
                        break;
                    case 29:
                        zsmacska.Text = "semmitmondó dumákkal van teli ez a szar";
                        break;
                    case 30:
                        zsmacska.Text = "senki nem lehet értékesebb nálad";
                        break;
                    case 31:
                        zsmacska.Text = "Fox is love Fox is life";
                        break;
                    case 32:
                        zsmacska.Text = "jó dolog ha örömet szerzel másoknak";
                        break;
                    case 33:
                        zsmacska.Text = "önbizalom mindent visz";
                        break;
                    case 34:
                        zsmacska.Text = "A Tesla egy jó kocsi márka!";
                        break;
                    case 35:
                        zsmacska.Text = "Lada a magyarok keze alatt ronccsá törik.";
                        break;
                    case 36:
                        zsmacska.Text = "01101111 01101011 01101111 01110011";
                        break;
                    case 37:
                        zsmacska.Text = "méregzsák ne legyél";
                        break;
                    case 38:
                        zsmacska.Text = "penészes kenyeret nehogy megedd (ProTipp)";
                        break;
                    case 39:
                        zsmacska.Text = "ez után jön a 40";
                        break;
                    case 40:
                        zsmacska.Text = "ezelőtt van a 39";
                        break;
                    case 41:
                        zsmacska.Text = "a lábad akkora de az iq-d biztos nem olyan sok";
                        break;
                    case 42:
                        zsmacska.Text = "ez a szám semmit nem mond";
                        break;
                    case 43:
                        zsmacska.Text = "ha szereted a rókákat kövesd a készítőt githubon";
                        break;
                    case 44:
                        zsmacska.Text = "bruh";
                        break;
                    case 45:
                        zsmacska.Text = "2012es szám csodát rejt";
                        break;
                    case 46:
                        zsmacska.Text = "az unalom néha nagyot alkot";
                        break;
                    case 47:
                        zsmacska.Text = "A kefír szar";
                        break;
                    case 48:
                        zsmacska.Text = "a Counter Strike még mindig legenda";
                        break;
                    case 49:
                        zsmacska.Text = "zzz";
                        break;
                    case 50:
                        zsmacska.Text = "ez éppen 100nak a fele";
                        break;
                    case 51:
                        zsmacska.Text = "hát bizony ez 51";
                        break;
                    case 52:
                        zsmacska.Text = "igen ez meg 52";
                        break;
                    case 53:
                        zsmacska.Text = "discord > facebook";
                        break;
                    case 54:
                        zsmacska.Text = "rwghegeg";
                        break;
                    case 55:
                        zsmacska.Text = "Ford Mustang jó , de a tesla mindent visz";
                        break;
                    case 56:
                        zsmacska.Text = "ha nem eszel megdöglessz";
                        break;
                    case 57:
                        zsmacska.Text = "aki tud az tud";
                        break;
                    case 58:
                        zsmacska.Text = "nem tudom mit írjak ide";
                        break;
                    case 59:
                        zsmacska.Text = "Tesco egy putri";
                        break;
                    case 60:
                        zsmacska.Text = "UwU";
                        break;
                    case 61:
                        zsmacska.Text = "Auchan egy epikus áruház";
                        break;
                    case 62:
                        zsmacska.Text = "KFC ben jó a hús!";
                        break;
                    case 63:
                        zsmacska.Text = "63? hova gondolsz?";
                        break;
                    case 64:
                        zsmacska.Text = "Manapság minden proci 64bites";
                        break;
                    case 65:
                        zsmacska.Text = "Kemény vagy mint a kád széle";
                        break;
                    case 66:
                        zsmacska.Text = "többre vagy képes mint gondolnád";
                        break;
                    case 67:
                        zsmacska.Text = "2+2 az 8 , tudtad?";
                        break;
                    case 68:
                        zsmacska.Text = "már csak egy lépésre vagy csabitól";
                        break;
                    case 69:
                        zsmacska.Text = "csabi kedvenc száma";
                        break;
                    case 70:
                        zsmacska.Text = "Találtál egy pontyot";
                        break;
                    case 71:
                        zsmacska.Text = "01100010 01110010 01110101 01101000";
                        MessageBox.Show("A windows váratlanul összeomlott.");
                        MessageBox.Show("its a prank lol");
                        zsmacska.Visible = false;
                        break;
                    case 72:
                        zsmacska.Text = "a windows xp jó volt";
                        break;
                    case 73:
                        zsmacska.Text = "hipp-hopp bunnyhopp";
                        break;
                    case 74:
                        zsmacska.Text = "az önvezető autó nem életveszélyes!";
                        break;
                    case 75:
                        zsmacska.Text = "gugolva lőjj csgoban (ProTipp)";
                        break;
                    case 76:
                        zsmacska.Text = "a bunnyhopp script csalás!";
                        break;
                    case 77:
                        zsmacska.Text = "Trabant egy szar";
                        break;
                    case 78:
                        zsmacska.Text = "ฅʕ•̫͡•ʔฅ";
                        break;
                    case 79:
                        zsmacska.Text = "11000011 10111100 01100111 01111001 01100101 01110011";
                        MessageBox.Show("ha van eszed megfejted");
                        zsmacska.Visible = false;
                        break;
                    case 80:
                        zsmacska.Text = "szerintem a magyar zenék szarok";
                        break;
                    case 81:
                        zsmacska.Text = "→_→";
                        break;
                    case 82:
                        zsmacska.Text = "←_←";
                        break;
                    case 83:
                        zsmacska.Text = "ᓚᘏᗢ";
                        break;
                    case 84:
                        zsmacska.Text = "ASD";
                        break;
                    case 85:
                        zsmacska.Text = "A need for speed jó";
                        break;
                    case 86:
                        zsmacska.Text = "A forza jobb mint a NFS";
                        break;
                    case 87:
                        zsmacska.Text = "Android > IoS";
                        break;
                    case 88:
                        zsmacska.Text = "bass boosted mixes > all";
                        break;
                    case 89:
                        zsmacska.Text = "ez az üzenet a forráskódban a 309edik helyen van deklarálva";
                        break;
                    case 90:
                        zsmacska.Text = "ne vegyél IpHoNeT";
                        break;
                    case 91:
                        zsmacska.Text = "Xiaomi > Iphone";
                        break;
                    case 92:
                        zsmacska.Text = "nézdmá' egy öt100as";
                        break;
                    case 93:
                        zsmacska.Text = "foxy szereti a sültkrumplit";
                        break;
                    case 94:
                        zsmacska.Text = "a minecraft egy jó játék";
                        break;
                    case 95:
                        zsmacska.Text = "megsúgom az igazat ennek a programnak se füle se farka";
                        break;
                    case 96:
                        zsmacska.Text = "A matek fontos , mindennek az alapja";
                        break;
                    case 97:
                        zsmacska.Text = "?BaCkWaRdS? did u ever tried it?";
                        break;
                    case 98:
                        zsmacska.Text = "a program készítője már nem rajong a fortniteért";
                        break;
                    case 99:
                        zsmacska.Text = "asd";
                        break;
                    case 100:
                        zsmacska.Text = "dik egy 100'as";
                        break;
                    case 2012:
                        zsmacska.Text = "Elvileg ekkor volt a világvége.";
                        break;
                    case 2146:
                        zsmacska.Text = "Mogyoród irányítószáma";
                        break;
                    case 2112:
                        zsmacska.Text = "Veresegyház irányitószáma";
                        break;
                    case 2162:
                        zsmacska.Text = "Őrbottyán irányitószáma";
                        break;
                    case 2120:
                        zsmacska.Text = "Dunakeszi irányítószáma";
                        break;
                    case 2100:
                        zsmacska.Text = "Gödöllő irányítószáma";
                        break;
                    case 666:
                        zsmacska.Text = "Démont idéztél";
                        ohshit Ohshit = new ohshit();
                        Ohshit.ShowDialog();
                        break;
                    case 777:
                        zsmacska.Text = "ezzel sose fogsz itten démont idézgetni sorry";
                        break;
                    case 888:
                        zsmacska.Text = "EZT MEGSZIVTAD";
                        szivas Szivas = new szivas();
                        Szivas.ShowDialog();
                        break;


                    default:
                        zsmacska.Text = "sajnos ez a szám nem nyert";
                        break;
                }
            }
            catch (Exception)
            {
                textBox2.Visible = false;
                zsmacska.Visible = false;
                MessageBox.Show("Ha van eszed akkor pls írj már be egy számot!!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("A programnak egy része váratlanul összeomlott");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            about About = new about();
            About.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}