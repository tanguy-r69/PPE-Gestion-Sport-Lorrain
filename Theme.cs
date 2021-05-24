namespace PPE_Maison_Des_Ligues
{
    public class Theme
    {
        #region Propriétés privées

        private int idTheme;
        private string libelleTheme;

        #endregion

        #region Constructeur

        public Theme(int idTheme, string libelleTheme)
        {
            this.idTheme = idTheme;
            this.libelleTheme = libelleTheme;
        }

        #endregion

        #region Accesseur

        public int IdTheme
        {
            get => idTheme;
            set => idTheme = value;
        }

        public string LibelleTheme
        {
            get => libelleTheme;
            set => libelleTheme = value;
        }

        

        #endregion
    }
}