namespace BoringTetris
{
    public partial class View : Form
    {
        /*
         * kan INTE v�lja dimensioner
         * ett rutn�t visas
         * man klickar rutor, rutorna fylls
         * n�r en hel horizontell rad �r fylld f�rsvinner den och �vre rader faller INTE ner, spelaren f�r po�ng
         * starta knapp, startar nytt spel enligt dimensionerna
         * model inneh�ller en 2d array med bool, och score, SetSquare(x,y) s�tter en ruta, spelplanen uppdateras automatiskt
         * controller h�mtar info fr�n modellen, GetScore och GetGrid typ
         * From1 �r synonymt med View, kolla om man kan byta namn
         * bara ett modell objekt, dubble array uppdateras vid omstart
         * sdf
         * uppgifter, l�gg till score, l�gg till s� att rad faller ner ovan ifr�n
         */

        private Controller controller;

        public View()
        {
            InitializeComponent();
        }

        internal void RegisterController(Controller controller)
        {
            this.controller = controller;
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }


        // f�rsta raden
        private void pic0_0_Click(object sender, EventArgs e) { click(0, 0); }
        private void pic0_1_Click(object sender, EventArgs e) { click(0, 1); }
        private void pic0_2_Click(object sender, EventArgs e) { click(0, 2); }
        private void pic0_3_Click(object sender, EventArgs e) { click(0, 3); }
        private void pic0_4_Click(object sender, EventArgs e) { click(0, 4); }
        // andra raden
        private void pic1_0_Click(object sender, EventArgs e) { click(1, 0); }
        private void pic1_1_Click(object sender, EventArgs e) { click(1, 1); }
        private void pic1_2_Click(object sender, EventArgs e) { click(1, 2); }
        private void pic1_3_Click(object sender, EventArgs e) { click(1, 3); }
        private void pic1_4_Click(object sender, EventArgs e) { click(1, 4); }
        // tredje raden
        private void pic2_0_Click(object sender, EventArgs e) { click(2, 0); }
        private void pic2_1_Click(object sender, EventArgs e) { click(2, 1); }
        private void pic2_2_Click(object sender, EventArgs e) { click(2, 2); }
        private void pic2_3_Click(object sender, EventArgs e) { click(2, 3); }
        private void pic2_4_Click(object sender, EventArgs e) { click(2, 4); }
        // fj�rde raden
        private void pic3_0_Click(object sender, EventArgs e) { click(3, 0); }
        private void pic3_1_Click(object sender, EventArgs e) { click(3, 1); }
        private void pic3_2_Click(object sender, EventArgs e) { click(3, 2); }
        private void pic3_3_Click(object sender, EventArgs e) { click(3, 3); }
        private void pic3_4_Click(object sender, EventArgs e) { click(3, 4); }
        // femte raden
        private void pic4_0_Click(object sender, EventArgs e) { click(4, 0); }
        private void pic4_1_Click(object sender, EventArgs e) { click(4, 1); }
        private void pic4_2_Click(object sender, EventArgs e) { click(4, 2); }
        private void pic4_3_Click(object sender, EventArgs e) { click(4, 3); }
        private void pic4_4_Click(object sender, EventArgs e) { click(4, 4); }
        // sj�tte raden
        private void pic5_0_Click(object sender, EventArgs e) { click(5, 0); }
        private void pic5_1_Click(object sender, EventArgs e) { click(5, 1); }
        private void pic5_2_Click(object sender, EventArgs e) { click(5, 2); }
        private void pic5_3_Click(object sender, EventArgs e) { click(5, 3); }
        private void pic5_4_Click(object sender, EventArgs e) { click(5, 4); }
        // sjunde raden
        private void pic6_0_Click(object sender, EventArgs e) { click(6, 0); }
        private void pic6_1_Click(object sender, EventArgs e) { click(6, 1); }
        private void pic6_2_Click(object sender, EventArgs e) { click(6, 2); }
        private void pic6_3_Click(object sender, EventArgs e) { click(6, 3); }
        private void pic6_4_Click(object sender, EventArgs e) { click(6, 4); }



        private void click(int row, int col)
        {
            controller.Click(row, col);
        }
    }
}