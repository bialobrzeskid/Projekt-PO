using System;

public interface IPublikacja
{
    string Autor { get; set; }
    DateTime Publikacja { get; set; }
    int Strony { get; set; }
}