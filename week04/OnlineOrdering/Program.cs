using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("The ten most fast snails","SnailD0ct0r55",1504);
        video1.AddComment("AracnidLover67","Spiders are way cooler than snails, a snail would totally lose against any spider");
        video1.AddComment("XxMaineCraftxX","@AracnidLover67 chill bro, you ain't a spider. Also, snails are delicious!");
        video1.AddComment("BravoMacho","I'm terrified of snails");
        
        Video video2 = new Video("Battlfront 2: Campaing, Chapter 5","X1berCrys74l",7201);
        video3.AddComment("TywinLannnister44","You are kinda bad at this, I beated this lvl 8 years ago, you noob!");
        video3.AddComment("XxXMinerPro357XxX","Maybe try using more the special habilities, the recond droid can shock the enemies for a littlewhile. Loved the video");
        video3.AddComment("AnakinLuke71","lol, bro pls use the cover!!");
        video3.AddComment("Tobias Gutierrez","Si usas la habilidad del blaster pesado, puedes despejar los pasillos sin problemas.");

        Video video3 = new Video("Why GOT deserved better","Nigth's Watch Sorcerer",3547);
        video3.AddComment("TywinLannnister44","You bunch of %&Q&%@, you ruined my character!!!");
        video3.AddComment("TywinLannnister44","nOw Im being censoredd!!!");
        video3.AddComment("XxXMinerPro357XxX","Loved the analysis, great vid!");
        video3.AddComment("AnakinLuke71","Imo it wasn't that bad.");
        video3.AddComment("Tobias Gutierrez","No eres el verdadero Tywin @TywinLannnister44, no siquiera hablas con clase!");
        
        Video video4 = new Video("WHY I'M THE GREATEST PERSON TO EVER EXIST, AND WHY YOU SHOULD RESPECT MY INTELIGENCE","TywinLannnister44",21600);
        video4.AddComment("TywinLannnister44","AMAZING VIDEO");
        video4.AddComment("XxXMinerPro357XxX","I think you should relax, best wishes");
        video4.AddComment("AnakinLuke71","POV: When @TobiasGutierrez gives you the perfect villain arc");
        video4.AddComment("Nigth's Watch Sorcerer","Bro @TobiasGutierrez this is your fault...");
        video4.AddComment("Tobias Gutierrez","No es mi culpa por decir la verdad. NO ERES EL VERDADERO TWYN LANNISTER");
    }
}