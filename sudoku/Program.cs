char fin =' ';
int[,] sudokuboard = { { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
                       { 6, 0, 0, 1, 9, 5, 0, 0, 0 } ,{ 0, 9, 8, 0, 0, 0, 0, 6, 0 },
                       { 8, 0, 0, 0, 6, 0, 0, 0, 3 }, { 4, 0, 0, 8, 0, 3, 0, 0, 1 }, { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
                       { 0, 6, 0, 0, 0, 0, 2, 8, 0 }, { 0, 0, 0, 4, 1, 9, 0, 0, 5 }, { 0, 0, 0, 0, 8, 0, 0, 7, 9 } };
while (fin!='s')
{
    //comentario prueba1
    tablero();
   
    responder();
   // Console.WriteLine("continuar ingrese cualquier letra si realmente quiere finalizar el juego presione [s]");
   // fin = char.Parse(Console.ReadLine().ToLower());
  
}
void tablero()
{
    Console.Clear();

    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("-----------Sudoku----------");
    Console.BackgroundColor = ConsoleColor.White;
    
    for (int q = 0; q < 9; q++)
    {
        int coordenadax = q ;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        
        Console.Write(coordenadax);
        Console.Write("  ");

    }
    Console.Write("9");
    Console.WriteLine();
    for (int q = 0; q < 9; q++)
    {
        
        Console.ForegroundColor = ConsoleColor.Black;
      
        Console.Write("===");
       

    }
    Console.Write("=");
    Console.WriteLine();//comentario2 comentario3
    for (int i = 0; i < 9; i++)
    {
        int coordenaday = i + 1;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write(coordenaday);
        for (int j = 0; j < 9; j++)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("||");
            //Random rand = new Random();
            if (i % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            //sudokuboard[i,j] = rand.Next(0, 8);
            Console.Write(sudokuboard[i, j]);
           


        }
        Console.WriteLine();
        for (int q = 0; q < 9; q++)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("===");
           
         

        }
        Console.Write("=");

        Console.WriteLine();



    }
}

 void responder()
{
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.White;
    int posX = 0;
    int posY=0;
    Console.WriteLine("ingrese la fila a modificar");
    
    posX = int.Parse(Console.ReadLine());
    posX=posX-1; 
    Console.WriteLine("ingrese la  columna a modificar");
    posY = int.Parse(Console.ReadLine());
    posY = posY - 1;

    //responder
    int o = posY + 1;
    int p = posX + 1;
    Console.WriteLine("se encuentra en la columna: " + o);
    Console.WriteLine("se encuentra en la fila: " + p);
    Console.WriteLine("Ingrese un numero en caso de no ser un 0 ingrese de nuevo el mismo numero");
   // sudokuboard[i, j] = int.Parse(Console.ReadLine());
   int pepe=int.Parse(Console.ReadLine());
    if (pepe == 0)
    {
        Console.WriteLine("Intentelo de nuevo y no ponga 0 en la casilla");//evita que pongan 0 en alguna casilla
        responder();
    }
    for(int i = 0; i < 9; i++)
    {
        if (sudokuboard[posX,i] == pepe || sudokuboard[i, posY] == pepe)
        {
            Console.WriteLine("Numero repetido en fila/columna, reintentalo");
            responder();
        }
       
    }
    if (sudokuboard[posX, posY] == 0)//no remplazar un numero que no sea 0
    {
        


        sudokuboard[posX, posY] = pepe;
        Console.WriteLine(sudokuboard[posX, posY]);

    }
    else
    {
        Console.WriteLine("Intentelo de nuevo");

        responder();
    }
    //sudokuboard[posX, posY] = pepe;
    // Console.WriteLine(sudokuboard[posX, posY]);

    //finalizar
    Console.WriteLine("continuar ingrese cualquier letra si no [s]");
    fin = char.Parse(Console.ReadLine().ToLower());
    switch (fin)
    {
        case 's':

            cerrar();
        break;
    }
   
   


    //llama a imprimir el tablero actualizado
    Console.BackgroundColor = ConsoleColor.Black;
    tablero();












}
       // Console.WriteLine();
     

       
        

    
      
void cerrar()
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Red;
}

