using System;

public class Reference{

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

   
    private string _VerseText;

    private Reference(){
      _book =null;
      _chapter=0;
      _verse=0;
      _endVerse =0;
      _VerseText=null;

    }

    public Reference(string book ,int chapter ,int verse , int endVerse ){

        _book= book ;
        _chapter=chapter;
        _verse= verse;
        _endVerse=0;
        

    }






    
}