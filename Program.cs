Autor a1 = new Autor("Pedro" , "Brasileiro");
a1.MostrarInfo();

Livro livro1 = new Livro ("Cachorro" , a1 , 49.99);
livro1.MostrarInfo();
livro1.AplicarDesconto(10.0);
livro1.MostrarInfo();
livro1.AplicarDesconto(10);
livro1.MostrarInfo();