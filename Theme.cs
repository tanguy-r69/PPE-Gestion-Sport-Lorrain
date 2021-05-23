namespace PPE_Maison_Des_Ligues
{
    public class Theme
    {
        #region Propriétés privées

        private int idTheme;
        private string libelleTheme;
        private int idAtelier;

        #endregion

        #region Constructeur

        public Theme(int idTheme, string libelleTheme, int idAtelier)
        {
            this.idTheme = idTheme;
            this.libelleTheme = libelleTheme;
            this.idAtelier = idAtelier;
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

        public int IdAtelier
        {
            get => idAtelier;
            set => idAtelier = value;
        }

        #endregion
    }
}