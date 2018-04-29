using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;





namespace BlackJack
{
    
    public partial class BlackJackForm : Form
    {
        List<Button> cardsOnTable;
        List<Karta> deck;
        List<int> redosljed;
        double ulog = 0;
        double novac = 0;
        int gorex, gorey, doljex , doljey, igrac, diler;
        int brojPodjeljenihKarata, asDiler, asIgrac;



        public BlackJackForm()
        {
            InitializeComponent();
            this.cardsOnTable = new List<Button>();
            deck = new List<Karta>();
            redosljed = new List<int>(22);
            for(int i = 1; i < 14; i++)
            {
                deck.Add(new Karta(i, "clubs"));
                deck.Add(new Karta(i, "diamonds"));
                deck.Add(new Karta(i, "hearts"));
                deck.Add(new Karta(i, "spades"));
            }
            novac = 50;
            textBoxMoney.Text = novac.ToString();

        }



        private void povecajUlog_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            double x = Convert.ToDouble(b.Text);
            buttonDeal.Enabled = true;

            if(novac - ulog -x >= 0)
            {
                ulog += x;
            }
            textBoxUlog.Text = ulog.ToString();
        }

        private void buttonDeal_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < brojPodjeljenihKarata; i++) {
                this.Controls.Remove(cardsOnTable[i]);
                cardsOnTable[i].Dispose();
            }
            cardsOnTable.Clear();
            redosljed.Clear();
            brojPodjeljenihKarata = 0;
            asDiler = 0;
            asIgrac = 0;
            gorex = 350;
            gorey = 80;
            doljex = 350;
            doljey = 350;
            igrac = 0;
            diler = 0;
            if(ulog != 0 && novac > 0)
            {
                Console.Write("1. Igrac:" + igrac + " Diler:" + diler+"\n");  
                buttonDeal.Enabled = false;
                buttonUlog1.Enabled = false;
                buttonUlog5.Enabled = false;
                buttonUlog10.Enabled = false;
                buttonUlog20.Enabled = false;
                buttonHit.Visible = true;
                buttonStay.Visible = true;
                labelIshod.Visible = false;

                Random rnd = new Random();
                
                int x;
                for (int i = 0; i < 22; i++)
                {
                    do{
                        x = rnd.Next(52);
                    } while (redosljed.Contains(x));
                    redosljed.Add(x);
                }
                prikaziKartu(deck[redosljed[0]], gorex, gorey);
                gorex += 20;
                diler += deck[redosljed[0]].getValue();
                Console.Write("2. Igrac:" + igrac + " Diler:" + diler + "\n");  
                for (int i = 1; i < 3; i++) {
                    prikaziKartu(deck[redosljed[i]], doljex, doljey);
                    doljex += 20;
                    igrac += deck[redosljed[i]].getValue();
                    if (igrac == 21)
                        blackJack();
                    if (deck[redosljed[i]].getValue() == 11)
                        asIgrac++;
                    Console.Write("3. Igrac:" + igrac + " Diler:" + diler + "\n");  
                }
                                
                if (deck[redosljed[0]].getValue() == 11)
                    asDiler++;
                brojPodjeljenihKarata = 3;  

            }
            else if (novac <= 0) {
                labelIshod.Text = "You are out of money";
                labelIshod.Visible = true;
            }
        }
        private void prikaziKartu(Karta karta, int x, int y)
        {
            cardsOnTable.Add(new Button());

            System.Drawing.Image slika;
            slika = Image.FromFile("../../slike/PNG-cards-1.3/" + karta.getName()+".png");
            cardsOnTable[cardsOnTable.Count -1].BackgroundImage = slika;
            cardsOnTable[cardsOnTable.Count - 1].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            cardsOnTable[cardsOnTable.Count - 1].ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            cardsOnTable[cardsOnTable.Count - 1].Location = new System.Drawing.Point(x, y);
            cardsOnTable[cardsOnTable.Count - 1].Name = karta.getName();
            cardsOnTable[cardsOnTable.Count - 1].Size = new System.Drawing.Size(65, 94);
            cardsOnTable[cardsOnTable.Count - 1].TabIndex = 9;
            cardsOnTable[cardsOnTable.Count - 1].UseVisualStyleBackColor = true;
            this.Controls.Add(cardsOnTable[cardsOnTable.Count - 1]);
            cardsOnTable[cardsOnTable.Count - 1].BringToFront();
        }

        private void buttonHit_Click(object sender, EventArgs e) {
            prikaziKartu(deck[redosljed[brojPodjeljenihKarata]], doljex, doljey);
            doljex += 20;
            igrac += deck[redosljed[brojPodjeljenihKarata]].getValue();

            if (deck[redosljed[brojPodjeljenihKarata]].getValue() == 11)
                asIgrac++;
            brojPodjeljenihKarata++;
            Console.Write("4. Igrac:" + igrac + " Diler:" + diler + "\n");  
            if (igrac > 21 && asIgrac == 0)
                poraz();
            else if (igrac > 21 && asIgrac != 0) {
                igrac -= 10;
                asIgrac--;
            }
            if (igrac == 21)
                buttonStay_Click(sender, e);

        }

        private void buttonStay_Click(object sender, EventArgs e) {
            do {
                prikaziKartu(deck[redosljed[brojPodjeljenihKarata]], gorex, gorey);
                gorex += 20;
                diler += deck[redosljed[brojPodjeljenihKarata]].getValue();
                brojPodjeljenihKarata++;
                if (deck[redosljed[brojPodjeljenihKarata]].getValue() == 11)
                    asDiler++;
                if (diler > 21 && asDiler != 0) {
                    diler -= 10;
                    asDiler--;
                }
                Console.Write("5. Igrac:" + igrac + " Diler:" + diler + "\n");  
            } while (diler < 17);
            if (diler > 21 || igrac > diler)
                pobjeda();
            else if (diler > igrac)
                poraz();
            else
                izjednaceno();



        }
        private void blackJack() {
            novac += ulog * 1.5;
            Console.Write("blackjack Igrac:" + igrac + " Diler:"+diler);
            labelIshod.Text = "BlackJack!!!";
            vratiNaPocetno();
        }

        private void pobjeda() {
            novac += ulog;
            Console.Write("pobjeda Igrac:" + igrac + " Diler:" + diler);
            labelIshod.Text = "You Win";
            vratiNaPocetno();
        }
        private void poraz() {
            novac -= ulog;
            Console.Write("poraz Igrac:" + igrac + " Diler:" + diler);
            labelIshod.Text = "You Lose";
            vratiNaPocetno();
        }
        private void izjednaceno() {
            Console.Write("izjednaceno Igrac:" + igrac + " Diler:" + diler);
            labelIshod.Text = "Tie";
            vratiNaPocetno();
        }

        private void vratiNaPocetno() {
            ulog = 0;
            textBoxMoney.Text = novac.ToString();
            textBoxUlog.Text = ulog.ToString();
            labelIshod.Visible = true;
            buttonUlog1.Enabled = true;
            buttonUlog5.Enabled = true;
            buttonUlog10.Enabled = true;
            buttonUlog20.Enabled = true;
            buttonHit.Visible = false;
            buttonStay.Visible = false;
            
            

        }

        
    }
}


public class Karta
{
    String color;
    int value;
    String name;

    public Karta(int value, String color)
    {
        this.value = value;
        this.color = color;
        name = value + "_of_" + color;
        if (value > 10)
            this.value = 10;
        if (value == 1)
            this.value = 11;
    }
    public String getName()
    {
        return name;
    }
    public int getValue() {
        return value;
    }

}
