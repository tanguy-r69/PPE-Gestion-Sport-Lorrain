namespace PPE_Maison_Des_Ligues
{
    public class Animateur
    {
        #region Propriétés privées
        private int id;
        private string nom;
        #endregion

        
        #region Constructeur
        public Animateur(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }
        #endregion
        
        
        #region Accesseurs

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