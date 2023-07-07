//Proyecto de Programación Orientada a Objetos. José Carrillo - Clase Camioneta


    //Clase Camioneta
  class Camioneta : Coche {
         int KilogramosDeCarga {get; set;}

         public int GetKilogramosCarga() {return this.KilogramosDeCarga;}

        public void SetKilogramosCarga(int kilogramoscarga) {this.KilogramosDeCarga = kilogramoscarga;}
        
        public int AsientosExtra {get;set;}

        public int GetAsientosExtra() {return this.AsientosExtra;}

        public void SetAsientosExtra(int asientosextra) {this.AsientosExtra = asientosextra;}


        public bool VidrioTemplado {get; set;}
          public string GetVidrioTemplado() {
            if (this.VidrioTemplado){
                return "La camioneta tiene vidrio templado.";
            }
            return "La camioneta no tiene vidrio templado.";
        }

        public void SetVidrioTemplado(string vidriotemplado="No", bool vidriotempladob = false){
            if (vidriotemplado.ToLower().Equals("Si") || vidriotempladob){
                this.VidrioTemplado = true; 
            }
            this.VidrioTemplado = false;
        }

        // Objeto Camioneta
        public Camioneta(
            int kilogramoscarga, 
            int asientosextra, 
            int ancho = 4, 
            int largo = 8, 
            int peso = 1500, 
            int ruedas = 4, 
            string motor="16 cilindros") : base(ancho, largo, peso, ruedas, motor){
            this.KilogramosDeCarga = kilogramoscarga;
            this.AsientosExtra = asientosextra;
        }

        public void Cargar() {
            Console.WriteLine($"La camioneta carga objetos con su parte de atras...");
        }
    }