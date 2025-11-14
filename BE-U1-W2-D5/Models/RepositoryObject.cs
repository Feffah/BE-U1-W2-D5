namespace BE_U1_W2_D5.Models
{
    public static class RepositoryObject
    {
        public static List<Scarpa> _scarpe;
        public static List<Scarpa> GetAll()
        {

            return _scarpe;
        }

        public static void SaveScarpa(Scarpa scarpa)
        {
            _scarpe.Add(scarpa);
        }
    }
}
