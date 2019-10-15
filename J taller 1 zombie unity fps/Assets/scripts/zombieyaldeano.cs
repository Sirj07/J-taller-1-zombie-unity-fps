using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieyaldeano : MonoBehaviour
{
    public int  limite= 10; //variable entera para limitar la generacion de los aldenos y zombies 
    int Numero_zombi, Numero_gente, Numero_edad; // variables para el conteo  y limite de los  zombis y aldeanos y edad
    int colorzombie; // variables para los colores del zombie 
    string NNombre; // variables para los nombres de aldenos 
    int intNombre;  // variable para el ser  usada como random para los nombres


//"""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
    class zombie
    {
       
        public string zombi_color; // variable para decir el color del zombie 
        
        GameObject Objeto_zombie; // variable para crear al zombie y poderle agregar componentes



        public zombie( int colorzombie) // estructura para crear al zombie 
        {
           
            Objeto_zombie = GameObject.CreatePrimitive(PrimitiveType.Capsule); 
            // la variable Objetozombie se crea como una capsula en una posicion randon
            Vector3 posicion = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            Objeto_zombie.transform.position = posicion;
            Objeto_zombie.AddComponent<Rigidbody>();
            // se le agrega  la posicion y un componente rigidbody

            int colores = Random.Range(0, 3); // variable para determinar el random de los colores del zombie

           

            colores = colorzombie; // la cual  ya sea  igual  la anterior  variable de color de zombie

            // casos  para los colores  de los zombies  el cual determina su color y el color que va a decir despues 
            switch (colores) 
            {
                case 0:
                    Objeto_zombie.GetComponent<Renderer>().material.color = Color.magenta;
                    zombi_color = "magenta";
                    break;
                case 1:
                    Objeto_zombie.GetComponent<Renderer>().material.color = Color.green;
                    zombi_color = "green";
                    break;
                case 2:
                    Objeto_zombie.GetComponent<Renderer>().material.color = Color.cyan;
                    zombi_color = "cyan";
                    break;
            }
            print(Mensajezombi(zombi_color)); // variable para decir el mensaje del zombie respectivamente
        }
        string Mensajezombi (string zombicolor) // mensaje que es llamado 
        {
            string mensaje; // variable que almacen del menseja 

            mensaje = "Darmensaje "+"soy un zombi de color " + zombicolor;
            return mensaje; // retorno de la variable 
        }

        

    }

//"""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""


    class Gente
    {

        public string Nombres; // variable para almacenar los nombre 
        public int Edad; // variable para almacenar Nedad
        GameObject Objeto_gente; // variable para la gente 
        

        public Gente(string NNombre, int Nedad)
        {
            Nombres = NNombre; 
            Edad = Nedad;
            Objeto_gente = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            Vector3 Gentusapo = new Vector3();  
            Gentusapo.x = Random.Range(-10, 10);
            Gentusapo.y = 0f;
            Gentusapo.z = Random.Range(-10, 10);
            Objeto_gente.transform.position = Gentusapo;
            Objeto_gente.AddComponent<Rigidbody>();
            /* crea un objeto tipo cilindro con una posion random y al cual le va agregar 
             tambien el componente rigidbody y su respectivo color de forma random para despues ser generodos  */
            int colores_gente = Random.Range(0, 2);
            switch (colores_gente)
            {
                case 0:
                    Objeto_gente.GetComponent<Renderer>().material.color = Color.blue;
                    break;
                case 1:
                    Objeto_gente.GetComponent<Renderer>().material.color = Color.red;
                    break;
                    
            }


            


        }

    }

    //"""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
    void Start()
    {
       // al momento de presionar  play en unity  el  crea a los zombies y  aldeanos y se va sumado ala  variable del limite 
      // 
        Numero_zombi = Random.Range(5, limite + 1);
        Numero_gente = limite - Numero_zombi;
        Numero_gente = Random.Range(0, Numero_gente + 1);

        for (int i = 0; i < Numero_zombi; i++) // usa los casos de  los colores  para los zombies hasta que se cumpla
        {
            colorzombie = Random.Range(0, 3);
            zombie z = new zombie(colorzombie);
        }



    

       
        // array para almacenar los datos de los nombre  de los aldeanos 

        string[] Nombre = new string[]
        {
                  "rodrigo",
                  "robin",
                  "torrez",
                  "pequeñi",
                  "don juan",
                  "blue",
                  "saltin",
                  "sergio",
                  "estevan",
                  "tu tia en tanga",
                  "tu colega ",
                  "camilo",
                  "crespos",
                  "alexis",
                  "hay te va sam pedro :v",
                  "fly",
                  "jason",
                  "andrey",
                  "atreus",
                  "artion",
                  "alegandra",
                  "zeus",
                  "mauricio",
                  "puto el que lo lea",
                  "el wilson bolso ",
                  "el brayan",
                  "el benites ",
                  "carlos",



        };
        for (int i = 0; i < Numero_gente; i++) // genera a los aldenos  y su nombre y edad hasta que cumpla su condicion
        {
            
            intNombre = Random.Range(0, 20);
            NNombre = Nombre[intNombre];
            Numero_edad = Random.Range(15, 100);

            Gente genera_gente = new Gente(NNombre,Numero_edad);

           
            print( "darmensaje "+" hola mi nombre es " + NNombre + " y tengo "+ Numero_edad);

        }

         
    }


    //""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""

}
       
        


            
           





    
        
