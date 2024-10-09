using System.Drawing.Text;

namespace BoringTetris
{
    internal class Controller
    {
        private Model model;
        private View view;

        public Controller(Model model, View view)
        {
            this.model = model;
            this.view = view;
            
            // lägg till controllern i viewn så att den kan meddela när
            // användaren trycker på knappar och bilder
            view.RegisterController(this);
        }

        /// <summary>
        /// När användaren klickat på ett block uppdateras model och view.
        /// </summary>
        public void Click(int row, int col)
        {
            model.Set(row, col);

            UpdateView();
        }

        /// <summary>
        /// När användaren klickat på clear-knappen uppdateras model och view.
        /// </summary>
        public void Clear()
        {
            model.Clear();

            UpdateView();
        }

        /// <summary>
        /// View uppdateras genom att varje block i modellens matris
        /// överförs till blocken i viewn.
        /// </summary>
        private void UpdateView()
        {
            // uppdatera score    
            view.UpdateScore(model.GetScore());

            // för varje rad
            for (int row = 0; row < model.NumRows(); row++)
            {
                // för varje kolumn
                for (int col = 0; col < model.NumCols(); col++)
                {
                    // hämta blockets status från model
                    bool blockStatus = model.Get(row, col);

                    // om blocket är true så fylls det med innehåll i viewn
                    if (blockStatus)
                    {
                        view.Set(row, col);
                    }
                    // annars töms blocket på innehåll i viewn
                    else
                    {
                        view.Clear(row, col);
                    }
                }
            }
        }
    }
}
