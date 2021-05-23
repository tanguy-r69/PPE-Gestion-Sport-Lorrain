namespace PPE_Maison_Des_Ligues
{
    public class Intervenant
    {
        #region Propriétés privées

        private int id;
        private string nom;

        #endregion

        #region Constructeur

        public Intervenant(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        #endregion

        #region Acccesseurs

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Nom
        {
            get => nom;
            set => nom = value;
        }

        #endregion
    }
}