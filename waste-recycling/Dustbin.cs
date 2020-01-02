using System;

namespace WasteRecycling
{
    public class Dustbin
    {
        public string Color { get; set; }
        public PaperGarbage[] PaperContent = new PaperGarbage[0];
        public PlasticGarbage[] PlasticContent  = new PlasticGarbage[0];
        public Garbage[] HouseWasteContent = new Garbage[0];
                

        public Dustbin()
        {

        }

        public Dustbin(string color)
        {
            Color = color;
        }
        public void DisplayContents()
        {
            Console.WriteLine("{0} Dustbin!",Color);
            Console.WriteLine();
            
            Console.WriteLine("House waste content: {0} item(s)", HouseWasteContent.Length);
            foreach (var item in HouseWasteContent)
            {
                Console.WriteLine(item.Name);
            }
                        
            Console.WriteLine();
                        
            Console.WriteLine("Paper content: {0} item(s)", PaperContent.Length);
            foreach (var item in PaperContent)
            {
                Console.WriteLine(item.Name);
            }
                      
            Console.WriteLine();
                       
            Console.WriteLine("Plastic content: {0} item(s)", PlasticContent.Length);
            foreach (var item in PlasticContent)
            {
                Console.WriteLine(item.Name);
            }
                        
            Console.WriteLine();
            Console.WriteLine();

        }

        
        public void ThrowOutGarbage(Garbage garbage)
        {
            if (garbage is PlasticGarbage)
            {
                if (((PlasticGarbage)garbage).Cleaned)
                {
                    Array.Resize(ref PlasticContent, PlasticContent.Length + 1);
                    PlasticContent[PlasticContent.Length - 1] = (PlasticGarbage)garbage;
                }
                else
                {
                    throw new DustbinContentException("Not Cleaned");
                }
            }

            else if (garbage is PaperGarbage)
            {
                if (((PaperGarbage)garbage).Squeezed)
                {
                    Array.Resize(ref PaperContent, PaperContent.Length + 1);
                    PaperContent[PaperContent.Length - 1] = (PaperGarbage)garbage;
                }
                else
                {
                    throw new DustbinContentException("Not Squeezed");
                }
            }

            else if (garbage is Garbage) 
            {
                Array.Resize(ref HouseWasteContent, HouseWasteContent.Length + 1);
                HouseWasteContent[HouseWasteContent.Length - 1] = garbage;
            }
            else
            {
                throw new DustbinContentException("Not Garbage");
            }

        }
        public void EmptyContents()
        {
            PaperContent = new PaperGarbage[0];
            PlasticContent = new PlasticGarbage[0];
            HouseWasteContent = new Garbage[0];
        }
    }
}
