namespace WasteRecycling
{
    public class PlasticGarbage : Garbage
    {
        public bool Cleaned { get; set; } = true;
                
        public PlasticGarbage(string name, bool cleaned) : base(name)
        {
            Name = name;
            Cleaned = cleaned;

        }

        public void Clean()
        {
            Cleaned = true;
        }
    }
}
